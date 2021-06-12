
namespace CapacitaDesk {
    partial class RegistroDeNovoParceiro {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeNovoParceiro));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewParceiro = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Hora = new System.Windows.Forms.ColumnHeader();
            this.NomeDaInstituicao = new System.Windows.Forms.ColumnHeader();
            this.UfParceiros = new System.Windows.Forms.ColumnHeader();
            this.CidadeParceiro = new System.Windows.Forms.ColumnHeader();
            this.BtnExibirParceiro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxNomedaInstitucao = new System.Windows.Forms.TextBox();
            this.BtnBuscarParceiro = new System.Windows.Forms.Button();
            this.comboBoxEstadoParceiro = new System.Windows.Forms.ComboBox();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(33, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(149, 43);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 2;
            this.PictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel1.BackgroundImage = global::CapacitaDesk.Properties.Resources.bg_blue10;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 103;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "REGISTRO DE NOVOS PARCEIROS";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listViewParceiro);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(58, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 236);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de novos parceiros";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listViewParceiro
            // 
            this.listViewParceiro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewParceiro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Hora,
            this.NomeDaInstituicao,
            this.UfParceiros,
            this.CidadeParceiro});
            this.listViewParceiro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewParceiro.FullRowSelect = true;
            this.listViewParceiro.HideSelection = false;
            this.listViewParceiro.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewParceiro.Location = new System.Drawing.Point(15, 27);
            this.listViewParceiro.MultiSelect = false;
            this.listViewParceiro.Name = "listViewParceiro";
            this.listViewParceiro.Size = new System.Drawing.Size(642, 198);
            this.listViewParceiro.TabIndex = 1;
            this.listViewParceiro.UseCompatibleStateImageBehavior = false;
            this.listViewParceiro.View = System.Windows.Forms.View.Details;
            this.listViewParceiro.SelectedIndexChanged += new System.EventHandler(this.listViewParceiro_SelectedIndexChanged);
            this.listViewParceiro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewParceiro_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 40;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 90;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            this.Hora.Width = 90;
            // 
            // NomeDaInstituicao
            // 
            this.NomeDaInstituicao.Text = "Nome da Instituição";
            this.NomeDaInstituicao.Width = 250;
            // 
            // UfParceiros
            // 
            this.UfParceiros.Text = "UF";
            this.UfParceiros.Width = 40;
            // 
            // CidadeParceiro
            // 
            this.CidadeParceiro.Text = "Cidade";
            this.CidadeParceiro.Width = 100;
            // 
            // BtnExibirParceiro
            // 
            this.BtnExibirParceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExibirParceiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExibirParceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExibirParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibirParceiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExibirParceiro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExibirParceiro.Location = new System.Drawing.Point(606, 511);
            this.BtnExibirParceiro.Name = "BtnExibirParceiro";
            this.BtnExibirParceiro.Size = new System.Drawing.Size(121, 35);
            this.BtnExibirParceiro.TabIndex = 107;
            this.BtnExibirParceiro.Text = "EXIBIR";
            this.BtnExibirParceiro.UseVisualStyleBackColor = false;
            this.BtnExibirParceiro.Click += new System.EventHandler(this.BtnExibirParceiro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label6.Location = new System.Drawing.Point(161, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Data Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(337, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Estado ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Data Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "Nome da Insituicao";
            // 
            // TxtBoxNomedaInstitucao
            // 
            this.TxtBoxNomedaInstitucao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomedaInstitucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomedaInstitucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomedaInstitucao.Location = new System.Drawing.Point(16, 44);
            this.TxtBoxNomedaInstitucao.Name = "TxtBoxNomedaInstitucao";
            this.TxtBoxNomedaInstitucao.Size = new System.Drawing.Size(304, 14);
            this.TxtBoxNomedaInstitucao.TabIndex = 1;
            // 
            // BtnBuscarParceiro
            // 
            this.BtnBuscarParceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnBuscarParceiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuscarParceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnBuscarParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarParceiro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscarParceiro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscarParceiro.Location = new System.Drawing.Point(526, 68);
            this.BtnBuscarParceiro.Name = "BtnBuscarParceiro";
            this.BtnBuscarParceiro.Size = new System.Drawing.Size(134, 35);
            this.BtnBuscarParceiro.TabIndex = 107;
            this.BtnBuscarParceiro.Text = "BUSCAR";
            this.BtnBuscarParceiro.UseVisualStyleBackColor = false;
            this.BtnBuscarParceiro.Click += new System.EventHandler(this.BtnBuscarParceiro_Click);
            // 
            // comboBoxEstadoParceiro
            // 
            this.comboBoxEstadoParceiro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxEstadoParceiro.DropDownHeight = 60;
            this.comboBoxEstadoParceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoParceiro.DropDownWidth = 150;
            this.comboBoxEstadoParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEstadoParceiro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEstadoParceiro.FormattingEnabled = true;
            this.comboBoxEstadoParceiro.IntegralHeight = false;
            this.comboBoxEstadoParceiro.Location = new System.Drawing.Point(337, 30);
            this.comboBoxEstadoParceiro.Name = "comboBoxEstadoParceiro";
            this.comboBoxEstadoParceiro.Size = new System.Drawing.Size(169, 28);
            this.comboBoxEstadoParceiro.TabIndex = 4;
            this.comboBoxEstadoParceiro.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoParceiro_SelectedIndexChanged);
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerInicial.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerInicial.CustomFormat = " ";
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(17, 83);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(126, 25);
            this.dateTimePickerInicial.TabIndex = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimparPesquisa);
            this.groupBox1.Controls.Add(this.dateTimePickerFinal);
            this.groupBox1.Controls.Add(this.dateTimePickerInicial);
            this.groupBox1.Controls.Add(this.comboBoxEstadoParceiro);
            this.groupBox1.Controls.Add(this.BtnBuscarParceiro);
            this.groupBox1.Controls.Add(this.TxtBoxNomedaInstitucao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(58, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 120);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimparPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnLimparPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparPesquisa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimparPesquisa.Location = new System.Drawing.Point(526, 23);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(134, 35);
            this.btnLimparPesquisa.TabIndex = 110;
            this.btnLimparPesquisa.Text = "LIMPAR PESQUISA";
            this.btnLimparPesquisa.UseVisualStyleBackColor = false;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFinal.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerFinal.CustomFormat = " ";
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(161, 83);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(126, 25);
            this.dateTimePickerFinal.TabIndex = 109;
            // 
            // RegistroDeNovoParceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapacitaDesk.Properties.Resources.bg_white10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnExibirParceiro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroDeNovoParceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.Load += new System.EventHandler(this.RegistroDeNovoParceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewParceiro;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader NomeDaInstituicao;
        private System.Windows.Forms.ColumnHeader UfParceiros;
        private System.Windows.Forms.ColumnHeader CidadeParceiro;
        private System.Windows.Forms.Button BtnExibirParceiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBoxNomedaInstitucao;
        private System.Windows.Forms.Button BtnBuscarParceiro;
        private System.Windows.Forms.ComboBox comboBoxEstadoParceiro;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Button btnLimparPesquisa;
    }
}