
namespace CapacitaDesk {
    partial class ListaDeCurso {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeCurso));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewCurso = new System.Windows.Forms.ListView();
            this.IdCurso = new System.Windows.Forms.ColumnHeader();
            this.NomeDaInstituicao = new System.Windows.Forms.ColumnHeader();
            this.NomeDoCurso = new System.Windows.Forms.ColumnHeader();
            this.Deficiencia = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxDeficiencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNomeDaInstitucao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxNomeDoCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnExibirBuscarInstituicao = new System.Windows.Forms.Button();
            this.textBoxBuscarInstituicao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnExibirInstituicao = new System.Windows.Forms.Button();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewCurso);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(60, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 212);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Cursos";
            // 
            // ListViewCurso
            // 
            this.ListViewCurso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCurso,
            this.NomeDaInstituicao,
            this.NomeDoCurso,
            this.Deficiencia});
            this.ListViewCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewCurso.HideSelection = false;
            this.ListViewCurso.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListViewCurso.Location = new System.Drawing.Point(8, 26);
            this.ListViewCurso.Name = "ListViewCurso";
            this.ListViewCurso.Size = new System.Drawing.Size(653, 177);
            this.ListViewCurso.TabIndex = 0;
            this.ListViewCurso.UseCompatibleStateImageBehavior = false;
            this.ListViewCurso.View = System.Windows.Forms.View.Details;
            // 
            // IdCurso
            // 
            this.IdCurso.Text = "ID";
            this.IdCurso.Width = 40;
            // 
            // NomeDaInstituicao
            // 
            this.NomeDaInstituicao.Text = "Nome da instituição";
            this.NomeDaInstituicao.Width = 200;
            // 
            // NomeDoCurso
            // 
            this.NomeDoCurso.Text = "Nome do curso";
            this.NomeDoCurso.Width = 200;
            // 
            // Deficiencia
            // 
            this.Deficiencia.Text = "Deficiência";
            this.Deficiencia.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxDeficiencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtBoxNomeDaInstitucao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxNomeDoCurso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(60, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 71);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // TxtBoxDeficiencia
            // 
            this.TxtBoxDeficiencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxDeficiencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxDeficiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxDeficiencia.Location = new System.Drawing.Point(453, 43);
            this.TxtBoxDeficiencia.Name = "TxtBoxDeficiencia";
            this.TxtBoxDeficiencia.Size = new System.Drawing.Size(190, 14);
            this.TxtBoxDeficiencia.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(453, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Deficiência";
            // 
            // TxtBoxNomeDaInstitucao
            // 
            this.TxtBoxNomeDaInstitucao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomeDaInstitucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeDaInstitucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeDaInstitucao.Location = new System.Drawing.Point(8, 43);
            this.TxtBoxNomeDaInstitucao.Name = "TxtBoxNomeDaInstitucao";
            this.TxtBoxNomeDaInstitucao.Size = new System.Drawing.Size(235, 14);
            this.TxtBoxNomeDaInstitucao.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nome da Instituição";
            // 
            // TxtBoxNomeDoCurso
            // 
            this.TxtBoxNomeDoCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomeDoCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeDoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeDoCurso.Location = new System.Drawing.Point(249, 43);
            this.TxtBoxNomeDoCurso.Name = "TxtBoxNomeDoCurso";
            this.TxtBoxNomeDoCurso.Size = new System.Drawing.Size(198, 14);
            this.TxtBoxNomeDoCurso.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(249, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nome do Curso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnExibirBuscarInstituicao);
            this.groupBox3.Controls.Add(this.textBoxBuscarInstituicao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox3.Location = new System.Drawing.Point(60, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(669, 62);
            this.groupBox3.TabIndex = 106;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // BtnExibirBuscarInstituicao
            // 
            this.BtnExibirBuscarInstituicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExibirBuscarInstituicao.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExibirBuscarInstituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExibirBuscarInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibirBuscarInstituicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExibirBuscarInstituicao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExibirBuscarInstituicao.Location = new System.Drawing.Point(530, 31);
            this.BtnExibirBuscarInstituicao.Name = "BtnExibirBuscarInstituicao";
            this.BtnExibirBuscarInstituicao.Size = new System.Drawing.Size(121, 25);
            this.BtnExibirBuscarInstituicao.TabIndex = 107;
            this.BtnExibirBuscarInstituicao.Text = "BUSCAR";
            this.BtnExibirBuscarInstituicao.UseVisualStyleBackColor = false;
            this.BtnExibirBuscarInstituicao.Click += new System.EventHandler(this.BtnExibirBuscarInstituicao_Click);
            // 
            // textBoxBuscarInstituicao
            // 
            this.textBoxBuscarInstituicao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxBuscarInstituicao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBuscarInstituicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBuscarInstituicao.Location = new System.Drawing.Point(6, 40);
            this.textBoxBuscarInstituicao.Name = "textBoxBuscarInstituicao";
            this.textBoxBuscarInstituicao.Size = new System.Drawing.Size(518, 14);
            this.textBoxBuscarInstituicao.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nome da Instituição";
            // 
            // BtnExibirInstituicao
            // 
            this.BtnExibirInstituicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExibirInstituicao.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExibirInstituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExibirInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibirInstituicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExibirInstituicao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExibirInstituicao.Location = new System.Drawing.Point(600, 500);
            this.BtnExibirInstituicao.Name = "BtnExibirInstituicao";
            this.BtnExibirInstituicao.Size = new System.Drawing.Size(121, 25);
            this.BtnExibirInstituicao.TabIndex = 108;
            this.BtnExibirInstituicao.Text = "EXIBIR";
            this.BtnExibirInstituicao.UseVisualStyleBackColor = false;
            this.BtnExibirInstituicao.Click += new System.EventHandler(this.BtnExibirInstituicao_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "LISTA DE CURSOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 110;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 109;
            // 
            // ListaDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnExibirInstituicao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaDeCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListViewCurso;
        private System.Windows.Forms.ColumnHeader IdCurso;
        private System.Windows.Forms.ColumnHeader NomeDaInstituicao;
        private System.Windows.Forms.ColumnHeader NomeDoCurso;
        private System.Windows.Forms.ColumnHeader Deficiencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBoxDeficiencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxNomeDaInstitucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxNomeDoCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxBuscarInstituicao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnExibirBuscarInstituicao;
        private System.Windows.Forms.Button BtnExibirInstituicao;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}