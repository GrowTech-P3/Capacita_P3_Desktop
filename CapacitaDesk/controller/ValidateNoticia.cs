using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CapacitaDesk.model;

namespace CapacitaDesk.controller {
    class ValidateNoticia {
        public String validateNoticia(Noticia noticia) {

            String message = "ok";
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (noticia.titulo_noticia == null || noticia.titulo_noticia.Trim().Equals("")) {
                return message = "Informe o Título da notícia";

            }
            if (noticia.descricao == null || noticia.descricao.Trim().Equals("")) {
                return message = "Informe o Descrição";

            }
            if (noticia.txt_noticia == null || noticia.txt_noticia.Trim().Equals("")) {
                return message = "Informe o texto da notícia";

            }
            if (noticia.img_publicacao == null || noticia.img_publicacao.Trim().Equals("")) {
                return message = "Insira uma imagem";

            }
            return message;
            
        }   
        
    }
}
