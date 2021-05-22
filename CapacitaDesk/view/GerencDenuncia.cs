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
    public partial class GerencDenuncia : Form {
        AdminLogado administrador = new AdminLogado();
        public GerencDenuncia(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void BtnExibirDenuncia_Click(object sender, EventArgs e) {
            this.Close();
            VisualizarDenuncia vDenuncia = new VisualizarDenuncia();
            vDenuncia.ShowDialog();
        }
    }
}
