using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class Noticia
    {
        public String id { get; set; }
        public String titulo_noticia { get; set; }
        public String id_usuario { get; set; }
        public String descricao { get; set; }
        public String txt_noticia { get; set; }
        public String data_publicacao { get; set; }
        public String img_publicacao { get; set; }
        public Usuario usuario { get; set; }
    }
}
