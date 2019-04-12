package pe.uni.ecocolegio.prueba;

import java.util.Map;
import pe.uni.ecocolegio.service.LogonService;

public class Prueba02 {

    public static void main(String[] args) {
        try {
            // Datos
            String usuario = "KGUZMAN";
            String clave = "123456";
            // Proceso
            LogonService service = new LogonService();
            Map<String,Object> rec = service.validarUsuario(usuario, clave);
            // Reporte
            System.out.println("Hola: " + rec.get("NOMBRE"));
        } catch (Exception e) {
                System.err.println(e.getMessage());
        }
    }
    
}
