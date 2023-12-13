package stream;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class TestStream {

	public static void main(String[] args) {
		List<Curso> cursos = new ArrayList<Curso>();
		cursos.add(new Curso("Cursos profesional de Java", 6.5f, 50, 200 ));
		cursos.add(new Curso("Cursos profesional de Python", 8.5f, 60, 800 ));
		cursos.add(new Curso("Cursos profesional de DB", 4.5f, 70, 700 ));
		cursos.add(new Curso("Cursos profesional de Android", 7.5f, 10, 400 ));
		cursos.add(new Curso("Cursos profesional de Escritura", 1.5f, 10, 300 ));

		
		 // Ejercicio 1: Obtener la cantidad de cursos con una duración mayor a 5 horas.
        long cantidadCursosMayorA5Horas = cursos.stream()
                .filter(curso -> curso.getDuracion() > 5)
                .count();
        System.out.println("Cantidad de cursos con duración mayor a 5 horas: " + cantidadCursosMayorA5Horas);

        // Ejercicio 2: Obtener la cantidad de cursos con una duración menor a 2 horas.
        long cantidadCursosMenorA2Horas = cursos.stream()
                .filter(curso -> curso.getDuracion() < 2)
                .count();
        System.out.println("Cantidad de cursos con duración menor a 2 horas: " + cantidadCursosMenorA2Horas);

        // Ejercicio 3: Listar el título de todos aquellos cursos con una cantidad de vídeos mayor a 50.
        List<String> titulosCursosConMasDe50Videos = cursos.stream()
                .filter(curso -> curso.getVideos() > 50)
                .map(Curso::getTitulo)
                .collect(Collectors.toList());
        System.out.println("Títulos de cursos con más de 50 videos: " + titulosCursosConMasDe50Videos);

        // Ejercicio 4: Mostrar en consola el título de los 3 cursos con mayor duración.
        List<String> titulosCursosConMayorDuracion = cursos.stream()
                .sorted(Comparator.comparing(Curso::getDuracion).reversed())
                .limit(3)
                .map(Curso::getTitulo)
                .collect(Collectors.toList());
        System.out.println("Títulos de los 3 cursos con mayor duración: " + titulosCursosConMayorDuracion);

        // Ejercicio 5: Mostrar en consola la duración total de todos los cursos.
        float duracionTotalCursos = cursos.stream()
                .map(Curso::getDuracion)
                .reduce(0f, Float::sum);
        System.out.println("Duración total de todos los cursos: " + duracionTotalCursos + " horas");

        // Ejercicio 6: Mostrar en consola todos aquellos cursos que superen el promedio en cuanto a duración se refiere.
        float duracionPromedioCursos = duracionTotalCursos / cursos.size();
        System.out.println("Cursos que superan el promedio de duración:");

        cursos.stream()
                .filter(curso -> curso.getDuracion() > duracionPromedioCursos)
                .forEach(curso -> System.out.println("- " + curso.getTitulo()));

        // Ejercicio 7: Mostrar en consola la duración de todos aquellos cursos que tengan una cantidad de alumnos inscritos menor a 500.
        System.out.println("Duración de cursos con menos de 500 alumnos inscritos:");

        cursos.stream()
                .filter(curso -> curso.getAlumnos() < 500)
                .forEach(curso -> System.out.println("- " + curso.getDuracion() + " horas"));

        // Ejercicio 8: Obtener el curso con mayor duración.
        Curso cursoConMayorDuracion = cursos.stream()
                .max(Comparator.comparing(Curso::getDuracion))
                .orElse(null);
        System.out.println("Curso con mayor duración: " + cursoConMayorDuracion);

        // Ejercicio 9: Crear una lista de Strings con todos los títulos de los cursos.
        List<String> titulosDeCursos = cursos.stream()
                .map(Curso::getTitulo)
                .collect(Collectors.toList());
        System.out.println("Lista de títulos de cursos: " + titulosDeCursos);
   
		
		
		
	}

}
