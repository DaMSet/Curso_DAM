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
	
	Proa(), Popa(), Babor() ,Estribor();
	
	private int[] escalera ;
	

	Zona(){
		Random random = new Random(); 
		
		ArrayList<Integer> lista1 = new ArrayList<Integer>();
		lista1.add(1);
		lista1.add(2);
		lista1.add(3);

		ArrayList<Integer> lista2 = new ArrayList<Integer>();
		lista2.add(4);
		lista2.add(5);
		lista2.add(6);
		
		ArrayList<Integer> lista3 = new ArrayList<Integer>();
		lista3.add(7);
		lista3.add(8);
		lista3.add(9);
		
		ArrayList<Integer> lista4 = new ArrayList<Integer>();
		lista4.add(10);
		lista4.add(11);
		lista4.add(12);
		
        // Generar un número aleatorio entre los tres números
        int numeroAleatorio = random.nextInt(3); // Genera un número entre 0 (inclusive) y 3 (exclusivo)

        // Sumar el número aleatorio al primer número para obtener un número entre los tres
        int resultado =lista1.get(numeroAleatorio);

        
		
		this.escalera = escalera;
	}
	
	
	public int[] getescalera(){
		return escalera;
	}
	
	
	
}

