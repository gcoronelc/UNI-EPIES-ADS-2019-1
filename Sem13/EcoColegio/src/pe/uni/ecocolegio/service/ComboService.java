package pe.uni.ecocolegio.service;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import pe.uni.ecocolegio.bd.AccesoDB;
import pe.uni.ecocolegio.dto.ComboDto;

public class ComboService extends ServiceAbstract{
    
    
    public List<ComboDto> getComboNiveles() {
        List<ComboDto> lista = new ArrayList<>();
        Connection cn = null;
        String sql = "SELECT ID_NIVEL ID, NOMBRE NAME FROM DBO.TB_NIVEL";
        try {
            cn = AccesoDB.getConnection();
            PreparedStatement pstm = cn.prepareStatement(sql);
            ResultSet rs = pstm.executeQuery();
            lista = rsMapToList( rs );
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
    public List<ComboDto> getComboGrados(int mivel) {
        List<ComboDto> lista = new ArrayList<>();
        Connection cn = null;
        String sql = "SELECT ID_GRADO ID, NOMBRE NAME FROM DBO.TB_GRADO " +
            "WHERE ID_NIVEL = ?";
        try {
            cn = AccesoDB.getConnection();
            PreparedStatement pstm = cn.prepareStatement(sql);
            pstm.setInt(1, mivel);
            ResultSet rs = pstm.executeQuery();
            lista = rsMapToList( rs );
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

    
    
    




    private List<ComboDto> rsMapToList(ResultSet rs) throws SQLException {
        List<ComboDto>  lista = new ArrayList<>();
        ComboDto dto = null;
        while(rs.next()){
            dto = new ComboDto();
            dto.setId(rs.getInt("ID"));
            dto.setName(rs.getString("NAME"));
            lista.add(dto);
        }
        rs.close();
        return lista;
    }
    
    
}
