using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    class Instituicao
    {
        public String idInstituicao { get; set; }
        public Usuario usuario { get; set; }

        public String nome { get; set; }

        public String telefone { get; set; }
        public String endereco { get; set; }
        public String numero { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }
        public String cep { get; set; }
        public String cnpj { get; set; }
        public String ativo { get; set; }
    }
}
