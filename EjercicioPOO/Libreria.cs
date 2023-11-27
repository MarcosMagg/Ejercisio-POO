using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    internal class Libreria
    {
        public List<Libro> libros;

        public Libreria() 
        { 
            libros = new List<Libro>();
        }


        //Metodos
        public void Listarlibros()
        {
            Console.WriteLine("Listado de libros");
            Console.Write("\n");
            foreach (var libro in libros)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}");
                Console.WriteLine($"Autor: {libro.Autor}");
                Console.WriteLine($"Descripcion: {libro.Descripcion}");
                Console.WriteLine($"Prestado: {libro.Prestado}");
                Console.Write("\n\n");
            }
            
        }

        public void PrestarLibro(string titulo, String nombreAlumno)
        {
            var libro = libros.Find(libro => libro.Titulo == titulo);
            if (libro != null && !libro.Prestado) //si libro es distinto de null y distinto que la condicion prestado
            {
                libro.Prestado = true;
                Console.WriteLine($"El libro {titulo} ha sido prestado");
            }
            else
            {
                Console.WriteLine($"El libro {titulo} no se encuentra disponibe");
            }  
        }



        public void DevolverLibro(string titulo)//similar al PrestarLibro, solo que sin nega el prestado
        {
            var libro = libros.Find(libro => libro.Titulo == titulo);
            if (libro != null && libro.Prestado)
            {
                libro.Prestado = false;
                Console.WriteLine($"El libro {titulo} ha sido devuelto");
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no existe o no ha sido prestado");
            }
        }

        public void EstudianteConLibor(string nombreAlumno)
        {
            var libroPrestado = libros.FindAll(libroPrestado => libroPrestado.Prestado);
            if (libroPrestado.Count > 0)
            {
                Console.WriteLine($"Libros prestados a {nombreAlumno} : ");
                foreach (var libro in libroPrestado)
                {
                    Console.WriteLine($"Titulo: {libro.Titulo}");
                    Console.WriteLine($"Autor: {libro.Autor}");
                }
            }
            else
            {
                Console.WriteLine($"No hay libros prestados al alumno {nombreAlumno}");
            }
            }
        }



    }

