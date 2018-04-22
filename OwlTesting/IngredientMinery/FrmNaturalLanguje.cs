using RecipeScraper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IngredientMinery
{
    public partial class FrmNaturalLanguje : Form
    {
        ClDataAcces objDataAccess = new ClDataAcces();
        private static char[] delimiters_no_digits = new char[] {
            '{', '}', '(', ')','[', ']', '>', '<','-', '_', '=', '+',
            '|', '\\', ':', ';', ' ', ',', '.', '/', '?', '~', '!',
            '@', '#', '$', '%', '^', '&', '*', ' ', '\r', '\n', '\t',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','½','¼','¾' };
        public FrmNaturalLanguje()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            
            CheckForIllegalCrossThreadCalls = false;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            Task cargarIngredientesAsync = new Task(() =>
            {
                buscarResultado();

            });
            cargarIngredientesAsync.Start();

        }
        private void buscarResultado()
        {
            DataTable Data = new DataTable();
            string resultado = string.Empty, ingredientValue = string.Empty;
            int patronT = txtPatron.Text.Trim().Length;
            int index = 0;
            StringBuilder strB = new StringBuilder();
            string sQlString = "SELECT * FROM translate limit 0,100";
            Data = objDataAccess.EjecutaQueryGet(sQlString);
            foreach (DataRow ingrediente in Data.Rows)
            {

                ingredientValue = ingrediente["IngredienteDescripcion"].ToString().Trim();
                index = ingredientValue.IndexOf(txtPatron.Text);
                if (index < 0)
                {

                    strB.AppendLine(RemoverNumeros(ingredientValue));
                }
                else
                {
                    index += patronT;
                    resultado = ingredientValue.Trim().Substring(index, ingredientValue.Length - (index));
                    strB.AppendLine(RemoverNumeros(resultado.Trim()));
                }



            }
            txtResultado.Text += strB.ToString();


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
        public string RemoverNumeros(string value) {
            string result = string.Empty;
            int umIndex = 0;
            string[] palabras = Tokenize(value);
            foreach (string word in palabras) {
                
                     result += $" {word}"; 
            }
            umIndex = result.IndexOf("g ");
            if (umIndex > 0)
              result =  result.Remove(umIndex, 2);
            return result.TrimStart();
        }
    }

}
