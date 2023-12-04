package Clases;

public class persona {

	private String dni; 
	private String nombre;
	private TipoPersona tipoP;
	
	
	public persona(String dni, String nombre, TipoPersona tipoP) {
		super();
		this.dni = dni;
		this.nombre = nombre;
		this.tipoP = tipoP;
	}


	public String getDni() {
		return dni;
	}


	public void setDni(String dni) {
		this.dni = dni;
	}


	public String getNombre() {
		return nombre;
	}


	public void setNombre(String nombre) {
		this.nombre = nombre;
	}


	public TipoPersona getTipoP() {
		return tipoP;
	}


	public void setTipoP(TipoPersona tipoP) {
		this.tipoP = tipoP;
	}
	
	
	
	
	
}
