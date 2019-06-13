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
			// Paso 1: Verifica si el estudiante ya pogo la cuota de ingreso
			sql = "select count(1) cont "
							+ "from dbo.tb_obligacion "
							+ "where id_estudiante = ? "
							+ "and id_tipo = 1;";
			pstm = cn.prepareStatement(sql);
			pstm.setInt(1, estudiante);
			rs = pstm.executeQuery();
			rs.next();
			int cont = rs.getInt("cont");
			if (cont > 0) {
				this.setEstado(-1);
				this.setMensaje("El estudiante ya tiene la cuota de ingreso");
				return;
			}
			rs.close();
			pstm.close();
			// Paso 2: Obtener el importe de cuota de ingreso
			sql = "select ingreso from dbo.tb_periodo "
							+ "where id_periodo = ?";
			pstm = cn.prepareStatement(sql);
			pstm.setInt(1, periodo);
			rs = pstm.executeQuery();
			if (!rs.next()) {
				this.setEstado(-1);
				this.setMensaje("El periodo no existe.");
				return;
			}
			double importe = rs.getDouble(1);
			rs.close();
			pstm.close();
			// Paso 3: Registrar obligación
			String nombre = "CUOTA DE INGRESO DE ESTUDIANTE " + estudiante;
			String fecha = periodo + ".03.31";
			sql = "insert into dbo.TB_obligacion(NOMBRE,"
							+ "ID_ESTUDIANTE,ID_MATRICULA,ID_PERIODO,"
							+ "ID_TIPO,IMPORTE,FECHA_VENC,ID_USUARIO) "
							+ "values(?,?,null,?,1,?,CONVERT(date, ?, 102),?)";
			pstm = cn.prepareStatement(sql);
			pstm.setString(1, nombre);
			pstm.setInt(2, estudiante);
			pstm.setInt(3, periodo);
			pstm.setDouble(4, importe);
			pstm.setString(5, fecha);
			pstm.setInt(6, usuario);
			pstm.executeUpdate();
			pstm.close();
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
