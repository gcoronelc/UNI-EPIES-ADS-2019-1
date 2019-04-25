package pe.uni.ecocolegio.controller;

public abstract class ControllerAbstract{
    
    private int estado;
    private String mensaje;

    public ControllerAbstract() {
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public String getMensaje() {
        return mensaje;
    }

    public void setMensaje(String mensaje) {
        this.mensaje = mensaje;
    }
    
    
    
    
}
