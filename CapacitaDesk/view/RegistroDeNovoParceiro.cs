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
    public partial class RegistroDeNovoParceiro : Form {
        public RegistroDeNovoParceiro() {
            InitializeComponent();
        }

        private void ListViewParceiro_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void BtnExibirParceiro_Click(object sender, EventArgs e) {
            this.Close();
            DetalheDoParceiro dParceiro = new DetalheDoParceiro();
            dParceiro.ShowDialog();

        }
    }
}
