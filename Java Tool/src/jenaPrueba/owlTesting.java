package jenaPrueba;

import java.io.IOException;
import java.io.PrintStream;

import org.apache.jena.ontology.DatatypeProperty;
import org.apache.jena.ontology.Individual;
import org.apache.jena.ontology.ObjectProperty;
import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.ontology.OntModelSpec;
import org.apache.jena.rdf.model.ModelFactory;
import org.omg.CORBA.portable.IndirectionException;

public class owlTesting {

	public static void main(String[] args)  throws IOException{
		
       CreateIndividual();
	}
	public static void ReadFileOwl() {
		
		String path = "src/FoodOntologyRecomenderOwl2142018.owl" ;
		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		model.read(path);
		model.write(System.out);
	}
	
	    public static void CreateIndividual(){
		String BaseUri ="";
		String path = "src/FoodOntologyRecomenderOwl2142018.owl" ;
		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		model.read(path);
		
	    BaseUri = 	model.getNsPrefixURI(""); 
	    OntClass Receta = model.getOntClass(BaseUri+"Receta");  
	    Individual papaFrita = model.createIndividual(BaseUri+"PapaFrita", Receta);
	    DatatypeProperty calorias =  model.getDatatypeProperty(BaseUri+"recetaCalorias");
	    DatatypeProperty carbohidradtos =  model.getDatatypeProperty(BaseUri+"recetaCarbs");
	    DatatypeProperty grasas =  model.getDatatypeProperty(BaseUri+"recetaFat");
	    DatatypeProperty fibra =  model.getDatatypeProperty(BaseUri+"recetaFibre");
	    
	    papaFrita.setPropertyValue(calorias,model.createTypedLiteral(10.0));
	    papaFrita.setPropertyValue(carbohidradtos,model.createTypedLiteral(20.0));
	    papaFrita.setPropertyValue(grasas,model.createTypedLiteral(30.0));
	    papaFrita.setPropertyValue(fibra,model.createTypedLiteral(40.0));
	  
	    ObjectProperty hasIngredient = model.getObjectProperty(BaseUri+"recetaTieneIngrediente");
	    Individual ingrediente = model.getIndividual(BaseUri+"papa");
	    
	    papaFrita.setPropertyValue(hasIngredient, ingrediente);
	    
	    
	    //  model.createIndividual(BaseUri+"PapaFrita", Receta);
	    try {
	    	 PrintStream p= new PrintStream(path);
	    	 model.writeAll(p, "RDF/XML", null);
	 	     model.close();
        } catch (IOException e) {
            System.out.println("Caught the exception.");
        }
	   
	   

	    
	    
	   System.out.print(Receta.getURI());
	} 

}
