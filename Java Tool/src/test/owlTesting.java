package test;
import java.io.IOException;
import java.io.PrintStream;
import java.util.Iterator;

import org.apache.jena.ontology.DatatypeProperty;
import org.apache.jena.ontology.Individual;
import org.apache.jena.ontology.ObjectProperty;
import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.ontology.OntModelSpec;
import org.apache.jena.rdf.model.Literal;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.RDFNode;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.Statement;
import org.apache.jena.rdf.model.StmtIterator;
import org.apache.jena.vocabulary.RDF;
import org.apache.jena.vocabulary.RDFS;


public class owlTesting {

	
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
    public static void printSpesificClass() {
    	
    	@SuppressWarnings("unused")
		String BaseUri ="";
		String path = "src/FoodOntologyRecomenderOwl2142018.owl" ;
		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		model.read(path);
		BaseUri = 	model.getNsPrefixURI(""); 
		
		for (Iterator<OntClass> i = model.listClasses();i.hasNext();){
			OntClass cls = i.next();
			System.out.print(cls.getLocalName()+": ");
			for(@SuppressWarnings("rawtypes")
			Iterator it = cls.listInstances(true);it.hasNext();){
				Individual ind = (Individual)it.next();
				if(ind.isIndividual()){
					System.out.print(ind.getLocalName()+" ");
				}
			}
			System.out.println();
		}
		/*
	    Resource recipe = model.getResource( BaseUri + "Receta" );
 
	    StmtIterator i = model.listStatements( null, RDF.type, recipe );

	        while (i.hasNext()) {
	            Resource receta = i.next().getSubject();
	            System.out.println( receta.getURI() );
	        }
    	*/
    }

    protected String getValueAsString( Resource r, Property p ) {
        Statement s = r.getProperty( p );
        if (s == null) {
            return "";
        }
        else {
            return s.getObject().isResource() ? s.getResource().getURI() : s.getString();
        }
    }
    
    protected String getEnglishLabel( Resource cheese ) {
        StmtIterator i = cheese.listProperties( RDFS.label );
        while (i.hasNext()) {
            Literal l = i.next().getLiteral();

            if (l.getLanguage() != null && l.getLanguage().equals( "en")) {
                // found the English language label
                return l.getLexicalForm();
            }
        }

        return "A Cheese with No Name!";
    } 
    protected  String getLabel( Resource individual ) {
        StmtIterator i = individual.listProperties( RDFS.label );
        while (i.hasNext()) {
            Literal l = i.next().getLiteral();

            if (l.getLanguage() != null) {
                // found the English language label
                return l.getLexicalForm();
            }
        }

        return "";
    } 
    
    @SuppressWarnings("unused")
	protected  void listTemporadas(  ) {
    	String[] ingredientDtProperties = {"ingredienteID","mainIngredient"};
    	String[] recetaDtProperties = {"recetaCalorias","recetaCarbs","recetaFat",
    			"recetaFibre","rectaID","recetaSalt","recetaProtein","recetaSaturates","recetaSugar"};
    
    	String BaseUri ="";
		String path = "src/FoodOntologyRecomenderOwl352018.owl" ;
		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		model.read(path);
		BaseUri = 	model.getNsPrefixURI(""); 
    	
    	
        Resource cheeseClass = model.getResource( BaseUri + "Receta" );
   
        StmtIterator i = model.listStatements( null, RDF.type, cheeseClass );

        while (i.hasNext()) {
            Resource cheese = i.next().getSubject();
            String Label = getLabel(cheese);
            
            System.out.println(Label);
            System.out.println("--------------------------------------");
            StmtIterator p = cheese.listProperties();
            
            while(p.hasNext()) {
            	
                 System.out.println(p.nextStatement().getObject().toString()+"\r");
            }
            
        }
    }
    protected  void getIndividualProperties() {
    	String[] ingredientDtProperties = {"ingredienteID","mainIngredient"};
    	String[] recetaDtProperties = {"recetaCalorias","recetaCarbs","recetaFat",
    			"recetaFibre","rectaID","recetaSalt","recetaProtein","recetaSaturates","recetaSugar"};
    
    	String BaseUri ="";
		String path = "src/FoodOntologyRecomenderOwl352018.owl" ;
		OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		DatatypeProperty propiedad = null;
		model.read(path);
		BaseUri = 	model.getNsPrefixURI(""); 
    
    	
        Resource receta = model.getResource( BaseUri + "Receta" );
   
        StmtIterator i = model.listStatements( null, RDF.type, receta );

        while (i.hasNext()) {
            Resource objReceta = i.next().getSubject();
            String Label = getLabel(objReceta);
            Individual RecetaIndividual = model.getIndividual(objReceta.getURI());
            StmtIterator listaPropiedades = RecetaIndividual.listProperties();
            while(listaPropiedades.hasNext()) 
            {
            	
            	    Statement s = (Statement) listaPropiedades.next();    
                   	Property prop = model.getProperty(BaseUri+s.getPredicate().getLocalName());
            	    if(s.getObject().isLiteral()) {
                   	RDFNode  value = RecetaIndividual.getPropertyValue(prop);
                    if(value != null) 
                    {
            		   Literal valor = value.asLiteral();
            		   String conversion ="";
            		   conversion = valor.getValue().toString();
            		   System.out.println(conversion); 
                    }
                    }else 
                    {
                   	 Resource ingrediente = model.getResource(s.getObject().toString());
                   	 String LabelValue =  getLabel(ingrediente);
                   	 if( LabelValue != "")
                   	     System.out.println(LabelValue); 
                   }
            		
            	
            }
            
            
            
            System.out.println(Label);
                      
            
        }
    }
    @SuppressWarnings("null")
	public  void printdataReceta(String PathOwl) 
    {
    	 OntModel model = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		 model.read(PathOwl);
		 String BaseUri = 	model.getNsPrefixURI(""); 
		 Resource receta = model.getResource( BaseUri + "Receta" );
         StmtIterator i = model.listStatements( null, RDF.type, receta );
         while(i.hasNext()) {
        	 Resource objReceta = i.next().getSubject();
             RecipeClass objRecipe =  new RecipeClass();
             objRecipe.getData(objReceta,model);
             objRecipe.printData();
         }
    }
    

}


