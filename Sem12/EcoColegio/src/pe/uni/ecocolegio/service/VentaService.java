package pe.uni.ecocolegio.service;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import pe.uni.ecocolegio.bd.AccesoDB;

public class VentaService extends ServiceAbstract {

    public void generarCuotaIngreso(
            int estudiante, int periodo, int usuario
    ) {
        // Estado por defecto
        this.setEstado(1);
        this.setMensaje("Proceso ok.");
        // Variables
        Connection cn = null;
        String sql;
        PreparedStatement pstm;
        ResultSet rs;
        // Proceso General
        try {
            // Inicio de Transacción
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            // Paso 1
            sql = "select count(1) cont "
                    + "from dbo.tb_obligacion "
                    + "where id_estudiante = ? "
                    + "and id_tipo = 1;";           
            pstm = cn.prepareStatement(sql);
            pstm.setInt(1, estudiante);
            rs = pstm.executeQuery();
            rs.next();
            int cont = rs.getInt("cont");
            if( cont > 0 ){
                this.setEstado(-1);
                this.setMensaje("El estudiante ya tiene la cuota de ingreso");
                return;
            }
            

            // Confirmar transacción
            cn.commit();
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

}
