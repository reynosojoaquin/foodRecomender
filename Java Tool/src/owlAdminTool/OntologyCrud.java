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
import org.apache.jena.ontology.ObjectProperty;
import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.ontology.OntModelSpec;
import org.apache.jena.rdf.model.ModelFactory;
public class OntologyCrud {

	public static void FillOwlModel() 
	{
		String recipeID = "",Nombre ="",Sal="",Calorias="",Fibra="",Azucar="",
		       Grasas ="",GrasasSaturadas="",carbohidratos="",proteinas="",
		       MainIngredient ="",ClassOf="",geolocalizacion = "",Pais="",
		   	   Proteinas="",Colesterol="",RecipeTipoPlaro="",Location ="",
			   PaisNombre="",ClassOF ="",ingredienteDescripcion="",ingredienteID="",RecipeID="",RecetaActual="";	
		       Individual objreceta = null; ObjectProperty hasIngredient = null; Individual Ingrediente = null;
		    
		
		
		 try {
	            Class.forName("com.mysql.cj.jdbc.Driver");
	            Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/foodrecomendersystemdb", "root", "admin");
	            Statement st = conexion.createStatement();
	            ResultSet Recipe = st.executeQuery("SELECT  distinct(recipeID),nombre  FROM recipedatatoowl ;");
	            
	            String BaseUri ="";
	    		String path = "src/FoodOntologyRecomenderOwl2142018.owl" ;
	    		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
	    		model.read(path);
	    		BaseUri = 	model.getNsPrefixURI(""); 
	    		OntClass Receta = model.getOntClass(BaseUri+"Receta");
	    		OntClass IngredienteType = null;
	    		
	    		//DEFIDIENDO EL OBJECT PROPERTY QUE DESCRIBE LA REALACION DE LA RECETA CON LOS INGREDIENTES
		        hasIngredient = model.getObjectProperty(BaseUri+"recetaTieneIngrediente");
	        
		        
		        if (Recipe != null) {
	                  while (Recipe.next()) 
	                  {
	                	  Nombre   = Recipe.getObject("nombre").toString();
	     	    		  recipeID = Recipe.getObject("recipeID").toString();
	     	    		 
	                	  Statement StIngredient = conexion.createStatement();
	      	              ResultSet Ingredient = StIngredient.executeQuery("SELECT * FROM recipedatatoowl where recipeId = "+
	                	  recipeID+";");
	      	             
	      	              while(Ingredient.next()) 
	      	              {
	      	            	  
	      	            	  
	      	            	  Sal      = Ingredient.getObject("sal").toString();
	      	            	  Calorias = Ingredient.getObject("calorias").toString();
	      	            	  Fibra	   = Ingredient.getObject("fibra").toString();
	      	            	  Azucar   = Ingredient.getObject("azucar").toString();
	      	            	  Grasas   = Ingredient.getObject("grasas").toString();
	      	             	  GrasasSaturadas	   = Ingredient.getObject("fibra").toString();
	      	            	  carbohidratos   = Ingredient.getObject("azucar").toString();
	      	            	  proteinas   = Ingredient.getObject("proteinas").toString();
	      	            	  Colesterol=Ingredient.getObject("Colesterol").toString();
	      	            	  RecipeTipoPlaro=Ingredient.getObject("recipeTipoPlato").toString();
	      	            	  Location =Ingredient.getObject("Location").toString();
	      	            	  PaisNombre=Ingredient.getObject("PaisNombre").toString();
	      	            	  ClassOF =Ingredient.getObject("classOf").toString();
	      	                  MainIngredient=Ingredient.getObject("mainIngredient").toString();;
	      	                  ingredienteDescripcion=Ingredient.getObject("ingredienteDescripcion").toString();
	      	                  ingredienteID=Ingredient.getObject("ingredienteID").toString();	
	      	            	 
	      	            	  
	      	            	  
	      	            	  
	      	            	//CREACION DE LOS DATA PROPERTIES DE LA RECETA
	      	            	  
	      	            	DatatypeProperty DPcalorias =  model.getDatatypeProperty(BaseUri+"recetaCalorias");
      		    		    DatatypeProperty DPcarbohidradtos =  model.getDatatypeProperty(BaseUri+"recetaCarbs");
      		    		    DatatypeProperty DPgrasas =  model.getDatatypeProperty(BaseUri+"recetaFat");
      		    		    DatatypeProperty DPfibra =  model.getDatatypeProperty(BaseUri+"recetaFibre");
      		    		    DatatypeProperty DPproteinas =  model.getDatatypeProperty(BaseUri+"recetaProtein");
    		    		    DatatypeProperty DPSalt =  model.getDatatypeProperty(BaseUri+"recetaSalt");
    		    		    DatatypeProperty DPSaturates =  model.getDatatypeProperty(BaseUri+"recetaSaturates");
    		    		    DatatypeProperty DPSugar =  model.getDatatypeProperty(BaseUri+"recetaSugar");
	      	            	  
	      	            	//EVALUAR EL NOMBRE DE LA RECETA PARA CREAR EL OBJETO SI NO EXISTE
    		    		    
    		    		    if(Nombre != RecetaActual)
    		    		    {
    		    	 		    	 RecetaActual = Nombre;
    		    	 		    	 objreceta = model.createIndividual(BaseUri+ RecipeID, Receta);
    		    	 		    	 
    		    		    }
    		    		    
    		    		    // ASIGNANDO VALORES A LAS PROPIEDADES DE LA RECETA
                	  		
                	  	              	  		
                	  	    objreceta.setPropertyValue(DPcalorias,model.createTypedLiteral(Calorias));
           		    		objreceta.setPropertyValue(DPcarbohidradtos,model.createTypedLiteral(carbohidratos));
           		    		objreceta.setPropertyValue(DPgrasas,model.createTypedLiteral(Grasas));
           		    		objreceta.setPropertyValue(DPfibra,model.createTypedLiteral(Fibra));
           		      		objreceta.setPropertyValue(DPproteinas,model.createTypedLiteral(Proteinas));
           		    		objreceta.setPropertyValue(DPSalt,model.createTypedLiteral(Sal));
           		    		objreceta.setPropertyValue(DPSaturates,model.createTypedLiteral(GrasasSaturadas));
           		    		objreceta.setPropertyValue(DPSugar,model.createTypedLiteral(Azucar));
           		    		
           		    		
      		  		        
      		  		        //CREANDO LOS INDIVIDUAL DE LOS INGREDINTES 
           		    	    IngredienteType = model.getOntClass(ClassOF);
	            		    Ingrediente = model.createIndividual(BaseUri+recipeID+"_"+ingredienteID,IngredienteType);
	            		   
	            		   
	            		   // ASIGNANDO LA RELACION ENTRE LA RECETA ACTUAL CON EL INGREDIENTE CREADO
	            		    
	      	    		    objreceta.setPropertyValue(hasIngredient, Ingrediente);
	  		    		    
	      	            	  
	      	              }
	                	  
	                	  
	                	  
	                	  
	                	  
	                  /*  System.out.println("  ID: " + rs.getObject("PaisID"));
	                    System.out.println("  Nombre: " + rs.getObject("Descripcion"));
	                    System.out.println("  Geolocalizacion: " + rs.getObject("geolocalizacion"));
	                    System.out.println("- ");*/
	                }
	                 
		    		    
		    		    //  model.createIndividual(BaseUri+"PapaFrita", Receta);
		    		    try {
		    		    	 PrintStream p= new PrintStream(path);
		    		    	 model.writeAll(p, "RDF/XML", null);
		    		 	     model.close();
		    	        } catch (IOException e) {
		    	            System.out.println("Caught the exception.");
		    	        }    
	                Recipe.close();
	            }
	            st.close();
	 
	        }
	        catch(SQLException s)
	        {
	            System.out.println("Error: SQL.");
	            System.out.println("SQLException: " + s.getMessage());
	        }
	        catch(Exception s)
	        {
	            System.out.println("Error: Varios.");
	            System.out.println("SQLException: " + s.getMessage());
	        }
	}
}
