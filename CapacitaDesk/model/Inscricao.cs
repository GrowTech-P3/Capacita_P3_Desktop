using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class Inscricao
    {
        public String idIncricao { get; set; } 
        public Curso curso { get; set; } 
        public UsuarioPcd usuarioPcd { get; set; }
    }
}
