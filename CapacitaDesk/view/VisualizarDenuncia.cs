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
            TxtBoxEmail.Text = denunciaCurso.usuario_pcd.email;
            TxtBoxData.Text = Convert.ToDateTime(denunciaCurso.data).ToString("dd/MM/yy");
            TxtBoxNomeCursoDenuncia.Text = denunciaCurso.cursos[0].nome_curso;
            TxtBoxDescricaoDenuncia.Text = denunciaCurso.descricao;
        }
    }
}
