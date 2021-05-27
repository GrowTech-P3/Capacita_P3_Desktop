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
using System.Text.RegularExpressions;

namespace CapacitaDesk {
    public partial class NovoUsuarioPcd : Form {
       
        Usuario admin = new Usuario();
        
        public void estadoComboBox() {

            String rota = "http://localhost:3000/estados";

            Object objResponse = ConnectionAPI.getLista(rota, admin.Token);
            

            List<Estado> estados = JsonConvert.DeserializeObject<List<Estado>>(objResponse.ToString());


            for (int i = 0; i < estados.Count; i++)
            {
                comboBoxEstado.Items.Add(estados[i].label);
            }
        }
        public NovoUsuarioPcd(Usuario adminUser) {
            InitializeComponent();
            this.admin = adminUser;
            estadoComboBox();
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
            ValidateUsuarioPcd validar = new ValidateUsuarioPcd();
            usuarioPcd.deficiencias = new String[5];

            String rota = "http://localhost:3000/usuarioPcd";

            usuarioPcd.id_estado = Convert.ToString(comboBoxEstado.SelectedIndex + 1);
            usuarioPcd.cidade = textBoxCidade.Text;
            usuarioPcd.email = TxtBoxEmailUsuario.Text;
            usuarioPcd.password = TxtBoxSenhaUsuario.Text;
            usuarioPcd.cpf = maskedTextBoxCPF.Text;
            usuarioPcd.bairro = TxtBoxBairroUsuario.Text;
            usuarioPcd.cep = maskedTextBoxCep.Text;
            usuarioPcd.endereco = TxtBoxEnderecoUsuario.Text;
            usuarioPcd.numero = TxtBoxNumUsuario.Text;
            usuarioPcd.telefone = maskedTextBoxTelefone.Text;
            usuarioPcd.nome = TxtBoxNomeUsuario.Text;
            usuarioPcd.deficiencias[0] = checkBoxAuditivo.Checked ? "1" : "0";
            usuarioPcd.deficiencias[1] = checkBoxFisico.Checked ? "2" : "0";
            usuarioPcd.deficiencias[2] = checkBoxMental.Checked ? "3" : "0";
            usuarioPcd.deficiencias[3] = checkBoxMudez.Checked ? "4" : "0";
            usuarioPcd.deficiencias[4] = checkBoxVisual.Checked ? "5" : "0";


            String validate = validar.validateUsuarioPCD(usuarioPcd);
            if (validate.Trim().Equals("ok"))
            {
                String json = JsonConvert.SerializeObject(usuarioPcd);
                Object objResponse = ConnectionAPI.post(rota, json, admin.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
            }
            else { 
                MessageBox.Show(validate);
            }



            DialogResult Resp = MessageBox.Show("Deseja cadastrar outro usuário?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resp == DialogResult.No) {

                this.Dispose();
            }
        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtBoxEmailUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxSenhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void TxtBoxNumUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void TxtBoxSenhaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != 32)) {
                e.Handled = true;
            }
        }
    }
}
