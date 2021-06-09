
namespace CapacitaDesk {
    partial class RegistroFinanceiro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFinanceiro));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSaldoTotal = new System.Windows.Forms.TextBox();
            this.ListViewFinanceiro = new System.Windows.Forms.ListView();
            this.Curso = new System.Windows.Forms.ColumnHeader();
            this.NomeUsuario = new System.Windows.Forms.ColumnHeader();
            this.NomeDaInstituicao = new System.Windows.Forms.ColumnHeader();
            this.DataHora = new System.Windows.Forms.ColumnHeader();
            this.Valor = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNomeCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscarParceiro = new System.Windows.Forms.Button();
            this.TxtBoxNomedaInstitucao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxSaldoTotal);
            this.groupBox2.Controls.Add(this.ListViewFinanceiro);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(58, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 236);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Financeiro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saldo Total";
            // 
            // textBoxSaldoTotal
            // 
            this.textBoxSaldoTotal.Enabled = false;
            this.textBoxSaldoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSaldoTotal.Location = new System.Drawing.Point(548, 201);
            this.textBoxSaldoTotal.Name = "textBoxSaldoTotal";
            this.textBoxSaldoTotal.Size = new System.Drawing.Size(109, 29);
            this.textBoxSaldoTotal.TabIndex = 2;
            // 
            // ListViewFinanceiro
            // 
            this.ListViewFinanceiro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Curso,
            this.NomeUsuario,
            this.NomeDaInstituicao,
            this.DataHora,
            this.Valor});
            this.ListViewFinanceiro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListViewFinanceiro.HideSelection = false;
            this.ListViewFinanceiro.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ListViewFinanceiro.Location = new System.Drawing.Point(15, 27);
            this.ListViewFinanceiro.Name = "ListViewFinanceiro";
            this.ListViewFinanceiro.Size = new System.Drawing.Size(642, 167);
            this.ListViewFinanceiro.TabIndex = 1;
            this.ListViewFinanceiro.UseCompatibleStateImageBehavior = false;
            this.ListViewFinanceiro.View = System.Windows.Forms.View.Details;
            this.ListViewFinanceiro.SelectedIndexChanged += new System.EventHandler(this.ListViewParceiro_SelectedIndexChanged);
            // 
            // Curso
            // 
            this.Curso.Text = "Curso";
            this.Curso.Width = 90;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.Text = "Nome do Usuário";
            this.NomeUsuario.Width = 150;
            // 
            // NomeDaInstituicao
            // 
            this.NomeDaInstituicao.Text = "Nome da Instituição";
            this.NomeDaInstituicao.Width = 150;
            // 
            // DataHora
            // 
            this.DataHora.Text = "Data";
            this.DataHora.Width = 100;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNomeCurso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnBuscarParceiro);
            this.groupBox1.Controls.Add(this.TxtBoxNomedaInstitucao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(58, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 120);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // textBoxNomeCurso
            // 
            this.textBoxNomeCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNomeCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomeCurso.Location = new System.Drawing.Point(326, 42);
            this.textBoxNomeCurso.Name = "textBoxNomeCurso";
            this.textBoxNomeCurso.Size = new System.Drawing.Size(213, 14);
            this.textBoxNomeCurso.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(326, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Curso";
            // 
            // BtnBuscarParceiro
            // 
            this.BtnBuscarParceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnBuscarParceiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuscarParceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnBuscarParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarParceiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscarParceiro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscarParceiro.Location = new System.Drawing.Point(548, 42);
            this.BtnBuscarParceiro.Name = "BtnBuscarParceiro";
            this.BtnBuscarParceiro.Size = new System.Drawing.Size(112, 61);
            this.BtnBuscarParceiro.TabIndex = 107;
            this.BtnBuscarParceiro.Text = "BUSCAR";
            this.BtnBuscarParceiro.UseVisualStyleBackColor = false;
            this.BtnBuscarParceiro.Click += new System.EventHandler(this.BtnBuscarParceiro_Click);
            // 
            // TxtBoxNomedaInstitucao
            // 
            this.TxtBoxNomedaInstitucao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomedaInstitucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomedaInstitucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomedaInstitucao.Location = new System.Drawing.Point(31, 42);
            this.TxtBoxNomedaInstitucao.Name = "TxtBoxNomedaInstitucao";
            this.TxtBoxNomedaInstitucao.Size = new System.Drawing.Size(289, 14);
            this.TxtBoxNomedaInstitucao.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label5.Location = new System.Drawing.Point(31, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Nome da Instituicao";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "REGISTRO FINANCEIRO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 108;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(33, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(149, 43);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 2;
            this.PictureBoxLogo.TabStop = false;
            // 
            // RegistroFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListViewFinanceiro;
        private System.Windows.Forms.ColumnHeader Curso;
        private System.Windows.Forms.ColumnHeader NomeUsuario;
        private System.Windows.Forms.ColumnHeader NomeDaInstituicao;
        private System.Windows.Forms.ColumnHeader CidadeParceiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNomeCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscarParceiro;
        private System.Windows.Forms.TextBox TxtBoxNomedaInstitucao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSaldoTotal;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader DataHora;
    }
}