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
    public partial class GerencDenuncia : Form {
        public GerencDenuncia() {
            InitializeComponent();
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
