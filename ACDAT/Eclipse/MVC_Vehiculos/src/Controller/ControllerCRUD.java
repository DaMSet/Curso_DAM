package Controller;




import java.util.List;

import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.DAOVehiculoImpl;
import Recursos.Vehiculo;
import Vista.PanelCRUD;





public class ControllerCRUD
{
	
	
	public static void cargarTabla(JTable tablaVehiculos)
	{ //DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaVehiculos.getModel();
		List<Vehiculo> lstVehiculos = DAOVehiculoImpl.getInstance().getVehiculos();
		
		DefaultTableModel modelo=new DefaultTableModel();
	 
	 
	 modelo.addColumn("Marca");

	 modelo.addColumn("Modelo");

	 modelo.addColumn("Matricula");

	
    
   
	 Object[] registroLeido = new Object [3];
	 
	 for(Vehiculo vehiculo:lstVehiculos)

	 {	 

			registroLeido[0]= vehiculo.getMarca();

			registroLeido[1]= vehiculo.getModelo();

			registroLeido[2]=  vehiculo.getMatricula();
	 



		 modelo.addRow(registroLeido);

	 }

	 
	 
	 tablaVehiculos.setModel(modelo);
	}
	
	
	public static boolean insertarVehiculo( PanelCRUD frmVehiculo, JTable tablaVehiculos)
	{ boolean insertado=false;
	Vehiculo vehiculo=new Vehiculo();
	 
	 
	 
	 vehiculo.setMarca(frmVehiculo.getTxtMarca().getText());

	 vehiculo.setModelo(frmVehiculo.getTxtModelo().getText());

	 vehiculo.setMatricula(frmVehiculo.getTxtMatricula().getText());
	 
		if (DAOVehiculoImpl.getInstance().insertarVehiculo(vehiculo)!=0)
		{insertado=true;
		cargarTabla( tablaVehiculos);
		}
     return insertado;		
	}


	

	public static boolean borrarVehiculos(PanelCRUD frmVehiculo, JTable tablaVehiculos) {
		
		boolean borrado=false;
		Vehiculo vehiculo=new Vehiculo();
		 
		 
		 
		/* vehiculo.setMarca(frmVehiculo.getTxtMarca().getText());

		 vehiculo.setModelo(frmVehiculo.getTxtModelo().getText());*/

		 vehiculo.setMatricula(frmVehiculo.getTxtMatricula().getText());
		 
			if (DAOVehiculoImpl.getInstance().eliminarVehiculo(vehiculo)==0)
			{
				borrado=true;
				
			
									
			}
			
			return borrado;
			
	}
	
	
	
	
	

}

/*
 CREATE TABLE `mysql`.`coches` (
  `id` int(11) NOT NULL,
  `marca` varchar(255) NOT NULL,
  `modelo` varchar(255) NOT NULL,
  `matricula` varchar(10) NOT NULL,
  `id_propietario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
ALTER TABLE `mysql`.`coches` ADD PRIMARY KEY (`id`), ADD KEY `fk_propietario` (`id_propietario`);
ALTER TABLE `mysql`.`coches` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29 ;

SET SQL_MODE='NO_AUTO_VALUE_ON_ZERO';

INSERT INTO `mysql`.`coches`(`id`, `marca`, `modelo`, `matricula`, `id_propietario`) SELECT `id`, `marca`, `modelo`, `matricula`, `id_propietario` FROM `db_vehiculos`.`coches`;
CREATE TABLE `mysql`.`propietarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
ALTER TABLE `mysql`.`propietarios` ADD PRIMARY KEY (`id`);
ALTER TABLE `mysql`.`propietarios` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

SET SQL_MODE='NO_AUTO_VALUE_ON_ZERO';

INSERT INTO `mysql`.`propietarios`(`id`, `nombre`) SELECT `id`, `nombre` FROM `db_vehiculos`.`propietarios`;
 * */
