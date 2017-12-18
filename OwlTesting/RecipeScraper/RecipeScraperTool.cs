using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Threading;
using System.IO;
using RecipeScraper.Lib;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace RecipeScraper
{
    public partial class RecipeScraperTool : Form
    {
        FileTool Ftool = new FileTool();
        decimal percent = 0;
        int errorCount = 0;
        Dictionary<string, string> visitedLink = new Dictionary<string, string>();
        HtmlElement botonClik = null;
        WebBrowser browser = new WebBrowser();
        HtmlWeb web = new HtmlWeb();
        int contador = 0, cantidad = 0;
        private static bool completed = false;
        string baseUrl = string.Empty;
        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
       
        public RecipeScraperTool()
        {
            InitializeComponent();
        }
        public void DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {

            switch (cboFormato.SelectedIndex)
            {
                case 0:
                    
                    var documentAsIHtmlDocument3 = (mshtml.IHTMLDocument3)browser.Document.DomDocument;
                    StringReader sr = new StringReader(documentAsIHtmlDocument3.documentElement.outerHTML);
                    document.Load(sr);
                    HtmlNode[] nodes = document.DocumentNode.SelectNodes(".//a[@class='heroLinkItem']").ToArray();
                    scrapData(nodes, 0);
                    break;


            }


        }
        private void consultarPagina(string Url)
        {

            baseUrl = Url;
            browser = new WebBrowser();
            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            browser.ScriptErrorsSuppressed = true;
            browser.Visible = true;
            browser.Navigate(Url);
            progressBarBusqueda.Maximum = Convert.ToInt32(txtTotalRegistros.Text);
            progressBarBusqueda.Step = 1;


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string Url = "";
            if (txtTotalRegistros.Text != "")
            {
                cantidad = Convert.ToInt32(txtTotalRegistros.Text);
                if (cboFormato.SelectedIndex == 0)
                {
                    switch (cboScrapMode.SelectedIndex)
                    {
                        case 0:

                            CheckForIllegalCrossThreadCalls = false;
                            Task BuscarDataWebAsync = new Task(() =>
                            {
                                consultarPagina(Url);
                                MessageBox.Show("La Busqueda a concluido");
                            });

                            break;
                        case 1:
                            if (txtFileRoute.Text != "")
                            {
                                CheckForIllegalCrossThreadCalls = false;
                                Task BuscarDataLocalAsync = new Task(() =>
                                {
                                    scrapLocalPage(txtFileRoute.Text, 1);
                                    MessageBox.Show("La Busqueda a concluido");
                                }
                                );
                                BuscarDataLocalAsync.Start();

                            }
                            else
                            { MessageBox.Show("Debe Buscar una ruta de archivo valida"); }
                            break;
                    }
                }
                else
                {

                    if (txtFileRoute.Text != "")
                    {
                        CheckForIllegalCrossThreadCalls = false;
                        Task BuscarMicroDataLocalAsync = new Task(() =>
                        {
                            scrapLocalPage(txtFileRoute.Text, cboScrapMode.SelectedIndex);

                        }
                        );
                        BuscarMicroDataLocalAsync.Start();

                    }
                    else
                    { MessageBox.Show("Debe Buscar una ruta de archivo valida"); }



                }
            }
            else { MessageBox.Show("Debe colocar un valor de registros a buscar"); }
        }

        public void scrapData(HtmlNode[] nodes, int dataformat)
        {

            int itemCount = 0, cantNodeIndetified = 0;
            string urlActual = string.Empty;
            cantidad = Convert.ToInt32(txtTotalRegistros.Text);
            lbTotalNodosIdentificados.Text = nodes.Count().ToString();
            cantNodeIndetified = nodes.Count();
            foreach (HtmlNode enlace in nodes)
            {
                itemCount++;
                lbTotalNodosEvaluados.Text = itemCount.ToString();
                this.Refresh();
                foreach (HtmlAttribute atributo in enlace.Attributes)
                {
                    urlActual = atributo.Value.ToString();
                    lbEnlaceActual.Text = urlActual;
                    lbEnlaceActual.Refresh();
                    if (RegexTool.isUrl(urlActual))
                    {
                        if (!isVisited(urlActual))
                        {

                            HtmlAgilityPack.HtmlDocument recipe = web.Load(urlActual);

                            if (hasRecipe(recipe, dataformat))
                            {
                                addValueToDic(urlActual, "");
                                lbTotalRegistroEncontrados.Text = contador.ToString();
                                lbTotalRegistroEncontrados.Refresh();
                                GetMicroData(recipe,dataformat);
                            }
                            else
                            {
                                var recetas = recipe.DocumentNode.SelectNodes(".//article/a/@href");
                                addValueToDic(urlActual, "");
                                if (recetas != null)
                                {
                                    scrapData(recetas.ToArray(), 0);
                                }
                            }


                        }
                    }

                }

            }

        }
        public bool hasRecipe(HtmlAgilityPack.HtmlDocument page, int QFormat)
        {
            bool resultado = false;
            switch (QFormat)
            {
                case 0:
                    if (page.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/Recipe']") != null)
                        resultado = true;
                    break;
                case 1:
                    if (page.DocumentNode.SelectSingleNode("//script[@type='application/ld+json']") != null)
                    {
                        string jsonValue = page.DocumentNode.
                            SelectSingleNode("//script[@type='application/ld+json']").InnerText;
                        dynamic recipe = JsonConvert.DeserializeObject(jsonValue);
                        if (recipe.recipeYield != null)
                            resultado = true;

                    }
                    break;
            }

            return resultado;
        }
        public DataSet GetMicroData(HtmlAgilityPack.HtmlDocument Document, int dataFormat)
        {
            string dataError = string.Empty, pictureRoute = string.Empty, appRoute = string.Empty, filename = string.Empty;
            ClDataAcces objDataAccess = new ClDataAcces();
            string Name = string.Empty;
            string Ingredient = string.Empty;
            DataSet recipeData = new DataSet();
            DataTable recipeTable = new DataTable();
            DataTable nutritionData = new DataTable();
            HtmlNode[] nodes = null;
            HtmlNode[] child = null;
            HtmlNode NameNode = null;
            WebClient cliente = new WebClient();
            IList<string> listIngredient = null;
            Uri Url = null;
            string calories = string.Empty, fat = string.Empty, saturatefat = string.Empty,
                fiber = string.Empty, carbohydrate = string.Empty, protein = string.Empty,
                cholesterol = string.Empty, sugar = string.Empty, sodium = string.Empty, imagenUrl = string.Empty;

            // RECIPE DATA 
            recipeTable.Columns.Add("Name", typeof(string));
            recipeTable.Columns.Add("Ingrediente", typeof(string));
            recipeTable.Columns.Add("recipeTipoPlatoData", typeof(string));
            recipeTable.Columns.Add("recipeCulturaData", typeof(string));
            recipeTable.Columns.Add("recipeNacionalidadData", typeof(string));
            recipeTable.Columns.Add("recipeMomentoData", typeof(string));
            recipeTable.Columns.Add("recipeTemporadaData", typeof(string));
            recipeTable.Columns.Add("Picture", typeof(string));


            // NUTRICION DATA

            nutritionData.Columns.Add("Calorias", typeof(decimal));
            nutritionData.Columns.Add("fat", typeof(decimal));
            nutritionData.Columns.Add("saturatefat", typeof(decimal));
            nutritionData.Columns.Add("fiber", typeof(decimal));
            nutritionData.Columns.Add("carbohydrate", typeof(decimal));
            nutritionData.Columns.Add("protein", typeof(decimal));
            nutritionData.Columns.Add("cholesterol", typeof(decimal));
            nutritionData.Columns.Add("sugar", typeof(decimal));
            nutritionData.Columns.Add("sodium", typeof(decimal));

            appRoute = Application.StartupPath;

            switch(dataFormat)
            {

                case 0:
           
                    nodes = Document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/Recipe']").ToArray();
                    NameNode = Document.DocumentNode.SelectSingleNode(".//*[@class='recipeDetailHeader showOnTabletToDesktop']");
                    imagenUrl = Document.DocumentNode.Descendants("img")
                    .Where(node => node.Attributes["class"] != null && node.Attributes["class"].Value == "recipeDetailSummaryImageMain")
                    .Select(node => node.Attributes["src"].Value)
                    .DefaultIfEmpty(string.Empty)
                    .FirstOrDefault()
                    .ToString();
            
           
                    cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(Cliente_DownloadFileCompleted);
                    Url = new Uri(imagenUrl);

                    filename = System.IO.Path.GetFileName(Url.LocalPath);
                    pictureRoute = appRoute.Remove(appRoute.Length - 10) + "\\Picture\\" + filename;
                    cliente.DownloadFileAsync(Url, pictureRoute);
                    Name = NameNode.InnerText;

                    foreach (HtmlNode item in nodes)
                    {
                        child = item.SelectNodes(".//*[@itemprop='ingredients']").ToArray();

                        foreach (HtmlNode chldnode in child)
                        {

                            for (int ind = 0; ind < chldnode.Attributes.Count; ind++)
                            {


                                Ingredient = chldnode.InnerText.Trim();
                                recipeTable.NewRow();
                                recipeTable.Rows.Add(Name, Ingredient, CboTipoPlato.Text, cboCultura.Text,
                                cboNacionalidad.Text, cboMomentoComida.Text, cboTemporada.Text, pictureRoute);
                            }
                        }
                        if (Document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/NutritionInformation']") != null)
                        {
                            nodes = Document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/NutritionInformation']").ToArray();

                            foreach (HtmlNode chldnode in nodes)
                            {
                                child = chldnode.SelectNodes(".//*[@itemprop]").ToArray();
                                foreach (HtmlNode ntNodo in child)
                                {
                                    for (int ind = 0; ind < ntNodo.Attributes.Count; ind++)
                                    {

                                        Console.WriteLine(ntNodo.Attributes[ind].Value + ": " +
                                        RegexTool.GetNumber(ntNodo.InnerText) + "\r");
                                        if (ntNodo.InnerText != "")
                                        {
                                            switch (ntNodo.Attributes[ind].Value)
                                            {
                                                case "calories":
                                                    calories = RegexTool.GetNumber(ntNodo.InnerText);

                                                    break;
                                                case "fatContent":
                                                    fat = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "saturatedFatContent":
                                                    saturatefat = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "fiberContent":
                                                    fiber = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "carbohydrateContent":
                                                    carbohydrate = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "proteinContent":
                                                    protein = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "cholesterolContent":
                                                    cholesterol = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "sugarContent":
                                                    sugar = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                                case "sodiumContent":
                                                    sodium = RegexTool.GetNumber(ntNodo.InnerText);
                                                    break;
                                            }
                                        }


                                    }

                                }
                            }
                            try
                            {
                                nutritionData.Rows.Add(Convert.ToDecimal(calories), Convert.ToDecimal(fat), Convert.ToDecimal(saturatefat),
                                         Convert.ToDecimal(fiber), Convert.ToDecimal(carbohydrate), Convert.ToDecimal(protein), Convert.ToDecimal(cholesterol)
                                         , Convert.ToDecimal(sugar), Convert.ToDecimal(sodium));
                            }
                            catch (Exception error)
                            {
                                dataError = error.Message;
                            }
                        }
                    }
                    if (nutritionData.Rows.Count > 0)
                    {
                        contador++;
                        percent = contador / cantidad * 100;
                        lbPorcent.Text = percent.ToString();
                        lbPorcent.Refresh();
                        progressBarBusqueda.PerformStep();
                        progressBarBusqueda.Refresh();
                        recipeData.Tables.Add(recipeTable);
                        recipeData.Tables.Add(nutritionData);
                        dataError = objDataAccess.insertRecipeData(recipeData);
                        if (dataError != "")
                        {
                            errorCount++;
                            lbErrorCount.Text = errorCount.ToString();
                            Ftool.WriteLogFile(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + dataError);
                        }
                    }
                    break;
                case 1:
                    // RECUPERANDO EN VALOR JSON EN LA PAGINA

                    string jsonValue = Document.DocumentNode.
                            SelectSingleNode("//script[@type='application/ld+json']").InnerText;

                    //SERIALIZANDO EL OBJETO JSON A UN OBJETO DINAMICO

                    dynamic jsonData = JsonConvert.DeserializeObject(jsonValue);
                    jsonData.nutrition.Remove("@type");


                    Dictionary<string, string> values = jsonData.nutrition.ToObject<Dictionary<string, string>>();
                    listIngredient = jsonData.recipeIngredient.ToObject<IList<string>>();

                    // RECUPERANDO VALORES NUTRICIONALES

                    foreach (KeyValuePair<string, string> valor in values)
                    {
                        switch (valor.Key)
                        {
                            case "calories":
                                calories = valor.Value;
                                break;
                            case "fatContent":
                                fat = valor.Value;
                                break;
                            case "saturatedFatContent":
                                saturatefat = valor.Value;
                                break;
                            case "proteinContent":
                                protein = valor.Value;
                                break;
                            case "carbohydrateContent":
                                carbohydrate = valor.Value;
                                break;
                            case "sugarContent":
                                sugar = valor.Value;
                                break;
                            case "sodiumContent":
                                sodium = valor.Value;
                                break;
                            case "fiberContent":
                                fiber = valor.Value;
                                break;

                        }
                    }
                    try
                    {
                        nutritionData.Rows.Clear();
                        nutritionData.Rows.Add(Convert.ToDecimal(calories), Convert.ToDecimal(fat), Convert.ToDecimal(saturatefat),
                                 Convert.ToDecimal(fiber), Convert.ToDecimal(carbohydrate), Convert.ToDecimal(protein), Convert.ToDecimal(cholesterol)
                                 , Convert.ToDecimal(sugar), Convert.ToDecimal(sodium));
                    }
                    catch (Exception error)
                    {
                        dataError = error.Message;
                    }

                    //RECUPERANDO INGREDIENTES 

                    foreach (string ingrediente in listIngredient)
                    {
                                                Ingredient = ingrediente;
                        recipeTable.NewRow();
                        recipeTable.Rows.Add(Name, Ingredient, CboTipoPlato.Text, cboCultura.Text,
                        cboNacionalidad.Text, cboMomentoComida.Text, cboTemporada.Text, pictureRoute);
                    }

                   

                    if (nutritionData.Rows.Count > 0)
                    {
                        //RECUPERANDO IMAGEN DEL LA RECETA
                        imagenUrl = jsonData.image;
                        cliente.DownloadFileCompleted += new AsyncCompletedEventHandler(Cliente_DownloadFileCompleted);
                        Url = new Uri(imagenUrl);

                        filename = System.IO.Path.GetFileName(Url.LocalPath);
                        pictureRoute = appRoute.Remove(appRoute.Length - 10) + "\\Picture\\" + filename;
                        cliente.DownloadFileAsync(Url, pictureRoute);

                        contador++;
                        percent = contador / cantidad * 100;
                        lbPorcent.Text = percent.ToString();
                        lbPorcent.Refresh();
                        progressBarBusqueda.PerformStep();
                        progressBarBusqueda.Refresh();
                        recipeData.Tables.Add(recipeTable);
                        recipeData.Tables.Add(nutritionData);
                        dataError = objDataAccess.insertRecipeData(recipeData);
                        if (dataError != "")
                        {
                            errorCount++;
                            lbErrorCount.Text = errorCount.ToString();
                            Ftool.WriteLogFile(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " " + dataError);
                        }
                    }




                    break;
             
        }
            return recipeData;
        }
        public bool isVisited(string Url)
        {
            if (visitedLink.ContainsKey(Url))
                return true;
            else
                return false;

        }
        private void addValueToDic(string Tkey, string Tvalue)
        {
            visitedLink.Add(Tkey, Tvalue);
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileHtmlPage.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileRoute.Text = openFileHtmlPage.FileName;
            }
        }

        private void frmScraper_Load(object sender, EventArgs e)
        {
            cboFormato.SelectedIndex = 0;
        }
        private void scrapLocalPage(string file, int DataFormat)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(file);
            switch (DataFormat)
            {
                case 0:
                    HtmlNode[] nodes = doc.DocumentNode.SelectNodes(".//article/a/@href").ToArray();
                    scrapData(nodes, DataFormat);
                    break;
                case 1:
                    HtmlNode[] JsonNodes = doc.DocumentNode.SelectNodes("//div[@class='recipe-block']/a/@href").ToArray();
                    scrapData(JsonNodes, DataFormat);
                    break;
            }
            MessageBox.Show("La Busqueda a concluido");

        }

        private void RecipeScraperTool_Load(object sender, EventArgs e)
        {
            cboFormato.SelectedIndex = 0;
            cboScrapMode.SelectedIndex = 0;
        }

        private void Cliente_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}
