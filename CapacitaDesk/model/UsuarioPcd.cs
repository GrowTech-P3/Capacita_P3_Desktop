using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitaDesk.model
{
    public class UsuarioPcd
    {
        public UsuarioPcd() {
            this.usuario = new Usuario();
        }
        public String idUsuarioPcd { get; set; }
        public Usuario usuario {get;set;}
        public String email { get; set; }
        public String password { get; set; }
        public String nome { get; set; }
        public String telefone { get; set; }
        public String endereco { get; set; }
        public String numero { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String id_estado { get; set; }
        public String cep { get; set; }
        public String cpf { get; set; }
        public String ativo { get; set; }
        public String[] deficiencias { get; set; } 
        public List<String> deficiencia { get; set; }
    }
}
