package Clases;

import java.util.ArrayList;
import java.util.Random;

public enum Zona {

	/*
	Proa(new int[] {4,9,24}), Popa(new int[] {4,9,24}), Babor(new int[] {4,9,24}) ,Estribor(new int[] {4,9,24});
	
	private int[] lista ;
	

	Zona(int[] lista){
		this.lista = lista;
	}
	
	
	public int[] getlista(){
		return lista;
	}
	*/
	
	Proa(1,2,3), Popa(4,5,6), Babor(7,8,9) ,Estribor(10,11,12);
	
	private int escalera ;
	

	Zona(int num1, int num2, int num3 ){
		Random random = new Random(); 
		
		ArrayList<Integer> lista = new ArrayList<Integer>();
		lista.add(num1);
		lista.add(num2);
		lista.add(num3);

		
		
        // Generar un número aleatorio entre los tres números
        int numeroAleatorio = random.nextInt(3); // Genera un número entre 0 (inclusive) y 3 (exclusivo)

        // Sumar el número aleatorio al primer número para obtener un número entre los tres
        int resultado =lista.get(numeroAleatorio);

        
		
		this.escalera = resultado;
	}
	
	
	public int getescalera(){
		return escalera;
	}
	
	
	
}

