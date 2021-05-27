using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapacitaDesk.model;
using Newtonsoft.Json;

namespace CapacitaDesk.controller
{
    class ValidateUsuarioPcd
    {
        public String validateUsuarioPCD(UsuarioPcd usuarioPcd){
            String message = "ok";
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (usuarioPcd.nome == null || usuarioPcd.nome.Trim().Equals(""))
            {
                return message = "Informe o nome";
            }
            if (usuarioPcd.cpf == null || usuarioPcd.cpf.Trim().Equals(",   ,   -")) {
                return message = "Informe o valor do CPF";
            }
            if (usuarioPcd.cpf.Length != 14) {
                return message = "CPF incompleto!";
            }
            if (usuarioPcd.telefone == null || usuarioPcd.telefone.Trim().Equals("(  )      -"))
            {
                return message = "Informe o núnero de telefone";
            }
            if (usuarioPcd.telefone.Length != 15) {
                return message = "Telefone incompleto!";
            }
            if (usuarioPcd.endereco == null || usuarioPcd.endereco.Trim().Equals(""))
            {
                return message = "Informe o endereço";
            }
            if (usuarioPcd.numero == null || usuarioPcd.numero.Trim().Equals(""))
            {
                return message = "Informe o numero";
            }
            if (usuarioPcd.id_estado.Trim().Equals("0") || usuarioPcd.id_estado == null)
            {
                return message = "Informe o estado";
            }
            if (usuarioPcd.cep == null || usuarioPcd.cep.Trim().Equals(",   -"))
            {
                return message = "Informe o CEP";
            }
            if (usuarioPcd.cep.Length != 10) {
                return message = "CEP incompleto!";
            }
            if (usuarioPcd.bairro == null || usuarioPcd.bairro.Trim().Equals(""))
            {
                return message = "Informe o Bairro";
            }
            if (usuarioPcd.cidade == null || usuarioPcd.cidade.Trim().Equals(""))
            {
                return message = "Informe a Cidade";
            }
            if (usuarioPcd.email == null || usuarioPcd.email.Trim().Equals(""))
            {
                return message = "Informe o Email";
            }
            
            if (!rg.IsMatch(usuarioPcd.email))
            {
                return message = "formato de Email inválido!";
            }
           
            if (usuarioPcd.password == null || usuarioPcd.password.Trim().Equals(""))
            {
                return message = "Informe a senha";
            }
            
            return message;
        }
    }
}
