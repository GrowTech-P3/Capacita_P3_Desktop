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

namespace CapacitaDesk {
    public partial class Dashboard : Form {
        public Dashboard() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }

        
        private void Dashboard_Load(object sender, EventArgs e) {
            
        }

        private void button2_Click(object sender, EventArgs e) {

            NovoAdministrador home = new NovoAdministrador();
            home.ShowDialog();     
        }

        private void button3_Click(object sender, EventArgs e) {
            NovaInstituicao novaInstituicao = new NovaInstituicao();
            novaInstituicao.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            
            NovoUsuarioPcd userPcd = new NovoUsuarioPcd();
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
    }
}
