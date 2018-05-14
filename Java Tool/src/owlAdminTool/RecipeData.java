package owlAdminTool;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.concurrent.RecursiveTask;

import org.apache.jena.ontology.Individual;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.rdf.model.Literal;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.RDFNode;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.Statement;
import org.apache.jena.rdf.model.StmtIterator;
import org.apache.jena.vocabulary.RDFS;;

public class RecipeData {
	private Double RecetaFat;
	private  Double RecetaSalt;
	private  Double RecetaProtein;
	private  Double RecetaSaturates;
	private  Double RecetaCalorias;
	private  Double RecetaCarbs;
	private  Double RecetaSugar;
	private  Double RecetaFibre;
    private  ArrayList<String> ingredientes;   
	public  RecipeData() 
	{
		this.RecetaFat 			= (double)0;
		this.RecetaSalt 		= (double)0;
		this.RecetaProtein 		= (double)0;
	    this.RecetaSaturates 	= (double)0;
	    this.RecetaCalorias 	= (double)0;
	    this.RecetaCarbs 		= (double)0;
	    this.RecetaSugar		= (double)0;
	    this.RecetaFibre 		= (double)0;
	}
	public void asignarValoresDataPropeties(Double Fat,Double Salt, Double Protein, Double Saturates,
			Double Calorias,Double Carbs, Double Sugar,Double Fiber )
	{
		
		this.RecetaFat 			= Fat;
		this.RecetaSalt 		= Salt;
		this.RecetaProtein 		= Protein;
		this.RecetaSaturates 	= Saturates;
		this.RecetaCalorias    	= Calorias;
		this.RecetaCarbs		= Carbs;
		this.RecetaSugar		= Sugar;
		this.RecetaFibre		= Fiber;
	}
	public void  getData(Resource receta,OntModel model) {
		
		 Individual RecetaIndividual = model.getIndividual(receta.getURI());
         StmtIterator listaPropiedades = RecetaIndividual.listProperties();
         String BaseUri = model.getNsPrefixURI(""); 
         String PropertyName = "";
         
         while(listaPropiedades.hasNext()) 
         {
         	
         	    Statement s = (Statement) listaPropiedades.next();    
         	    PropertyName   = s.getPredicate().getLocalName();
         	    
               	Property prop = model.getProperty(BaseUri+PropertyName);
         	    if(s.getObject().isLiteral()) {
                	RDFNode  value = RecetaIndividual.getPropertyValue(prop);
                 if(value != null) 
                 {
         		   Literal valor = value.asLiteral();
         		   String conversion ="";
         		   conversion = valor.getValue().toString();
         		   switch (PropertyName) {
         		  		case "RecetaFat":
         		  			this.RecetaFat  =  valor.getDouble();		 
					    			break;
         		        case "RecetaSalt":
         		        	this.RecetaSalt  =  valor.getDouble();
			    			break;
         		   	    case "RecetaProtein":
         		   	    	this.RecetaProtein = valor.getDouble();
 			    			break;
         		     	case "RecetaSaturates":
         		     		this.RecetaSaturates = valor.getDouble();
			    			break;
         		     	case "RecetaCalorias":
         		     		this.RecetaCalorias  = valor.getDouble();
			    			break;
         		     	case "RecetaSugar":
         		     		this.RecetaSugar     = valor.getDouble();
         		     		break;
         		     	case "RecetaFibre":
         		     		this.RecetaFibre     = valor.getDouble();
         		     		break;
        		   			
         		   	}
         		   
                 }
                 }else 
                 {
                	 Resource ingrediente = model.getResource(s.getObject().toString());
                	 String LabelValue =  getLabel(ingrediente);
                	 if( LabelValue != "")
                	    this.ingredientes.add(LabelValue);
                }
         		
         	
         }
         
	}
	 
	//PROCEDIMIENTO QUE DEVUELVE EL VALOR DEL LABEL DE UN RECURSO DADO
	protected static String getLabel( Resource individual ) {
	        StmtIterator i = individual.listProperties( RDFS.label );
	        while (i.hasNext()) {
	            Literal l = i.next().getLiteral();

	            if (l.getLanguage() != null) {
	                //devuelve el valor del label del recurso
	                return l.getLexicalForm();
	            }
	        }

	        return "";
	    } 
	public  void printData() {
		System.out.println("DATA PROPERTIES VALUES    \r");
		System.out.println("fat: "+Double.toString(this.RecetaFat));
		System.out.println("Sal: "+Double.toString(this.RecetaSalt));
		System.out.println("Proteinas: "+Double.toString(this.RecetaProtein));
		System.out.println("Grasas saturadas: "+Double.toString(this.RecetaSaturates));
		System.out.println("Calorias: "+Double.toString(this.RecetaCalorias));
		System.out.println("Carbohidratos: "+Double.toString(this.RecetaCarbs));
		System.out.println("Azucar: "+Double.toString(this.RecetaSugar));
		System.out.println("Fibra: "+Double.toString(this.RecetaFibre));
		System.out.println("   ");
		System.out.println("OBJECT PROPERTIES VALUES    \r");
		Iterator<String> IngLst = ingredientes.iterator();
		while(IngLst.hasNext()) 
		{
			String element = IngLst.next();
			System.out.println(element);
			
		}
		
	}
}
