package pe.uni.ecocolegio.prueba;

import java.util.List;
import pe.uni.ecocolegio.service.SeccionService;

public class Prueba05 {

    public static void main(String[] args) {
        // Variables
        List<String> lista;
        // Proceso
        SeccionService seccionService;
        seccionService = new SeccionService();
        lista = seccionService.getPeriodosPlanificacion();
        // Reporte
        for (String periodo : lista) {
            System.out.println(periodo);
        }
        
    }
    
}
