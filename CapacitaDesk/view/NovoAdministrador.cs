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
using Newtonsoft.Json;
using CapacitaDesk.controller;

namespace CapacitaDesk {
    public partial class NovoAdministrador : Form {
        AdminLogado administrador = new AdminLogado();
        public NovoAdministrador(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            this.Dispose();
            Dashboard home = new Dashboard();
            home.ShowDialog();
        }

        private void NovoAdministrador_Load(object sender, EventArgs e) {

        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e) {
            Administrador administrador = new Administrador();
            administrador.email = TxtBoxEmailUsuario.Text;
            administrador.nome = TxtBoxNomeUsuario.Text;
            administrador.password = TxtBoxSenhaUsuario.Text;
            String rota = "http://localhost:3000/administrador";
            String json = JsonConvert.SerializeObject(administrador);
            Object objResponse = ConnectionAPI.post(rota,json, this.administrador.Token);
            RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
            MessageBox.Show(respUsuario.message);
            DialogResult Resp = MessageBox.Show("Deseja cadastrar outro usuário?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resp == DialogResult.No) {

                this.Dispose();
            }
        }
    }
}
