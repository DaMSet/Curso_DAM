package Clases;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		
		
		Zona	num = Zona.Babor;
		
		System.out.println(num.getescalera());

		
		
		List<Persona> lista = new ArrayList<>();
		
		
		lista.add(new Persona("32093956D", Pais.España, Zona.Estribor, "David", false, LocalDate.of(1999,10, 20)));
		lista.add(new Pasajero("32093956D", Pais.America, Zona.Babor, "Pepe", false, LocalDate.of(1998,10, 20),1));
		lista.add(new Tripulacion("32093956D", Pais.America, Zona.Babor, "Alex", false, LocalDate.of(1998,10, 20),Responsabilidad.Muy_alta));
		lista.add(new Persona("32093956D", Pais.Francia, Zona.Popa, "Jose", false, LocalDate.of(2000,10, 20)));
		
		
		Collections.sort(lista);
		
		
		for (Persona persona : lista) {
			System.out.println(persona.getPais());
            System.out.println(persona.getNombre());
        }
		
		
	}

}
