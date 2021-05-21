using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class RespUsuario
    {
        public String message { get; set; }
        public Usuario usuario { get; set; }
        public String token { get; set; }
    }
}
