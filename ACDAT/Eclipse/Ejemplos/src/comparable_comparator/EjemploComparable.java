package comparable_comparator;

import java.util.Arrays;
import java.util.Comparator;

public class EjemploComparable {
	
    public static void main(String[] args) {
    	
    	/// EJEMPLOS DE COMPARABLE  (Comparable<Persona>)
        Persona[] personas = {
                new Persona("Juan", 25),
                new Persona("Maria", 30),
                new Persona("Pedro", 20)
        };

        Arrays.sort(personas);

        for (Persona persona : personas) {
            System.out.println(persona);
        }
        
        ///EJEMPLOS DE COMPARABLE  (Comparable<Persona>)
        
        
        Producto[] productos = {
                new Producto("Laptop", 1200.0),
                new Producto("Teléfono", 800.0),
                new Producto("Tablet", 500.0)
            };

            Arrays.sort(productos);

            for (Producto producto : productos) {
                System.out.println(producto);
            }
        
            
        ////// EJEMPLOS DE COMPARATOR (Comparator<Producto>)
            
       
        Producto[] productos2 = {
                new Producto("Laptop2", 21200.0),
                new Producto("Teléfono2", 2800.0),
                new Producto("Tablet2", 2500.0)
            };

            Arrays.sort(productos2, new ComparadorPorNombre());

            
            for (Producto producto : productos2) {
                System.out.println(producto);
            }     
        
        
    }
}

