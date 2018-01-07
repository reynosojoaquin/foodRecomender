using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeScraper;
using RecipeScraper.Lib;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;
using RavSoft.GoogleTranslator;
using com.hp.hpl.jena.rdf.model;
using com.hp.hpl.jena.util;
using com.hp.hpl.jena.vocabulary;
using System;
using java.io;

namespace IngredientMinery
{
    public partial class frmMineria : Form
    {
        DataTable registroEncontrados = new DataTable();
        ClDataAcces objDataAccess = new ClDataAcces();
        int registroTraducidos = 0;
        SortedDictionary<string, int> dict
                       = new SortedDictionary<string, int>();
        SortedDictionary<int, string> baseConocimiento = new SortedDictionary<int, string>();
        Dictionary<string, string> ingredientes = new Dictionary<string, string>();
        FileTool objFileTool = new FileTool();
        string vocabulary = string.Empty;
        string[] classOf = { "Embutido",
            "pan","Pasta","aceite","adereso","cereal","condimento","especia",
        "fruta","hortalizas","nuez","semillas","verduras","vino","carne","vinagre"};
        string[] palabras = { };
        public frmMineria()
        {
            InitializeComponent();
        }
        private static char[] delimiters_no_digits = new char[] {
            '{', '}', '(', ')','[', ']', '>', '<','-', '_', '=', '+',
            '|', '\\', ':', ';', ' ', ',', '.', '/', '?', '~', '!',
            '@', '#', '$', '%', '^', '&', '*', ' ', '\r', '\n', '\t',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','½','¼','¾' };


        private void evaluarInfoDB(string value, int ingredienteID)
        {

            txtFrencuenciaPalabras.Text = "";
            // vocabulary = buscarDataVocabulary().Rows[0]["vocabulary"].ToString();
            // palabras =  vocabulary.Split(',');
            if (txtDatosOrigen.Text != string.Empty)
            {
                string[] words = Tokenize(value);
                if (words.Length > 0)
                {


                    foreach (string word in words)
                    {
                        if (dict.ContainsKey(word))
                        {
                            dict[word]++;
                        }
                        else
                        {
                            dict.Add(word, ingredienteID);
                        }
                    }
                    // evaluando diccionario para eliminar palabras innecesarias

                    removeNotIngredients(dict);

                    StringBuilder resultSb = new StringBuilder(dict.Count * 9);
                    foreach (KeyValuePair<string, int> entry in dict)
                    {
                        resultSb.AppendLine(string.Format("{0}", entry.Key));
                    }

                    txtFrencuenciaPalabras.Text = resultSb.ToString();
                }
                lbTotalIngredientes.Text = dict.Count.ToString();
            }
        }
        private void removeNotIngredients(SortedDictionary<string, int> diccionario)
        {
            foreach (KeyValuePair<int, string> entrada in baseConocimiento)
            {

                diccionario.Remove(entrada.Value);
            }
        }
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            evaluarIngredientes();

        }
        public static string[] Tokenize(string text)
        {
            string[] tokens = text.Split(delimiters_no_digits,
                                    StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];

                // Change token only when it starts and/or ends with "'" and  
                // it has at least 2 characters. 

                if (token.Length > 1)
                {
                    if (token.StartsWith("'") && token.EndsWith("'"))
                        tokens[i] = token.Substring(1, token.Length - 2); // remove the starting and ending "'" 

                    else if (token.StartsWith("'"))
                        tokens[i] = token.Substring(1); // remove the starting "'" 

                    else if (token.EndsWith("'"))
                        tokens[i] = token.Substring(0, token.Length - 1); // remove the last "'" 
                }
            }

            return tokens;
        }

        private void btnEvaluarBaseDatos_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task cargarIngredientesAsync = new Task(() =>
            {
                verificarData();

            });
            cargarIngredientesAsync.Start();
        }
        private void verificarData()
        {
            int count = 0, ingredientID = 0;
            string infoRecipe = string.Empty;
            string ingredientValue = string.Empty;
            DataTable resultado = new DataTable();

            try
            {

                if (txtLimit.Text != "")
                {
                    string sQlString = "SELECT * FROM ingredientes limit 0,{0}";
                    sQlString = string.Format(sQlString, txtLimit.Text);
                    resultado = objDataAccess.EjecutaQuery(sQlString);
                    registroEncontrados = resultado.Copy();
                    foreach (DataRow ingrediente in resultado.Rows)
                    {

                        ingredientValue = ingrediente["descripcion"].ToString();
                        ingredientID = Convert.ToInt32(ingrediente["ingredienteID"].ToString());
                        txtDatosOrigen.Text += ingredientValue + "\r";
                        evaluarInfoDB(ingredientValue, ingredientID);
                        count++;
                        lbTotalregistro.Text = count.ToString();
                    }
                    MessageBox.Show("Proceso Concluido con exito");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void frmMineria_Load(object sender, EventArgs e)
        {
           txtFrencuenciaPalabras.ScrollBars = ScrollBars.Both;
            txtMainVocabulary.ScrollBars = ScrollBars.Both;
            buscarBaseConocimiento();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            addWordBaseConocimiento(txtNuevaPalabra.Text);
        }
        private void addWordBaseConocimiento(string word)
        {
            buscarBaseConocimiento();
            if (!baseConocimiento.ContainsValue(word))
            {
                baseConocimiento.Add(baseConocimiento.Count + 1, word);
                actualizarVocaBulary();
                txtNuevaPalabra.Text = "";
            }
            else
            {
                MessageBox.Show("Palabra registrada en la base de conocimiento");
            }
        }
        private void actualizarVocaBulary()
        {

            if (baseConocimiento.Count > 0)
            {
                objFileTool.clearJsonFile();
                objFileTool.writeJsonDataTofile(JsonConvert.SerializeObject(baseConocimiento, Formatting.Indented));
                buscarBaseConocimiento();
            }
        }
        private DataTable buscarDataVocabulary()
        {
            string infoRecipe = string.Empty;
            DataTable resultado = new DataTable();
            try
            {
                resultado = objDataAccess.EjecutaQuery("SELECT vocabulary FROM main");
                txtMainVocabulary.Text = resultado.Rows[0]["vocabulary"].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return resultado;
        }
        private void eliminarPalabrasVocabulario() { }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void evaluarIngredientes()
        {
            foreach (KeyValuePair<int, string> entrada in baseConocimiento)
            {
                dict.Remove(entrada.Value);
            }
            txtFrencuenciaPalabras.Text = "";
            StringBuilder resultSb = new StringBuilder(dict.Count * 9);
            foreach (KeyValuePair<string, int> entry in dict)
            {
                resultSb.AppendLine(string.Format("{0}", entry.Key));
            }

            txtFrencuenciaPalabras.Text = resultSb.ToString();
            lbTotalIngredientes.Text = dict.Count().ToString();
        }

        private void btnMarcarRegistro_Click(object sender, EventArgs e)
        {
            marcarRegistrosEvaluados();
        }
        private void marcarRegistrosEvaluados()
        {
            string sqlData = string.Empty;
            string QueryString = string.Empty;
            foreach (DataRow registro in registroEncontrados.Rows)
            {
                sqlData = "UPDATE INGREDIENTES SET EVALUADO = 1 WHERE INGREDIENTEID = {0};";
                sqlData = string.Format(sqlData, registro["ingredienteID"].ToString());
                QueryString += sqlData;
            }
        }
        /*  private void cargarDatosBaseConocimiento() {
              string baseConocimientoStr = string.Empty;
              baseConocimientoStr = buscarDataVocabulary().Rows[0]["vocabulary"].ToString();
              string[] palabras = baseConocimientoStr.Split(',');
              int cont = 0;
              foreach (string word in palabras) {

                  cont++;
                  baseConocimiento.Add(cont, word);
              }

              objFileTool.writeJsonDataTofile(JsonConvert.SerializeObject(baseConocimiento, Formatting.Indented));
          }*/

        private void btnBaseConocimiento_Click(object sender, EventArgs e)
        {
            //  cargarDatosBaseConocimiento();
        }
        private void buscarBaseConocimiento()
        {
            dynamic jsonData = JsonConvert.DeserializeObject(objFileTool.readJsonDataFromFile());
            baseConocimiento = jsonData.ToObject<SortedDictionary<int, string>>();
            txtMainVocabulary.Text = "";
            foreach (KeyValuePair<int, string> valor in baseConocimiento)
            {
                txtMainVocabulary.Text += valor.Value + ", ";

            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPalabra();
        }
        private void eliminarPalabra()
        {
            string valueSeleted = string.Empty, tempValue = string.Empty;

            valueSeleted = txtMainVocabulary.SelectedText;
            if (txtMainVocabulary.SelectedText != "")
            {
                int word = txtMainVocabulary.SelectionLength;
                txtMainVocabulary.Text = txtMainVocabulary.Text.Remove(txtMainVocabulary.SelectionStart, word);


                if (baseConocimiento.ContainsValue(valueSeleted))
                {
                    baseConocimiento.Remove(baseConocimiento.FirstOrDefault(x => x.Value == valueSeleted).Key);
                    actualizarVocaBulary();
                }



            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addWordBaseConocimiento(txtFrencuenciaPalabras.SelectedText);
            evaluarIngredientes();
        }

        private void btnTraducir_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task translateIngredientesAsync = new Task(() =>
            {
                FindRowsTotranslate();

            });
            translateIngredientesAsync.Start();
            
        }
        private void translateRegitros(int recetaID,int ingredienteID, string IngredienteDescripcion,string recetaNombre)
        {
            string receta = string.Empty, ingrediente=string.Empty,sQlStr=string.Empty;
           
            receta = transLate(recetaNombre);
            ingrediente = transLate(IngredienteDescripcion);
            sQlStr = "insert into translate (recipeID,recipeName,ingredienteID,ingredienteDescripcion) values ("
                    +" {0},'{1}',{2},'{3}')";
            sQlStr = string.Format(sQlStr, recetaID, receta, ingredienteID, ingrediente);
            try
            {
                objDataAccess.EjecutaQuery(sQlStr);
                registroTraducidos++;
                lbTraducciones.Text = registroTraducidos.ToString();

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void FindRowsTotranslate()
        {
            int recipeID = 0, ingredientID = 0;
            string RecipeNombre = string.Empty;
            string ingredientValue = string.Empty;
            DataTable Data = new DataTable();

            try
            {

                if (txtLimit.Text != "")
                {
                    string sQlString = "SELECT * FROM receta_ingredientes limit 0,{0}";
                    sQlString = string.Format(sQlString, txtLimit.Text);
                    Data = objDataAccess.EjecutaQuery(sQlString);
                    foreach (DataRow ingrediente in Data.Rows)
                    {

                        ingredientValue = ingrediente["descripcion"].ToString();
                        recipeID = Convert.ToInt32(ingrediente["recipeID"].ToString());
                        ingredientID = Convert.ToInt32(ingrediente["ingredienteID"].ToString());
                        RecipeNombre = ingrediente["RecetaNombre"].ToString();
                        translateRegitros(recipeID, ingredientID, ingredientValue, RecipeNombre);
                    }
                    MessageBox.Show("Proceso Concluido con exito");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private string transLate(string dataToTranslate)
        {
            string resultado = string.Empty;

            Translator t = new Translator();
            resultado = t.Translate(dataToTranslate, "English", "Spanish");
            return resultado;
        }
        private void AddComboColum()
        {
            SubClassOf.Items.AddRange(classOf.ToArray());
        }
        private void cargarDataClasificacion()
        {
            string sQlString = string.Empty;
            switch (chkModify.Checked)
            {
                case true:
                    sQlString = "SELECT * FROM translate where classOf is not null  limit 0,{0}";
                    break;
                case false:
                    sQlString = "SELECT * FROM translate  where classOf = '' or classOf is null limit 0,{0}";
                    break;
            }
            sQlString = string.Format(sQlString, txtLimit.Text);
            DataTable  DataClasificacion = objDataAccess.EjecutaQuery(sQlString);
            lbRegistroEncontrados.Text = DataClasificacion.Rows.Count.ToString();
            dgDatosClasificacion.AutoGenerateColumns = false;
            dgDatosClasificacion.DataSource = DataClasificacion;
            AddComboColum();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage3)
            {
              
            }
        }
        private void guardarCambiosClasificacion()
        {
             string sqlData = "update translate set classOf = '{0}' where recipeID = {1} and ingredienteID = {2} ";
            try
            {
                foreach (DataGridViewRow fila in dgDatosClasificacion.Rows)
                {
                    if (fila.Cells["SubClassOf"].Value.ToString() != "") {
                        sqlData = string.Format(sqlData, fila.Cells["SubClassOf"].Value, fila.Cells["RecipeID"].Value, fila.Cells["ingredienteID"].Value);
                        objDataAccess.EjecutaQuery(sqlData);
                    }
                }
                MessageBox.Show("Datos Registrados con exito"); 
            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            guardarCambiosClasificacion();
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            cargarDataClasificacion();
        }
        private void cargarDataMigracionToOwl()
        {
            if(txtLimit.Text != "")
            { 
                 string sQlString = string.Empty;
                 sQlString = "SELECT * FROM translate where classOf is not null  limit 0,{0}";
                 sQlString = string.Format(sQlString, txtLimit.Text);
                 DataTable DataToOwl = objDataAccess.EjecutaQuery(sQlString);
                dgOwlData.AutoGenerateColumns = false;
                 dgOwlData.DataSource = DataToOwl;
            }
        }

        private void btnBuscarDataOwl_Click(object sender, EventArgs e)
        {
            cargarDataMigracionToOwl();
        }

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            visualizarFile();
        }
        private void visualizarFile()
        {
            string inputFileName = objFileTool.GetAplicationDirectory()+ "FoodOntologyRecomenderOwl.owl";
            Model model = ModelFactory.createDefaultModel();

            // use the class loader to find the input file
            InputStream inputStream = FileManager.get().open(inputFileName);
            if (inputStream == null)
            {
                throw new ArgumentException("File: " + inputFileName + " not found");
            }
            // read the RDF/XML file
            model.read(new InputStreamReader(inputStream), "");
            
            frmVisualizarOwlFile objFileViewer = new frmVisualizarOwlFile();
            // print the graph as RDF/XML
            java.io.StringWriter stringWriter = new java.io.StringWriter();
            model.write(stringWriter, "RDF / XML - ABBREV");
            objFileViewer.OwlFileStr = stringWriter.toString();
            objFileViewer.ShowDialog();
        }
    }
}
