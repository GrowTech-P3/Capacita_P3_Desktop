using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class Curso
    {
        public String id { get; set; }
        public Instituicao instituicao { get; set; }
        public String nome_curso { get; set; }
        public TipoDeficiencia tipo_deficiencium { get; set; }
        public String duracao { get; set; }
        public String cargaHoraria { get; set; }
        public String valor { get; set; }
        public String ativo { get; set; }
        public String resumoDescricao { get; set; }
        public String descricao { get; set; }
        public String imgUrlCurso { get; set; }
        public String createdAt { get; set; }
    }
}
