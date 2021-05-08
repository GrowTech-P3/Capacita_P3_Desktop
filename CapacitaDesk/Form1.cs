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
    public partial class login : Form {

        Thread nt;
        public login() {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e) {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm(object obj) {
            Application.Run(new Dashboard());
        }

        private void login_Load(object sender, EventArgs e) {

        }
    }
}
