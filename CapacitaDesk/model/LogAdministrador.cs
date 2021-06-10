using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class LogAdministrador
    {
        public String idLog { get; set; }
        public Administrador administrador { get; set; }
        public String logAtividade  { get; set; }
        public String dataHora  { get; set; }
    }
}
