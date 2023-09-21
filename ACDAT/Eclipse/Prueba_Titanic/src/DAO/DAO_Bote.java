package DAO;

public class DAO_Bote {

	private static DAO_Bote instancia = null;
	
	
	private DAO_Bote() {
		
		
		
		
		
		
	}
	
	
	public static DAO_Bote getInstance() {
		

		if(instancia == null) {
		
			instancia = new DAO_Bote();
		
		}
			
		return instancia;		
		
		
	}
	
}
