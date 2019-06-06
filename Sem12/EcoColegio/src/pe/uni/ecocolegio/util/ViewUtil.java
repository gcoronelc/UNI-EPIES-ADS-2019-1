
package pe.uni.ecocolegio.util;

import javax.swing.JComboBox;
import pe.uni.ecocolegio.dto.ComboDto;


public class ViewUtil {

    public static int obtenerValorCombo(JComboBox<ComboDto> combo) {
        int index = combo.getSelectedIndex();
        if( index == -1 ){
            return 0;
        }
        ComboDto dto = (ComboDto) combo.getSelectedItem();
        return dto.getId();
    }
    
}
