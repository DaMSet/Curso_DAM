using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad6
{
    public class Alumno
    {
        static void Main(string[] args)
        {
        }

        public string Nombre { get; set; }
        public int Nota { get; set; }

        public static List<string> getNombres(List<Alumno> alumnos)
        {
           
            return alumnos.Select(p => p.Nombre).ToList(); 

        }

        public static Alumno getListadoNota(List<Alumno> alumnos, int nota)
        {

            return alumnos.FirstOrDefault(alumno => alumno.Nota == nota);

        }

        public static Alumno getPrimerAlumno(List<Alumno> alumnos)
        {
            return alumnos.FirstOrDefault(alumno => alumno.Nombre == getNombres);
        }

        public static Alumno getUltimoAlumno(List<Alumno> alumnos)
        {
            return null;
        }

        public static int getSumaNota(List<Alumno> alumnos)
        {
            throw new NotImplementedException();
        }

        public static int getNotaMaxima(List<Alumno> alumnos)
        {
            throw new NotImplementedException();
        }

        public static int getNotaMinima(List<Alumno> alumnos)
        {
            throw new NotImplementedException();
        }

        public static int getNotaPorNombre(List<Alumno> alumnos, string v)
        {
            throw new NotImplementedException();
        }

        public static double getNotaMedia(List<Alumno> alumnos)
        {
            throw new NotImplementedException();
        }
    }
}
