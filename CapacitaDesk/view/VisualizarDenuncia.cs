using CapacitaDesk.controller;
using CapacitaDesk.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacitaDesk {
    public partial class VisualizarDenuncia : Form {
        DenunciaCurso denunciaCurso = null;
        AdminLogado  administrador = null;       
        public VisualizarDenuncia(AdminLogado administrador, DenunciaCurso denunciaCurso) {
            this.denunciaCurso = denunciaCurso;
            this.administrador = administrador;

            InitializeComponent();

            TxtBoxNomeUsuario.Text = denunciaCurso.usuario_pcd.nome;
            TxtBoxNomeDaInstituicao.Text = denunciaCurso.cursos[0].instituicao.nome;
            TxtBoxEmail.Text = denunciaCurso.usuario_pcd.usuario.email;
            TxtBoxData.Text = Convert.ToDateTime(denunciaCurso.data).ToString("dd/MM/yy");
            TxtBoxNomeCursoDenuncia.Text = denunciaCurso.cursos[0].nome_curso;
            TxtBoxDescricaoDenuncia.Text = denunciaCurso.descricao;
        }

        private void BtnEncerrarDenuncia_Click(object sender, EventArgs e) {
            
            String rota = "http://localhost:3000/denunciaCurso-fechar";
            String json = JsonConvert.SerializeObject(denunciaCurso);

            Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
            RespUsuario respDenunciaCurso = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            MessageBox.Show(respDenunciaCurso.message);

            Dispose();
            GerencDenuncia regGerenciarDenuncia = new GerencDenuncia(administrador);
            regGerenciarDenuncia.ShowDialog();
        }

        private void BtnAvaliarDenuncia_Click(object sender, EventArgs e) {
            Dispose();
            GerencDenuncia regGerenciarDenuncia = new GerencDenuncia(administrador);
            regGerenciarDenuncia.ShowDialog();
        }

        private void BtnSuspenderCurso_Click(object sender, EventArgs e) {
           
            String rota = "http://localhost:3000/denunciaCurso-curso-inativo";
            String json = JsonConvert.SerializeObject(denunciaCurso);

            Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
            RespUsuario respDenunciaCurso = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            MessageBox.Show(respDenunciaCurso.message);

            Dispose();
            GerencDenuncia regGerenciarDenuncia = new GerencDenuncia(administrador);
            regGerenciarDenuncia.ShowDialog();
        }
    }
}
