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

namespace CapacitaDesk {
    public partial class PostarNoticia : Form {
        AdminLogado administrador = new AdminLogado();
        public PostarNoticia(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
        }

        private void BtnPostar_Click(object sender, EventArgs e) {
            MessageBox.Show("Notícia Postada com Sucesso!");
            DialogResult Resp = MessageBox.Show("Deseja postar outra notícia?", "Capacita Desk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resp == DialogResult.No) {

                this.Dispose();
            }
        }
    }
}
