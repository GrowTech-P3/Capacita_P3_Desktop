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
        public void limparCampos()
        {
            TxtBoxEmailUsuario.Clear();
            TxtBoxNomeUsuario.Clear();
            TxtBoxSenhaUsuario.Clear();
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
            ValidadeAdministrador validate = new ValidadeAdministrador();


            Administrador administrador = new Administrador();
            administrador.email = TxtBoxEmailUsuario.Text;
            administrador.nome = TxtBoxNomeUsuario.Text;
            administrador.password = TxtBoxSenhaUsuario.Text;
            String validar = validate.validateAdministrador(administrador);
            if (validar.Trim().Equals("ok")) { 
                String rota = "http://localhost:3000/administrador";
                String json = JsonConvert.SerializeObject(administrador);
                Object objResponse = ConnectionAPI.post(rota, json, this.administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
                limparCampos();
            } 
            else
            {
                MessageBox.Show(validar);
            }
            
        }

        private void TxtBoxSenhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxSenhaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != 32)) {
                e.Handled = true;
            }
        }
    }
}
