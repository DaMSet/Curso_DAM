package Clases;

public class organizacion {

	private String nombre; 
	private String nif;
	private TipoVecinal tipoV;
	
	
	public organizacion(String nombre, String nif, TipoVecinal tipoV) {
		super();
		this.nombre = nombre;
		this.nif = nif;
		this.tipoV = tipoV;
	}


	public String getNombre() {
		return nombre;
	}


	public void setNombre(String nombre) {
		this.nombre = nombre;
	}


	public String getNif() {
		return nif;
	}


	public void setNif(String nif) {
		this.nif = nif;
	}


	public TipoVecinal getTipoV() {
		return tipoV;
	}


	public void setTipoV(TipoVecinal tipoV) {
		this.tipoV = tipoV;
	}
	
	
	
	
	
}
