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
    public partial class login : Form {

       
        public login() {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e) {

            String rota = "http://localhost:3000/usuario-login";

            Usuario u1 = new Usuario();
            u1.email = TxtUsuario.Text;
            u1.senha = TxtSenha.Text;

            String json = JsonConvert.SerializeObject(u1);

            Object objResponse = ConnectionAPI.post(rota, json);

            RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            if (respUsuario.token != null && respUsuario.administrador != null)
            {
                MessageBox.Show("Login efetuado com sucesso!");
                this.Hide();
                Dashboard home = new Dashboard(respUsuario.usuario);
                home.Show();
            } else
            {
                MessageBox.Show("Usuário não autorizado!");
            }  
        }

        private void login_Load(object sender, EventArgs e) {

        }
    }
}
