using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class RespUsuario
    {
        public String message { get; set; }
        public Usuario usuario { get; set; }

        public Administrador admin { get; set; }
        public UsuarioPcd usuarioPCD { get; set; }
        public Instituicao instituicao { get; set; }

        public AdminLogado administrador { get; set; }

        public Estado estados { get; set; }
     
        public String token { get; set; }
    }
}
