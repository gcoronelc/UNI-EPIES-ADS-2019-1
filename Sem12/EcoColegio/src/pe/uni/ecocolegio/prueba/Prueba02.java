package pe.uni.ecocolegio.prueba;

import java.util.Map;
import pe.uni.ecocolegio.service.LogonService;

public class Prueba02 {

    public static void main(String[] args) {

        // Datos
        String usuario = "KGUZMAN";
        String clave = "123456";
        // Proceso
        LogonService service = new LogonService();
        Map<String,Object> rec = service.validarUsuario(usuario, clave);
        // Reporte
        if( service.getEstado() == 1){
            System.out.println("Hola: " + rec.get("NOMBRE"));
        } else {
            System.err.println(service.getMensaje());
        }
        

    }
    
}
