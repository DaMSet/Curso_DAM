package Clases;

public enum Zona {

	Proa(new int[] {4,9,24}), Popa(new int[] {4,9,24}), Babor(new int[] {4,9,24}) ,Estribor(new int[] {4,9,24});
	
	private int[] lista ;
	//int[] numeros = {1, 2, 3, 4, 5};

	Zona(int[] lista){
		this.lista = lista;
	}
	
	
	public int[] getlista(){
		return lista;
	}
}

