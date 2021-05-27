using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapacitaDesk.model;
namespace CapacitaDesk.controller
{
    class ValidateInstituicao
    {
        public String validateInstituicao(Instituicao instituicao)
        {
            String message = "ok";
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (instituicao.nome == null || instituicao.nome.Trim().Equals(""))
            {
                return message = "Informe o nome";
            }
            if (instituicao.id_estado.Trim().Equals("0") || instituicao.id_estado == null)
            {
                return message = "Informe o estado";
            }

            if (instituicao.cnpj == null || instituicao.cnpj.Trim().Equals(",   ,   /    -"))
            {
                return message = "Informe o valor do CNPJ";
            }
            if (instituicao.cnpj.Length != 18)
            {
                return message = "CNPJ Incompleto";
            }

            if (instituicao.telefone == null || instituicao.telefone.Trim().Equals("(  )      -"))
            {
                return message = "Informe o núnero de telefone";
            }
            if (instituicao.telefone.Length != 15)
            {
                return message = "Telefone Incompleto";
            }

            if (instituicao.cep == null || instituicao.cep.Trim().Equals(",   -"))
            {
                return message = "Informe o CEP";
            }
            if(instituicao.cep.Length != 10)
            {
                return message = "CEP Incompleto!";
            }
            if (instituicao.cidade == null || instituicao.cidade.Trim().Equals(""))
            {
                return message = "Informe a Cidade";
            }
            if (instituicao.endereco == null || instituicao.endereco.Trim().Equals(""))
            {
                return message = "Informe o endereço";
            }
            if (instituicao.numero == null || instituicao.numero.Trim().Equals(""))
            {
                return message = "Informe o numero";
            }
            if (instituicao.bairro == null || instituicao.bairro.Trim().Equals(""))
            {
                return message = "Informe o Bairro";
            }
            if (instituicao.email == null || instituicao.email.Trim().Equals(""))
            {
                return message = "Informe o Email";
            }
            if (!rg.IsMatch(instituicao.email))
            {
                return message = "formato de Email inválido!";
            }
            if (instituicao.password == null || instituicao.password.Trim().Equals(""))
            {
                return message = "Informe a senha";
            }
            return message;
        }
    
    }
}
