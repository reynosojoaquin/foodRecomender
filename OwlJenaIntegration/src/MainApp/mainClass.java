package MainApp;
import org.apache.jena.ontology.OntClass;
import org.apache.log4j.PropertyConfigurator;

import OwlCrud.DataTranfer;
import OwlCrud.receta;
import OwlCrud.tools;
import Similarity.*;
public class mainClass {
	
	public static void main(String[] args) throws Exception {
		String path = "src/log4j.properties" ;
		PropertyConfigurator.configure(path);
		DataTranfer objDataTranfer = new DataTranfer();
		MatrizDeSimilitud objSimilitud = new MatrizDeSimilitud();
		receta objReceta = new receta();
		receta objReceta2 = new receta();
		tools objtools = new tools();
		double numeros[] = {4,1,11,13,2,7};
		
		double vectorA1[] = {2,3,4,8};
		double vectorB1[] = {2,3,5,10};
		
		double vectorA2[] = {1,2,3,4};
		double vectorB2[] = {5,6,7,8};
		
		double vectorA3[] = {2,2,2,2};
		double vectorB3[] = {2,2,2,2};
		if(args.length > 0) 
		{
			
		}
		else 
		{
			//objSimilitud.GenerateMatrizDeSimilitud("src/Libs/FoodOntologyRecomenderOwl1552018.owl");
		//   objReceta.hasTaxSimilarity(objReceta2, "src/Libs/FoodOntologyRecomenderOwl1552018.owl");
			
		 //    System.out.println(Double.toString(objtols.GetDesviacionStandar(numeros))); 
			
		/*	System.out.println("SIMILAR");
			System.out.println("----------\r");
			System.out.println(Double.toString(objtools.GetDistanciaEuclidea(vectorA1, vectorB1)));
			System.out.println("\r");
			System.out.println("DIFERENTE");
			System.out.println("---------- \r");
			System.out.println(Double.toString(objtools.GetDistanciaEuclidea(vectorA2, vectorB2)));
			System.out.println("\r");
			System.out.println("DIFERENTE");
			System.out.println("----------\r");
			
			System.out.println(Double.toString(objtools.GetDistanciaEuclidea(vectorA3, vectorB3))); */
			//objSimilitud.GetVectorClass("src/Libs/FoodOntologyRecomenderOwl1552018.owl");
			
		   /*	objDataTranfer.MigrateDataToOwl("src/Libs/FoodOntologyRecomenderOwl1552018.owl",
	     		"SELECT  distinct(recipeID),nombre  FROM recipedatatoowl where classOf is not null  limit 0,"
						, 4000); */
		}
	}

}
