using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class LibroFisico : Libro
    {

        public LibroFisico(string Titulo, string Autor) : base(Titulo, Autor)
        {

            Tipo = "Fisico";


        }

        public bool Disponible { get; set; }

    }
}
