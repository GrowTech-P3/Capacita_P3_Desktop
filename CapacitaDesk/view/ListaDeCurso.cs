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
    public partial class ListaDeCurso : Form {
        AdminLogado administrador = new AdminLogado();
        public ListaDeCurso(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            carregarTabela();
        }

        public void carregarTabela()
        {
            List<Curso> cursos;
            String rota = "http://localhost:3000/curso-inativo";

            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            cursos = JsonConvert.DeserializeObject<List<Curso>>(objectResponse.ToString());

            ListViewCurso.Items.Clear();

            foreach (Curso curso in cursos)
            {
                ListViewItem item = ListViewCurso.Items.Add(curso.id);
                item.SubItems.Add(curso.instituicao.nome);
                item.SubItems.Add(curso.nome_curso);
                item.SubItems.Add(curso.tipo_deficiencium.nome);
            }
        }

        // CARREGAR TABELA FILTRANDO PELO NOME DA INSTITUICAO
        public void carregarTabelaCursoInst(String nomeInstituicao)
        {
            List<Curso> cursos;
            
            Instituicao instPesquisa = new Instituicao();
            instPesquisa.nome = nomeInstituicao;

            String rota = "http://localhost:3000/curso-inst-pesquisa-inativo";
            String json = JsonConvert.SerializeObject(instPesquisa);

            Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
            cursos = JsonConvert.DeserializeObject<List<Curso>>(objectResponse.ToString());

            ListViewCurso.Items.Clear();

            foreach (Curso curso in cursos)
            {
                ListViewItem item = ListViewCurso.Items.Add(curso.id);
                item.SubItems.Add(curso.instituicao.nome);
                item.SubItems.Add(curso.nome_curso);
                item.SubItems.Add(curso.tipo_deficiencium.nome);
            }
        }

        private void BtnExibirInstituicao_Click(object sender, EventArgs e) {
            DetalheDoCurso detalheCurso = new DetalheDoCurso();
            detalheCurso.ShowDialog();
        }
        private void BtnExibirBuscarInstituicao_Click(object sender, EventArgs e)
        {
            carregarTabelaCursoInst(TxtBoxNomeDaInstitucao.Text);
        }
    }
}
