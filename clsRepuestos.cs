using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryArmaniniAutoCor_SP1
{
    internal class clsRepuestos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public bool origen { get; set; }

        public string ObtenerDatos()
        {
            return Codigo + " " + Nombre + " " + Marca + " " + Precio + " " + origen + " ";
        }


    }
}
