using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapacitaDesk.model;
namespace CapacitaDesk.controller
{
    class ValidadeAdministrador
    {
        public String validateAdministrador(Administrador administrador)
        {
           String message = "ok";
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (administrador.nome == null || administrador.nome.Trim().Equals(""))
            {
                return message = "Informe o nome";
            }
            if (administrador.email == null || administrador.email.Trim().Equals(""))
            {
                return message = "Informe o email";
            }
            if (!rg.IsMatch(administrador.email))
            {
                return message = "Formato de Email inválido!";
            }
            if (administrador.password == null || administrador.password.Trim().Equals(""))
            {
                return message = "Informe a senha";
            }








            return message;
        }
    }
}
