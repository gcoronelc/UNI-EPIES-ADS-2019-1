package pe.uni.ecocolegio.service;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import pe.uni.ecocolegio.bd.AccesoDB;
import pe.uni.ecocolegio.dto.SeccionDto;

public class SeccionService extends ServiceAbstract {

    public void crearSeccion(Map<String, Object> datos) {
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
        } finally {
            try {
                cn.close();
            } catch (Exception e) {
            }
        }
    }

    public void crearSeccion(SeccionDto dto) {
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
        } finally {
            try {
                cn.close();
            } catch (Exception e) {
            }
        }
    }

    public List<String> getPeriodosPlanificacion() {
        List<String> lista = new ArrayList<>();
        Connection cn = null;
        String sql = "SELECT ID_PERIODO PERIODO FROM DBO.TB_PERIODO WHERE ESTADO = 1";
        try {
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            PreparedStatement pstm = cn.prepareStatement(sql);
            ResultSet rs = pstm.executeQuery();
            while(rs.next()){
                lista.add(rs.getString("PERIODO"));
            }
            rs.close();
            pstm.close();
            this.setEstado(1);
            this.setMensaje("OK");
        } catch (Exception e) {
            this.setEstado(-1);
            this.setMensaje(e.getMessage());
        } finally {
            try {
                cn.close();
            } catch (Exception e) {
            }
        }
        return lista;
    }
    
    
    

}
