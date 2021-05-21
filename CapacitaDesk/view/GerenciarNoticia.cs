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
    public partial class GerenciarNoticia : Form {
        public GerenciarNoticia() {
            InitializeComponent();
        }

        private void BtnExibirNoticia_Click(object sender, EventArgs e) {
            this.Close();
            VisualizarNoticia vNoticia = new VisualizarNoticia();
            vNoticia.ShowDialog();
        }
    }
}
