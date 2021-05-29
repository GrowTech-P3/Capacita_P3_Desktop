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

            AdminLogado admin = new AdminLogado();
            admin.email = TxtUsuario.Text;
            admin.senha = TxtSenha.Text;

            String json = JsonConvert.SerializeObject(admin);
            Object objResponse = ConnectionAPI.login(rota, json);
            RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());


            if (respUsuario.administrador != null && respUsuario.administrador.ativo.Trim().Equals("true"))
            {
                MessageBox.Show("Login efetuado com sucesso!");
                this.Hide();
                Dashboard home = new Dashboard(respUsuario.administrador);
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
