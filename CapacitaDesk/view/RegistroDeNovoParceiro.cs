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
    public partial class RegistroDeNovoParceiro : Form {
        AdminLogado administrador = new AdminLogado();
        public RegistroDeNovoParceiro(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
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
