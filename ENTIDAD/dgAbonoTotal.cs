using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgAbonoTotal
    {

        public int? Id_Venta { get; set; }

        public int? Id_Credito { get; set; }

        public int? Id_Usuario { get; set; }


        public int? Id_Tipo_Venta { get; set; }

        

    
        public int? Id_Cliente { get; set; }



      
        public float? TotalVenta { get; set; }

        public float? CantidadPagadaTotal { get; set; }

        public float? CantidadFaltanteTotal { get; set; }

        public float? Cambio { get; set; }

       
    }
}
