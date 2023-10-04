﻿using System;
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
            return alumnos.FirstOrDefault();
        }

        public static Alumno getUltimoAlumno(List<Alumno> alumnos)
        {
            return alumnos.LastOrDefault();
        }

        public static int getSumaNota(List<Alumno> alumnos)
        {
            return alumnos.Sum(p => p.Nota);
        }

        public static int getNotaMaxima(List<Alumno> alumnos)
        {
            return alumnos.Max(p => p.Nota);
        }

        public static int getNotaMinima(List<Alumno> alumnos)
        {
            return alumnos.Min(p => p.Nota);
        }

        public static int getNotaPorNombre(List<Alumno> alumnos, string v)
        {

            var alumno = alumnos.FirstOrDefault(alumno => alumno.Nombre == v);

            return alumno.Nota;
        }

        public static double getNotaMedia(List<Alumno> alumnos)
        {
           return  Math.Round(alumnos.Average(p => p.Nota),2);
        }
    }
}
