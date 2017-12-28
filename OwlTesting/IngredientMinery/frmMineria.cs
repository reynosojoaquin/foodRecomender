using System;
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

namespace IngredientMinery
{
    public partial class frmMineria : Form
    {
        DataTable registroEncontrados = new DataTable();
        ClDataAcces objDataAccess = new ClDataAcces();
        SortedDictionary<string, int> dict
                       = new SortedDictionary<string, int>();
        SortedDictionary<int, string> baseConocimiento = new SortedDictionary<int, string>();
        Dictionary<string, string> ingredientes = new Dictionary<string, string>();
        FileTool objFileTool = new FileTool();
        string vocabulary = string.Empty;
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


        private void evaluarInfoDB(string value,int ingredienteID)
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
        private void removeNotIngredients(SortedDictionary<string,int> diccionario)
        {
            foreach(KeyValuePair<int,string>entrada in baseConocimiento){

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
            int count = 0,ingredientID =0;
            string infoRecipe = string.Empty;
            string ingredientValue = string.Empty;
            DataTable resultado = new DataTable();
            
            try { 
                resultado = objDataAccess.EjecutaQuery("SELECT * FROM ingredientes limit 0,1000");
                registroEncontrados = resultado.Copy();
                foreach (DataRow ingrediente in resultado.Rows)
                {

                    ingredientValue = ingrediente["descripcion"].ToString();
                    ingredientID = Convert.ToInt32(ingrediente["ingredienteID"].ToString());
                    txtDatosOrigen.Text += ingredientValue + "\r";
                    evaluarInfoDB(ingredientValue,ingredientID);
                    count++;
                    lbTotalregistro.Text = count.ToString();
                }
                MessageBox.Show("Proceso Concluido con exito");
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void frmMineria_Load(object sender, EventArgs e)
        {
            txtFrencuenciaPalabras.ScrollBars = ScrollBars.Both;
            buscarBaseConocimiento();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            buscarBaseConocimiento();
            if (!baseConocimiento.ContainsValue(txtNuevaPalabra.Text))
            {
                baseConocimiento.Add(baseConocimiento.Count + 1, txtNuevaPalabra.Text);
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
           
            if(baseConocimiento.Count > 0)
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
        private void buscarBaseConocimiento() {
            dynamic jsonData = JsonConvert.DeserializeObject(objFileTool.readJsonDataFromFile());
            baseConocimiento = jsonData.ToObject<SortedDictionary<int,string>>();
            txtMainVocabulary.Text = "";
            foreach (KeyValuePair<int,string>valor in baseConocimiento)
            {
                txtMainVocabulary.Text += valor.Value+", ";

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
                    baseConocimiento.Remove(baseConocimiento.FirstOrDefault(x=>x.Value == valueSeleted).Key);
                    actualizarVocaBulary();
                }
              
               
                
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }   
    
}
