package Clases;

import java.util.Date;

public class Persona {

	private	String DNI;
	private Pais pais;
	private Zona zona;
	private String nombre;
	private Integer minusvalia; 
	//Este puede ser de distintas formas de comprovar el tipo de minusvalia ,comuun enum o numerica 
	//Lo hago numerica para hecerlo diferente de mi compañero
	private Date fecha;
	
	public Persona(String DNI,Pais pais,Zona zona,String nombre, Integer minusvalia, Date fecha) {
		
		this.DNI = DNI;
		this.pais = pais;
		this.zona = zona;
		this.nombre = nombre;
		this.minusvalia = minusvalia;
		this.fecha = fecha;		
		
	}


	public String getDNI() {
		return DNI;
	}


	public void setDNI(String dNI) {
		DNI = dNI;
	}


	public Pais getPais() {
		return pais;
	}


	public void setPais(Pais pais) {
		this.pais = pais;
	}


	public Zona getZona() {
		return zona;
	}


	public void setZona(Zona zona) {
		this.zona = zona;
	}


	public String getNombre() {
		return nombre;
	}


	public void setNombre(String nombre) {
		this.nombre = nombre;
	}


	public Integer getMinusvalia() {
		return minusvalia;
	}


	public void setMinusvalia(Integer minusvalia) {
		this.minusvalia = minusvalia;
	}


	public Date getFecha() {
		return fecha;
	}


	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}
	
	
	
	
}
