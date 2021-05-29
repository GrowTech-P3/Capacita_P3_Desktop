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
        public void limparCampos()
        {
            textBoxCidade.Clear();
            TxtBoxEmailUsuario.Clear();
            TxtBoxSenhaUsuario.Clear();
            maskedTextBoxCPF.Clear();
            TxtBoxBairroUsuario.Clear();
            maskedTextBoxCep.Clear();
            TxtBoxEnderecoUsuario.Clear();
            TxtBoxNumUsuario.Clear();
            maskedTextBoxTelefone.Clear();
            TxtBoxNomeUsuario.Clear();
            comboBoxEstado.SelectedIndex = -1;
            checkBoxAuditivo.Checked = false;
            checkBoxFisico.Checked = false;
            checkBoxMental.Checked = false;
            checkBoxMudez.Checked = false;
            checkBoxVisual.Checked = false;
            checkBoxAtivoUser.Checked = false;
            checkBoxInativoUser.Checked = false;
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
            String rota = "http://localhost:3000/usuarioPcd";
            usuarioPcd.deficiencias = new String[5];    
      
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
                limparCampos();
            }
            else { 
                MessageBox.Show(validate);
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

        private void maskedTextBoxCPF_Click(object sender, EventArgs e)
        {
            maskedTextBoxCPF.SelectionStart = 0;
        }

        private void maskedTextBoxTelefone_Click(object sender, EventArgs e)
        {
            maskedTextBoxTelefone.SelectionStart = 1;
        }

        private void maskedTextBoxCep_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.SelectionStart = 0;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            UsuarioPcd usuarioPcd = new UsuarioPcd();
            String rota = "http://localhost:3000/buscar-usuariopcd";
            RespUsuario respUsuario = new RespUsuario();
            

            usuarioPcd.cpf = maskedTextBoxCPF.Text;
            if (usuarioPcd.cpf != null && !(usuarioPcd.cpf.Trim().Equals("")) && usuarioPcd.cpf.Trim().Length == 14)
            {

                String json = JsonConvert.SerializeObject(usuarioPcd);
                Object objResponse = ConnectionAPI.post(rota, json, admin.Token);
                respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
                if (!(respUsuario.message.Trim().Equals("Usuário PCD não encontrado!"))) { 
                TxtBoxNomeUsuario.Text = respUsuario.usuarioPCD.nome;
                maskedTextBoxCPF.Text = respUsuario.usuarioPCD.cpf;
                maskedTextBoxTelefone.Text = respUsuario.usuarioPCD.telefone;
                comboBoxEstado.SelectedIndex = Convert.ToInt32(respUsuario.usuarioPCD.id_estado) - 1;
                maskedTextBoxCep.Text = respUsuario.usuarioPCD.cep;
                TxtBoxBairroUsuario.Text = respUsuario.usuarioPCD.bairro;
                TxtBoxEnderecoUsuario.Text = respUsuario.usuarioPCD.endereco;
                textBoxCidade.Text = respUsuario.usuarioPCD.cidade;
                TxtBoxNumUsuario.Text = respUsuario.usuarioPCD.numero;
                TxtBoxEmailUsuario.Text = respUsuario.usuario.email;
                if (respUsuario.usuario.ativo.Trim().Equals("true"))
                {
                    checkBoxAtivoUser.Checked = true;
                    checkBoxInativoUser.Checked = false;
                }
                else {
                    checkBoxAtivoUser.Checked = false;
                    checkBoxInativoUser.Checked = true;
                }
                for (int i = 0; i < respUsuario.usuarioPCD.deficiencia.Count ; i++)
                {
                    if (respUsuario.usuarioPCD.deficiencia[i].Trim().Equals("1"))
                    {
                        checkBoxAuditivo.Checked = true;
                    }
                    else if (respUsuario.usuarioPCD.deficiencia[i].Trim().Equals("2"))
                    {
                        checkBoxFisico.Checked = true;
                    }
                    else if (respUsuario.usuarioPCD.deficiencia[i].Trim().Equals("3"))
                    {
                        checkBoxMental.Checked = true; 
                    }
                    else if (respUsuario.usuarioPCD.deficiencia[i].Trim().Equals("4"))
                    {
                        checkBoxMudez.Checked = true;
                    }
                    else if (respUsuario.usuarioPCD.deficiencia[i].Trim().Equals("5")) { 
                        checkBoxVisual.Checked = true;
                    }
                }
                }
            }
            else {
                MessageBox.Show("Informe o CPF para buscar usuário");
            }

        }

        private void checkBoxAtivoUser_Click(object sender, EventArgs e)
        {
            checkBoxAtivoUser.Checked = true;
            checkBoxInativoUser.Checked = false;
        }

        private void checkBoxInativoUser_Click(object sender, EventArgs e)
        {
            checkBoxAtivoUser.Checked = false;
            checkBoxInativoUser.Checked = true;
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            String rota = "http://localhost:3000/usuariopcd";
            UsuarioPcd usuarioPcd = new UsuarioPcd();

            usuarioPcd.cpf = maskedTextBoxCPF.Text;

            if (usuarioPcd.cpf != null && usuarioPcd.cpf.Length == 14)
            {

                String json = JsonConvert.SerializeObject(usuarioPcd);
                Object objResponse = ConnectionAPI.remove(rota, json, admin.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

                MessageBox.Show(respUsuario.message);
                limparCampos();
            }
            else {
                MessageBox.Show("Informe ao menos o CPF para remover");
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            UsuarioPcd usuarioPcd = new UsuarioPcd();
            ValidateUsuarioPcd validar = new ValidateUsuarioPcd();

            String rota = "http://localhost:3000/usuariopcd/update";

            usuarioPcd.id_estado = Convert.ToString(comboBoxEstado.SelectedIndex + 1);
            usuarioPcd.cidade = textBoxCidade.Text;
            usuarioPcd.email = TxtBoxEmailUsuario.Text;
            usuarioPcd.cpf = maskedTextBoxCPF.Text;
            usuarioPcd.bairro = TxtBoxBairroUsuario.Text;
            usuarioPcd.cep = maskedTextBoxCep.Text;
            usuarioPcd.endereco = TxtBoxEnderecoUsuario.Text;
            usuarioPcd.numero = TxtBoxNumUsuario.Text;
            usuarioPcd.telefone = maskedTextBoxTelefone.Text;
            usuarioPcd.nome = TxtBoxNomeUsuario.Text;
            if (checkBoxAtivoUser.Checked == true)
            {
                usuarioPcd.ativo = "true";
            }
            else {
                usuarioPcd.ativo = "false";
            }
            String validate = validar.validateUsuarioPCD(usuarioPcd);
            if (validate.Trim().Equals("ok")  || validate.Trim().Equals("Informe a senha"))
            {
                String json = JsonConvert.SerializeObject(usuarioPcd);
                Object objResponse = ConnectionAPI.post(rota, json, admin.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
                limparCampos();
            }
            else
            {
                MessageBox.Show(validate);
            }
        }
    }
}
