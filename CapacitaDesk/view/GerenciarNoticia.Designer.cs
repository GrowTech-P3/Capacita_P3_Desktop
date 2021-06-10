
namespace CapacitaDesk {
    partial class GerenciarNoticia {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarNoticia));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExcluirNoticia = new System.Windows.Forms.Button();
            this.BtnExibirNoticia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewNoticia = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Tipo = new System.Windows.Forms.ColumnHeader();
            this.Titulo = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscarNoticia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPostarNoticia = new System.Windows.Forms.Button();
            this.btnAlterarNoticia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 103;
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
            this.label1.Location = new System.Drawing.Point(243, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "GERENCIAR NOTÍCIAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 104;
            // 
            // BtnExcluirNoticia
            // 
            this.BtnExcluirNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExcluirNoticia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExcluirNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExcluirNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluirNoticia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluirNoticia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExcluirNoticia.Location = new System.Drawing.Point(276, 481);
            this.BtnExcluirNoticia.Name = "BtnExcluirNoticia";
            this.BtnExcluirNoticia.Size = new System.Drawing.Size(121, 35);
            this.BtnExcluirNoticia.TabIndex = 7;
            this.BtnExcluirNoticia.Text = "EXCLUIR";
            this.BtnExcluirNoticia.UseVisualStyleBackColor = false;
            this.BtnExcluirNoticia.Click += new System.EventHandler(this.BtnExcluirNoticia_Click);
            // 
            // BtnExibirNoticia
            // 
            this.BtnExibirNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExibirNoticia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExibirNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExibirNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibirNoticia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExibirNoticia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExibirNoticia.Location = new System.Drawing.Point(530, 481);
            this.BtnExibirNoticia.Name = "BtnExibirNoticia";
            this.BtnExibirNoticia.Size = new System.Drawing.Size(121, 35);
            this.BtnExibirNoticia.TabIndex = 9;
            this.BtnExibirNoticia.Text = "EXIBIR";
            this.BtnExibirNoticia.UseVisualStyleBackColor = false;
            this.BtnExibirNoticia.Click += new System.EventHandler(this.BtnExibirNoticia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewNoticia);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(117, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 197);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de notícias";
            // 
            // ListViewNoticia
            // 
            this.ListViewNoticia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.Email,
            this.Tipo,
            this.Titulo});
            this.ListViewNoticia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewNoticia.FullRowSelect = true;
            this.ListViewNoticia.HideSelection = false;
            this.ListViewNoticia.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListViewNoticia.Location = new System.Drawing.Point(8, 26);
            this.ListViewNoticia.MultiSelect = false;
            this.ListViewNoticia.Name = "ListViewNoticia";
            this.ListViewNoticia.Size = new System.Drawing.Size(527, 161);
            this.ListViewNoticia.TabIndex = 10;
            this.ListViewNoticia.UseCompatibleStateImageBehavior = false;
            this.ListViewNoticia.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 30;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 70;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.Width = 160;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 100;
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulo";
            this.Titulo.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.BtnBuscarNoticia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBoxEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxTitulo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(117, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 118);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(184, 79);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(113, 27);
            this.dtpDataFinal.TabIndex = 4;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(19, 80);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(113, 27);
            this.dtpDataInicial.TabIndex = 3;
            // 
            // BtnBuscarNoticia
            // 
            this.BtnBuscarNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnBuscarNoticia.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuscarNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnBuscarNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarNoticia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscarNoticia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscarNoticia.Location = new System.Drawing.Point(422, 67);
            this.BtnBuscarNoticia.Name = "BtnBuscarNoticia";
            this.BtnBuscarNoticia.Size = new System.Drawing.Size(112, 35);
            this.BtnBuscarNoticia.TabIndex = 5;
            this.BtnBuscarNoticia.Text = "BUSCAR";
            this.BtnBuscarNoticia.UseVisualStyleBackColor = false;
            this.BtnBuscarNoticia.Click += new System.EventHandler(this.BtnBuscarNoticia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Data Inicial";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxEmail.Location = new System.Drawing.Point(19, 41);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(240, 14);
            this.TxtBoxEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Email";
            // 
            // TxtBoxTitulo
            // 
            this.TxtBoxTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxTitulo.Location = new System.Drawing.Point(265, 41);
            this.TxtBoxTitulo.Name = "TxtBoxTitulo";
            this.TxtBoxTitulo.Size = new System.Drawing.Size(269, 14);
            this.TxtBoxTitulo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label6.Location = new System.Drawing.Point(184, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 93;
            this.label6.Text = "Data Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(265, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Título";
            // 
            // btnPostarNoticia
            // 
            this.btnPostarNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPostarNoticia.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPostarNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnPostarNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostarNoticia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPostarNoticia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPostarNoticia.Location = new System.Drawing.Point(149, 481);
            this.btnPostarNoticia.Name = "btnPostarNoticia";
            this.btnPostarNoticia.Size = new System.Drawing.Size(121, 35);
            this.btnPostarNoticia.TabIndex = 6;
            this.btnPostarNoticia.Text = "POSTAR NOTÍCIA";
            this.btnPostarNoticia.UseVisualStyleBackColor = false;
            this.btnPostarNoticia.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterarNoticia
            // 
            this.btnAlterarNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnAlterarNoticia.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAlterarNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnAlterarNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarNoticia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarNoticia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterarNoticia.Location = new System.Drawing.Point(403, 481);
            this.btnAlterarNoticia.Name = "btnAlterarNoticia";
            this.btnAlterarNoticia.Size = new System.Drawing.Size(121, 35);
            this.btnAlterarNoticia.TabIndex = 8;
            this.btnAlterarNoticia.Text = "ALTERAR";
            this.btnAlterarNoticia.UseVisualStyleBackColor = false;
            this.btnAlterarNoticia.Click += new System.EventHandler(this.btnAlterarNoticia_Click);
            // 
            // GerenciarNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAlterarNoticia);
            this.Controls.Add(this.btnPostarNoticia);
            this.Controls.Add(this.BtnExcluirNoticia);
            this.Controls.Add(this.BtnExibirNoticia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciarNoticia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnExcluirNoticia;
        private System.Windows.Forms.Button BtnExibirNoticia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListViewNoticia;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Topico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscarNoticia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.Button btnPostarNoticia;
        private System.Windows.Forms.Button btnAlterarNoticia;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.ColumnHeader Email;
    }
}