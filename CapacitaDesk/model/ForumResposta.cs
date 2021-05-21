using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class ForumResposta
    {
        public String idResposta { get; set; }
        public String resposta { get; set; }
        public ForumTopico forumTopico { get; set; }
        public Usuario usuario { get; set; }
        public String ativo { get; set; }
    }
}
