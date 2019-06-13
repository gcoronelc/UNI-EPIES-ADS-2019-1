package pe.uni.ecocolegio.prueba;

import java.util.HashMap;
import java.util.Map;
import pe.uni.ecocolegio.service.SeccionService;

public class Prueba03 {

    public static void main(String[] args) {
        // Datos
        Map<String,Object> datos;
        datos = new HashMap<>();
        datos.put("NOMBRE", "1RO A - AULA AZUL");
        datos.put("GRADO", 101);
        datos.put("PERIODO", 2020);
        datos.put("VACANTES", 20);
        // Proceso
        SeccionService seccionService;
        seccionService = new SeccionService();
        seccionService.crearSeccion(datos);
        // Reporte
        System.out.println("Estado: " + seccionService.getEstado());
        System.out.println("Mensaje: " + seccionService.getMensaje());
    }
    
}
