using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapacitaDesk.model;
using System.IO;
using CapacitaDesk.controller;
using CapacitaDesk.model;
using Newtonsoft.Json;

namespace CapacitaDesk {
    public partial class PostarNoticia : Form {
        AdminLogado administrador = new AdminLogado();
        private Noticia noticia;

        public PostarNoticia(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
        }

        public PostarNoticia(AdminLogado admin, Noticia noticia) : this(admin)
        {
            this.noticia = noticia;
            TxtBoxEscreverNoticia.Text = noticia.txt_noticia;
            TxtBoxTitulo.Text = noticia.titulo_noticia;
            textBox1.Text = noticia.descricao;
        }

        public void limparCampos() {
            TxtBoxTitulo.Clear();
            textBox1.Clear();
            txtBoxImagem.Clear();
            TxtBoxEscreverNoticia.Clear();
        }


        private void BtnPostar_Click(object sender, EventArgs e) {
            Noticia noticia = new Noticia();
            ValidateNoticia validar = new ValidateNoticia();
            String rota = "http://localhost:3000/noticia";

            noticia.id_usuario      = administrador.id;
            noticia.titulo_noticia  = TxtBoxTitulo.Text;
            noticia.descricao       = textBox1.Text;
            noticia.img_publicacao  = txtBoxImagem.Text;
            noticia.txt_noticia     = TxtBoxEscreverNoticia.Text;

            String validate = validar.validateNoticia(noticia);
            if (validate.Trim().Equals("ok")) {
                String json = JsonConvert.SerializeObject(noticia);
                Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
               
                Dispose();
                GerenciarNoticia Gnoticia = new GerenciarNoticia(administrador);
                Gnoticia.ShowDialog();

            }
            else {
                MessageBox.Show(validate);
            }
        }

        private void btnAddFoto_Click(object sender, EventArgs e) {
            
            string origemDaImagem = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {

                origemDaImagem = openFileDialog1.SafeFileName;
                txtBoxImagem.Text = origemDaImagem;
            }
                
        }
    }
}
