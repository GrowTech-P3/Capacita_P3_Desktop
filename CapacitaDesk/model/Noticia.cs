using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class Noticia
    {
        public String idNoticia { get; set; }
        public String tituloNoticia { get; set; }
        public String descricao { get; set; }
        public String txtNoticia { get; set; }
        public String dataPublicacao { get; set; }
        public String imgUrlPublicacao { get; set; }
        public Instituicao instituicao { get; set; }
    }
}
