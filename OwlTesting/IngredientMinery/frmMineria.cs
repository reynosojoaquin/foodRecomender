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

namespace IngredientMinery
{
    public partial class frmMineria : Form
    {
        DataTable registroEncontrados = new DataTable();
        ClDataAcces objDataAccess = new ClDataAcces();
        SortedDictionary<string, int> dict
                       = new SortedDictionary<string, int>();
        Dictionary<string, string> ingredientes = new Dictionary<string, string>();
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


        private void evaluarInfoDB()
        {

            txtFrencuenciaPalabras.Text = "";
            vocabulary = buscarDataVocabulary().Rows[0]["vocabulary"].ToString();
            palabras =  vocabulary.Split(',');
            if (txtDatosOrigen.Text != string.Empty)
            {
                string[] words = Tokenize(txtDatosOrigen.Text);
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
                            dict.Add(word, 1);
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
            }
        }
        private void removeNotIngredients(SortedDictionary<string,int> diccionario)
        {
            foreach(string word in palabras){

                diccionario.Remove(word);
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
            int count = 0;
            string infoRecipe = string.Empty;
            DataTable resultado = new DataTable();
            
            try { 
                resultado = objDataAccess.EjecutaQuery("SELECT * FROM ingredientes limit 0,100");
                registroEncontrados = resultado.Copy();
                foreach (DataRow ingrediente in resultado.Rows)
                {
                    txtDatosOrigen.Text += ingrediente["descripcion"].ToString() + "\r";
                    evaluarInfoDB();
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
            buscarDataVocabulary();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!txtMainVocabulary.Text.Contains(txtNuevaPalabra.Text))
            { 
                txtMainVocabulary.Text += txtNuevaPalabra.Text+",";
                actualizarVocaBulary();
                txtNuevaPalabra.Text = "";
            }
            else
            {
                MessageBox.Show("Palabra registrada en el vocabulario");
            }
        }
        private void actualizarVocaBulary()
        {
            string infoRecipe = string.Empty;
            DataTable resultado = new DataTable();
            if(txtMainVocabulary.Text != "") { 
            try
            {
                string SqlStr = "UPDATE main SET vocabulary = '{0}';select vocabulary from main";
                SqlStr = string.Format(SqlStr, txtMainVocabulary.Text);
                resultado = objDataAccess.EjecutaQuery(SqlStr);
                    txtMainVocabulary.Text = resultado.Rows[0]["vocabulary"].ToString();
                MessageBox.Show("Proceso Concluido con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
            string valueSeleted = string.Empty,tempValue = string.Empty;
            int index = 0;

            valueSeleted = txtMainVocabulary.SelectedText;
          if (txtMainVocabulary.SelectedText != "") {
                tempValue = txtMainVocabulary.Text;
                index = txtMainVocabulary.Text.IndexOf(valueSeleted);
                tempValue.Remove(index,valueSeleted.Length);
                txtMainVocabulary.Text = tempValue;
            }
        }

        private void evaluarIngredientes()
        {
            foreach (string word in palabras)
            {
                dict.Remove(word);
            }
            txtFrencuenciaPalabras.Text = "";
            StringBuilder resultSb = new StringBuilder(dict.Count * 9);
            foreach (KeyValuePair<string, int> entry in dict)
            {
                resultSb.AppendLine(string.Format("{0}", entry.Key));
            }

            txtFrencuenciaPalabras.Text = resultSb.ToString();
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
    }   
}
