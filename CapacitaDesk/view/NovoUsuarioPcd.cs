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
    public partial class NovoUsuarioPcd : Form {

        Usuario admin = new Usuario();
        public NovoUsuarioPcd(Usuario adminUser) {
            InitializeComponent();
            this.admin = adminUser;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void PanelUsuario_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            
            
        }
       
        private void NovoUsuarioPcd_Load(object sender, EventArgs e) {

        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e) {
            UsuarioPcd usuarioPcd = new UsuarioPcd();
            usuarioPcd.deficiencias = new String[5];

            String rota = "http://localhost:3000/usuarioPcd";

            usuarioPcd.id_estado = "1" ;
            usuarioPcd.cidade = "Testando";
            usuarioPcd.email = TxtBoxEmailUsuario.Text;
            usuarioPcd.password = TxtBoxSenhaUsuario.Text;
            usuarioPcd.cpf = TxtBoxCpfUsuario.Text;
            usuarioPcd.bairro = TxtBoxBairroUsuario.Text;
            usuarioPcd.cep = TxtBoxCepUsuario.Text;
            usuarioPcd.endereco = TxtBoxEnderecoUsuario.Text;
            usuarioPcd.numero = TxtBoxNumUsuario.Text;
            usuarioPcd.telefone = TxtBoxTelefoneUsuario.Text;
            usuarioPcd.nome = TxtBoxNomeUsuario.Text;
            usuarioPcd.deficiencias[0] = checkBoxAuditivo.Checked ? "1" : "0";
            usuarioPcd.deficiencias[1] = checkBoxFisico.Checked ? "2" : "0";
            usuarioPcd.deficiencias[2] = checkBoxMental.Checked ? "3" : "0";
            usuarioPcd.deficiencias[3] = checkBoxMudez.Checked ? "4" : "0";
            usuarioPcd.deficiencias[4] = checkBoxVisual.Checked ? "5" : "0";

            String json = JsonConvert.SerializeObject(usuarioPcd);
            Object objResponse = ConnectionAPI.post(rota, json,admin.Token);

            RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            MessageBox.Show(respUsuario.message);

            DialogResult Resp = MessageBox.Show("Deseja cadastrar outro usuário?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resp == DialogResult.No) {

                this.Dispose();
            }
        }
    }
}
