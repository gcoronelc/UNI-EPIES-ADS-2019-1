package pe.uni.ecocolegio.service;

public abstract class ServiceAbstract{
    
    private int estado;
    private String mensaje;

    public ServiceAbstract() {
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
