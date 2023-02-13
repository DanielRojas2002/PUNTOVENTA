using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgUsuario
    {
        public int? Id_Usuario { get; set; }
        public string? Usuario { get; set; }

        public string? Contrasenia { get; set; }

        public int? Id_Perfil { get; set; }

        public string? DescripcionPerfil { get; set; }

    }
}
