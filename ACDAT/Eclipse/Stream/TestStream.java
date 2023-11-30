import java.util.ArrayList;
import java.util.List;

public class TestStream {

	public static void main(String[] args) {
		List<Curso> cursos = new ArrayList<Curso>();
		cursos.add(new Curso("Cursos profesional de Java", 6.5f, 50, 200 ));
		cursos.add(new Curso("Cursos profesional de Python", 8.5f, 60, 800 ));
		cursos.add(new Curso("Cursos profesional de DB", 4.5f, 70, 700 ));
		cursos.add(new Curso("Cursos profesional de Android", 7.5f, 10, 400 ));
		cursos.add(new Curso("Cursos profesional de Escritura", 1.5f, 10, 300 ));

		
		
		
		//Obtener la cantidad de cursos con una duración mayor a 5 horas.
		
		long catidadDeCursosMayoresA5Horas = cursos.stream()
				.filter(curso -> curso.getDuracion() > 5.0)
				.count();
		
		System.out.println("Cantidad de cursos con duración mayor a 5 horas: " + catidadDeCursosMayoresA5Horas);


		//Obtener la cantidad de cursos con una duración menor a 2 horas.
		
		
		long catidadDeCursosMenoresA2Horas = cursos.stream()
				.filter(curso -> curso.getDuracion() < 2)
				.count();
		
		System.out.println("Cantidad de cursos con duración menor a 2 horas: " + catidadDeCursosMenoresA2Horas);

		
	}
	
	
	
	
	

}

/*
  
Obtener la cantidad de cursos con una duración mayor a 5 horas.
Obtener la cantidad de cursos con una duración menor a 2 horas.
Listar el título de todos aquellos cursos con una cantidad de vídeos mayor a 50.
Mostrar en consola el título de los 3 cursos con mayor duración.
Mostrar en consola la duración total de todos los cursos.
Mostrar en consola todos aquellos libros que superen el promedio en cuanto a duración se refiere.
Mostrar en consola la duración de todos aquellos cursos que tengan una cantidad de alumnos inscritos menor a 500.
Obtener el curso con mayor duración.
Crear una lista de Strings con todos los títulos de los cursos.
 
 */