/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Base_de_datos;

/**
 *
 * @author santi
 */
public class Vehiculo {
    
    private String id;

    private String nombre;

 

    public Vehiculo() {


    }

    public Vehiculo(String id,String nombre) {
        this.id = id;
        this.nombre = nombre;
    }

    public String getnombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

   

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }


    @Override
    public String toString() {
        return "Vehiculo [id=" + id + ", nombre=" + nombre + "]";
    }

    String getNombre() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
}
