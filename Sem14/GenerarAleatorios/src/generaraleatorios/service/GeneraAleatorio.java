package generaraleatorios.service;

import java.util.Random;

public class GeneraAleatorio {

	private String[] grupos;
	private Random rnd;

	public GeneraAleatorio() {
		rnd = new Random();
		grupos = new String[] {
			"Grupo 01",
			"Grupo 02",
			"Grupo 03",
			"Grupo 04",
			"Grupo 05",
			"Grupo 06",
			"Grupo 07"
		};
	}
	
	public String[] traerGrupos(){
		int n = grupos.length;
		int[] orden = new int[n];
		for (int i = 0; i < orden.length; i++) {
			orden[i] = -1;
		}
		for (int i = 0; i < orden.length; i++) {
			orden[i] = traerAleatorio(i,orden);
		}
		String[] listaGrupos = new String[n];
		for (int i = 0; i < listaGrupos.length; i++) {
			listaGrupos[i] = grupos[orden[i]];
		}
		return listaGrupos;
	}

	private int traerAleatorio(int i, int[] orden) {
		boolean pasa = false;
		int num = 0;
		while( ! pasa ){
			num = rnd.nextInt(orden.length);
			pasa = true;
			for (int j = 0; j < orden.length; j++) {
				if(orden[j] == num){
					pasa = false;
					break;
				}
			}
		}
		return num;
	}
	
	
}
