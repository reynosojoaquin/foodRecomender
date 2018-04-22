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
        MySqlDataAdapter adapter = null;

        public DataTable EjecutaQueryGet(string queryStr)
        {
            DataTable resultado = new DataTable();
            
            resultado.Columns.Add("error");
          
            try
            {
            
                conn = new MySqlConnection(connStr);
                comando = new MySqlCommand(queryStr, conn);
                adapter = new MySqlDataAdapter(comando);
                conn.Open();
                adapter.Fill(resultado);
                //reader = comando.ExecuteReader();
                //resultado.Load(reader);
               // reader.Close();
            }
            catch(Exception ex)
            {
                resultado.Rows.Add();
                resultado.Rows[0]["error"] = ex.ToString();

            }
            conn.Close();
            return resultado;
        }
        public DataTable EjecutaQuerySet(string queryStr)
        {
            DataTable resultado = new DataTable();

            resultado.Columns.Add("error");

            try
            {

                conn = new MySqlConnection(connStr);
                comando = new MySqlCommand(queryStr, conn);
                conn.Open();
                reader = comando.ExecuteReader();
                //resultado.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
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
            recipeMomentoData = string.Empty, recipeTemporadaData = string.Empty, Picture = string.Empty,origen=string.Empty;
            Boolean esSopa = false, esPasta = false, esMarisco = false, esEnsalada = false,
            EsBebida = false, esBajoColesterol = false, esBajoEnCalorias = false, esLibreGluten = false;

            using (TransactionScope transaction = new TransactionScope())
            {
                name = data.Tables[0].Rows[0]["Name"].ToString();
                origen = data.Tables[0].Rows[0]["origen"].ToString();
                recipeTipoPlatoData = data.Tables[0].Rows[0]["recipeTipoPlatoData"].ToString();
                recipeCulturaData = data.Tables[0].Rows[0]["recipeCulturaData"].ToString();
                recipeNacionalidadData = data.Tables[0].Rows[0]["recipeNacionalidadData"].ToString();
                recipeMomentoData = data.Tables[0].Rows[0]["recipeMomentoData"].ToString();
                recipeTemporadaData = data.Tables[0].Rows[0]["recipeTemporadaData"].ToString();
                Picture = data.Tables[0].Rows[0]["Picture"].ToString();
                esSopa = Convert.ToBoolean(data.Tables[0].Rows[0]["esSopa"].ToString());
                esPasta = Convert.ToBoolean(data.Tables[0].Rows[0]["esPasta"].ToString());
                esMarisco = Convert.ToBoolean(data.Tables[0].Rows[0]["esMarisco"].ToString());
                esEnsalada = Convert.ToBoolean(data.Tables[0].Rows[0]["esEnsalada"].ToString());
                EsBebida = Convert.ToBoolean(data.Tables[0].Rows[0]["esBebida"].ToString());
                esBajoColesterol = Convert.ToBoolean(data.Tables[0].Rows[0]["esBajoColesterol"].ToString());
                esBajoEnCalorias = Convert.ToBoolean(data.Tables[0].Rows[0]["esBajoEnCalorias"].ToString());
                esLibreGluten = Convert.ToBoolean(data.Tables[0].Rows[0]["esLibreGluten"].ToString());


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

                        retorno = EjecutaQuerySet(sQLString);
                        id = retorno.Rows[0]["codigo"].ToString();

                        foreach (DataRow rcfil in data.Tables[0].Rows)
                        {
                            sQLString = "insert into ingredientes (recipeID,descripcion) values"
                                + " ({0},'{1}')";
                            sQLString = string.Format(sQLString, id, rcfil["ingrediente"].ToString());
                            retorno = EjecutaQuerySet(sQLString);

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
                           + " recipeTipoPlatoData = '{0}',recipeCulturaData = '{1}',recipeNacionalidadData = '{2}',recipeMomentoData = '{3}',"
                           + " recipeTemporadaData = '{4}',origen ='{5}', "
                           +"esSopa = {6}, esPasta = {7}, esMarisco={8}, esEnsalada ={9}, esBebida={10}, esBajoColesterol={11}, "
                           +"esBajoEnCalorias={12},esLibreGluten={13}"
                           + " where Nombre = '{14}'";

                            sQLString = string.Format(sQLString, recipeTipoPlatoData,
                                recipeCulturaData, recipeNacionalidadData, recipeMomentoData, recipeTemporadaData,origen,esSopa
                                ,esPasta,esMarisco,esEnsalada,EsBebida,esBajoColesterol,esBajoEnCalorias,esLibreGluten, name);
                            retorno = EjecutaQuerySet(sQLString);
                            transactionModifica.Complete();
                        }
                        catch (Exception ex)
                        {
                            error++;
                            sysMessage = ex.Message;
                        }


                       
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
                    if (EjecutaQueryGet(Query).Rows.Count > 0)
                        resultado = true;
                    return resultado;

                }
            } 
}
