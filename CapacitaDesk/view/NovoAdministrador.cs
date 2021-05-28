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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            
            Administrador admin = new Administrador();
            
            admin.email = TxtBoxEmailUsuario.Text;
            
            if (!(admin.email.Trim().Equals("") || admin.email == null))
            {
                String rota = "http://localhost:3000/administrador/" + admin.email;
                String json = JsonConvert.SerializeObject(admin);
                Object objResponse = ConnectionAPI.getOne(rota, json,administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                TxtBoxNomeUsuario.Text = respUsuario.admin.nome;
            }
            else 
            {
                MessageBox.Show("Informe email para Buscar");
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            String rota = "http://localhost:3000/administrador";
            Administrador admin = new Administrador();

            admin.email = TxtBoxEmailUsuario.Text;
            if (!(admin.email.Trim().Equals("") || admin.email == null))
            {
                String json = JsonConvert.SerializeObject(admin);
                Object objResponse = ConnectionAPI.remove(rota,json,administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
            }
            else
            {
                MessageBox.Show("Digite um email");
            }

        }
    }
}
