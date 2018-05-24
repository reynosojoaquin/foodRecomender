package OwlCrud;
import Similarity.*;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.LinkedList;

import org.apache.jena.ontology.Individual;
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
import org.apache.jena.util.iterator.ExtendedIterator;
import org.apache.jena.vocabulary.RDF;


public class receta {
	  public String Nombre;
	  Double RecetaFat;
	  Double RecetaSalt;
	  Double RecetaProtein;
	  Double RecetaSaturates;
	  Double RecetaCalorias;
	  Double RecetaCarbs;
	  Double RecetaSugar;
	  Double RecetaFibre;
	  String Pais;
	  String tipoPlato;
      ArrayList<String> ingredientes;   
        
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
                   	    PropertyName   =  s.getPredicate().getLocalName();
                		Property prop = modelo.getProperty(BaseUri+PropertyName);
         	       	if(!PropertyName.equals("recetaTienePais") || !PropertyName.equals("recetaTieneTipoPlato"))
            		{
                		if(s.getObject().isLiteral()) 
                		{
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
                		
            }else 
            {
            	Resource ingrediente = modelo.getResource(s.getObject().toString());
            	String  LabelValue  = tools.getLabel(ingrediente);
                	switch(PropertyName) 
                	{
                		case "recetaTienePais":
                			this.Pais = LabelValue;
                		break;
                		case "recetaTieneTipoPlato":
                			this.tipoPlato = LabelValue;
                			break;
                	}		
            }  		
         	
            }
         
	}
	public recetaAtributos   getAtributeRecipeVector( Resource receta,OntModel modelo ) 
	{
		 recetaAtributos retorno = new recetaAtributos();
		 String  PropValue = "";
		 double[] RecipeAtribute = new double[4];
		 int pais 					 = 0;
		 int cantidadIngrediente   	 = 0;
		 int tipoPlato            	 = 0;
		 
		 ArrayList<String> tipoPlatoList = new ArrayList<String>()
		 {{ 
			 add("Desayuno");
			 add("Comida");
			 add("Cena");
			 add("Merienda");
		 }};
		 ArrayList<double[]> ingredientesReceta = new ArrayList<double[]>();
		 ArrayList<String> paisList  = getIndividualPais(modelo);
		 String BaseUri = 	modelo.getNsPrefixURI(""); 
         String PropertyName = "";
         
         Property pPais 			= modelo.getProperty(BaseUri+"recetaTienePais");
         Property pTipoPlato 		= modelo.getProperty(BaseUri+"recetaTieneTipoPlato");
         Property pIngredienteID 	= modelo.getProperty(BaseUri+"recetaTieneIngrediente");
         Individual RecetaIndividual = modelo.getIndividual(receta.getURI());
         StmtIterator listaPropiedades = RecetaIndividual.listProperties();
         while(listaPropiedades.hasNext()) 
         {
     	        Statement s = (Statement) listaPropiedades.next();   
               	PropertyName   =  s.getPredicate().getLocalName();
                       		
     	        	Resource propiedad = modelo.getResource(s.getObject().toString());
     	       		String LabelValue = tools.getValueAsString(propiedad,pIngredienteID);
     	       		if( LabelValue != "")
     	       			this.ingredientes.add(LabelValue);
               	              
        	   switch(PropertyName) 
            	{
            		case "recetaTienePais":
            		    PropValue = tools.getValueAsString(propiedad, pPais);
            			pais = paisList.indexOf(PropValue);
            		break;
            		case "recetaTieneTipoPlato":
            			 PropValue = tools.getValueAsString(propiedad, pTipoPlato);
            			 tipoPlato = tipoPlatoList.indexOf(PropValue) ;
            		break;
            		case  "recetaTieneIngrediente":
            			ingredientesReceta.add(getAtributeIngredientVector(propiedad, modelo));
            			break;
            	}		
         		
     	
        }
         
         retorno.ingredientesAtributos = ingredientesReceta;
         return retorno;
		
	} 
	
	public double[]   getAtributeIngredientVector( Resource ingrediente,OntModel modelo ) 
	{
		 String  PropValue = "";
		 double[] IngredientAtribute = new double[3];
		 int SuperClass			   	 = 0;
		 int MainIngredient      	 = 0;
		 int Class 				     = 0;		
		 ArrayList<String> listClass = GetVectorClass(modelo); 
		
 		 OntClass SuperClassOnt;
		 String BaseUri = 	modelo.getNsPrefixURI(""); 
         String PropertyName = "";
         
         Property pClass 			= modelo.getProperty(BaseUri+"ingredienteClass");
         Property pIngredienteID 	= modelo.getProperty(BaseUri+"ingredienteID");
         Individual ingredienteIndividual = modelo.getIndividual(ingrediente.getURI());
         StmtIterator listaPropiedades = ingredienteIndividual.listProperties();
         while(listaPropiedades.hasNext()) 
         {
     	           Statement s = (Statement) listaPropiedades.next();   
                 	PropertyName   =  s.getPredicate().getLocalName();
                 	String LabelValue = "";
                	
	     	       	switch(PropertyName) 
	            	{
	     	       	case "ingredienteID":
	     	            	Resource propiedadID = modelo.getResource(s.getObject().toString());    	        	
     	       		        LabelValue = tools.getValueAsString(propiedadID,pIngredienteID);
	     	       			MainIngredient = Integer.parseInt(LabelValue);
	     	       			
	     	       			break;
	     	       	case "ingredienteClass":
	     	       			Resource propiedadClass = modelo.getResource(s.getObject().toString());    	        	
	     	       			LabelValue = tools.getValueAsString(propiedadClass,pClass);
	     	       			Class = listClass.indexOf(LabelValue);
	     	       			SuperClassOnt = modelo.getOntClass(BaseUri+LabelValue);
	     	       			SuperClass    = listClass.indexOf(SuperClassOnt.getLocalName());  
	     	       	}
     	       	
        
        }  		
         
         IngredientAtribute[0] = MainIngredient;
         IngredientAtribute[1] = Class;
         IngredientAtribute[2] = SuperClass;
         return IngredientAtribute;
		
	} 
	public ArrayList<String> getIndividualPais(OntModel modelo) 
	{
		ArrayList<String> retorno = null;
		String value = "";
		String[] paises =null;
		Resource pais = modelo.getResource(modelo.getNsPrefixURI("")+"Pais");
		ExtendedIterator<Individual> individuals = modelo.listIndividuals(pais);
		 while (individuals != null)
		 {
			 Individual indvPais = individuals.next();
			 value += indvPais.getLocalName()+",";
	     }
		 paises = value.split(",");
		 retorno = new ArrayList<String>(paises.length);
		 for(String p:paises) 
		 {
		    retorno.add(p);	 
		 }
		 
		return retorno;
	}
	public   ArrayList<String> GetObjectProPerties(){
		 
		 return this.ingredientes;
	}
	public boolean IsEqual(receta objreceta) {
		boolean	cantIngredinte  		= false;
	    boolean similitudIngrediente    = false;
	   
	    
	    cantIngredinte = this.ingredientes.size() == objreceta.ingredientes.size()? true:false;
	    if(cantIngredinte)
	    {
	    		for(int ingrediente = 0; ingrediente < this.ingredientes.size();ingrediente++) {
	    			similitudIngrediente = this.ingredientes.get(ingrediente).equals(
	    					objreceta.ingredientes.get(ingrediente)) ? true:false;
	    			if(!similitudIngrediente) {
	    				break;
	    			}
	    		}
	    		if(!similitudIngrediente)
	    		{
	    		
	    			return false;
	    		}
	    		else 
	    		{
	    			return true;
	    		}
	    }else 
	    {
	    	return false;
	    }
				
		
	}
    
	public boolean hasTaxSimilarity(receta objreceta,String path) {
		OntModel modelo = null;
		OntClass ingrediente=null;
		String BaseUri = "";
		
		modelo = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		modelo.read(path);
		BaseUri = modelo.getNsPrefixURI("");
		
		ingrediente = modelo.getOntClass(BaseUri+"Ingrediente");
		ExtendedIterator<OntClass> i = ingrediente.listSubClasses();
		System.out.println("*********** GENERANDO MATRIZ DE SIMILITUD ************");
	        while (i.hasNext()) 
	        {
	        	OntClass c = (OntClass) i.next();
	            receta objReceta = new receta();
	        	System.out.println(c.getLocalName());
	            String vClasse = c.getLocalName().toString();

                if (c.hasSubClass()) 
                {
                    System.out.print("   " + getSubClass(c, modelo) + " " + "\n");
                }
                            
	        }
		return true;
	}
    
	public String getSubClass(OntClass SuperClass,OntModel modelo)
	{
		 String BaseClass = SuperClass.getLocalName().toString();
		 String BaseUri = modelo.getNsPrefixURI("");
		 String retorno = "";
     	 retorno =  BaseClass+"\n";
    	 OntClass cla = modelo.getOntClass(BaseUri + BaseClass);
         for (ExtendedIterator<OntClass> it = cla.listSubClasses(); it.hasNext();)
         {
                 OntClass subClass = (OntClass) it.next();
                 retorno += subClass.getLocalName() + ",";
                 if(subClass.hasSubClass())
                	 	retorno +=  getSubClass(subClass,modelo);
         }
		 
		 return retorno;
	}
	
	
    public ArrayList<String>[] getArrayClass() 
    {
    	ArrayList<String> retorno[]=null;
    	
    	return retorno;
    }
    public OntModel CreateOntoModel(String path) 
	{
		OntModel modelo;
		modelo = ModelFactory.createOntologyModel(OntModelSpec.OWL_DL_MEM);
		modelo.read(path);
		return modelo;
	}
	
    public ArrayList<String> GetVectorClass(OntModel ont)
    {
    	String ingredientStr ="";
    	
    	String classes[] = null;
        String BaseUri = ont.getNsPrefixURI("");
    	OntClass ingrediente = ont.getOntClass(BaseUri+"Ingrediente");
    	ingredientStr = getSubClass(ingrediente, ont);
    	System.out.println(ingredientStr);
    	classes = ingredientStr.split(",");
    	ArrayList<String> retorno = new ArrayList<String>(classes.length);
    	for(String value: classes) {
    		retorno.add(value);
    	}
    	return retorno;
    } 	



}
