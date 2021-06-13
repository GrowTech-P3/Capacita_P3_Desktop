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
            //String[] formatDate = new string[2];
            TxtBoxNomedaInstitucao.Clear();
            textBoxNomeCurso.Clear();
            double total = 0;
            textBoxSaldoTotal.Text = Convert.ToString(total);
            String rota = "http://localhost:3000/financeiro";
            Object objectResponse = ConnectionAPI.getLista(rota, this.administrador.Token);
            financeiro = JsonConvert.DeserializeObject<List<Financeiro>>(objectResponse.ToString());
            if (financeiro != null && financeiro.Count > 0)
            {
                ListViewFinanceiro.Items.Clear();
                foreach (Financeiro financ in financeiro)
                {
                    ListViewItem item = ListViewFinanceiro.Items.Add(financ.curso.nome_curso);
                    item.SubItems.Add(financ.usuarioPCD.nome);
                    item.SubItems.Add(financ.instituicao.nome);
                    //formatDate = financ.dataHora.Split("T");
                    //item.SubItems.Add(formatDate[0]);
                    item.SubItems.Add(Convert.ToDateTime(financ.dataHora).ToString("dd/MM/yy"));
                    total = total + Convert.ToInt32(financ.valor) * 0.5;
                    item.SubItems.Add(financ.valor);
                }
                textBoxSaldoTotal.Text = Convert.ToString(total);
            }
            else {
                MessageBox.Show("Conteúdo financeiro não encontrado!");
            }
        }
        private void ListViewParceiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscarParceiro_Click(object sender, EventArgs e)
        {
            Financeiro financas = new Financeiro();
            Instituicao inst = new Instituicao();
            Curso curso = new Curso();
            inst.nome = TxtBoxNomedaInstitucao.Text;
            curso.nome_curso = textBoxNomeCurso.Text;
            ListViewFinanceiro.Items.Clear();
            if (!(inst.nome == null || inst.nome.Trim().Equals("")))
            {
               if(curso.nome_curso == null || curso.nome_curso.Trim().Equals(""))
                {
                    String rota = "http://localhost:3000/financeiro/instituicao";
                    String json = JsonConvert.SerializeObject(inst);
                    Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
                    List<Financeiro> financeiro;
                    financeiro = JsonConvert.DeserializeObject<List<Financeiro>>(objResponse.ToString());
                    String[] formatDate = new string[2];
                    double total = 0;
                    if (financeiro != null && financeiro.Count > 0) {
                        ListViewFinanceiro.Items.Clear();
                        foreach (Financeiro financ in financeiro)
                        {
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
                    else {
                        textBoxSaldoTotal.Text = "";
                        MessageBox.Show("Instituição não encontrada!");
                        encherListView();
                    }
                }
                else
                {
                    financas.curso = curso;
                    financas.instituicao = inst;
                    String rota = "http://localhost:3000/financeiro/instituicao/cursos";
                    String json = JsonConvert.SerializeObject(financas);
                    Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
                    List<Financeiro> financeiro;
                    financeiro = JsonConvert.DeserializeObject<List<Financeiro>>(objResponse.ToString());
                    String[] formatDate = new string[2];
                    double total = 0;
                    if (financeiro != null && financeiro.Count>0) {
                        ListViewFinanceiro.Items.Clear();
                        foreach (Financeiro financa in financeiro)
                        {
                            ListViewItem item = ListViewFinanceiro.Items.Add(financa.curso.nome_curso);
                            item.SubItems.Add(financa.usuarioPCD.nome);
                            item.SubItems.Add(financa.instituicao.nome);
                            formatDate = financa.dataHora.Split("T");
                            item.SubItems.Add(formatDate[0]);
                            total = total + Convert.ToInt32(financa.valor) * 0.5;
                            item.SubItems.Add(financa.valor);
                        }
                        textBoxSaldoTotal.Text = Convert.ToString(total);
                    }
                    else {
                        textBoxSaldoTotal.Text = "";
                        MessageBox.Show("Curso ou instituição não encontados!");
                        encherListView();
                    }
                }
            }
            else if(!(curso.nome_curso == null || curso.nome_curso.Trim().Equals("")))
            {
                String rota = "http://localhost:3000/financeiro/cursos";
                String json = JsonConvert.SerializeObject(curso);
                Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
                List<Financeiro> financeiro;
                financeiro = JsonConvert.DeserializeObject<List<Financeiro>>(objResponse.ToString());
                String[] formatDate = new string[2];
                double total = 0;
                if (financeiro != null && financeiro.Count>0) {
                    ListViewFinanceiro.Items.Clear();
                    foreach (Financeiro financ in financeiro)
                    {
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
                else {
                    textBoxSaldoTotal.Text = "";
                    MessageBox.Show("Curso não encontrado!");
                    encherListView();
                }
            }
            else
            {
                encherListView();
            }
              
        }
    }
}
