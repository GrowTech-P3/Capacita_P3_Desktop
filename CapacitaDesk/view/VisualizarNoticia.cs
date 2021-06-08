using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapacitaDesk.controller;
using CapacitaDesk.model;
using Newtonsoft.Json;

namespace CapacitaDesk {
    public partial class VisualizarNoticia : Form {

        Noticia noticia = null;
        AdminLogado administrador = null;
        public VisualizarNoticia(AdminLogado administrador, Noticia noticia) {
            this.noticia = noticia;
            this.administrador = administrador;

            InitializeComponent();

            TxtBoxNomeUsuario.Text = (noticia.usuario.tipo.Equals("1")) ? noticia.usuario.instituicao.nome : noticia.usuario.administrador.nome;
            TxtBoxData.Text = Convert.ToDateTime(noticia.data_publicacao).ToString("dd/MM/yy");
            TxtBoxEmail.Text = noticia.usuario.email;
            TxtBoxTipoUsuario.Text = (noticia.usuario.tipo.Equals("1")) ? "Instituição" : "Administrador";
            TxtBoxDescricaoNoticia.Text = noticia.descricao;
            TxtBoxTitulo.Text = noticia.titulo_noticia;
            TxtBoxEscreverNoticia.Text = noticia.txt_noticia;
          
        }
    }
}
