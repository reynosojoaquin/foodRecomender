using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Transactions;
namespace MicroDataScraper
{
   public  class ClDataAcces
    {
        string connStr = "server=localhost;user=root;database=foodrecomendersystemdb;port=3306;password=admin";
        MySqlConnection conn = null;
        MySqlCommand comando = null;
        MySqlDataReader reader = null; 
        public DataTable EjecutaQuery(string queryStr)
        {
            DataTable resultado = new DataTable();
            try
            {
                conn = new MySqlConnection(connStr);
                comando = new MySqlCommand(queryStr, conn);
                conn.Open();
                reader = comando.ExecuteReader();
                resultado.Load(reader);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return resultado;
        }
        public void insertRecipeData(DataSet data)
        {
            DataTable retorno = null;
            string sQLString = String.Empty;
                 string calories = string.Empty, fat = string.Empty, saturatefat = string.Empty,
                fiber = string.Empty, carbohydrate = string.Empty, protein = string.Empty,
                cholesterol = string.Empty, sugar = string.Empty, sodium = string.Empty,
                name=string.Empty,ingrediente=string.Empty,id=string.Empty;

            using (TransactionScope transaction = new TransactionScope())
            {
                
                name = data.Tables[0].Rows[0]["Name"].ToString();
                if (!recipeExist(name))
                {
                    try
                    {
                        foreach (DataRow ntfil in data.Tables[1].Rows)
                        {
                            calories = ntfil["calorias"].ToString();
                            fat = ntfil["fat"].ToString();
                            saturatefat = ntfil["saturatefat"].ToString();
                            fiber = ntfil["fiber"].ToString();
                            carbohydrate = ntfil["carbohydrate"].ToString();
                            protein = ntfil["protein"].ToString();
                            cholesterol = ntfil["cholesterol"].ToString();
                            sugar = ntfil["sugar"].ToString();
                            sodium = ntfil["sodium"].ToString();
                        }

                        sQLString = "insert into recipe (Nombre,sal,calorias,fibra,azucar,grasas," +
                        "grasasSaturadas,carbohidratos,proteinas,colesterol) values ('{0}',{1},"
                        + "{2},{3},{4},{5},{6},{7},{8},{9});select max(recipeID) as codigo from recipe;";
                        sQLString = string.Format(sQLString, name, sodium, calories, fiber,
                            sugar, fat, saturatefat, carbohydrate,protein,cholesterol);
                        
                        retorno =  EjecutaQuery(sQLString);
                        id = retorno.Rows[0]["codigo"].ToString();
                        foreach (DataRow rcfil in data.Tables[0].Rows)
                        {
                            sQLString = "insert into ingredientes (recipeID,descripcion) values"
                                +" ({0},'{1}')";
                            sQLString = string.Format(sQLString,id, rcfil["ingrediente"].ToString());
                            EjecutaQuery(sQLString);
                        }
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
           }

        }

        
        public bool recipeExist(string id) {
            bool resultado = false;
            string Query = string.Empty;
            Query = "SELECT RECIPEID FROM RECIPE WHERE NOMBRE = '{0}'";
            Query = string.Format(Query, id);
            if (EjecutaQuery(Query).Rows.Count > 0)
                resultado = true;
            return resultado;

        }
    }
}
