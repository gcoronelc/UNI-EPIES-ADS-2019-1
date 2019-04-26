package pe.uni.ecocolegio.service;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Map;
import pe.uni.ecocolegio.bd.AccesoDB;
import pe.uni.ecocolegio.dto.SeccionDto;


public class SeccionService  extends ServiceAbstract{
    
    public void crearSeccion( Map<String,Object> datos){
        Connection cn = null;
        String sql = "INSERT INTO DBO.TB_SECCION"
                + "(NOMBRE,ID_GRADO,ID_PERIODO,VACANTES,MATRICULADOS) "
                + "VALUES(?,?,?,?,0)";
        try {
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            PreparedStatement pstm = cn.prepareStatement(sql);
            pstm.setString(1, datos.get("NOMBRE").toString());
            pstm.setInt(2, Integer.parseInt(datos.get("GRADO").toString()));
            pstm.setInt(3, Integer.parseInt(datos.get("PERIODO").toString()));
            pstm.setInt(4, Integer.parseInt(datos.get("VACANTES").toString()));
            pstm.executeUpdate();
            cn.commit();
            pstm.close();
            this.setEstado(1);
            this.setMensaje("OK");
        } catch (Exception e) {
            try {
                cn.rollback();
            } catch (Exception e1) {
            }
            this.setEstado(-1);
            this.setMensaje(e.getMessage());
        } finally{
            try {
                cn.close();
            } catch (Exception e) {
            }
        }
    }
    
    
     public void crearSeccion( SeccionDto dto ){
        Connection cn = null;
        String sql = "INSERT INTO DBO.TB_SECCION"
                + "(NOMBRE,ID_GRADO,ID_PERIODO,VACANTES,MATRICULADOS) "
                + "VALUES(?,?,?,?,0)";
        try {
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            PreparedStatement pstm = cn.prepareStatement(sql);
            pstm.setString(1, dto.getNombre());
            pstm.setInt(2, dto.getGrado());
            pstm.setInt(3, dto.getPeriodo());
            pstm.setInt(4, dto.getVacantes());
            pstm.executeUpdate();
            cn.commit();
            pstm.close();
            this.setEstado(1);
            this.setMensaje("OK");
        } catch (Exception e) {
            try {
                cn.rollback();
            } catch (Exception e1) {
            }
            this.setEstado(-1);
            this.setMensaje(e.getMessage());
        } finally{
            try {
                cn.close();
            } catch (Exception e) {
            }
        }
    }
    
}
