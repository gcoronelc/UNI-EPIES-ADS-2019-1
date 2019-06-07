package pe.uni.ecocolegio.prueba;

import pe.uni.ecocolegio.service.VentaService;

public class Prueba07 {

    public static void main(String[] args) {
        VentaService venta = new VentaService();
        venta.generarCuotaIngreso(1, 2020, 1);
        System.out.println("Venta: " + venta.getMensaje());
    }
    
}
