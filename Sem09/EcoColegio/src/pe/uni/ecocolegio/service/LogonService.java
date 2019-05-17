package pe.uni.ecocolegio.service;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Map;
import pe.uni.ecocolegio.bd.AccesoDB;
import pe.uni.ecocolegio.util.JdbcUtil;

public class LogonService extends ServiceAbstract{

    public Map<String, Object> validarUsuario(String usuario, String clave) {
        // Estado Inicial
        this.setEstado(1);
        this.setMensaje("OK");
        // Variables
        Connection cn = null;
        String sql = "select id_usuario, id_rol, nombre, "
                + "apellido, usuario "
                + "from dbo.tb_usuario "
                + "where usuario = ? "
                + "and   clave  = ? ";
        Map<String,Object> rec = null;
        // Proceso
        try {
            cn = AccesoDB.getConnection();
            PreparedStatement ps = cn.prepareStatement(sql);
            ps.setString(1, usuario);
            ps.setString(2, clave);
            ResultSet rs = ps.executeQuery();
            rec = JdbcUtil.rsToMap(rs);
            rs.close();
            ps.close();
            if(rec == null){
                throw  new Exception("Datos incorrectos.");
            }
        } catch (Exception e) {
            this.setEstado(-1);
            this.setMensaje(e.getMessage());
        } finally {
            try {
                cn.close();
            } catch (Exception e) {
            }
        }
        // Reporte
        return rec;
    }

    
    
}
