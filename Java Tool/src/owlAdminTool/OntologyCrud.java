package owlAdminTool;
import java.io.IOException;
import java.io.PrintStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import org.apache.jena.ontology.DatatypeProperty;
import org.apache.jena.ontology.Individual;
import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.ontology.OntModelSpec;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.ontology.*;

public class OntologyCrud {
	
	public  void printProgBar(float percent,String info){
	    StringBuilder bar = new StringBuilder("[");

	    for(int i = 0; i < 50; i++){
	        if( i < (percent/2)){
	            bar.append("=");
	        }else if( i == (percent/2)){
	            bar.append(">");
	        }else{
	            bar.append(" ");
	        }
	    }

	    bar.append("]   " + percent + "%     "+info);
	    System.out.print("\r" + bar.toString());
	}
	
	
	public  void  GenerarMatrizSimilitud(String modelPath) throws Exception
	{
		String BaseUri = "";
		String path = modelPath;
		OntModel model = null;
		model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		model.read(path);
		BaseUri = model.getNsPrefixURI("");
		
		
		
	}
    
	public  void migrarDataToOwl(String modelPath,int cantidad) throws Exception  {
		float percent =0;
		double   contador = 0,totalRegistro =0;;
		

		String recipeID = "", Nombre = "", Sal = "", Calorias = "", Fibra = "", Azucar = "", Grasas = "",
				GrasasSaturadas = "", carbohidratos = "", proteinas = "", MainIngredient = "", geolocalizacion = "",
				Pais = "", Proteinas = "", Colesterol = "", RecipeTipoPlato = "", Location = "", PaisNombre = "",
				ClassOF = "", ingredienteDescripcion = "", ingredienteID = "", RecetaActual = "";

		 String ingredientName = "";
		Individual objreceta = null;
		Individual Ingrediente = null;
		Individual INDIVIngredientList = null;
		
		Statement  StIngredienteList = null;
		Statement StIngredient = null;
		ResultSet Ingredient = null;
		ResultSet RsListaIngredientes = null;
		
		OntClass IngredienteType = null;
		OntClass Receta = null;
		OntModel model = null;
		OntClass ClassIngredientList = null;

		
		
		
		
		String BaseUri = "";
		String path = modelPath;

		try {
			System.out.println("1-LEYENDO LOS DATOS DESDE LA BASE DE DATOS...");
			Class.forName("com.mysql.cj.jdbc.Driver");
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/foodrecomendersystemdb", "root",
					"admin");
			Statement st = conexion.createStatement();
			ResultSet Recipe = st.executeQuery("SELECT  distinct(recipeID),nombre  FROM recipedatatoowl where classOf is not null  limit 0,"+Integer.toString(cantidad)+";");
			
			
			Recipe.last();
			totalRegistro = Recipe.getRow();
			Recipe.beforeFirst();
			
			model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
			model.read(path);
			BaseUri = model.getNsPrefixURI("");
			Receta = model.getOntClass(BaseUri + "Receta");
			
			

			// DEFIDIENDO EL OBJECT PROPERTY QUE DESCRIBE LA REALACION DE LA RECETA CON LOS
			// INGREDIENTES
		

			if (Recipe != null) {
				
     			while (Recipe.next()) {
     				
     				 
				     recipeID = Recipe.getString("recipeID");
					 Nombre = Recipe.getObject("nombre").toString();
					 objreceta = model.createIndividual(BaseUri + recipeID, Receta);
				     objreceta.addLabel(model.createLiteral(Nombre));
			       	 StIngredient = conexion.createStatement();
					 Ingredient = StIngredient.executeQuery("SELECT * FROM recipedatatoowl where recipeId = " + recipeID + " and  classOf is not null ;");
					 contador++;
					 percent =   (float)((contador / totalRegistro) * 100);
					 printProgBar(percent,Double.toString(contador)+"/"+Double.toString(totalRegistro)+" ====> "+Nombre);

					if (Ingredient != null) {

						while (Ingredient.next()) {
							ObjectProperty hasIngredient = null;
							Sal 						= Ingredient.getString("sal");
							Calorias 					= Ingredient.getString("calorias");
							Fibra 						= Ingredient.getString("fibra");
							Azucar 						= Ingredient.getString("azucar");
							Grasas 						= Ingredient.getString("grasas");
							GrasasSaturadas 			= Ingredient.getString("fibra");
							carbohidratos 				= Ingredient.getString("azucar");
							proteinas 					= Ingredient.getString("proteinas");
							Colesterol 					= Ingredient.getString("Colesterol");
							RecipeTipoPlato 			= Ingredient.getString("recipeTipoPlatoData");
							geolocalizacion 			= Ingredient.getString("geolocalizacion");
							PaisNombre 					= Ingredient.getString("paisNombre");
							ClassOF 					= Ingredient.getString("classOf");
							MainIngredient 				= Ingredient.getString("mainIngredient");
							ingredienteDescripcion 		= Ingredient.getString("Ingredientedescripcion");
							ingredienteID 				= Ingredient.getString("ingredienteID");

							// CREACION DE LOS DATA PROPERTIES DE LA RECETA

							DatatypeProperty DPcalorias = model.getDatatypeProperty(BaseUri + "recetaCalorias");
							DatatypeProperty DPcarbohidradtos = model.getDatatypeProperty(BaseUri + "recetaCarbs");
							DatatypeProperty DPgrasas = model.getDatatypeProperty(BaseUri + "recetaFat");
							DatatypeProperty DPfibra = model.getDatatypeProperty(BaseUri + "recetaFibre");
							DatatypeProperty DPproteinas = model.getDatatypeProperty(BaseUri + "recetaProtein");
							DatatypeProperty DPSalt = model.getDatatypeProperty(BaseUri + "recetaSalt");
							DatatypeProperty DPSaturates = model.getDatatypeProperty(BaseUri + "recetaSaturates");
							DatatypeProperty DPSugar = model.getDatatypeProperty(BaseUri + "recetaSugar");
							DatatypeProperty DPrecetaID = model.getDatatypeProperty(BaseUri + "recetaID");

							// CREACION DE LOS DATAPEOPERTY DE LOS INGREDIENTES
							DatatypeProperty DPingrendienteID = model.getDatatypeProperty(BaseUri + "ingredienteID");
							DatatypeProperty DPIngredientePrincipal = model.getDatatypeProperty(BaseUri + "mainIngredient");
							// EVALUAR EL NOMBRE DE LA RECETA PARA CREAR EL OBJETO SI NO EXISTE

							
								
								
								// ASIGNANDO VALORES A LAS PROPIEDADES DE LA RECETA
							if(RecetaActual != Nombre)
							{
								RecetaActual = Nombre;
								objreceta.setPropertyValue(DPcalorias,
										model.createTypedLiteral((Calorias != "") ? Float.parseFloat(Calorias) : 0));
								objreceta.setPropertyValue(DPcarbohidradtos,
										model.createTypedLiteral((carbohidratos !="") ? Float.parseFloat(carbohidratos):0));
								objreceta.setPropertyValue(DPgrasas,
										model.createTypedLiteral((Grasas !="")? Float.parseFloat(Grasas):0));
								objreceta.setPropertyValue(DPfibra, model.createTypedLiteral(Float.parseFloat(Fibra)));
								objreceta.setPropertyValue(DPproteinas,
										model.createTypedLiteral((Proteinas != "") ? Float.parseFloat(Proteinas) : 0));
								objreceta.setPropertyValue(DPSalt,
										model.createTypedLiteral((Sal !="")? Float.parseFloat(Sal):0));
								objreceta.setPropertyValue(DPSaturates,
										model.createTypedLiteral((GrasasSaturadas!="")? Float.parseFloat(GrasasSaturadas):0));
								objreceta.setPropertyValue(DPSugar, model.createTypedLiteral((Azucar!="")?Float.parseFloat(Azucar):0));
								objreceta.setPropertyValue(DPrecetaID,
										model.createTypedLiteral(Integer.parseInt(recipeID)));
							

							}

							// CREANDO LOS INDIVIDUAL DE LOS INGREDINTES
							IngredienteType = model.getOntClass(BaseUri + "Ingrediente");
							Ingrediente = model.createIndividual(BaseUri + recipeID + "_" + ingredienteID,
									IngredienteType);

							// ASIGNANDO VALORES A LAS PROPIEDADES DE LOS INGREDIENTES

							Ingrediente.setPropertyValue(DPingrendienteID,
									model.createTypedLiteral(Integer.parseInt(ingredienteID)));
							Ingrediente.addLabel(model.createLiteral(MainIngredient));
							Ingrediente.setPropertyValue(DPIngredientePrincipal,model.createTypedLiteral(MainIngredient));

							// ASIGNANDO LA RELACION ENTRE LA RECETA ACTUAL CON EL INGREDIENTE CREADO
							hasIngredient = model.getObjectProperty(BaseUri + "recetaTieneIngrediente");
							model.add(objreceta,hasIngredient,Ingrediente);
						}

					}

					

				}
			}
			try {
				
				 StIngredienteList =  conexion.createStatement();
				 RsListaIngredientes = StIngredienteList.executeQuery("SELECT  * from ingredientlist");
				String ingredientListID = "";		 
				while(RsListaIngredientes.next()) {
					ingredientName =  RsListaIngredientes.getString("Descripcion");
					ingredientListID = RsListaIngredientes.getString("ingredientID");
					ClassIngredientList  = model.getOntClass(BaseUri+"ingredienteList");
					INDIVIngredientList = model.createIndividual(BaseUri+"Lst"+ingredientListID, ClassIngredientList);
				    INDIVIngredientList.addLabel(model.createLiteral(ingredientName));
				    System.out.println("\r "+"Lst"+ingredientName.trim());
					
				}
				System.out.println("\r LISTA DE INGREDIENTES GUARDADOS CON EXITO");
				
	
				
				PrintStream p = new PrintStream(path);
				model.writeAll(p, "RDF/XML", null);
				
				System.out.println("\r TOTAL DE RECETAS REGISTRADAS CON EXITO ===========> "+ Double.toString(totalRegistro));
			} catch (IOException e) {
				System.out.println("Caught the exception.");
			}
			
			
			
			
			model.close();
			Recipe.close();
			st.close();
			
			
			
			
			
       
		} catch (SQLException s) {
			System.out.println("Error: SQL.");
			System.out.println("SQLException: " + s.getMessage());
		} catch (Exception s) {
			System.out.println("Error: Varios.");
			System.out.println("SQLException: " + s.getMessage());
		}
		
		
		
	}
	
	
	

}
