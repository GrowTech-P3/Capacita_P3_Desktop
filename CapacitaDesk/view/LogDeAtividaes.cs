using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapacitaDesk.controller;
using CapacitaDesk.model;
using Newtonsoft.Json;

namespace CapacitaDesk {
    public partial class LogDeAtividaes : Form {

        AdminLogado administrador = new AdminLogado();
        public LogDeAtividaes(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            encherListView();
        }

        private void BtnBuscarAtividade_Click(object sender, EventArgs e)
        {
            String[] formatDate = new string[2];
            Administrador admin = new Administrador();
            admin.idAdministrador = TxtBoxID.Text;
            if(!(admin.idAdministrador == null || admin.idAdministrador.Trim().Equals(""))) {
                List<LogAdministrador> logAdmin;
                String rota = "http://localhost:3000/log/" + admin.idAdministrador;
                String json = JsonConvert.SerializeObject(admin);
                Object objResponse = ConnectionAPI.getOne(rota, json, administrador.Token);
                logAdmin = JsonConvert.DeserializeObject<List<LogAdministrador>>(objResponse.ToString());
                if (logAdmin != null && logAdmin.Count > 0) {
                    ListViewAtividade.Items.Clear();
                    foreach (LogAdministrador log in logAdmin)
                    {
                        ListViewItem item = ListViewAtividade.Items.Add(log.administrador.idAdministrador);
                        formatDate = log.dataHora.Split("T");
                        item.SubItems.Add(formatDate[0]);
                        item.SubItems.Add(log.administrador.nome);
                        item.SubItems.Add(log.logAtividade);
                    }
                }
                else {
                    MessageBox.Show("Log de Administrador não encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Digite um ID para pesquisar!!");
                encherListView();
            }


        }
        public void encherListView()
        {
            String[] formatDate = new string[2];
            List<LogAdministrador> logAdm;
            String rota = "http://localhost:3000/log";
            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            logAdm = JsonConvert.DeserializeObject<List<LogAdministrador>>(objectResponse.ToString());
            if (logAdm != null && logAdm.Count > 0) {
                ListViewAtividade.Items.Clear();
                foreach (LogAdministrador log in logAdm)
                {
                    ListViewItem item = ListViewAtividade.Items.Add(log.administrador.idAdministrador);
                    formatDate = log.dataHora.Split("T");
                    item.SubItems.Add(formatDate[0]);
                    item.SubItems.Add(log.administrador.nome);
                    item.SubItems.Add(log.logAtividade);
                }
            }
            else {
                MessageBox.Show("Logs não encontrados!");
            }
        }

        private void TxtBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
