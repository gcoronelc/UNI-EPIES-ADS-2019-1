package pe.uni.ecocolegio.prueba;

import java.util.List;
import java.util.Map;
import pe.uni.ecocolegio.service.SeccionService;

public class Prueba06 {

    public static void main(String[] args) {
        // Variables
        List<Map<String,Object>> lista;
        // Proceso
        SeccionService seccionService;
        seccionService = new SeccionService();
        lista = seccionService.getSecciones(2020, 1, 102);
        // Reporte
        for (Map<String,Object> r : lista) {
            System.out.println(r.get("SECCION").toString() 
                    + " - " + r.get("NOMBRE").toString() );
        }
        
    }
    
}
