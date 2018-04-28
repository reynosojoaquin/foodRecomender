package owlAdminTool;
import java.sql.*;
public class DataAccees {

	 public static Connection getMySqlConnection() throws Exception {
		    String driver = "com.mysql.cj.jdbc.Driver";
		    String url = "jdbc:mysql://localhost/foodrecomendersystemdb";
		    String username = "root";
		    String password = "admin";
		    Class.forName(driver);
		    Connection conn = DriverManager.getConnection(url, username, password);
		    return conn;
		  }
	 public static ResultSet GetData(String SqlQuery) throws Exception 
	 {
		 Statement st = getMySqlConnection().createStatement();
		 ResultSet Result = st.executeQuery(SqlQuery);
		 return Result;
	 }
	 

}
