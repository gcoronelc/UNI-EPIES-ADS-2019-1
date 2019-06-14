package pe.uni.ecocolegio.controller;

import java.util.List;
import java.util.Map;
import pe.uni.ecocolegio.dto.ComboDto;
import pe.uni.ecocolegio.dto.SeccionDto;
import pe.uni.ecocolegio.service.ComboService;
import pe.uni.ecocolegio.service.SeccionService;
import pe.uni.ecocolegio.service.VentaService;
import pe.uni.ecocolegio.util.Session;

public class SeccionController extends ControllerAbstract {

	private SeccionService seccionService;
	private ComboService comboService;

	public SeccionController() {
		seccionService = new SeccionService();
		comboService = new ComboService();
	}

	public List<String> getPeriodos() {
		List<String> lista = seccionService.getPeriodosPlanificacion();
		this.setEstado(seccionService.getEstado());
		this.setMensaje(seccionService.getMensaje());
		return lista;
	}

	public List<ComboDto> getNiveles() {
		List<ComboDto> lista = comboService.getComboNiveles();
		this.setEstado(comboService.getEstado());
		this.setMensaje(comboService.getMensaje());
		return lista;
	}

	public List<ComboDto> getGrados(int nivel) {
		List<ComboDto> lista = comboService.getComboGrados(nivel);
		this.setEstado(comboService.getEstado());
		this.setMensaje(comboService.getMensaje());
		return lista;
	}

	public void crearSeccion(SeccionDto dto) {
		seccionService.crearSeccion(dto);
		this.setEstado(comboService.getEstado());
		this.setMensaje(comboService.getMensaje());
	}

	public List<Map<String, Object>> getSecciones(int periodo, int nivel, int grado) {
		List<Map<String, Object>> lista = seccionService.getSecciones(periodo, nivel, grado);
		this.setEstado(seccionService.getEstado());
		this.setMensaje(seccionService.getMensaje());
		return lista;
	}

	public void generaCuotaIngreso(int estudiante, int periodo) {
		// Obtener el usuario
		Map<String, Object> usuarioBean;
		usuarioBean = (Map<String, Object>) Session.get("usuario");
		int usuario = Integer.parseInt(usuarioBean.get("ID_USUARIO").toString() );
		// Proceso
		VentaService service = new VentaService();
		service.generarCuotaIngreso(estudiante, periodo, usuario);
		this.setEstado(service.getEstado());
		this.setMensaje(service.getMensaje());
	}

        public List<Map<String, Object>> getEstudiantesCuotaIngreso(String apellido){
            return seccionService.getEstudiantesCuotaIngreso(apellido);
        }
}
