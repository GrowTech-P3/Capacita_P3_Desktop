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
    public partial class DetalheDoCurso : Form {
        Curso curso = null;
        AdminLogado administrador = null;
        public DetalheDoCurso(AdminLogado administrador, Curso curso) {
            this.curso = curso;
            this.administrador = administrador;

            InitializeComponent();

            TxtBoxNomeInstituicao.Text = curso.instituicao.nome;
            TxtBoxValor.Text = curso.valor;
            TxtBoxNomeCurso.Text = curso.nome_curso;
            TxtBoxCargaHoraria.Text = curso.carga_horaria;
            TxtBoxDuracao.Text = curso.duracao;
            TxtBoxHoraio.Text = curso.horario;
            TxtBoxTipoDeficiencia.Text = curso.tipo_deficiencium.nome;
            TxtBoxDescricao.Text = curso.descricao;
            TxtBoxResumo.Text = curso.resumo;   
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void BtnAceitarCurso_Click(object sender, EventArgs e)
        {
            String rota = "http://localhost:3000/curso-liberacao";
            String json = JsonConvert.SerializeObject(curso);

            Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
            RespUsuario respCurso = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            MessageBox.Show(respCurso.message);
            if (respCurso.message.Trim().Equals("Curso autorizado com sucesso!"))
            {
                String rotaLog = "http://localhost:3000/log";
                LogAdministrador logAdministrador = new LogAdministrador();
                logAdministrador.logAtividade = "Autorizando Curso";
                logAdministrador.administrador.idAdministrador = administrador.id;
                String jsonLog = JsonConvert.SerializeObject(logAdministrador);
                ConnectionAPI.post(rotaLog, jsonLog, administrador.Token);
            }
            Dispose();
            ListaDeCurso listaDeCurso = new ListaDeCurso(administrador);
            listaDeCurso.ShowDialog();
        }

        private void BtnRecusarCurso_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
