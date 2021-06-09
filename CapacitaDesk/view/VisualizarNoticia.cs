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

            //TxtBoxNomeUsuario.Text = (noticia.usuario.tipo.Equals("1")) ? noticia.usuario.instituicao.nome : noticia.usuario.administrador.nome;
            TxtBoxData.Text = Convert.ToDateTime(noticia.data_publicacao).ToString("dd/MM/yy");
            TxtBoxEmail.Text = noticia.usuario.email;
            TxtBoxTipoUsuario.Text = (noticia.usuario.tipo.Equals("1")) ? "Instituição" : "Administrador";
            TxtBoxDescricaoNoticia.Text = noticia.descricao;
            TxtBoxTitulo.Text = noticia.titulo_noticia;
            TxtBoxEscreverNoticia.Text = noticia.txt_noticia;
            textBoxId.Text = noticia.id;
          
        }

        public void limparCampos() {

            TxtBoxData.Clear();
            TxtBoxDescricaoNoticia.Clear();
            TxtBoxEmail.Clear();
            TxtBoxEscreverNoticia.Clear();
            TxtBoxNomeUsuario.Clear();
            TxtBoxTipoUsuario.Clear();
            TxtBoxTitulo.Clear();
        }

        private void BtnExcluirDenuncia_Click(object sender, EventArgs e) {

         
            String rota = "http://localhost:3000/noticia";
            Noticia noticia = new Noticia();

            noticia.id = textBoxId.Text;

            String json = JsonConvert.SerializeObject(noticia);
            Object objResponse = ConnectionAPI.remove(rota, json, administrador.Token);
            RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            MessageBox.Show(respUsuario.message);

            Dispose();
            GerenciarNoticia Gnoticia = new GerenciarNoticia(administrador);
            Gnoticia.ShowDialog();

        }

        private void BtnEditarDenuncia_Click(object sender, EventArgs e) {

            TxtBoxData.Enabled = true;
            TxtBoxDescricaoNoticia.Enabled = true;
            TxtBoxEmail.Enabled = true;
            TxtBoxEscreverNoticia.Enabled = true;
            TxtBoxNomeUsuario.Enabled = true;
            TxtBoxTipoUsuario.Enabled = true;
            TxtBoxTitulo.Enabled = true;

           
        }
    }
}
