using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class ForumTopico
    {
        public String idTopico { get; set; }
        public String titulo { get; set; } 
        public String texto { get; set; } 
        public Usuario usuario { get; set; } 
        public String ativo { get; set; }
    }
}
