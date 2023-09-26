package Clases;

import java.time.LocalDate;
import java.util.Date;

public class Persona implements Comparable<Persona>{

	private	String DNI;
	private Pais pais;
	private Zona zona;
	private String nombre;
	private Boolean minusvalia; 
	//Este puede ser de distintas formas de comprovar el tipo de minusvalia ,como enum o numerica o boolean
	//Lo hago numerica para hecerlo diferente de mi compañero
	private LocalDate fecha;
	
	public Persona(String DNI,Pais pais,Zona zona,String nombre, Boolean minusvalia, LocalDate fecha) {
		
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


	public Boolean getMinusvalia() {
		return minusvalia;
	}


	public void setMinusvalia(Boolean minusvalia) {
		this.minusvalia = minusvalia;
	}


	public LocalDate getFecha() {
		return fecha;
	}


	public void setFecha(LocalDate fecha) {
		this.fecha = fecha;
	}


	
	@Override
	public int compareTo(Persona persona2) {
		
	
			// Comparar primero por país
	        int comparacionPorPais = this.pais.compareTo(persona2.pais);
	        
	        if (comparacionPorPais != 0) {
	        	return comparacionPorPais;
	        } else {
	            // Si el país es el mismo, compara por nombre dentro del mismo país
	            return this.nombre.compareTo(persona2.nombre);
	        }
	        
	        
			
		}
	
		
		
	
	}
	

	
	
	
	

