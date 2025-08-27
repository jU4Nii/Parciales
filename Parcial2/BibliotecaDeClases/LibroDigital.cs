using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class LibroDigital : Libro
    {

        public LibroDigital(string Titulo, string Autor) : base(Titulo, Autor)
        {

            Tipo = "Digital";


        }
    }
}
