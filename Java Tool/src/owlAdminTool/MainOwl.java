package owlAdminTool;

public class MainOwl {

	public static void main(String[] args) throws Exception {
	
		OntologyCrud Owl = new OntologyCrud();
		Owl.migrarDataToOwl( "src/FoodOntologyRecomenderOwl352018.owl",10);
	}

}
