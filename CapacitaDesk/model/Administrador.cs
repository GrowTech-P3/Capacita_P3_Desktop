using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class Administrador
    {
        public String idAdministrador { get; set; } 
        public Usuario usuario { get; set; }
        public String email { get; set; }
        public String password { get; set; }

        public Boolean ativo { get; set; }
        public String nome { get; set; }
    }
}
