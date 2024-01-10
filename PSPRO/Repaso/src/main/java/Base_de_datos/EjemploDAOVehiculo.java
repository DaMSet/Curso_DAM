/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Base_de_datos;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author santi
 */
public class EjemploDAOVehiculo {
    
    private static EjemploDAOVehiculo dao=null; 
    private static Connection connection;

    private EjemploDAOVehiculo() {
        super();
        connection = Connecion.enlace();
    }


    public int insertarVehiculo(Vehiculo vehiculo) {
        String sqlQuery = "INSERT INTO vehiculos (id, nombre) VALUES (?, ?)";

        try (PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
            statement.setInt(1, vehiculo.getId());
            statement.setString(2, vehiculo.getNombre());
            

            if (statement.executeUpdate() > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return 0;
    }


    public int eliminarVehiculo(int id) {
        String sqlQuery = "DELETE FROM coche WHERE id = ?";

        try(PreparedStatement statement = connection.prepareStatement(sqlQuery)) {
                statement.setInt(1, id);

        if (statement.executeUpdate() > 0) {
            System.out.println("Vehiculos eliminado exitosamente.");
            return 1;
        }
        }
        catch(SQLException e) {
                e.printStackTrace();
        }
        return 0;
    }




    public List<Vehiculo> getVehiculos(){
        List<Vehiculo> listaVehiculos = new ArrayList<>();

        try {
            String sql = "SELECT id,nombre FROM coche";
            PreparedStatement statement = connection.prepareStatement(sql);
            ResultSet resultSet = statement.executeQuery();

            while (resultSet.next()) {
            
                int id = resultSet.getInt("id");
                String nombre = resultSet.getString("nombre");
                
                Vehiculo vehiculo = new Vehiculo(id,nombre);

                listaVehiculos.add(vehiculo);
            }

        } catch (SQLException e) {
            System.err.println(e.getMessage());
        }

        return listaVehiculos;
    }


    //Patron Singleton
    public static EjemploDAOVehiculo getInstance() {
        if (dao== null){
            return dao =new EjemploDAOVehiculo();
        }
        return dao;
    }

}
