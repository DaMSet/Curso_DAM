package Clases;

public class Vivienda {

	
	private Integer NRegistro;
	private String Direccion;
	private TipoVivienda tipoVi;
	
	public Vivienda(Integer nRegistro, String direccion, TipoVivienda tipoVi) {
		super();
		NRegistro = nRegistro;
		Direccion = direccion;
		this.tipoVi = tipoVi;
	}

	public Integer getNRegistro() {
		return NRegistro;
	}

	public void setNRegistro(Integer nRegistro) {
		NRegistro = nRegistro;
	}

	public String getDireccion() {
		return Direccion;
	}

	public void setDireccion(String direccion) {
		Direccion = direccion;
	}

	public TipoVivienda getTipoVi() {
		return tipoVi;
	}

	public void setTipoVi(TipoVivienda tipoVi) {
		this.tipoVi = tipoVi;
	}
	
	
	
	
	
}
