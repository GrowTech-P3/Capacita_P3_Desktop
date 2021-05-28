using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class Curso
    {
        public String id { get; set; }
        public Instituicao instituicao { get; set; }
        public String nome_curso { get; set; }
        public TipoDeficiencia tipo_deficiencium { get; set; }
        public String duracao { get; set; }
        public String carga_horaria { get; set; }
        public String horario { get; set; }
        public String valor { get; set; }
        public String ativo { get; set; }
        public String resumo { get; set; }
        public String descricao { get; set; }
        public String url_img { get; set; }
        public String createdAt { get; set; }
    }
}
