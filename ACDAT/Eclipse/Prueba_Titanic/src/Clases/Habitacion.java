package Clases;

import java.util.List;

public class Habitacion {

	private int numeroHabitacion;
    private List<Pasajero> ocupantes;
    
	public int getNumeroHabitacion() {
		return numeroHabitacion;
	}
	
	public void setNumeroHabitacion(int numeroHabitacion) {

		this.numeroHabitacion = numeroHabitacion;
	}
	
	public List<Pasajero> getOcupantes() {
		return ocupantes;
	}
	
	public void setOcupantes(List<Pasajero> ocupantes) {
		this.ocupantes = ocupantes;
	}
    
    
    
	
}
