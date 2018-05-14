package OwlCrud;

import java.util.ArrayList;
import org.apache.jena.ontology.Individual;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.rdf.model.Literal;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.RDFNode;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.Statement;
import org.apache.jena.rdf.model.StmtIterator;


public class receta {
	  String Nombre;
	  Double RecetaFat;
	  Double RecetaSalt;
	  Double RecetaProtein;
	  Double RecetaSaturates;
	  Double RecetaCalorias;
	  Double RecetaCarbs;
	  Double RecetaSugar;
	  Double RecetaFibre;
      ArrayList<String> ingredientes;   
      ArrayList<receta> RecipeList;
	public  receta() 
	{
		this.RecetaFat 			= (double)0;
		this.RecetaSalt 		= (double)0;
		this.RecetaProtein 		= (double)0;
	    this.RecetaSaturates 	= (double)0;
	    this.RecetaCalorias 	= (double)0;
	    this.RecetaCarbs 		= (double)0;
	    this.RecetaSugar		= (double)0;
	    this.RecetaFibre 		= (double)0;
	    this.Nombre				= "";
	    this.ingredientes       =  new ArrayList<String>();
	    this.RecipeList			= new ArrayList<receta>();
	    
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
	public  void  getData( Resource receta,OntModel modelo )
	{
		
		 
	        
	         String BaseUri = 	modelo.getNsPrefixURI(""); 
	         String PropertyName = "";
             Individual RecetaIndividual = modelo.getIndividual(receta.getURI());
             StmtIterator listaPropiedades = RecetaIndividual.listProperties();
             this.Nombre = tools.getLabel(receta);
             while(listaPropiedades.hasNext()) 
             {
         	
                   		Statement s = (Statement) listaPropiedades.next();    
                		PropertyName   = s.getPredicate().getLocalName();
         	       		Property prop = modelo.getProperty(BaseUri+PropertyName);
                		if(s.getObject().isLiteral()) {
                		RDFNode  value = RecetaIndividual.getPropertyValue(prop);
                		if(value != null) 
                		{
                			Literal valor = value.asLiteral();
         		 
         		   switch (PropertyName) {
         		  		case "recetaFat":
         		  			this.RecetaFat  =  valor.getDouble();		 
					    			break;
         		        case "recetaSalt":
         		        	this.RecetaSalt  =  valor.getDouble();
			    			break;
         		   	    case "recetaProtein":
         		   	    	this.RecetaProtein = valor.getDouble();
 			    			break;
         		     	case "recetaSaturates":
         		     		this.RecetaSaturates = valor.getDouble();
			    			break;
         		     	case "recetaCalorias":
         		     		this.RecetaCalorias  = valor.getDouble();
			    			break;
         		     	case "recetaSugar":
         		     		this.RecetaSugar     = valor.getDouble();
         		     		break;
         		     	case "recetaFibre":
         		     		this.RecetaFibre     = valor.getDouble();
         		     		break;
        		   			
         		   	}
         		   
                 }
                 }else 
                 {
                	 Resource ingrediente = modelo.getResource(s.getObject().toString());
                	 String LabelValue = tools.getLabel(ingrediente);
                	 if( LabelValue != "")
                	    this.ingredientes.add(LabelValue);
                }
         	
            }
         
	}
	 
	
	
}
