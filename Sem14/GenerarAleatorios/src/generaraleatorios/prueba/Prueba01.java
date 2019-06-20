package generaraleatorios.prueba;

import generaraleatorios.service.GeneraAleatorio;

public class Prueba01 {
	
	public static void main(String[] args) {
		GeneraAleatorio ga = new GeneraAleatorio();
		String[] grupos = ga.traerGrupos();
		for (int i = 0; i < grupos.length; i++) {
			String grupo = grupos[i];
			System.out.println(grupo);
		}
	}
}
