using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class Usuario
    {
        public String id { get; set; }
        public String email { get; set; }
        public String senha { get; set; }
        public String tipo { get; set; }
        public String ativo { get; set; }
        public String Token { get; set; }
        public UsuarioPcd usuarioPcd { get; set; }
        public Instituicao instituicao { get; set; }
        public Administrador administrador { get; set; }

    }
}
