/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package BD;

/**
 *
 * @author david
 */
public class Coche {
    
    private int idCoche;
    private String nombre;

    public Coche(int idCoche, String nombre) {
        this.idCoche = idCoche;
        this.nombre = nombre;
    }

    public Coche() {
        
    }

    public int getIdCoche() {
        return idCoche;
    }

    public void setIdCoche(int idCoche) {
        this.idCoche = idCoche;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public String toString() {
        return "coche{" + "idCoche=" + idCoche + ", nombre=" + nombre + '}';
    }
    
    
    
}
