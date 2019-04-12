package pe.peru.app.db;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class AccesoDB {

   private AccesoDB() {
   }

   public static Connection getConnection() throws SQLException {
      // Datos
      String driver = "com.mysql.jdbc.Driver";
      String url = "jdbc:mysql://localhost:3306/ControlDocumentos";
      String user = "root";
      String password = "mysql";
      Connection cn = null;
      try {
         // Paso 1: Cargar el driver a memoria 
         Class.forName(driver).newInstance();
         // Paso 2: Obtener el objeto Connection 
         cn = DriverManager.getConnection(url, user, password);
      } catch (SQLException e) {
         throw e;
      } catch (ClassNotFoundException e) {
         throw new SQLException("No se encontró el driver de la base de datos.");
      } catch (Exception e) {
         throw new SQLException("No se puede establecer la conexión con la BD.");
      }
      return cn;
   }

}
