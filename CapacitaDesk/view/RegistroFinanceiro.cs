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
    public partial class RegistroFinanceiro : Form {
        AdminLogado administrador = new AdminLogado();
        public RegistroFinanceiro(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
        }
    }
}
