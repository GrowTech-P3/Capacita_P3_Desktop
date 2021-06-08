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
using CapacitaDesk.controller;
using CapacitaDesk.model;
using Newtonsoft.Json;

namespace CapacitaDesk {
    public partial class GerenciarNoticia : Form {

        AdminLogado administrador = new AdminLogado();
        public GerenciarNoticia(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            carregarTabela();
        }
        public void carregarTabela() {
            List<Noticia> noticias;
            String rota = "http://localhost:3000/noticia";

            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            noticias = JsonConvert.DeserializeObject<List<Noticia>>(objectResponse.ToString());

            ListViewNoticia.Items.Clear();

            foreach (Noticia noticia in noticias) {
                ListViewItem item = ListViewNoticia.Items.Add(noticia.id);
                item.SubItems.Add(Convert.ToDateTime(noticia.data_publicacao).ToString("dd/MM/yy"));
                //item.SubItems.Add(noticia.instituicao.nome);
                item.SubItems.Add(noticia.titulo_noticia);               

            }

        }
        private void exibirDetalhesNoticia() {

            if (ListViewNoticia.SelectedItems.Count > 0) {


                Noticia noticia = new Noticia();
                noticia.id = ListViewNoticia.SelectedItems[0].SubItems[0].Text;

                String rota = "http://localhost:3000/buscar-noticia";
                String json = JsonConvert.SerializeObject(noticia);

                Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objectResponse.ToString());

                this.Dispose();
                VisualizarNoticia dNoticia = new VisualizarNoticia(administrador, respUsuario.noticia);
                dNoticia.ShowDialog();
            }
        }

        private void BtnExibirNoticia_Click(object sender, EventArgs e) {
            exibirDetalhesNoticia();
        }

        private void button1_Click(object sender, EventArgs e) {
            PostarNoticia postNoticia = new PostarNoticia(administrador);
            postNoticia.ShowDialog();
        }
    }
}
