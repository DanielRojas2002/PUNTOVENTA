using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgProducto
    {
        public int? Id_Producto { get; set; }

        public int? Id_Categoria { get; set; }

        public int? Id_Medida { get; set; }

        public int? Id_Proveedor { get; set; }

        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public float? PrecioCompra { get; set; }
        public float? PrecioVenta { get; set; }


        public int? StockInicial { get; set; }

    }
}
