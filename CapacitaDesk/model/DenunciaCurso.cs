using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class DenunciaCurso
    {
        public string id { get; set; }
        public string descricao { get; set; }
        public string data { get; set; }
        public string aberto { get; set; }
        //public Curso cursos { get; set; }
        public UsuarioPcd usuario_pcd { get; set; }

    }
}
