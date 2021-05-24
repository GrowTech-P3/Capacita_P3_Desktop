﻿using System;
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

            instituicao.nome = TxtBoxNomeUsuario.Text;
            instituicao.telefone = maskedTextBoxTelefone.Text;
            instituicao.bairro = TxtBoxBairroUsuario.Text;
            instituicao.cep = maskedTextBoxCep.Text;
            instituicao.cidade = textBoxCidade.Text;
            instituicao.cnpj = maskedTextBoxCnpj.Text;
            instituicao.email = TxtBoxEmailUsuario.Text;
            instituicao.endereco = TxtBoxEnderecoUsuario.Text;
            instituicao.id_estado = Convert.ToString(comboBoxEstado.SelectedIndex + 1);
            instituicao.password = textBoxPassword.Text;
            instituicao.numero = textBoxNumero.Text;
            instituicao.descricao = textBoxDescricao.Text;
            String json = JsonConvert.SerializeObject(instituicao);

            Object objResponse = ConnectionAPI.post(rota, json, this.adminstrador.Token);
            RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());
            MessageBox.Show(respUsuario.message);
            DialogResult Resp = MessageBox.Show("Deseja cadastrar uma nova instituição?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resp == DialogResult.No) {

                this.Dispose();
            }
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
