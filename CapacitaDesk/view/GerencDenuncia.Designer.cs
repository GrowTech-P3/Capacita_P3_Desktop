
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
            this.Usuario = new System.Windows.Forms.ColumnHeader();
            this.Curso = new System.Windows.Forms.ColumnHeader();
            this.Instituicao = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxNomeCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxNomeInstituicao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBuscarDenuncia = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExibirDenuncia = new System.Windows.Forms.Button();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBoxHoraInicial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewDenuncia
            // 
            this.ListViewDenuncia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListViewDenuncia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Usuario,
            this.Curso,
            this.Instituicao,
            this.Data});
            this.ListViewDenuncia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewDenuncia.FullRowSelect = true;
            this.ListViewDenuncia.HideSelection = false;
            this.ListViewDenuncia.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListViewDenuncia.Location = new System.Drawing.Point(10, 26);
            this.ListViewDenuncia.MultiSelect = false;
            this.ListViewDenuncia.Name = "ListViewDenuncia";
            this.ListViewDenuncia.Size = new System.Drawing.Size(526, 204);
            this.ListViewDenuncia.TabIndex = 0;
            this.ListViewDenuncia.UseCompatibleStateImageBehavior = false;
            this.ListViewDenuncia.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 40;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuário";
            this.Usuario.Width = 120;
            // 
            // Curso
            // 
            this.Curso.Text = "Curso";
            this.Curso.Width = 120;
            // 
            // Instituicao
            // 
            this.Instituicao.Text = "instituição";
            this.Instituicao.Width = 150;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(251, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nome do Curso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtBoxNomeCurso
            // 
            this.TxtBoxNomeCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomeCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeCurso.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeCurso.Location = new System.Drawing.Point(251, 41);
            this.TxtBoxNomeCurso.Name = "TxtBoxNomeCurso";
            this.TxtBoxNomeCurso.Size = new System.Drawing.Size(162, 15);
            this.TxtBoxNomeCurso.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nome da Instituição";
            // 
            // TxtBoxNomeInstituicao
            // 
            this.TxtBoxNomeInstituicao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomeInstituicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeInstituicao.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeInstituicao.Location = new System.Drawing.Point(16, 41);
            this.TxtBoxNomeInstituicao.Name = "TxtBoxNomeInstituicao";
            this.TxtBoxNomeInstituicao.Size = new System.Drawing.Size(218, 15);
            this.TxtBoxNomeInstituicao.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerFinal);
            this.groupBox1.Controls.Add(this.dateTimePickerInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BtnBuscarDenuncia);
            this.groupBox1.Controls.Add(this.TxtBoxNomeInstituicao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxNomeCurso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(120, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 118);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFinal.CustomFormat = " ";
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(161, 82);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(126, 25);
            this.dateTimePickerFinal.TabIndex = 113;
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerInicial.CustomFormat = " ";
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(17, 82);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(126, 25);
            this.dateTimePickerInicial.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Data Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label6.Location = new System.Drawing.Point(161, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "Data Final";
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
            this.BtnBuscarDenuncia.Click += new System.EventHandler(this.BtnBuscarDenuncia_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewDenuncia);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(120, 261);
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
            this.BtnExibirDenuncia.Location = new System.Drawing.Point(533, 506);
            this.BtnExibirDenuncia.Name = "BtnExibirDenuncia";
            this.BtnExibirDenuncia.Size = new System.Drawing.Size(121, 35);
            this.BtnExibirDenuncia.TabIndex = 100;
            this.BtnExibirDenuncia.Text = "EXIBIR";
            this.BtnExibirDenuncia.UseVisualStyleBackColor = false;
            this.BtnExibirDenuncia.Click += new System.EventHandler(this.BtnExibirDenuncia_Click);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 102;
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
            // GerencDenuncia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.ColumnHeader Ususário;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Topico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxNomeCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxNomeInstituicao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnExibirDenuncia;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscarDenuncia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBoxHoraInicial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader Instituicao;
        private System.Windows.Forms.ColumnHeader Curso;
    }
}