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
using CapacitaDesk.controller;
using Newtonsoft.Json;

namespace CapacitaDesk {
    public partial class NovaInstituicao : Form {
        AdminLogado adminstrador = new AdminLogado();

        public void encherEstado() {
            String rota = "http://localhost:3000/estados";

            Object objResponse = ConnectionAPI.getLista(rota, adminstrador.Token);

            List<Estado> estados = JsonConvert.DeserializeObject<List<Estado>>(objResponse.ToString());

            for (int i = 0; i < estados.Count; i++)
            {
                comboBoxEstado.Items.Add(estados[i].label);
            }
        }
        
        public void limparCampos()
        {
            TxtBoxNomeUsuario.Clear();
            maskedTextBoxTelefone.Clear();
            TxtBoxBairroUsuario.Clear();
            maskedTextBoxCep.Clear();
            textBoxCidade.Clear();
            maskedTextBoxCnpj.Clear();
            TxtBoxEnderecoUsuario.Clear();
            comboBoxEstado.SelectedIndex = -1;
            textBoxNumero.Clear();
            textBoxDescricao.Clear();
            TxtBoxEmailUsuario.Clear();
            textBoxPassword.Clear();
        }
        
        public NovaInstituicao(AdminLogado admin) {
            InitializeComponent();
            this.adminstrador = admin;
            encherEstado();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label9_Click(object sender, EventArgs e) {

        }

        private void PictureBoxHome_Click(object sender, EventArgs e) {
            this.Dispose();
            Dashboard home = new Dashboard();
            home.ShowDialog();
        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e) {
            Instituicao instituicao = new Instituicao();
            String rota = "http://localhost:3000/instituicao";
            ValidateInstituicao validar = new ValidateInstituicao();
            instituicao.nome = TxtBoxNomeUsuario.Text;
            instituicao.telefone = maskedTextBoxTelefone.Text;
            instituicao.bairro = TxtBoxBairroUsuario.Text;
            instituicao.cep = maskedTextBoxCep.Text;
            instituicao.cidade = textBoxCidade.Text;
            instituicao.cnpj = maskedTextBoxCnpj.Text;
            instituicao.endereco = TxtBoxEnderecoUsuario.Text;
            instituicao.id_estado = Convert.ToString(comboBoxEstado.SelectedIndex + 1);
            instituicao.numero = textBoxNumero.Text;
            instituicao.descricao = textBoxDescricao.Text;
            instituicao.email = TxtBoxEmailUsuario.Text;
            instituicao.password = textBoxPassword.Text;
            String validate = validar.validateInstituicao(instituicao);
            if (validate.Trim().Equals("ok"))
            {
                String json = JsonConvert.SerializeObject(instituicao);
                Object objResponse = ConnectionAPI.post(rota, json, this.adminstrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
                MessageBox.Show(respUsuario.message);
                limparCampos();
            }
            else
            {
                MessageBox.Show(validate);
            }
            
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar != 32)) {
                e.Handled = true;
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08) {
                e.Handled = true;
            }
        }

        private void maskedTextBoxCnpj_Click(object sender, EventArgs e)
        {
            maskedTextBoxCnpj.SelectionStart = 0;
        }

        private void maskedTextBoxTelefone_Click(object sender, EventArgs e)
        {
            maskedTextBoxTelefone.SelectionStart = 1;
        }

        private void maskedTextBoxCep_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.SelectionStart = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAtivoInst_Click(object sender, EventArgs e)
        {
            checkBoxAtivoInst.Checked = true;
            checkBoxInativoInst.Checked = false;
        }

        private void checkBoxInativoInst_Click(object sender, EventArgs e)
        {
            checkBoxAtivoInst.Checked = false;
            checkBoxInativoInst.Checked = true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Instituicao inst = new Instituicao();

            //inst.cnpj = maskedTextBoxCnpj.Text;

            //String rota = "http://localhost:3000/busca-instituicao";

            //String json = JsonConvert.SerializeObject(inst);
            //Object objResponse = ConnectionAPI.post(rota, json, adminstrador.Token);
            //RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            //MessageBox.Show(respUsuario.message);

        }
    }
}
