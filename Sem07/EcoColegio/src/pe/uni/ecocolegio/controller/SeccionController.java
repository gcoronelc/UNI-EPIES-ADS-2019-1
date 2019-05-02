package pe.uni.ecocolegio.controller;

import java.util.List;
import pe.uni.ecocolegio.service.SeccionService;

public class SeccionController extends ControllerAbstract{
    
    private SeccionService service;

    public SeccionController() {
        service = new SeccionService();
    }
    

    public List<String> getPeriodos() {
        List<String> lista = service.getPeriodosPlanificacion();
        this.setEstado(service.getEstado());
        this.setMensaje(service.getMensaje());
        return lista;
    }
    
}
