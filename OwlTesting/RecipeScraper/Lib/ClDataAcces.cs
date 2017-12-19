using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
namespace RecipeScraper
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
            resultado.Columns.Add("error");
          
            try
            {
               
                conn = new MySqlConnection(connStr);
                comando = new MySqlCommand(queryStr, conn);
                conn.Open();
                reader = comando.ExecuteReader();
                resultado.Load(reader);
                reader.Close();
            }
            catch(Exception ex)
            {
                resultado.Rows.Add();
                resultado.Rows[0]["error"] = ex.ToString();

            }
            conn.Close();
            return resultado;
        }
        public string insertRecipeData(DataSet data,bool clasificar)
        {
            string sysMessage = "";
            int error = 0;
            DataTable retorno = new DataTable();
            string sQLString = String.Empty;
            string calories = string.Empty, fat = string.Empty, saturatefat = string.Empty,
            fiber = string.Empty, carbohydrate = string.Empty, protein = string.Empty,
            cholesterol = string.Empty, sugar = string.Empty, sodium = string.Empty,
            name = string.Empty, ingrediente = string.Empty, id = string.Empty, recipeTipoPlatoData = string.Empty,
            recipeCulturaData = string.Empty, recipeNacionalidadData = string.Empty,
            recipeMomentoData = string.Empty, recipeTemporadaData = string.Empty, Picture = string.Empty;

            using (TransactionScope transaction = new TransactionScope())
            {
                name = data.Tables[0].Rows[0]["Name"].ToString();
                recipeTipoPlatoData = data.Tables[0].Rows[0]["recipeTipoPlatoData"].ToString();
                recipeCulturaData = data.Tables[0].Rows[0]["recipeCulturaData"].ToString();
                recipeNacionalidadData = data.Tables[0].Rows[0]["recipeNacionalidadData"].ToString();
                recipeMomentoData = data.Tables[0].Rows[0]["recipeMomentoData"].ToString();
                recipeTemporadaData = data.Tables[0].Rows[0]["recipeTemporadaData"].ToString();
                Picture = data.Tables[0].Rows[0]["Picture"].ToString();
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
                        "grasasSaturadas,carbohidratos,proteinas,colesterol,recipeTipoPlatoData,"
                        + "recipeCulturaData,recipeNacionalidadData,recipeMomentoData,recipeTemporadaData,Picture)"
                        + " values ('{0}',{1},"
                        + "{2},{3},{4},{5},{6},{7},{8},{9},'{10}','{11}','{12}',"
                        + "'{13}','{14}','{15}');select max(recipeID) as codigo from recipe;";
                        sQLString = string.Format(sQLString, name, sodium, calories, fiber,
                            sugar, fat, saturatefat, carbohydrate, protein, cholesterol, recipeTipoPlatoData,
                            recipeCulturaData, recipeNacionalidadData, recipeMomentoData, recipeTemporadaData, Picture);

                        retorno = EjecutaQuery(sQLString);
                        id = retorno.Rows[0]["codigo"].ToString();

                        foreach (DataRow rcfil in data.Tables[0].Rows)
                        {
                            sQLString = "insert into ingredientes (recipeID,descripcion) values"
                                + " ({0},'{1}')";
                            sQLString = string.Format(sQLString, id, rcfil["ingrediente"].ToString());
                            retorno = EjecutaQuery(sQLString);

                        }
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        error++;
                        sysMessage = ex.Message;
                    }
                }
                else if (clasificar)
                {
                    using (TransactionScope transactionModifica = new TransactionScope())
                    {
                       
                        try
                        {
                            
                            sQLString = "update recipe  set  "
                           + " recipeTipoPlatoData = '{0}',recipeCulturaData = '{1}',recipeNacionalidadData = '{2}',recipeMomentoData = '{3}'"
                           + " recipeTemporadaData = '{4}' where descripcion = '{5}'";

                            sQLString = string.Format(sQLString, recipeTipoPlatoData,
                                recipeCulturaData, recipeNacionalidadData, recipeMomentoData, recipeTemporadaData,name);

                            retorno = EjecutaQuery(sQLString);

                            transaction.Complete();
                        }
                        catch (Exception ex)
                        {
                            error++;
                            sysMessage = ex.Message;
                        }


                        return sysMessage;
                    }
                    
                }
                return sysMessage;
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
