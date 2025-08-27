using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Prestamo
    {
        public Prestamo(DateTime Fecha, string NombreSocio, int CantDias)
        {
            this.Fecha = Fecha;
            this.NombreSocio = NombreSocio;
            this.CantDias = CantDias;
        }

        public DateTime Fecha {  get; set; }

        public string NombreSocio { get; set; }

        public int CantDias { get; set; }

    }
}
