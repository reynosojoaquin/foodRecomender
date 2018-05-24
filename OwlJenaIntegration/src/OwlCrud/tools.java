package OwlCrud;

import java.util.ArrayList;

import org.apache.jena.ontology.OntClass;
import org.apache.jena.ontology.OntModel;
import org.apache.jena.rdf.model.Literal;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.Statement;
import org.apache.jena.rdf.model.StmtIterator;
import org.apache.jena.util.iterator.ExtendedIterator;
import org.apache.jena.vocabulary.RDFS;

public class tools {
	
	//PROCEDIMIENTO QUE DEVUELVE EL VALOR DEL LABEL DE UN RECURSO DADO
		public static String getLabel( Resource individual ) {
		        StmtIterator i = individual.listProperties( RDFS.label );
		        while (i.hasNext()) {
		            Literal l = i.next().getLiteral();

		            if (l.getLanguage() != null) {
		                /*devuelve el valor del label del recurso*/
		                return l.getLexicalForm();
		            }
		        }

		        return "";
		    } 
    		
		public static  String getValueAsString( Resource r, Property p ) {
	        Statement s = r.getProperty( p );
	        if (s == null) {
	            return "";
	        }
	        else {
	            return s.getObject().isResource() ? s.getResource().getURI() : s.getString();
	        }
	    }
		
		public static String getLabelWithLag( Resource recurso, String Lang ) {
		        StmtIterator i = recurso.listProperties( RDFS.label );
		        String value="";
		        while (i.hasNext()) {
		            Literal l = i.next().getLiteral();

		            if (l.getLanguage() != null && l.getLanguage().equals(Lang)) {
		              
		                value = l.getLexicalForm();
		            }
		        }
				return value;
		    }

		public static  void printProgBar(float percent,String info){
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
		
		public static String remplaceWhiteSpace(String StrVar){
		
			return StrVar.replace(' ', '_');
		}
		public double GetMediaAritmetica(double numeros[]) 
		{
		   
		   double media	   		= 0;
		   
		   int 	  elementos   	= 0;
		   double suma			= 0;	
		   
		   elementos  = numeros.length;
		   for(double i:numeros) 
		   {
			   suma = suma + i;
		   }
		   media = suma/ elementos;
		    return media;
			
		}
		public double GetDesviacionStandar(double numeros[]) 
		{
			double varianza 		= 0;
			double retorno   		= 0;
			double sumatoria 		= 0;
			double desviacion		= 0;
			int elementos        = 0;
			double media			= 0;
			elementos  = 			numeros.length;
			media 	   =  			GetMediaAritmetica(numeros); 
			for(int i=0;i<elementos;i++) 
			{
				sumatoria = Math.pow(numeros[i]-media, 2);
				varianza = varianza + sumatoria;
			}
			varianza = varianza / (elementos-1);
			desviacion = Math.sqrt(varianza);
			retorno    = Math.rint(desviacion*100)/100;
			return retorno;
		}
		public double GetDistanciaEuclidea(double vectorA[],double vectorB[]) {
			double 	distancia =0;
			int  	sizeA	  =0;
			int 	sizeB 	  =0;
			double  resta     =0;
		  	double  Sumatoria =0;
		    sizeA = vectorA.length;
		    sizeB = vectorB.length;
		    if(sizeA == sizeB)
		    {
		      for(int i=0;i<sizeA;i++)
		      {
		    	  resta =  Math.pow((vectorA[i] - vectorB[i]),2);	
		    	  Sumatoria = Sumatoria + resta;
		      }
		    	
		      distancia = Math.sqrt(Sumatoria);
		    }
		
			return distancia;
		}
		
}
