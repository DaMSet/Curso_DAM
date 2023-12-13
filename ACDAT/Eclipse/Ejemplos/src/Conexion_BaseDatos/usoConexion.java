package Conexion_BaseDatos;

import java.sql.ResultSet;
import java.sql.SQLException;

public class usoConexion {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		ConexionBD conexionBD = ConexionBD.obtenerInstancia();

        // Ejemplo de inserción
        String insercion = "INSERT INTO tu_tabla (columna1, columna2) VALUES ('valor1', 'valor2')";
        boolean resultadoInsercion = conexionBD.ejecutarInsercion(insercion);
        System.out.println("Inserción exitosa: " + resultadoInsercion);

        // Ejemplo de consulta
        String consulta = "SELECT * FROM tu_tabla";
        ResultSet resultadoConsulta = conexionBD.ejecutarConsulta(consulta);
        if (resultadoConsulta != null) {
            try {
                while (resultadoConsulta.next()) {
                    // Procesar resultados de la consulta
                    System.out.println(resultadoConsulta.getString("columna1") + ", " +
                                       resultadoConsulta.getString("columna2"));
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }

        
        
        // Ejemplo de actualización
        String actualizacion = "UPDATE tu_tabla SET columna1 = 'nuevo_valor' WHERE columna2 = 'valor2'";
        boolean resultadoActualizacion = conexionBD.ejecutarActualizacion(actualizacion);
        System.out.println("Actualización exitosa: " + resultadoActualizacion);
        
        
        // Ejemplo de eliminación (DELETE)
        String idAEliminar = "1"; // Supongamos que queremos eliminar el registro con ID 1
        String eliminacion = "DELETE FROM tu_tabla WHERE id = " + idAEliminar;

        boolean resultadoEliminacion = conexionBD.ejecutarActualizacion(eliminacion);
        System.out.println("Eliminación exitosa: " + resultadoEliminacion);


        // Cerrar la conexión al final
        conexionBD.cerrarConexion();
		
	}

}
