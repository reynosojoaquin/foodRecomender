package jenaPrueba;

import org.apache.jena.rdf.model.Model;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.vocabulary.VCARD;

public class helloWolrldRdf {

	
	
	static String resourceURI = "http://somewhere/johnSmith";
	static String fullName = "John Smit";
	public static void main(String[] args) {
		
		Model m = ModelFactory.createDefaultModel();
		Resource  JohnSmith = m.createResource(resourceURI);
		JohnSmith.addProperty(VCARD.FN,fullName);
		m.write(System.out);
	}
}
