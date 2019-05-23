package pe.uni.ecocolegio.controller;

import java.util.Map;
import pe.uni.ecocolegio.service.LogonService;


public class LogonController extends ControllerAbstract{

    private LogonService logonService;

    public LogonController() {
        logonService = new LogonService();    
    }
    
    
    public Map<String, Object> validar(String usuario, String clave) {
        // Datos
        Map<String,Object> usuarioBean;
        // Proceso
        usuarioBean = logonService.validarUsuario(usuario, clave);
        this.setEstado(logonService.getEstado());
        this.setMensaje(logonService.getMensaje());
        // Reporte
        return usuarioBean;
    }

    
    

    
}
