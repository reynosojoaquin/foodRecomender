package OwlCrud;

import org.apache.jena.rdf.model.Literal;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdf.model.Statement;
import org.apache.jena.rdf.model.StmtIterator;
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
}
