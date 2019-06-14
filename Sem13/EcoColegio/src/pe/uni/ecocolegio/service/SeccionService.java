package pe.uni.ecocolegio.service;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import pe.uni.ecocolegio.bd.AccesoDB;
import pe.uni.ecocolegio.dto.SeccionDto;
import pe.uni.ecocolegio.util.JdbcUtil;

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
            while (rs.next()) {
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

    public List<Map<String, Object>> getSecciones(
            int periodo, int nivel, int grado
    ) {
        List<Map<String, Object>> lista = null;
        Connection cn = null;
        String sql = "{CALL DBO.USP_GET_SECCIONES(?,?,?)}";
        try {
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            CallableStatement cstm = cn.prepareCall(sql);
            cstm.setInt(1, periodo);
            cstm.setInt(2, nivel);
            cstm.setInt(3, grado);
            ResultSet rs = cstm.executeQuery();
            lista = JdbcUtil.rsToList(rs);
            rs.close();
            cstm.close();
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

    public List<Map<String, Object>> getEstudiantesCuotaIngreso(String apellido) {
        apellido += "%";
        List<Map<String, Object>> lista = null;
        Connection cn = null;
        String sql = "select id_estudiante id, dni, "
                + "CONCAT(paterno, ' ', materno, ', ', nombre) nombre "
                + "from dbo.tb_estudiante  "
                + "where id_estudiante not in "
                + "( select id_estudiante from dbo.tb_obligacion "
                + "  where id_tipo = 1 ) "
                + "and ( paterno like ? or materno like ? )";
        try {
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            PreparedStatement pstm = cn.prepareStatement(sql);
            pstm.setString(1, apellido);
            pstm.setString(2, apellido);
            ResultSet rs = pstm.executeQuery();
            lista = JdbcUtil.rsToList(rs);
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
