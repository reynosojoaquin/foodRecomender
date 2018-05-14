package test;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DbAccess {

	public static void main(String[] args) {
		conectarDB();
	}
	
	
	public static void conectarDB() {
		 System.out.println("INICIO DE EJECUCIÓN.");
	        try {
	            Class.forName("com.mysql.cj.jdbc.Driver");
	            Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost/foodrecomendersystemdb", "root", "admin");
	            Statement st = conexion.createStatement();
	            ResultSet rs = st.executeQuery("SELECT * FROM pais;");
	 
	            if (rs != null) {
	                System.out.println("Listado de paises");
	 
	                while (rs.next()) {
	                    System.out.println("  ID: " + rs.getObject("PaisID"));
	                    System.out.println("  Nombre: " + rs.getObject("Descripcion"));
	                    System.out.println("  Geolocalizacion: " + rs.getObject("geolocalizacion"));
	                    System.out.println("- ");
	                }
	                rs.close();
	            }
	            st.close();
	 
	        }
	        catch(SQLException s)
	        {
	            System.out.println("Error: SQL.");
	            System.out.println("SQLException: " + s.getMessage());
	        }
	        catch(Exception s)
	        {
	            System.out.println("Error: Varios.");
	            System.out.println("SQLException: " + s.getMessage());
	        }
	        System.out.println("FIN DE EJECUCIÓN.");
	}
	
	
}
