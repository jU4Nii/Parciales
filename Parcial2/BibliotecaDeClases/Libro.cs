using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Libro
    {

        public Libro(string Titulo, string Autor)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            ISBN = GeneradorId.GetNextISBN();


        }

        public string Titulo {  get; set; }

        public string Autor {  get; set; }

        public string Tipo { get; set; }

        public int ISBN { get; set; }

        public List<Prestamo> ListaPrestamos { get; set; } = new List<Prestamo>();

        public static List<Libro> ListaLibros = new List<Libro>();

        public static void MostrarLibrosYEstadisticas()
        {
            int cantTotalPrestamos = 0;
            int CantTotalLibrosFisicos = 0;
            int cantTotalLibrosDigitales = 0;
            foreach(Libro libro in ListaLibros)
            {

                Console.WriteLine($"Título: {libro.Titulo}; Autor: {libro.Autor}; Cantidad de préstamos: {libro.CalcularTotalPrestamos()}");
                cantTotalPrestamos += libro.CalcularTotalPrestamos();
                if (libro is LibroDigital libroD) cantTotalLibrosDigitales++;
                else if (libro is LibroFisico libroF) CantTotalLibrosFisicos++;

            }
            Console.WriteLine($"Cantidad total de préstamos: {cantTotalPrestamos}");
            Console.WriteLine($"Cantidad total de libros físicos: {CantTotalLibrosFisicos}");
            Console.WriteLine($"Cantidad total de libros digitales: {cantTotalLibrosDigitales}");

        }

        public int CalcularTotalPrestamos()
        {

            return this.ListaPrestamos.Count;

        }

    }
}
