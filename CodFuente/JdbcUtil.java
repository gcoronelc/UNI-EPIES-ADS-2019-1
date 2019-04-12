package pe.peru.app.service;

import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public final class JdbcUtil {

   private JdbcUtil() {
   }

   public static List<Map<String, Object>> rsToList(ResultSet rs) throws SQLException {
      ResultSetMetaData md = rs.getMetaData();
      int columns = md.getColumnCount();
      List<Map<String, Object>> results = new ArrayList<>();
      while (rs.next()) {
         Map<String, Object> row = new HashMap<>();
         for (int i = 1; i <= columns; i++) {
            Object valor = rs.getObject(i);
            if( valor == null ){
               valor = "";
            }
            row.put(md.getColumnLabel(i).toUpperCase(), valor.toString());
         }
         results.add(row);
      }
      return results;
   }
   
   public static Map<String, Object> rsToMap(ResultSet rs) throws SQLException {
      Map<String, Object> rec = null;
      if (rs.next()) {
         ResultSetMetaData md = rs.getMetaData();
         int columns = md.getColumnCount();
         rec = new HashMap<>();
         for (int i = 1; i <= columns; i++) {
            rec.put(md.getColumnLabel(i).toUpperCase(), rs.getObject(i));
         }
      }
      return rec;
   }

   public static String rsToString(ResultSet rs) throws SQLException {
      String data = "";
      int rows = 0;
      ResultSetMetaData md = rs.getMetaData();
      int columns = md.getColumnCount();
      for (int i = 1; i <= columns; i++) {
         data += md.getColumnLabel(i).toUpperCase();
         if (i < (columns - 1)) {
            data += "|";
         }
      }
      while (rs.next()) {
         rows++;
         data += "¬";
         for (int i = 1; i <= columns; i++) {
            data += rs.getObject(i).toString();
            if (i < (columns - 1)) {
               data += "|";
            }
         }
      }
      if(rows == 0){
         data = "";
      }
      return data;
   }

   
   public static String validarString( String dato ){
      if( dato == null ){
         dato = "";
      }
      dato = dato.trim();
      return dato;
   }
   
   public static String setNull( String dato ){
      dato = dato.trim();
      if( dato.length() == 0 ){
         dato = null;
      }
      return dato;
   }
}
