package OwlCrud;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.jena.ontology.DatatypeProperty;
import org.apache.jena.ontology.Individual;
import org.apache.jena.ontology.ObjectProperty;
import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.ontology.OntModelSpec;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.rdf.model.Resource;




public class DataTranfer {

	String BaseUri,path="";
	OntModel modelo = null;
	Statement  StIngredientes  = null;
	ResultSet  Ingredientes	= null;
	
	String recipeID = "", Nombre = "", Sal = "", Calorias = "", Fibra = "", Azucar = "", Grasas = "",
			GrasasSaturadas = "", carbohidratos = "", proteinas = "", MainIngredient = "", geolocalizacion = "",
			Pais = "", Proteinas = "", Colesterol = "", RecipeTipoPlato = "", Location = "", PaisNombre = "",
			ClassOF = "", ingredienteDescripcion = "", ingredienteID = "", RecetaActual = "";

	
	/*PROCEDIMIENTO PARA BUSCAR LA INFORMACION DESDE LA BASE DE DATOS
	 * SqlQuery: parametro que contiene la sentencia sql con la que se consulta la base de datos
	 * Cantidad: parametro que representa la cantidad de registros que se solicitan a la base de datos
	 */
	public ResultSet GetDbData(String Sqlquery,int Cantidad) throws Exception {
		ResultSet Data = null;
		System.out.println("1-LEYENDO LOS DATOS DESDE LA BASE DE DATOS...");
		Class.forName("com.mysql.cj.jdbc.Driver");
		Connection conexion = GetConnection();
		Statement st = conexion.createStatement();
	    try {
			return	 Data = st.executeQuery(Sqlquery+
					Integer.toString(Cantidad)+";");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return Data;
		
	}
    
	/*PROCEDIMIENTO QUE DEVUELVE UN MODELO ONTOLOGICO A PARTIR DE LA RUTA 
	 * path: parametro que representa la ruta de la ubicacion del archivo de la ontologia
	 */
		
	public OntModel CreateOntoModel(String path) 
	{
		
		modelo = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		modelo.read(path);
		BaseUri = modelo.getNsPrefixURI("");
		return modelo;
	}

	public Individual CreateRecipeIndividual() throws Exception
	{
		 Individual receta 			= null;
		 Individual Ingrediente     = null;
		 Individual tipoPlato		= null;
		 Connection con 			= null;
		 OntClass   RecetaType       = null;
		
		 ObjectProperty hasIngredient = null;
		 ObjectProperty hasTipoPlato = null;
		 
		 RecetaType = modelo.getOntClass(BaseUri + "Receta");
		 receta = modelo.createIndividual(BaseUri + recipeID, RecetaType);
	     receta.addLabel(modelo.createLiteral(Nombre));
	     
	     RecetaActual = Nombre;
	     con = this.GetConnection();
	   	 StIngredientes = con.createStatement();
		 Ingredientes =  GetDbData("SELECT * FROM recipedatatoowl where recipeId = " +
		      	 recipeID + " and  classOf is not null and recipeTipoPlatoData <> '' limit 0,",20);
		 if(Ingredientes != null)
		 {
			 while(Ingredientes.next()) 
			 {
			    Sal = Ingredientes.getString("sal");
				Calorias = Ingredientes.getString("calorias");
				Fibra = Ingredientes.getString("fibra");
				Azucar = Ingredientes.getString("azucar");
				Grasas = Ingredientes.getString("grasas");
				GrasasSaturadas = Ingredientes.getString("fibra");
				carbohidratos = Ingredientes.getString("azucar");
				proteinas = Ingredientes.getString("proteinas");
				Colesterol = Ingredientes.getString("Colesterol");
				RecipeTipoPlato = Ingredientes.getString("recipeTipoPlatoData");
				geolocalizacion = Ingredientes.getString("geolocalizacion");
				PaisNombre = Ingredientes.getString("paisNombre");
				
				// CREACION DE LOS DATA PROPERTIES DE LA RECETA

				DatatypeProperty DPcalorias 	  = 	GetDataProperty("recetaCalorias");
				DatatypeProperty DPcarbohidradtos = 	GetDataProperty("recetaCarbs");
				DatatypeProperty DPgrasas         = 	GetDataProperty("recetaFat");
				DatatypeProperty DPfibra 	      =		GetDataProperty("recetaFibre");
				DatatypeProperty DPproteinas 	  =		GetDataProperty("recetaProtein");
				DatatypeProperty DPSalt 		  =		GetDataProperty("recetaSalt");
				DatatypeProperty DPSaturates 	  =		GetDataProperty("recetaSaturates");
				DatatypeProperty DPSugar 		  =		GetDataProperty("recetaSugar");
				DatatypeProperty DPrecetaID 	  =		GetDataProperty("recetaID");

			
				// ASIGNANDO VALORES A LAS PROPIEDADES DE LA RECETA
				if(RecetaActual != Nombre)
				{
					RecetaActual = Nombre;
					receta.setPropertyValue(DPcalorias,
							modelo.createTypedLiteral((Calorias != "") ? Float.parseFloat(Calorias) : 0));
					receta.setPropertyValue(DPcarbohidradtos,
							modelo.createTypedLiteral((carbohidratos !="") ? Float.parseFloat(carbohidratos):0));
					receta.setPropertyValue(DPgrasas,
							modelo.createTypedLiteral((Grasas !="")? Float.parseFloat(Grasas):0));
					receta.setPropertyValue(DPfibra, modelo.createTypedLiteral(Float.parseFloat(Fibra)));
					receta.setPropertyValue(DPproteinas,
							modelo.createTypedLiteral((Proteinas != "") ? Float.parseFloat(Proteinas) : 0));
					receta.setPropertyValue(DPSalt,
							modelo.createTypedLiteral((Sal !="")? Float.parseFloat(Sal):0));
					receta.setPropertyValue(DPSaturates,
							modelo.createTypedLiteral((GrasasSaturadas!="")? Float.parseFloat(GrasasSaturadas):0));
					receta.setPropertyValue(DPSugar, modelo.createTypedLiteral((Azucar!="")?Float.parseFloat(Azucar):0));
					receta.setPropertyValue(DPrecetaID,
							modelo.createTypedLiteral(Integer.parseInt(recipeID)));
			
				}
				Ingrediente = GetIngredient(Ingredientes);
				
				// ASIGNANDO LA RELACION ENTRE LA RECETA ACTUAL CON EL INGREDIENTE CREADO
				hasIngredient =  GetObjectProperty("recetaTieneIngrediente");
				hasTipoPlato  =  GetObjectProperty("recetaTieneTipoPlato");
				tipoPlato     = modelo.getIndividual(BaseUri+RecipeTipoPlato);
				modelo.add(receta,hasIngredient,Ingrediente);
				if(tipoPlato != null)
			    	modelo.add(receta,hasTipoPlato,tipoPlato);
				}
		 }
	     con.close();
	     return receta;
	}
	
	public DatatypeProperty GetDataProperty(String nombre) {
		return modelo.getDatatypeProperty(BaseUri + nombre);
	}
	
	public ObjectProperty GetObjectProperty(String nombre) {
		return modelo.getObjectProperty(BaseUri+nombre);
	}
	
	public Connection GetConnection() throws ClassNotFoundException 
	{
		Connection conexion = null;
		try {
		Class.forName("com.mysql.cj.jdbc.Driver");
	    conexion = DriverManager.getConnection("jdbc:mysql://localhost/foodrecomendersystemdb",
				"root","admin");
	    }catch (SQLException s) {
			System.out.println("Error: SQL.");
			System.out.println("SQLException: " + s.getMessage());
		} 
	    return conexion; 
	}
  
	public Individual GetIngredient(ResultSet IngredientData) throws SQLException, FileNotFoundException {
    
    	Individual ingrediente = null;
    	OntClass IngredienteType = null;
    	
    	MainIngredient 			= IngredientData.getString("mainIngredient");
		ingredienteDescripcion 	= IngredientData.getString("Ingredientedescripcion");
		ingredienteID 			= IngredientData.getString("ingredienteID");
		ClassOF 				= IngredientData.getString("classOf");
		String Uri    = BaseUri+tools.remplaceWhiteSpace(MainIngredient);
		ingrediente   = modelo.getIndividual(Uri);
		System.out.println(MainIngredient);
		if(ingrediente == null) 
		{
			// CREACION DE LOS DATAPEOPERTY DE LOS INGREDIENTES
			DatatypeProperty DPingrendienteID 		= 	modelo.getDatatypeProperty(BaseUri + "ingredienteID");
			DatatypeProperty DPIngredientePrincipal = 	modelo.getDatatypeProperty(BaseUri + "mainIngredient");
			DatatypeProperty DPIngredienteClass     = 	modelo.getDatatypeProperty(BaseUri + "ingredienteClass");
		
			// CREANDO LOS INDIVIDUAL DE LOS INGREDINTES
			IngredienteType = modelo.getOntClass(BaseUri + ClassOF);
			ingrediente = modelo.createIndividual(Uri,IngredienteType);
       
			// ASIGNANO VALORES A LAS PROPIEDADES DE LOS INGREDIENTES

			ingrediente.setPropertyValue(DPingrendienteID,modelo.createTypedLiteral(Integer.parseInt(ingredienteID)));
			ingrediente.addLabel(modelo.createLiteral(MainIngredient));
			ingrediente.setPropertyValue(DPIngredientePrincipal,modelo.createTypedLiteral(MainIngredient));
			ingrediente.setPropertyValue(DPIngredienteClass,modelo.createTypedLiteral(ClassOF));
			
		}
    	return ingrediente;
    }

	public void MigrateDataToOwl(String modelPath,String SqlStr,int cant) throws Exception {
		path = modelPath;
		ResultSet Recetas = null;
		float percent =0;
		double   contador = 0,totalRegistro =0;;
		Recetas = GetDbData(SqlStr, cant);
		CreateOntoModel(modelPath);
		
		if(Recetas != null)
		{
			 Recetas.last();
			 totalRegistro = Recetas.getRow();
		     Recetas.beforeFirst();
			while(Recetas.next())
			{
				
				 Nombre = Recetas.getObject("nombre").toString();
				 recipeID = Recetas.getObject("recipeID").toString();
				 contador++;
				 percent =   (float)((contador / totalRegistro) * 100);
				 tools.printProgBar(percent,Double.toString(contador)+"/"+Double.toString(totalRegistro)+" ====> "+Nombre);
				 this.CreateRecipeIndividual();
			}
		}
		SaveData();
		
	}
	public void SaveData() throws SQLException 
	{
		try {	
				PrintStream p = new PrintStream(path);
				modelo.writeAll(p, "RDF/XML", null);
				System.out.println("*********** RECETAS REGISTRADAS CON EXITO ************");
			} 
		    catch (IOException e)
			{
				System.out.println("Caught the exception.");
			}
		modelo.close();
		StIngredientes.close();
		Ingredientes.close();
	}
}
