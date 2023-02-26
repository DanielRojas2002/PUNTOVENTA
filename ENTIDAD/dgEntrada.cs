using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgEntrada
    {

        public int? Id_Entrada { get; set; }

        public string? IdProducto { get; set; }


        public int? Id_Usuario { get; set; }


        public int? Stock { get; set; }
        public DateTime? FechaEntrada { get; set; }
    }
}
