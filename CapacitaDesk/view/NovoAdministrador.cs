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
    public partial class NovoAdministrador : Form {
        public NovoAdministrador() {
            InitializeComponent();
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
            MessageBox.Show("Usuário ADMINISTRADOR cadastrado com sucesso!");
            DialogResult Resp = MessageBox.Show("Deseja cadastrar outro usuário?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resp == DialogResult.No) {

                this.Dispose();
            }
        }
    }
}
