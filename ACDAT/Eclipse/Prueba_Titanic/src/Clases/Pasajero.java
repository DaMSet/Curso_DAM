package Clases;

import java.util.Date;

public class Pasajero extends Persona{

	
	private int numeroHabitacion;
	
	public Pasajero(String DNI, Pais pais, Zona zona, String nombre, Boolean minusvalia, Date fecha,int numeroHabitacion ) {
		super(DNI, pais, zona, nombre, minusvalia, fecha);
		
		this.numeroHabitacion = numeroHabitacion;
		
	}

	public int getNumeroHabitacion() {
		return numeroHabitacion;
	}

	public void setNumeroHabitacion(int numeroHabitacion) {
		this.numeroHabitacion = numeroHabitacion;
	}

	
	
	
	
	

}
