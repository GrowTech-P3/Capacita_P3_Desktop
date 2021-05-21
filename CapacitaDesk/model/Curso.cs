using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class Curso
    {
        public String idCurso { get; set; }
        public Instituicao instituicao { get; set; }
        public String nomeCurso { get; set; }
        public String deficiencias { get; set; }
        public String duracao { get; set; }
        public String cargaHoraria { get; set; }
        public String valor { get; set; }
        public String ativo { get; set; }
        public String resumoDescricao { get; set; }
        public String descricao { get; set; }
        public String imgUrlCurso { get; set; }
    }
}
