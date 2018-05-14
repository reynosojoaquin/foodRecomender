package MainApp;
import org.apache.log4j.PropertyConfigurator;

import OwlCrud.DataTranfer;

public class mainClass {
	
	public static void main(String[] args) throws Exception {
		String path = "src/log4j.properties" ;
		PropertyConfigurator.configure(path);
		DataTranfer objDataTranfer = new DataTranfer();
		if(args.length > 0) 
		{
			
		}
		else 
		{
				objDataTranfer.MigrateDataToOwl("src/Libs/FoodOntologyRecomenderOwl1452018.owl",
	     		"SELECT  distinct(recipeID),nombre  FROM recipedatatoowl where classOf is not null and recipeTipoPlatoData <> '' limit 0,"
						, 10);
		}
	}

}
