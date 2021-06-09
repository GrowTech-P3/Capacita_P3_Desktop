using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class Financeiro
    {
        public Curso curso { get; set; }
        public UsuarioPcd usuarioPCD { get; set; }
        public Instituicao instituicao { get; set; }
        public String dataHora { get; set; }
        public String valor { get; set; }
        

    }
}
