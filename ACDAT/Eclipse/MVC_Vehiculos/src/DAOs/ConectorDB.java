package DAOs;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import Recursos.Vehiculo;

public class ConectorDB {

	
	   private static final String URL = "jdbc:mysql://localhost:3306/db_vehiculos";
	   private static final String USUARIO = "admin";
	   private static final String CONTRASEÑA = "admin";
	   
	    // Método para obtener una conexión a la base de datos
	    public static Connection obtenerConexion() throws SQLException {
	        return DriverManager.getConnection(URL, USUARIO, CONTRASEÑA);
	    }
	    
	    // Método para cerrar la conexión
	    public static void cerrarConexion(Connection conexion) throws SQLException {
	        if (conexion != null && !conexion.isClosed()) {
	            conexion.close();
	        }
	    }
	    
	    
	    public static List<Vehiculo> obtenerCoches() {
	        List<Vehiculo> coches = new ArrayList<>();
	        Connection conexion = null;
	        PreparedStatement statement = null;
	        ResultSet resultSet = null;

	        try {
	            conexion = obtenerConexion();

	            String consulta = "SELECT * FROM Coches";
	            statement = conexion.prepareStatement(consulta);
	            resultSet = statement.executeQuery();

	            while (resultSet.next()) {
	                int id = resultSet.getInt("id");
	                String marca = resultSet.getString("marca");
	                String modelo = resultSet.getString("modelo");
	                String matricula = resultSet.getString("matricula");

	                Vehiculo coche = new Vehiculo(id, marca, modelo, matricula);
	                coches.add(coche);
	            }

	        } catch (SQLException e) {
	            e.printStackTrace();
	        } finally {
	            try {
	                if (resultSet != null) resultSet.close();
	                if (statement != null) statement.close();
	                cerrarConexion(conexion);
	            } catch (SQLException e) {
	                e.printStackTrace();
	            }
	        }

	        return coches;
	    }
	    
	    public static void agregarCoche(Vehiculo coche) {
	        Connection conexion = null;
	        PreparedStatement statement = null;

	        try {
	            conexion = obtenerConexion();

	            String consulta = "INSERT INTO Coches (marca, modelo, matricula) VALUES (?, ?, ?)";
	            statement = conexion.prepareStatement(consulta);
	            statement.setString(1, coche.getMarca());
	            statement.setString(2, coche.getModelo());
	            statement.setString(3, coche.getMatricula());

	            int filasAfectadas = statement.executeUpdate();
	            if (filasAfectadas > 0) {
	                System.out.println("Coche agregado exitosamente.");
	            } else {
	                System.out.println("No se pudo agregar el coche.");
	            }

	        } catch (SQLException e) {
	            e.printStackTrace();
	        } finally {
	            try {
	                if (statement != null) statement.close();
	                cerrarConexion(conexion);
	            } catch (SQLException e) {
	                e.printStackTrace();
	            }
	        }
	    }
	    
	    public static void editarCoche() 
	    {
	    	
	    	
	    }
	    
	    
	    public static void borrarCoche(String matricula) 
	    {
	    	Connection conexion = null;
	        PreparedStatement statement = null;

	        try {
	            conexion = obtenerConexion();

	            String consulta = "DELETE FROM Coches WHERE matricula = ?";
	            statement = conexion.prepareStatement(consulta);
	            statement.setString(1, matricula);

	            int filasAfectadas = statement.executeUpdate();
	            if (filasAfectadas > 0) {
	                System.out.println("Coche con matrícula " + matricula + " borrado exitosamente.");
	            } else {
	                System.out.println("No se encontró el coche con matrícula " + matricula + ".");
	            }

	        } catch (SQLException e) {
	            e.printStackTrace();
	        } finally {
	            try {
	                if (statement != null) statement.close();
	                cerrarConexion(conexion);
	            } catch (SQLException e) {
	                e.printStackTrace();
	            }
	        }
	    	
	    }
	    
	
}
