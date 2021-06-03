using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class DenunciaTemp
    {
        public String idDenuncia { get; set; }
        public UsuarioPcd usuarioPcd { get; set; }
        public Administrador administrador { get; set; }
        public String descricao { get; set; }
        public String data { get; set; }
        public String aberto { get; set; }
    }
}
