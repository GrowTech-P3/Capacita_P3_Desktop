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
    public partial class login : Form {

       
        public login() {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e) {
            this.Hide();
            Dashboard home = new Dashboard();
            home.Show();
            
        }

        private void login_Load(object sender, EventArgs e) {

        }
    }
}
