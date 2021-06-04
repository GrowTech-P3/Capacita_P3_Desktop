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
    public partial class GerencDenuncia : Form {
        

        AdminLogado administrador = new AdminLogado();
        public GerencDenuncia(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            carregarTabela();
            
        }

        private void label4_Click(object sender, EventArgs e) {

        }
       
        public void carregarTabela() {
            List<DenunciaCurso> denunciaCursos;
            String rota = "http://localhost:3000/denunciaCurso-aberta";

            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            denunciaCursos = JsonConvert.DeserializeObject<List<DenunciaCurso>>(objectResponse.ToString());

            ListViewDenuncia.Items.Clear();

            foreach (DenunciaCurso denunciaCurso in denunciaCursos) {
                ListViewItem item = ListViewDenuncia.Items.Add(denunciaCurso.id);
                item.SubItems.Add(denunciaCurso.usuario_pcd.nome);
                item.SubItems.Add(denunciaCurso.cursos[0].nome_curso);
                item.SubItems.Add(denunciaCurso.cursos[0].instituicao.nome);
                item.SubItems.Add(Convert.ToDateTime(denunciaCurso.data).ToString("dd/MM/yy"));
                
            }
        
        }
        public void carregarPesquisaDenuncia(PesquisaDenuncia pesquisa) {

            List<DenunciaCurso> denunciaCursos;

            String rota = "http://localhost:3000/denunciaCurso-pesquisa";
            String json = JsonConvert.SerializeObject(pesquisa);

            Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
            denunciaCursos = JsonConvert.DeserializeObject<List<DenunciaCurso>>(objectResponse.ToString());

            ListViewDenuncia.Items.Clear();

            foreach (DenunciaCurso denunciaCurso in denunciaCursos) {
                ListViewItem item = ListViewDenuncia.Items.Add(denunciaCurso.id);
                item.SubItems.Add(denunciaCurso.usuario_pcd.nome);
                item.SubItems.Add(denunciaCurso.cursos[0].nome_curso);
                item.SubItems.Add(denunciaCurso.cursos[0].instituicao.nome);
                item.SubItems.Add(Convert.ToDateTime(denunciaCurso.data).ToString("dd/MM/yy"));

            }
        }

        private void BtnBuscarDenuncia_Click(object sender, EventArgs e) {

            carregarPesquisaDenuncia(new PesquisaDenuncia() {
                nome_instituicao = TxtBoxNomeInstituicao.Text,
                nome_curso = TxtBoxNomeCurso.Text,
                //NECESSARIO ADICIONAR -1 DIA E +1 DIA NAS DATAS PARA PROCURAR ENTRE AS DATAS
                dataInicial = Convert.ToDateTime(dateTimePickerInicial.Text).ToString("yyyy-MM-dd"),
                dataFinal = Convert.ToDateTime(dateTimePickerFinal.Text).AddDays(1).ToString("yyyy-MM-dd")
            });

        }
        private void exibirDetalhesDenuncia() {
            
            if (ListViewDenuncia.SelectedItems.Count > 0) {


                DenunciaCurso denunciaCurso = new DenunciaCurso();
                denunciaCurso.id = ListViewDenuncia.SelectedItems[0].SubItems[0].Text;

                String rota = "http://localhost:3000/denunciaCurso-busca";
                String json = JsonConvert.SerializeObject(denunciaCurso);

                Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objectResponse.ToString());

                this.Dispose();
                VisualizarDenuncia dDenuncia = new VisualizarDenuncia(administrador, respUsuario.denunciaCurso);
                dDenuncia.ShowDialog();
            }
        }
        private void BtnExibirDenuncia_Click(object sender, EventArgs e) {
            exibirDetalhesDenuncia();
        }
    }
}
