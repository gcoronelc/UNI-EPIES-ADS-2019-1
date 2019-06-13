package pe.uni.ecocolegio.prueba;

import pe.uni.ecocolegio.dto.SeccionDto;
import pe.uni.ecocolegio.service.SeccionService;

public class Prueba04 {

    public static void main(String[] args) {
        // Datos
        SeccionDto dto = new SeccionDto();
        dto.setNombre("PRIMER GRADO A - Aula Genios");
        dto.setGrado(201);
        dto.setPeriodo(2020);
        dto.setVacantes(20);
        // Proceso
        SeccionService seccionService;
        seccionService = new SeccionService();
        seccionService.crearSeccion(dto);
        // Reporte
        System.out.println("Estado: " + seccionService.getEstado());
        System.out.println("Mensaje: " + seccionService.getMensaje());
    }
    
}
