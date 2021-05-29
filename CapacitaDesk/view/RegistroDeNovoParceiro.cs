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
using System.Text.RegularExpressions;

namespace CapacitaDesk {
    public partial class RegistroDeNovoParceiro : Form {
        AdminLogado administrador = new AdminLogado();

        public void estadoComboBoxParceiro() {

            String rota = "http://localhost:3000/estados";

            Object objResponse = ConnectionAPI.getLista(rota, administrador.Token);


            List<Estado> estados = JsonConvert.DeserializeObject<List<Estado>>(objResponse.ToString());

            comboBoxEstadoParceiro.Items.Add("");
            for (int i = 0; i < estados.Count; i++) {
                comboBoxEstadoParceiro.Items.Add(estados[i].label);
            }
        }


        public RegistroDeNovoParceiro(AdminLogado admin) {
            InitializeComponent();
            this.administrador = admin;
            estadoComboBoxParceiro();
            dateTimePickerInicial.Value = DateTime.Now.AddMonths(-1);
        }

        //CARREGAR TODAS AS INSTITUICOES NO LISTVIEW
        public void carregarTabela()
        {
            List<Instituicao> instituicoes;
            String rota = "http://localhost:3000/instituicao-inativa";

            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            instituicoes = JsonConvert.DeserializeObject <List<Instituicao>>(objectResponse.ToString());

            listViewParceiro.Items.Clear();

            foreach (Instituicao instituicao in instituicoes)
            {
                ListViewItem item = listViewParceiro.Items.Add(instituicao.id);
                item.SubItems.Add(Convert.ToDateTime(instituicao.createdAt).ToString("dd/MM/yy"));
                item.SubItems.Add(Convert.ToDateTime(instituicao.createdAt).ToString("hh:mm"));
                item.SubItems.Add(instituicao.nome);
                item.SubItems.Add(EstadoConvert.getEstadoUf(Convert.ToInt32(instituicao.id_estado)));
                item.SubItems.Add(instituicao.cidade);
            }
        }

        // CARREGAR TABELA FILTRANDO PELO PESQUISA
        public void carregarTabelaPesquisa(PesquisaInstituicao pesquisa)
        {
            List<Instituicao> instituicoes;
            
            String rota = "http://localhost:3000/instituicao-pesquisa";
            String json = JsonConvert.SerializeObject(pesquisa);

            Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
            instituicoes = JsonConvert.DeserializeObject<List<Instituicao>>(objectResponse.ToString());

            listViewParceiro.Items.Clear();

            foreach (Instituicao instituicao in instituicoes)
            {
                ListViewItem item = listViewParceiro.Items.Add(instituicao.id);
                item.SubItems.Add(Convert.ToDateTime(instituicao.createdAt).ToString("dd/MM/yy"));
                item.SubItems.Add(Convert.ToDateTime(instituicao.createdAt).ToString("hh:mm"));
                item.SubItems.Add(instituicao.nome);
                item.SubItems.Add(EstadoConvert.getEstadoUf(Convert.ToInt32(instituicao.id_estado)));
                item.SubItems.Add(instituicao.cidade);
            }
        }

        private void exibirDetalhesParceria()
        {
            if (listViewParceiro.SelectedItems.Count > 0)
            {
                

                Instituicao instituicao = new Instituicao();
                instituicao.id = listViewParceiro.SelectedItems[0].SubItems[0].Text;

                String rota = "http://localhost:3000/busca-instituicao";
                String json = JsonConvert.SerializeObject(instituicao);

                Object objectResponse = ConnectionAPI.post(rota, json, administrador.Token);
                RespUsuario respUsuario = JsonConvert.DeserializeObject<RespUsuario>(objectResponse.ToString());

                this.Dispose();
                DetalheDoParceiro dParceiro = new DetalheDoParceiro(administrador, respUsuario.instituicao);
                dParceiro.ShowDialog();
            }
        }

        private void BtnExibirParceiro_Click(object sender, EventArgs e) {
            exibirDetalhesParceria();
        }

        private void RegistroDeNovoParceiro_Load(object sender, EventArgs e)
        {
            carregarTabela();
        }

        private void BtnBuscarParceiro_Click(object sender, EventArgs e)
        {
            carregarTabelaPesquisa(new PesquisaInstituicao()
            {
                nome = TxtBoxNomedaInstitucao.Text,
                label = comboBoxEstadoParceiro.Text,
                //NECESSARIO ADICIONAR -1 DIA E +1 DIA NAS DATAS PARA PROCURAR ENTRE AS DATAS
                createdAt = Convert.ToDateTime(dateTimePickerInicial.Text).ToString("yyyy-MM-dd"),
                createdAt2 = Convert.ToDateTime(dateTimePickerFinal.Text).AddDays(1).ToString("yyyy-MM-dd")
            }) ;
        }

        private void listViewParceiro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            exibirDetalhesParceria();
        }

        private void listViewParceiro_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void comboBoxEstadoParceiro_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            TxtBoxNomedaInstitucao.Clear();
            comboBoxEstadoParceiro.SelectedIndex = 0;
            dateTimePickerInicial.Value = DateTime.Now.AddMonths(-1); ;
            dateTimePickerFinal.Value = DateTime.Now;
            carregarTabela();
        }
    }
}
