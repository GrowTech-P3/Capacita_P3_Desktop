
namespace CapacitaDesk {
    partial class Dashboard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBoxExit = new System.Windows.Forms.PictureBox();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnUsuarioPcd = new System.Windows.Forms.Button();
            this.BtnUsuarioAdministrador = new System.Windows.Forms.Button();
            this.BtnNovaInstituicao = new System.Windows.Forms.Button();
            this.BtnListaDeCursos = new System.Windows.Forms.Button();
            this.BtnRegistroDeParceiro = new System.Windows.Forms.Button();
            this.BtnLogDeAtividades = new System.Windows.Forms.Button();
            this.BtnFinanceiro = new System.Windows.Forms.Button();
            this.BtnPostarNoticia = new System.Windows.Forms.Button();
            this.BtnGerenciarNoticia = new System.Windows.Forms.Button();
            this.BtnGerenciarDenuncia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmailAdmin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.labelEmailAdmin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PictureBoxExit);
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 69);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1204, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "SAIR";
            // 
            // PictureBoxExit
            // 
            this.PictureBoxExit.Image = global::CapacitaDesk.Properties.Resources.BtnPower;
            this.PictureBoxExit.Location = new System.Drawing.Point(1206, 18);
            this.PictureBoxExit.Name = "PictureBoxExit";
            this.PictureBoxExit.Size = new System.Drawing.Size(27, 26);
            this.PictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxExit.TabIndex = 13;
            this.PictureBoxExit.TabStop = false;
            this.PictureBoxExit.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            this.PictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.linkLabel1.Location = new System.Drawing.Point(550, 645);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.capacitacursos.com.br";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnUsuarioPcd
            // 
            this.BtnUsuarioPcd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnUsuarioPcd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnUsuarioPcd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarioPcd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnUsuarioPcd.Image = global::CapacitaDesk.Properties.Resources.IconeNovoUser;
            this.BtnUsuarioPcd.Location = new System.Drawing.Point(53, 227);
            this.BtnUsuarioPcd.Name = "BtnUsuarioPcd";
            this.BtnUsuarioPcd.Size = new System.Drawing.Size(210, 158);
            this.BtnUsuarioPcd.TabIndex = 2;
            this.BtnUsuarioPcd.UseVisualStyleBackColor = false;
            this.BtnUsuarioPcd.Click += new System.EventHandler(this.BtnNovoUsuarioPcd_Click);
            // 
            // BtnUsuarioAdministrador
            // 
            this.BtnUsuarioAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnUsuarioAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnUsuarioAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarioAdministrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnUsuarioAdministrador.Image = global::CapacitaDesk.Properties.Resources.IconeNovoAdmin;
            this.BtnUsuarioAdministrador.Location = new System.Drawing.Point(291, 227);
            this.BtnUsuarioAdministrador.Name = "BtnUsuarioAdministrador";
            this.BtnUsuarioAdministrador.Size = new System.Drawing.Size(210, 158);
            this.BtnUsuarioAdministrador.TabIndex = 3;
            this.BtnUsuarioAdministrador.UseVisualStyleBackColor = false;
            this.BtnUsuarioAdministrador.Click += new System.EventHandler(this.BtnNovoAdministrador_Click);
            // 
            // BtnNovaInstituicao
            // 
            this.BtnNovaInstituicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnNovaInstituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnNovaInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovaInstituicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnNovaInstituicao.Image = global::CapacitaDesk.Properties.Resources.IconeNovaInstituicao;
            this.BtnNovaInstituicao.Location = new System.Drawing.Point(529, 227);
            this.BtnNovaInstituicao.Name = "BtnNovaInstituicao";
            this.BtnNovaInstituicao.Size = new System.Drawing.Size(210, 158);
            this.BtnNovaInstituicao.TabIndex = 4;
            this.BtnNovaInstituicao.UseVisualStyleBackColor = false;
            this.BtnNovaInstituicao.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnListaDeCursos
            // 
            this.BtnListaDeCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnListaDeCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnListaDeCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaDeCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnListaDeCursos.Image = global::CapacitaDesk.Properties.Resources.IconeListaDeCursos;
            this.BtnListaDeCursos.Location = new System.Drawing.Point(767, 227);
            this.BtnListaDeCursos.Name = "BtnListaDeCursos";
            this.BtnListaDeCursos.Size = new System.Drawing.Size(210, 158);
            this.BtnListaDeCursos.TabIndex = 5;
            this.BtnListaDeCursos.UseVisualStyleBackColor = false;
            this.BtnListaDeCursos.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnRegistroDeParceiro
            // 
            this.BtnRegistroDeParceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnRegistroDeParceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnRegistroDeParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroDeParceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnRegistroDeParceiro.Image = global::CapacitaDesk.Properties.Resources.IconeRgDeParceiros;
            this.BtnRegistroDeParceiro.Location = new System.Drawing.Point(1005, 227);
            this.BtnRegistroDeParceiro.Name = "BtnRegistroDeParceiro";
            this.BtnRegistroDeParceiro.Size = new System.Drawing.Size(210, 158);
            this.BtnRegistroDeParceiro.TabIndex = 6;
            this.BtnRegistroDeParceiro.UseVisualStyleBackColor = false;
            this.BtnRegistroDeParceiro.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnLogDeAtividades
            // 
            this.BtnLogDeAtividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnLogDeAtividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnLogDeAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogDeAtividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnLogDeAtividades.Image = global::CapacitaDesk.Properties.Resources.IconeLogDeAtividades;
            this.BtnLogDeAtividades.Location = new System.Drawing.Point(1005, 416);
            this.BtnLogDeAtividades.Name = "BtnLogDeAtividades";
            this.BtnLogDeAtividades.Size = new System.Drawing.Size(210, 158);
            this.BtnLogDeAtividades.TabIndex = 11;
            this.BtnLogDeAtividades.UseVisualStyleBackColor = false;
            this.BtnLogDeAtividades.Click += new System.EventHandler(this.BtnLogDeAtividades_Click);
            // 
            // BtnFinanceiro
            // 
            this.BtnFinanceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnFinanceiro.Image = global::CapacitaDesk.Properties.Resources.IconeFinanceiro;
            this.BtnFinanceiro.Location = new System.Drawing.Point(767, 416);
            this.BtnFinanceiro.Name = "BtnFinanceiro";
            this.BtnFinanceiro.Size = new System.Drawing.Size(210, 158);
            this.BtnFinanceiro.TabIndex = 10;
            this.BtnFinanceiro.UseVisualStyleBackColor = false;
            this.BtnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);
            // 
            // BtnPostarNoticia
            // 
            this.BtnPostarNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnPostarNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnPostarNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPostarNoticia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnPostarNoticia.Image = global::CapacitaDesk.Properties.Resources.IconePostarNoticia;
            this.BtnPostarNoticia.Location = new System.Drawing.Point(529, 416);
            this.BtnPostarNoticia.Name = "BtnPostarNoticia";
            this.BtnPostarNoticia.Size = new System.Drawing.Size(210, 158);
            this.BtnPostarNoticia.TabIndex = 9;
            this.BtnPostarNoticia.UseVisualStyleBackColor = false;
            this.BtnPostarNoticia.Click += new System.EventHandler(this.BtnPostarNoticia_Click);
            // 
            // BtnGerenciarNoticia
            // 
            this.BtnGerenciarNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnGerenciarNoticia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnGerenciarNoticia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerenciarNoticia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnGerenciarNoticia.Image = global::CapacitaDesk.Properties.Resources.IconeGerNoticia;
            this.BtnGerenciarNoticia.Location = new System.Drawing.Point(291, 416);
            this.BtnGerenciarNoticia.Name = "BtnGerenciarNoticia";
            this.BtnGerenciarNoticia.Size = new System.Drawing.Size(210, 158);
            this.BtnGerenciarNoticia.TabIndex = 8;
            this.BtnGerenciarNoticia.UseVisualStyleBackColor = false;
            this.BtnGerenciarNoticia.Click += new System.EventHandler(this.BtnGerenciarNoticia_Click);
            // 
            // BtnGerenciarDenuncia
            // 
            this.BtnGerenciarDenuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnGerenciarDenuncia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnGerenciarDenuncia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerenciarDenuncia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnGerenciarDenuncia.Image = global::CapacitaDesk.Properties.Resources.IconeGerDenuncia;
            this.BtnGerenciarDenuncia.Location = new System.Drawing.Point(53, 416);
            this.BtnGerenciarDenuncia.Name = "BtnGerenciarDenuncia";
            this.BtnGerenciarDenuncia.Size = new System.Drawing.Size(210, 158);
            this.BtnGerenciarDenuncia.TabIndex = 7;
            this.BtnGerenciarDenuncia.UseVisualStyleBackColor = false;
            this.BtnGerenciarDenuncia.Click += new System.EventHandler(this.BtnGerenciarDenuncia_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 59);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(584, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "HOME";
            // 
            // labelEmailAdmin
            // 
            this.labelEmailAdmin.AutoSize = true;
            this.labelEmailAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmailAdmin.ForeColor = System.Drawing.Color.White;
            this.labelEmailAdmin.Location = new System.Drawing.Point(1085, 30);
            this.labelEmailAdmin.Name = "labelEmailAdmin";
            this.labelEmailAdmin.Size = new System.Drawing.Size(57, 21);
            this.labelEmailAdmin.TabIndex = 15;
            this.labelEmailAdmin.Text = "label3";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnLogDeAtividades);
            this.Controls.Add(this.BtnFinanceiro);
            this.Controls.Add(this.BtnPostarNoticia);
            this.Controls.Add(this.BtnGerenciarNoticia);
            this.Controls.Add(this.BtnGerenciarDenuncia);
            this.Controls.Add(this.BtnRegistroDeParceiro);
            this.Controls.Add(this.BtnListaDeCursos);
            this.Controls.Add(this.BtnNovaInstituicao);
            this.Controls.Add(this.BtnUsuarioAdministrador);
            this.Controls.Add(this.BtnUsuarioPcd);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BtnUsuarioPcd;
        private System.Windows.Forms.Button BtnUsuarioAdministrador;
        private System.Windows.Forms.Button BtnNovaInstituicao;
        private System.Windows.Forms.Button BtnListaDeCursos;
        private System.Windows.Forms.Button BtnRegistroDeParceiro;
        private System.Windows.Forms.Button BtnLogDeAtividades;
        private System.Windows.Forms.Button BtnFinanceiro;
        private System.Windows.Forms.Button BtnPostarNoticia;
        private System.Windows.Forms.Button BtnGerenciarNoticia;
        private System.Windows.Forms.Button BtnGerenciarDenuncia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PictureBoxExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmailAdmin;
    }
}