package pe.egcc.eurekaappcs.util;

import java.util.HashMap;
import java.util.Map;

/**
 *
 * @author Gustavo Coronel
 */
public final class Memoria {

  private Memoria() {
  }
  
  private static final Map<String,Object> datos;
  
  static {
    datos = new HashMap<>();
  }
  
  public static void put(String key, Object value){
    datos.put(key, value);
  }
  
  public static Object get(String key){
    return datos.get(key);
  }
  
}
