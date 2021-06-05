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
    public partial class RegistroFinanceiro : Form {
        AdminLogado administrador = new AdminLogado();
        public RegistroFinanceiro(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            encherListView();
        }
        public void encherListView()
        {
            List<Financeiro> financeiro;
            String[] formatDate = new string[2];
            double total = 0;
            String rota = "http://localhost:3000/financeiro";
            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            financeiro = JsonConvert.DeserializeObject<List<Financeiro>>(objectResponse.ToString());
            ListViewFinanceiro.Items.Clear();
            foreach(Financeiro financ in financeiro){
                ListViewItem item = ListViewFinanceiro.Items.Add(financ.curso.nome_curso);
                item.SubItems.Add(financ.usuarioPCD.nome);
                item.SubItems.Add(financ.instituicao.nome);
                formatDate = financ.dataHora.Split("T");
                item.SubItems.Add(formatDate[0]);
                total = total + Convert.ToInt32(financ.valor) * 0.5;
                item.SubItems.Add(financ.valor);
            }
            textBoxSaldoTotal.Text = Convert.ToString(total);
        }
        private void ListViewParceiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
