package comparable_comparator;

public class Persona implements Comparable<Persona> {
    private String nombre;
    private int edad;

    public Persona(String nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }

    @Override
    public int compareTo(Persona otraPersona) {
    	//Utilizamos el compare mas las variables que queremos comparar y este nos devolvera 1, 0, o -1 dependioendo de si es mayor , igual o menor 
        return Integer.compare(this.edad, otraPersona.edad);
    }

    @Override
    public String toString() {
        return "Persona{" +
               "nombre='" + nombre + '\'' +
               ", edad=" + edad +
               '}';
    }
    
    
}