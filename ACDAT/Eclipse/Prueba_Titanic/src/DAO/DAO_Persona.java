package DAO;

public class DAO_Persona {

	private static DAO_Persona instancia = null;
	
	
	private DAO_Persona() {
		
		
		
		
		
		
	}
	
	
	public static DAO_Persona getInstance() {
		

		if(instancia == null) {
		
			instancia = new DAO_Persona();
		
		}
			
		return instancia;		
		
		
	}
	
}
