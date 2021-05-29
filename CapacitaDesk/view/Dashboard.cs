using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CapacitaDesk.model;

namespace CapacitaDesk {
    public partial class Dashboard : Form {

        AdminLogado administrador = new AdminLogado();

        String[] nome = new string[2];

        public Dashboard()
        {
            InitializeComponent();
            
        }
        public Dashboard(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            nome = administrador.email.Split("@");
            labelEmailAdmin.Text = nome[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }

        
        private void Dashboard_Load(object sender, EventArgs e) {
            
        }

        private void BtnNovoAdministrador_Click(object sender, EventArgs e) {
            NovoAdministrador home = new NovoAdministrador(administrador);
            home.ShowDialog();     
        }

        private void button3_Click(object sender, EventArgs e) {
            NovaInstituicao novaInstituicao = new NovaInstituicao(administrador);
            novaInstituicao.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            ListaDeCurso listDeCurso = new ListaDeCurso(administrador);
            listDeCurso.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) {
            RegistroDeNovoParceiro regNovoParceiro = new RegistroDeNovoParceiro(administrador);
            regNovoParceiro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {            
            NovoUsuarioPcd userPcd = new NovoUsuarioPcd(administrador);
            userPcd.ShowDialog();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e) {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e) {

            DialogResult Resp = MessageBox.Show("Deseja mesmo sair?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(Resp == DialogResult.Yes) {

                this.Close();
            }

            
        }

        private void BtnGerenciarDenuncia_Click(object sender, EventArgs e) {
            GerencDenuncia listDenunciaa = new GerencDenuncia(administrador);
            listDenunciaa.ShowDialog();
        }

        private void BtnGerenciarNoticia_Click(object sender, EventArgs e) {
            GerenciarNoticia listNoticia = new GerenciarNoticia(administrador);
            listNoticia.ShowDialog();
        }

        private void BtnNovoUsuarioPcd_Click(object sender, EventArgs e) {
            NovoUsuarioPcd userPcd = new NovoUsuarioPcd(administrador);
            userPcd.ShowDialog();
        }

        private void BtnPostarNoticia_Click(object sender, EventArgs e) {
            PostarNoticia postNoticia = new PostarNoticia(administrador);
            postNoticia.ShowDialog();
        }

        private void BtnFinanceiro_Click(object sender, EventArgs e) {
            RegistroFinanceiro financeiro = new RegistroFinanceiro(administrador);
            financeiro.ShowDialog();
        }

        private void BtnLogDeAtividades_Click(object sender, EventArgs e) {
            LogDeAtividaes log = new LogDeAtividaes(administrador);
            log.ShowDialog();
        }

        private void Dashboard_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
