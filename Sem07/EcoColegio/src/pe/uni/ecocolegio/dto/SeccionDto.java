package pe.uni.ecocolegio.dto;

public class SeccionDto {

    private int seccion;
    private String nombre;
    private int grado;
    private int periodo;
    private int vacantes;
    private int matriculados;

    public SeccionDto() {
    }

    public int getSeccion() {
        return seccion;
    }

    public void setSeccion(int seccion) {
        this.seccion = seccion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getGrado() {
        return grado;
    }

    public void setGrado(int grado) {
        this.grado = grado;
    }

    public int getPeriodo() {
        return periodo;
    }

    public void setPeriodo(int periodo) {
        this.periodo = periodo;
    }

    public int getVacantes() {
        return vacantes;
    }

    public void setVacantes(int vacantes) {
        this.vacantes = vacantes;
    }

    public int getMatriculados() {
        return matriculados;
    }

    public void setMatriculados(int matriculados) {
        this.matriculados = matriculados;
    }
    
    

}
