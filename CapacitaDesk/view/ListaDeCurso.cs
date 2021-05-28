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
        public void carregarTabelaCursoPesquisa()
        {
            List<Curso> cursosResultado;

            Curso cursoPesquisa = new Curso();
            Instituicao instPesquisa = new Instituicao();
            TipoDeficiencia deficienciaPesquisa = new TipoDeficiencia();
            Usuario usuarioPesquisa = new Usuario();

            deficienciaPesquisa.nome += checkBoxAuditivo.Checked    ? " auditivo"    : "";
            deficienciaPesquisa.nome += checkBoxFisico.Checked      ? " fisico"      : "";
            deficienciaPesquisa.nome += checkBoxMental.Checked      ? " mental"      : "";
            deficienciaPesquisa.nome += checkBoxMudez.Checked       ? " mudez"       : "";
            deficienciaPesquisa.nome += checkBoxVisual.Checked      ? " visual"      : "";
            deficienciaPesquisa.nome = deficienciaPesquisa.nome.Trim();
            cursoPesquisa.nome_curso = TxtBoxNomeDoCurso.Text;
            instPesquisa.nome = TxtBoxNomeDaInstitucao.Text;

            cursoPesquisa.instituicao = instPesquisa;
            cursoPesquisa.tipo_deficiencium = deficienciaPesquisa;
            cursoPesquisa.instituicao.usuario = usuarioPesquisa;

            String rota = "http://localhost:3000/curso-inst-pesquisa-inativo";
            String json = JsonConvert.SerializeObject(cursoPesquisa);

            Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
            cursosResultado = JsonConvert.DeserializeObject<List<Curso>>(objectResponse.ToString());

            ListViewCurso.Items.Clear();

            foreach (Curso curso in cursosResultado)
            {
                ListViewItem item = ListViewCurso.Items.Add(curso.id);
                item.SubItems.Add(curso.instituicao.nome);
                item.SubItems.Add(curso.nome_curso);
                item.SubItems.Add(curso.tipo_deficiencium.nome);
            }
        }

        private void exibirDetalhesCursos()
        {
            // VERIFICA SE UMA LINHA FOI SELECIONADA
            if (ListViewCurso.SelectedItems.Count > 0)
            {


                Curso curso = new Curso();
                curso.id = ListViewCurso.SelectedItems[0].SubItems[0].Text;

                String rota = "http://localhost:3000/buscar-curso";
                String json = JsonConvert.SerializeObject(curso);

                Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objectResponse.ToString());

                this.Dispose();
                DetalheDoCurso dCurso = new DetalheDoCurso(administrador, respUsuario.curso);
                dCurso.ShowDialog();
            }
        }

        private void BtnExibirInstituicao_Click(object sender, EventArgs e) {
            exibirDetalhesCursos();
        }

        private void BtnExibirBuscarInstituicao_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnFiltroCurso_Click(object sender, EventArgs e)
        {
            carregarTabelaCursoPesquisa();
        }

        private void checkBoxAuditivo_CheckedChanged(object sender, EventArgs e) {
            
            if (checkBoxAuditivo.Checked == true){ 
                checkBoxFisico.Checked = false;
                checkBoxMental.Checked = false;
                checkBoxMudez.Checked = false;
                checkBoxVisual.Checked = false;
            }
        }

        private void checkBoxMudez_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMudez.Checked == true){
                checkBoxFisico.Checked = false;
                checkBoxMental.Checked = false;
                checkBoxAuditivo.Checked = false;
                checkBoxVisual.Checked = false;
            }
        }

        private void checkBoxFisico_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFisico.Checked == true){
                checkBoxAuditivo.Checked = false;
                checkBoxMental.Checked = false;
                checkBoxMudez.Checked = false;
                checkBoxVisual.Checked = false;
            }
        }

        private void checkBoxMental_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMental.Checked == true){
                checkBoxFisico.Checked = false;
                checkBoxAuditivo.Checked = false;
                checkBoxMudez.Checked = false;
                checkBoxVisual.Checked = false;
            }
        }

        private void checkBoxVisual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisual.Checked == true){
                checkBoxFisico.Checked = false;
                checkBoxMental.Checked = false;
                checkBoxMudez.Checked = false;
                checkBoxAuditivo.Checked = false;
            }
        }

        private void ListViewCurso_MouseDoubleClick(object sender, MouseEventArgs e) {
            exibirDetalhesCursos();
        }
    }
}
