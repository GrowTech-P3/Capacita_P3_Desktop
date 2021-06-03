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

        private void BtnExibirDenuncia_Click(object sender, EventArgs e) {
            this.Close();
            VisualizarDenuncia vDenuncia = new VisualizarDenuncia();
            vDenuncia.ShowDialog();
        }
        public void carregarTabela() {
            List<DenunciaCurso> denunciaCursos;
            String rota = "http://localhost:3000/denunciaCursoAberta";

            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            denunciaCursos = JsonConvert.DeserializeObject<List<DenunciaCurso>>(objectResponse.ToString());

            ListViewInstituicao.Items.Clear();

            foreach (DenunciaCurso denunciaCurso in denunciaCursos) {
                ListViewItem item = ListViewInstituicao.Items.Add(denunciaCurso.id);
                item.SubItems.Add(denunciaCurso.usuario_pcd.nome);
                //item.SubItems.Add(denunciaCurso.cursos.nome_curso);
                //item.SubItems.Add(denunciaCurso.cursos.instituicao.nome);
                item.SubItems.Add(Convert.ToDateTime(denunciaCurso.data).ToString("dd/MM/yy"));
                
            }
        
        }
        //public void carregarPesquisaDenuncia(PesquisaDenuncia pesquisa) {
            
        //    List<DenunciaCurso> denunciaCursos;

        //    String rota = "http://localhost:3000/denunciaCursoAberta";
        //    String json = JsonConvert.SerializeObject(pesquisa);

        //    Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
        //    denunciaCursos = JsonConvert.DeserializeObject<List<DenunciaCurso>>(objectResponse.ToString());

        //    ListViewInstituicao.Items.Clear();

        //    foreach (DenunciaCurso denunciaCurso in denunciaCursos) {
        //        ListViewItem item = ListViewInstituicao.Items.Add(denunciaCurso.id);
        //        item.SubItems.Add(denunciaCurso.usuario_pcd.nome);
        //        //item.SubItems.Add(denunciaCurso.cursos.nome_curso);
        //        //item.SubItems.Add(denunciaCurso.cursos.instituicao.nome);
        //        item.SubItems.Add(Convert.ToDateTime(denunciaCurso.data).ToString("dd/MM/yy"));

        //    }
        //}

        private void BtnBuscarDenuncia_Click(object sender, EventArgs e) {
            
            //carregarPesquisaDenuncia(new PesquisaDenuncia() 
            //{
            //    nomeInstituicao = TxtBoxNomeInstituicao.Text,
            //    nomeCurso = TxtBoxNomeCurso.Text,
            //    //NECESSARIO ADICIONAR -1 DIA E +1 DIA NAS DATAS PARA PROCURAR ENTRE AS DATAS
            //    createdAt = Convert.ToDateTime(dateTimePickerInicial.Text).ToString("yyyy-MM-dd"),
            //    createdAt2 = Convert.ToDateTime(dateTimePickerFinal.Text).AddDays(1).ToString("yyyy-MM-dd")
            //});

        }
    }
}
