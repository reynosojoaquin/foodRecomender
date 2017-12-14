using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HtmlAgilityPack;
using System.Threading;


namespace RecipeScraper
{
    public class ClMicroDataTool
    {
        string baseUrl = string.Empty;
        private static System.Windows.Forms.HtmlElement botonClik = null;
        private static System.Windows.Forms.WebBrowser browser = null;
        private static bool completed = false;
        public DataSet getMicroData(HtmlDocument Document)
        {
           
            ClDataAcces objDataAccess = new ClDataAcces();
            string Name = string.Empty;
            string Ingredient = string.Empty;
            DataSet recipeData = new DataSet();
            DataTable recipe = new DataTable();
            DataTable nutritionData = new DataTable();
            string calories = string.Empty, fat = string.Empty, saturatefat = string.Empty,
                fiber = string.Empty, carbohydrate = string.Empty, protein = string.Empty,
                cholesterol = string.Empty, sugar = string.Empty, sodium = string.Empty;

            // RECIPE DATA 
            recipe.Columns.Add("Name");
            recipe.Columns.Add("Ingrediente");

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
            
           
            HtmlNode[] nodes = Document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/Recipe']").ToArray();
            HtmlNode[] child = null;
            HtmlNode NameNode = Document.DocumentNode.SelectSingleNode("/html/body/div[2]/div/div[1]/div[3]/section[1]/section[2]/div/h3");
            Name = NameNode.InnerText;
           
                foreach (HtmlNode item in nodes)
            {
                child = item.SelectNodes(".//*[@itemprop='ingredients']").ToArray();
                Console.WriteLine("INGREDIENTES\r");
                Console.WriteLine("-----------------------------------------------------------------------");
                foreach (HtmlNode chldnode in child)
                {

                    for (int ind = 0; ind < chldnode.Attributes.Count; ind++)
                    {

                        Console.WriteLine(chldnode.Attributes[ind].Name + ": " +
                        chldnode.Attributes[ind].Value.ToString() + " ---> " +
                        chldnode.InnerText.Trim() + "\r");
                        Ingredient = chldnode.InnerText.Trim();
                        recipe.NewRow();
                        recipe.Rows.Add(Name, Ingredient);

                    }
                }
                nodes = Document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/NutritionInformation']").ToArray();

                Console.WriteLine("INFORMACION DE NUTRICION\r");
                Console.WriteLine("-----------------------------------------------------------------------");

                foreach (HtmlNode chldnode in nodes)
                {
                    child = chldnode.SelectNodes(".//*[@itemprop]").ToArray();
                    foreach (HtmlNode ntNodo in child)
                    {
                        for (int ind = 0; ind < ntNodo.Attributes.Count; ind++)
                        {

                            Console.WriteLine(ntNodo.Attributes[ind].Value + ": " +
                             RegexTool.GetNumber(ntNodo.InnerText) + "\r");
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
                nutritionData.Rows.Add(Convert.ToDecimal(calories), Convert.ToDecimal(fat), Convert.ToDecimal(saturatefat),
                              Convert.ToDecimal(fiber), Convert.ToDecimal(carbohydrate), Convert.ToDecimal(protein), Convert.ToDecimal(cholesterol)
                              , Convert.ToDecimal(sugar), Convert.ToDecimal(sodium));
            }
            recipeData.Tables.Add(recipe);
            recipeData.Tables.Add(nutritionData);
            objDataAccess.insertRecipeData(recipeData);
            Console.WriteLine("Datos Registrados con exito");
            return recipeData;
         
        }
        public bool TestMicroData(HtmlDocument page)
        {
            bool resultado = false;
            HtmlNode[] nodes = page.DocumentNode.SelectNodes(".//*[@itemscope]").ToArray();
            if (nodes.Count() > 0)
                resultado = true;
            return resultado;
        }
        public DataSet microDataTest()
        {
            ClDataAcces objDataAccess = new ClDataAcces();
            string Name = string.Empty;
            string Ingredient = string.Empty;
            DataSet  recipeData = new DataSet();
            DataTable recipe = new DataTable();
            DataTable nutritionData = new DataTable();
            string calories = string.Empty,  fat =string.Empty, saturatefat=string.Empty,
                fiber =string.Empty, carbohydrate=string.Empty, protein =string.Empty, 
                cholesterol=string.Empty, sugar =string.Empty, sodium=string.Empty;

            // RECIPE DATA 
            recipe.Columns.Add("Name");
            recipe.Columns.Add("Ingrediente");

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



            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://www.eatingwell.com/recipe/249817/skillet-gnocchi-with-chard-white-beans/");
            HtmlNode[] nodes = document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/Recipe']").ToArray();
            HtmlNode[] child = null;
            HtmlNode NameNode = document.DocumentNode.SelectSingleNode("/html/body/div[2]/div/div[1]/div[3]/section[1]/section[2]/div/h3");
            Name = NameNode.InnerText;
            foreach (HtmlNode item in nodes)
            {
                child = item.SelectNodes(".//*[@itemprop='ingredients']").ToArray();
                //Console.WriteLine("INGREDIENTES\r");
                //Console.WriteLine("-----------------------------------------------------------------------");
                foreach (HtmlNode chldnode in child)
                {

                    for (int ind = 0; ind < chldnode.Attributes.Count; ind++)
                    {
                       
                             //Console.WriteLine(chldnode.Attributes[ind].Name + ": " +
                             //chldnode.Attributes[ind].Value.ToString() + " ---> " +
                             //chldnode.InnerText.Trim() + "\r");
                             Ingredient = chldnode.InnerText.Trim();
                             recipe.NewRow();
                             recipe.Rows.Add(Name, Ingredient);

                    }
                 }
                nodes = document.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/NutritionInformation']").ToArray();

                //Console.WriteLine("INFORMACION DE NUTRICION\r");
                //Console.WriteLine("-----------------------------------------------------------------------");
                
                foreach (HtmlNode chldnode in nodes)
                {
                    child = chldnode.SelectNodes(".//*[@itemprop]").ToArray();
                    foreach (HtmlNode ntNodo in child)
                    {
                        for (int ind = 0; ind < ntNodo.Attributes.Count; ind++)
                        {

                            //Console.WriteLine(ntNodo.Attributes[ind].Value + ": " +
                            // RegexTool.GetNumber(ntNodo.InnerText) + "\r");
                            switch (ntNodo.Attributes[ind].Value)
                            {
                                case "calories" :
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
                nutritionData.Rows.Add(Convert.ToDecimal(calories), Convert.ToDecimal(fat), Convert.ToDecimal(saturatefat),
                              Convert.ToDecimal(fiber), Convert.ToDecimal(carbohydrate), Convert.ToDecimal(protein), Convert.ToDecimal(cholesterol)
                              , Convert.ToDecimal(sugar), Convert.ToDecimal(sodium));
            }
            recipeData.Tables.Add(recipe);
            recipeData.Tables.Add(nutritionData);
            objDataAccess.insertRecipeData(recipeData);
            //Console.WriteLine("Datos Registrados con exito");
            return recipeData;
        }
        public bool hasRecipe(HtmlDocument page)
        {
            bool resultado = false;
            if (page.DocumentNode.SelectNodes(".//*[@itemtype='http://schema.org/Recipe']")  != null)
               resultado = true;
            return resultado;
        }
        public void scrapData(string Url,int cantidad)
        {
            browser = new System.Windows.Forms.WebBrowser();
            browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            
            HtmlDocument document = null;
            int contador = 0;
           HtmlWeb web = new HtmlWeb();
            while(contador <= cantidad) {
                 
                    
                    browser.Navigate(Url);
                    browser.Visible = true;
                    browser.Refresh();
                while (completed)
                    {
                         System.Windows.Forms.Application.DoEvents();
                         Thread.Sleep(100);
                    botonClik = browser.Document.GetElementById("btnMoreResults");
                    botonClik.InvokeMember("click");
                    document = (HtmlDocument)browser.Document.DomDocument;
                    HtmlNode[] nodes = document.DocumentNode.SelectNodes(".//a/@href").ToArray();
                    Console.Write("Buscando Recetas.....");
                    using (var progress = new ProgressBar())
                    {
                        foreach (HtmlNode enlace in nodes)
                        {

                            foreach (HtmlAttribute atributo in enlace.Attributes)
                            {
                                if (RegexTool.isUrl(atributo.Value))
                                {
                                    HtmlDocument recipe = web.Load(atributo.Value);
                                    if (hasRecipe(recipe))
                                    {
                                        contador++;
                                        progress.Report((double)contador / cantidad);
                                        Thread.Sleep(20);
                                        getMicroData(recipe);
                                    }
                                }
                            }

                        }
                    }
                }
                   
            }
            Console.WriteLine("Listo.");
            Console.ReadLine();
        }
        static void DocumentCompleted(object sender,System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            completed = true;
        }
        private void consultarPagina(string Url)
        {

            baseUrl = Url;
            browser = new System.Windows.Forms.WebBrowser();
            browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
            browser.ScriptErrorsSuppressed = true;
            browser.Visible = true;
            browser.Navigate(Url);

        }

    }
    
}
