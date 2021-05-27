
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeCurso));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewCurso = new System.Windows.Forms.ListView();
            this.IdCurso = new System.Windows.Forms.ColumnHeader();
            this.NomeDaInstituicao = new System.Windows.Forms.ColumnHeader();
            this.NomeDoCurso = new System.Windows.Forms.ColumnHeader();
            this.Deficiencia = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxNomeDaInstitucao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxNomeDoCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFiltroCurso = new System.Windows.Forms.Button();
            this.BtnExibirInstituicao = new System.Windows.Forms.Button();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxMudez = new System.Windows.Forms.CheckBox();
            this.checkBoxFisico = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxAuditivo = new System.Windows.Forms.CheckBox();
            this.checkBoxMental = new System.Windows.Forms.CheckBox();
            this.checkBoxVisual = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewCurso);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(58, 291);
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
            listViewItem2});
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
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.BtnFiltroCurso);
            this.groupBox1.Controls.Add(this.TxtBoxNomeDaInstitucao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBoxNomeDoCurso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(58, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 141);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // TxtBoxNomeDaInstitucao
            // 
            this.TxtBoxNomeDaInstitucao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomeDaInstitucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeDaInstitucao.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeDaInstitucao.Location = new System.Drawing.Point(8, 51);
            this.TxtBoxNomeDaInstitucao.Name = "TxtBoxNomeDaInstitucao";
            this.TxtBoxNomeDaInstitucao.Size = new System.Drawing.Size(259, 15);
            this.TxtBoxNomeDaInstitucao.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nome da Instituição";
            // 
            // TxtBoxNomeDoCurso
            // 
            this.TxtBoxNomeDoCurso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxNomeDoCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxNomeDoCurso.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeDoCurso.Location = new System.Drawing.Point(8, 98);
            this.TxtBoxNomeDoCurso.Name = "TxtBoxNomeDoCurso";
            this.TxtBoxNomeDoCurso.Size = new System.Drawing.Size(259, 15);
            this.TxtBoxNomeDoCurso.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nome do Curso";
            // 
            // BtnFiltroCurso
            // 
            this.BtnFiltroCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnFiltroCurso.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnFiltroCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnFiltroCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltroCurso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFiltroCurso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnFiltroCurso.Location = new System.Drawing.Point(542, 105);
            this.BtnFiltroCurso.Name = "BtnFiltroCurso";
            this.BtnFiltroCurso.Size = new System.Drawing.Size(121, 25);
            this.BtnFiltroCurso.TabIndex = 107;
            this.BtnFiltroCurso.Text = "BUSCAR";
            this.BtnFiltroCurso.UseVisualStyleBackColor = false;
            // 
            // BtnExibirInstituicao
            // 
            this.BtnExibirInstituicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnExibirInstituicao.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExibirInstituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnExibirInstituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExibirInstituicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExibirInstituicao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExibirInstituicao.Location = new System.Drawing.Point(598, 509);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel3.Controls.Add(this.checkBoxMudez);
            this.panel3.Controls.Add(this.checkBoxFisico);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.checkBoxAuditivo);
            this.panel3.Controls.Add(this.checkBoxMental);
            this.panel3.Controls.Add(this.checkBoxVisual);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(284, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 107);
            this.panel3.TabIndex = 78;
            // 
            // checkBoxMudez
            // 
            this.checkBoxMudez.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMudez.AutoSize = true;
            this.checkBoxMudez.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxMudez.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.checkBoxMudez.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.checkBoxMudez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMudez.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMudez.ForeColor = System.Drawing.Color.White;
            this.checkBoxMudez.Location = new System.Drawing.Point(101, 31);
            this.checkBoxMudez.Name = "checkBoxMudez";
            this.checkBoxMudez.Size = new System.Drawing.Size(59, 27);
            this.checkBoxMudez.TabIndex = 35;
            this.checkBoxMudez.Text = "Mudez";
            this.checkBoxMudez.UseVisualStyleBackColor = true;
            // 
            // checkBoxFisico
            // 
            this.checkBoxFisico.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxFisico.AutoSize = true;
            this.checkBoxFisico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxFisico.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.checkBoxFisico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.checkBoxFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFisico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFisico.ForeColor = System.Drawing.Color.White;
            this.checkBoxFisico.Location = new System.Drawing.Point(177, 31);
            this.checkBoxFisico.Name = "checkBoxFisico";
            this.checkBoxFisico.Size = new System.Drawing.Size(53, 27);
            this.checkBoxFisico.TabIndex = 36;
            this.checkBoxFisico.Text = "Físico";
            this.checkBoxFisico.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 38;
            this.label11.Text = "Deficiência:";
            // 
            // checkBoxAuditivo
            // 
            this.checkBoxAuditivo.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAuditivo.AutoSize = true;
            this.checkBoxAuditivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxAuditivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.checkBoxAuditivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.checkBoxAuditivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAuditivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAuditivo.ForeColor = System.Drawing.Color.White;
            this.checkBoxAuditivo.Location = new System.Drawing.Point(14, 31);
            this.checkBoxAuditivo.Name = "checkBoxAuditivo";
            this.checkBoxAuditivo.Size = new System.Drawing.Size(71, 27);
            this.checkBoxAuditivo.TabIndex = 32;
            this.checkBoxAuditivo.Text = "Auditivo";
            this.checkBoxAuditivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxMental
            // 
            this.checkBoxMental.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMental.AutoSize = true;
            this.checkBoxMental.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxMental.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.checkBoxMental.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.checkBoxMental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMental.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMental.ForeColor = System.Drawing.Color.White;
            this.checkBoxMental.Location = new System.Drawing.Point(14, 67);
            this.checkBoxMental.Name = "checkBoxMental";
            this.checkBoxMental.Size = new System.Drawing.Size(73, 27);
            this.checkBoxMental.TabIndex = 33;
            this.checkBoxMental.Text = "Mental   ";
            this.checkBoxMental.UseVisualStyleBackColor = true;
            // 
            // checkBoxVisual
            // 
            this.checkBoxVisual.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxVisual.AutoSize = true;
            this.checkBoxVisual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxVisual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Tomato;
            this.checkBoxVisual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.checkBoxVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxVisual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVisual.ForeColor = System.Drawing.Color.White;
            this.checkBoxVisual.Location = new System.Drawing.Point(101, 67);
            this.checkBoxVisual.Name = "checkBoxVisual";
            this.checkBoxVisual.Size = new System.Drawing.Size(56, 27);
            this.checkBoxVisual.TabIndex = 34;
            this.checkBoxVisual.Text = "Visual";
            this.checkBoxVisual.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaDeCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox TxtBoxNomeDaInstitucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxNomeDoCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFiltroCurso;
        private System.Windows.Forms.Button BtnExibirInstituicao;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxMudez;
        private System.Windows.Forms.CheckBox checkBoxFisico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxAuditivo;
        private System.Windows.Forms.CheckBox checkBoxMental;
        private System.Windows.Forms.CheckBox checkBoxVisual;
    }
}