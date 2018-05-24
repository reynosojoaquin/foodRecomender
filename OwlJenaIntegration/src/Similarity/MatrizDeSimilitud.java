package Similarity;

import java.util.ArrayList;
import java.util.Iterator;

import org.apache.jena.ontology.OntModel;
import org.apache.jena.ontology.OntModelSpec;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.StmtIterator;
import org.apache.jena.vocabulary.RDF;
import OwlCrud.*;
import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.rdf.model.Literal;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.Statement;
import org.apache.jena.rdf.model.StmtIterator;
import org.apache.jena.util.iterator.ExtendedIterator;
import org.apache.jena.vocabulary.RDFS;
public class MatrizDeSimilitud {

	@SuppressWarnings("unchecked")
	public void GenerateMatrizDeSimilitud(String Modelpath) {
		int total =0;
		double porcentage = 0;
		int contador = 0;
		ArrayList<receta> listRegisteredRecipe = new ArrayList<receta>();
		ArrayList<receta> listRegisteredRecipeCopy = new ArrayList<receta>();
		String BaseUri ="";
		String path = "src/FoodOntologyRecomenderOwl352018.owl" ;
		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		model.read(Modelpath);
		BaseUri = 	model.getNsPrefixURI(""); 
		Resource RecipeList = model.getResource( BaseUri + "Receta" );
	   
		StmtIterator i = model.listStatements( null, RDF.type, RecipeList);
		System.out.println("*********** GENERANDO MATRIZ DE SIMILITUD ************");
	        while (i.hasNext()) 
	        {
	            receta objReceta = new receta();
	        	Resource Receta = i.next().getSubject();
	        	objReceta.getData(Receta, model);
	        	listRegisteredRecipe.add(objReceta);
	           
	            
	        }
	        listRegisteredRecipeCopy = new  ArrayList<receta>(listRegisteredRecipe) ;
	        total = listRegisteredRecipeCopy.size(); 
	        
	        Iterator<receta> IngLst = listRegisteredRecipeCopy.iterator();
			while(IngLst.hasNext()) 
			{
				contador++;
				receta element = IngLst.next();
				System.out.println("Receta: "+element.Nombre+" "+Integer.toString(contador)+"/"+
				Integer.toString(total)+" \r");
				Iterator<String> prop =  element.GetObjectProPerties().iterator();
				while(prop.hasNext()) {
					while(prop.hasNext()) {
						System.out.println(prop.next().toString());
					}
				}
				System.out.println(" \r");
				
			}
			System.out.println("*********** PROCESO CONCLUIDO CON EXITO ************");
	}
	

}
