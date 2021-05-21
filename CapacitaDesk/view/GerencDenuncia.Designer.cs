
namespace CapacitaDesk {
    partial class GerencDenuncia {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerencDenuncia));
            this.ListViewDenuncia = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Hora = new System.Windows.Forms.ColumnHeader();
            this.Topico = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxTopico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxUsuarioDenuncia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDataInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDataFinal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBoxHoraFinal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBoxHoraInicial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarDenuncia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExibirDenuncia = new System.Windows.Forms.Button();
            this.BtnExcluirDenuncia = new System.Windows.Forms.Button();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewDenuncia
            // 
            this.ListViewDenuncia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Hora,
            this.Topico});
            this.ListViewDenuncia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewDenuncia.HideSelection = false;
            this.ListViewDenuncia.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListViewDenuncia.Location = new System.Drawing.Point(8, 26);
            this.ListViewDenuncia.Name = "ListViewDenuncia";
            this.ListViewDenuncia.Size = new System.Drawing.Size(527, 204);
            this.ListViewDenuncia.TabIndex = 0;
            this.ListViewDenuncia.UseCompatibleStateImageBehavior = false;
            this.ListViewDenuncia.View = System.Windows.Forms.View.Details;
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
            // Topico
            // 
            this.Topico.Text = "Tópico";
            this.Topico.Width = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(251, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Tópico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtBoxTopico
            // 
            this.TxtBoxTopico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxTopico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxTopico.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxTopico.Location = new System.Drawing.Point(251, 86);
            this.TxtBoxTopico.Name = "TxtBoxTopico";
            this.TxtBoxTopico.Size = new System.Drawing.Size(162, 15);
            this.TxtBoxTopico.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nome de usuário";
            // 
            // TxtBoxUsuarioDenuncia
            // 
            this.TxtBoxUsuarioDenuncia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxUsuarioDenuncia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxUsuarioDenuncia.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxUsuarioDenuncia.Location = new System.Drawing.Point(27, 86);
            this.TxtBoxUsuarioDenuncia.Name = "TxtBoxUsuarioDenuncia";
            this.TxtBoxUsuarioDenuncia.Size = new System.Drawing.Size(218, 15);
            this.TxtBoxUsuarioDenuncia.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Data Inicial";
            // 
            // TxtDataInicial
            // 
            this.TxtDataInicial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDataInicial.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDataInicial.Location = new System.Drawing.Point(27, 46);
            this.TxtDataInicial.Name = "TxtDataInicial";
            this.TxtDataInicial.Size = new System.Drawing.Size(74, 15);
            this.TxtDataInicial.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label6.Location = new System.Drawing.Point(114, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Data Final";
            // 
            // TxtDataFinal
            // 
            this.TxtDataFinal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDataFinal.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDataFinal.Location = new System.Drawing.Point(114, 46);
            this.TxtDataFinal.Name = "TxtDataFinal";
            this.TxtDataFinal.Size = new System.Drawing.Size(74, 15);
            this.TxtDataFinal.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label13.Location = new System.Drawing.Point(338, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 97;
            this.label13.Text = "Hora Final";
            // 
            // TxtBoxHoraFinal
            // 
            this.TxtBoxHoraFinal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxHoraFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxHoraFinal.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxHoraFinal.Location = new System.Drawing.Point(339, 46);
            this.TxtBoxHoraFinal.Name = "TxtBoxHoraFinal";
            this.TxtBoxHoraFinal.Size = new System.Drawing.Size(74, 15);
            this.TxtBoxHoraFinal.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label14.Location = new System.Drawing.Point(258, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 95;
            this.label14.Text = "Hora Inicial";
            // 
            // TxtBoxHoraInicial
            // 
            this.TxtBoxHoraInicial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxHoraInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxHoraInicial.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxHoraInicial.Location = new System.Drawing.Point(258, 46);
            this.TxtBoxHoraInicial.Name = "TxtBoxHoraInicial";
            this.TxtBoxHoraInicial.Size = new System.Drawing.Size(74, 15);
            this.TxtBoxHoraInicial.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarDenuncia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TxtDataInicial);
            this.groupBox1.Controls.Add(this.TxtBoxHoraFinal);
            this.groupBox1.Controls.Add(this.TxtBoxUsuarioDenuncia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxHoraInicial);
            this.groupBox1.Controls.Add(this.TxtBoxTopico);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDataFinal);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(120, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 118);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // BtnBuscarDenuncia
            // 
            this.BtnBuscarDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnBuscarDenuncia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuscarDenuncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnBuscarDenuncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarDenuncia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscarDenuncia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscarDenuncia.Location = new System.Drawing.Point(422, 67);
            this.BtnBuscarDenuncia.Name = "BtnBuscarDenuncia";
            this.BtnBuscarDenuncia.Size = new System.Drawing.Size(112, 35);
            this.BtnBuscarDenuncia.TabIndex = 108;
            this.BtnBuscarDenuncia.Text = "BUSCAR";
            this.BtnBuscarDenuncia.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewDenuncia);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(120, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 239);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de denúncia";
            // 
            // BtnExibirDenuncia
            // 
            this.BtnExibirDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExibirDenuncia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExibirDenuncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExibirDenuncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibirDenuncia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExibirDenuncia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExibirDenuncia.Location = new System.Drawing.Point(544, 514);
            this.BtnExibirDenuncia.Name = "BtnExibirDenuncia";
            this.BtnExibirDenuncia.Size = new System.Drawing.Size(121, 35);
            this.BtnExibirDenuncia.TabIndex = 100;
            this.BtnExibirDenuncia.Text = "EXIBIR";
            this.BtnExibirDenuncia.UseVisualStyleBackColor = false;
            this.BtnExibirDenuncia.Click += new System.EventHandler(this.BtnExibirDenuncia_Click);
            // 
            // BtnExcluirDenuncia
            // 
            this.BtnExcluirDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExcluirDenuncia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExcluirDenuncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExcluirDenuncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirDenuncia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluirDenuncia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExcluirDenuncia.Location = new System.Drawing.Point(417, 514);
            this.BtnExcluirDenuncia.Name = "BtnExcluirDenuncia";
            this.BtnExcluirDenuncia.Size = new System.Drawing.Size(121, 35);
            this.BtnExcluirDenuncia.TabIndex = 101;
            this.BtnExcluirDenuncia.Text = "EXCLUIR";
            this.BtnExcluirDenuncia.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "GERENCIAR DENÚNCIAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 102;
            // 
            // GerencDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnExcluirDenuncia);
            this.Controls.Add(this.BtnExibirDenuncia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerencDenuncia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewDenuncia;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader Topico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxTopico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxUsuarioDenuncia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDataInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDataFinal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBoxHoraFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBoxHoraInicial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnExibirDenuncia;
        private System.Windows.Forms.Button BtnExcluirDenuncia;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscarDenuncia;
    }
}