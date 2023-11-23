package DAOs;


import java.util.ArrayList;
import java.util.List;

import Recursos.Vehiculo;




public class DAOVehiculoImpl implements IDAOVehiculo {
	
	private List<Vehiculo> falsaBD;
	private static IDAOVehiculo dao=null; 

	private DAOVehiculoImpl() {
		super();
		//this.falsaBD = new ArrayList<Vehiculo>();
		this.falsaBD = ConectorDB.obtenerCoches();
		falsaBD.add(new Vehiculo(0,"Renault","Zoe","2345FDF"));
		ConectorDB.agregarCoche(new Vehiculo(0,"Renault","Zoe","2345FDF"));
		
		falsaBD.add(new Vehiculo(1,"Renault","Fluence","0000FTL"));
		ConectorDB.agregarCoche(new Vehiculo(1,"Renault","Fluence","0000FTL"));
		
		falsaBD.add(new Vehiculo(2,"Tesla","3","2422FHT"));
		ConectorDB.agregarCoche(new Vehiculo(2,"Tesla","3","2422FHT"));
		
		falsaBD.add(new Vehiculo(3,"Tesla","X","1221FDF"));
		ConectorDB.agregarCoche(new Vehiculo(3,"Tesla","X","1221FDF"));
	}

	@Override
	public int insertarVehiculo(Vehiculo vehiculo) {
	 falsaBD.add(vehiculo);
	 ConectorDB.agregarCoche(vehiculo);
		return 1;
	}

	

	@Override
	public int eliminarVehiculo(String matricula) {
		
		Vehiculo vehiculoBorrar =getVehiculo(matricula);
		
		
		falsaBD.remove(vehiculoBorrar);
		ConectorDB.borrarCoche(matricula);
		
		return 0;
	}

	@Override
	public int eliminarVehiculos(List<Vehiculo> lstVehiculos) {
		
		return 0;
	}

	@Override
	public Vehiculo getVehiculo(String matricula) {
		Vehiculo vehiculo = null;
		
		for (int i = 0; i < falsaBD.size(); i++) {
			
			if(falsaBD.get(i).getMatricula().equalsIgnoreCase(matricula)){vehiculo = falsaBD.get(i);}
			
		}
		
		return vehiculo;
	}

	@Override
	public List<Vehiculo> getVehiculos() {
		// TODO Auto-generated method stub
		return this.falsaBD;
	}

	
	public static IDAOVehiculo getInstance() {
	  if (dao== null) dao =new DAOVehiculoImpl();
	  
		return dao;
	}

	@Override
	public int eliminarVehiculo(Vehiculo vehiculo) {
		// TODO Auto-generated method stub
		return 0;
	}

}
