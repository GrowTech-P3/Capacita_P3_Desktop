using CapacitaDesk.controller;
using CapacitaDesk.model;
using Newtonsoft.Json;
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
    public partial class DetalheDoParceiro : Form {
        Instituicao     instituicao = null;
        AdminLogado     administrador = null;
        public DetalheDoParceiro(AdminLogado administrador, Instituicao instituicao) {
            this.instituicao    = instituicao;
            this.administrador  = administrador;

            InitializeComponent();
            TxtBoxNomeInstituicao.Text = instituicao.nome;
            TxtBoxCnpj.Text = instituicao.cnpj;
            TxtBoxEnderecoParceiro.Text = instituicao.endereco;
            TxtBoxNum.Text = instituicao.numero;
            TxtBoxTelefoneParceiro.Text = instituicao.telefone;
            TxtBoxCidadeParceiro.Text = instituicao.cidade;
            TxtBoxUfParceiro.Text = EstadoConvert.getEstadoUf(instituicao.id_estado);
            TxtBoxBairroParceiro.Text = instituicao.bairro;
            TxtBoxCep.Text = instituicao.cep;
            TxtBoxEmailParceiro.Text = instituicao.usuario.email;
            TxtBoxDescricaoParceiro.Text = instituicao.descricao;
        }

        private void BtnAceitarParceiro_Click(object sender, EventArgs e)
        {
            String rota = "http://localhost:3000/instituicao-liberacao";
            String json = JsonConvert.SerializeObject(instituicao);

            Object objResponse = ConnectionAPI.post(rota, json, administrador.Token);
            RespUsuario respInstituicao = JsonConvert.DeserializeObject<RespUsuario>(objResponse.ToString());

            MessageBox.Show(respInstituicao.message);

            Dispose();
            RegistroDeNovoParceiro regNovoParceiro = new RegistroDeNovoParceiro(administrador);
            regNovoParceiro.ShowDialog();
        }

        private void BtnRecusarParceiro_Click(object sender, EventArgs e)
        {
            Dispose();
            RegistroDeNovoParceiro regNovoParceiro = new RegistroDeNovoParceiro(administrador);
            regNovoParceiro.ShowDialog();
        }
    }
}
