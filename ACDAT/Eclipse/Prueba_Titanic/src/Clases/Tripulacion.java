package Clases;

import java.util.Date;

public class Tripulacion extends Persona{

	private Responsabilidad responsabilidad;
	
	public Tripulacion(String DNI, Pais pais, Zona zona, String nombre, Boolean minusvalia, Date fecha,Responsabilidad responsabilidad) {
		super(DNI, pais, zona, nombre, minusvalia, fecha);
		
		this.responsabilidad = responsabilidad;
		
	}

	public Responsabilidad getResponsabilidad() {
		return responsabilidad;
	}

	public void setResponsabilidad(Responsabilidad responsabilidad) {
		this.responsabilidad = responsabilidad;
	}
	
	
	

}
