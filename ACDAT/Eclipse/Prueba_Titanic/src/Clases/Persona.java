package Clases;

import java.util.Date;

public class Persona {

	private	String DNI;
	private String pais;
	private Zona zona;
	private String nombre;
	private Integer Minusvalia; 
	//Este puede ser de distintas formas de comprovar el tipo de minusvalia ,comuun enum o numerica 
	//Lo hago numerica para hecerlo diferente de mi compañero
	private Date fecha;
	
	public Persona(String DNI,String pais,Zona zona) {
		
		this.DNI = DNI;
		this.pais = pais;
		this.zona = zona;
		
		
	}


	public String getDNI() {
		return DNI;
	}


	public void setDNI(String dNI) {
		DNI = dNI;
	}


	public String getPais() {
		return pais;
	}


	public void setPais(String pais) {
		this.pais = pais;
	}


	public Zona getZona() {
		return zona;
	}


	public void setZona(Zona zona) {
		this.zona = zona;
	}
	
	
	
	
}
