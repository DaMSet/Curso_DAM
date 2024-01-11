/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package BD;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author david
 */
public class EjemploDAOcoche {
    
    private static EjemploDAOcoche dao = null;

    private EjemploDAOcoche() {
        super();
    }

    public int insertarVehiculo(Coche coche) {
        String sqlQuery = "INSERT INTO coche (idcoche, nombrecoche) VALUES (?, ?)";

        try (Connection conexion = Conexion.enlace();
             PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
            statement.setInt(1, coche.getIdCoche());
            statement.setString(2, coche.getNombre());

            if (statement.executeUpdate() > 0) {
                return 1;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return 0;
    }


    //Patrón Singleton
    public static EjemploDAOcoche getInstance() {
        if (dao == null) {
            return dao = new EjemploDAOcoche();
        }
        return dao;
    }

    
    public int eliminarCoche(int id) {
    String sqlQuery = "DELETE FROM coche WHERE id = ?";
    
    try (Connection conexion = Conexion.enlace();
         PreparedStatement statement = conexion.prepareStatement(sqlQuery)) {
        statement.setInt(1, id);

        if (statement.executeUpdate() > 0) {
            System.out.println("Vehiculo eliminado exitosamente.");
            return 1;
        }
    } catch (SQLException e) {
        e.printStackTrace();
    }
    return 0;
}




    public List<Coche> getCoches() {
    List<Coche> listaVehiculos = new ArrayList<>();

    try (Connection conexion = Conexion.enlace();
         PreparedStatement statement = conexion.prepareStatement("SELECT id, nombre FROM coche");
         ResultSet resultSet = statement.executeQuery()) {

        while (resultSet.next()) {
            int id = resultSet.getInt("id");
            String nombre = resultSet.getString("nombre");

            Coche coche = new Coche(id, nombre);
            listaVehiculos.add(coche);
        }

    } catch (SQLException e) {
        System.err.println(e.getMessage());
    }

    return listaVehiculos;
}


   
    
}
