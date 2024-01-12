package BD;

import java.beans.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author david
 */
public class Conexion {
    
  
    
    static Connection conn=null;
    static Statement st=null;
    static ResultSet rs=null;
    static String bd="coches";
    static String login="root";
    static String password="root";  
    static String url="jdbc:mysql://localhost:3306/coches"  ;//+bd;


    
    public static Connection enlace (){
        try {
            Class.forName("com.mysql.jdbc.Driver");
            //Class.forName("com.mysql.cj.jdbc.Driver");
            conn=DriverManager.getConnection(url,login,password);
            if (conn != null) {
            System.out.println("Conexión exitosa a la base de datos.");
        }
        } catch (SQLException ex) {
            System.out.println("Excepicon en la conexión");
        } catch (ClassNotFoundException ex) {
            System.out.println("No se encuentra la clase");
        }
        return conn;
    }


     public static void cerrarSesion() {
        try {
            conn.close();
        } catch (SQLException ex) {
            Logger.getLogger(Conexion.class.getName()).log(Level.SEVERE, null, ex);
        }
     }
     
    public static void main(String[] args) {

        conn=enlace();
        cerrarSesion();

    }

}

    

