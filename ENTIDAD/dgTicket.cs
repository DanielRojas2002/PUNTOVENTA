using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgTicket
    {

        public string? Id_Producto { get; set; }

        public int? Id_Venta { get; set; }

        public int? CantidadComprada { get; set; }

        public float? PrecioComprado { get; set; }

        public float? SubTotal { get; set; }

        public float? Total { get; set; }

        public float? Cambio { get; set; }

        public string? DescripcionTipoVenta { get; set; }
        public string? NombreProducto { get; set; }

        public string? Usuario { get; set; }

        public DateTime? FechaVenta { get; set; }

        public string? NombreEmpresa { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public string? Mensaje { get; set; }

       


    }
}
