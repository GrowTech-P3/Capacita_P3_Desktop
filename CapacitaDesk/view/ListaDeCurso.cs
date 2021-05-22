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
    public partial class ListaDeCurso : Form {
        AdminLogado administrador = new AdminLogado();
        public ListaDeCurso(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
        }

        private void BtnExibirInstituicao_Click(object sender, EventArgs e) {
            DetalheDoCurso detalheCurso = new DetalheDoCurso();
            detalheCurso.ShowDialog();
        }
    }
}
