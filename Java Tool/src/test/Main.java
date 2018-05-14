package test;
import org.apache.log4j.PropertyConfigurator;
import test.owlTesting;;
public class Main {

	public static void main(String[] args) {
		String path = "src/log4j.properties" ;
		PropertyConfigurator.configure(path);
        owlTesting ObjOwl =  new owlTesting();
        ObjOwl.printdataReceta("src/FoodOntologyRecomenderOwl352018.owl");
	}

}
