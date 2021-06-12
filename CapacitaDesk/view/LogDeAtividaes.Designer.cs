
namespace CapacitaDesk {
    partial class LogDeAtividaes {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogDeAtividaes));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListViewAtividade = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.NomeDoAdministrador = new System.Windows.Forms.ColumnHeader();
            this.logAtividade = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarAtividade = new System.Windows.Forms.Button();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.idAtividade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.PictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 69);
            this.panel1.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 59);
            this.panel2.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOG DE ATIVIDADES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListViewAtividade);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox2.Location = new System.Drawing.Point(78, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 335);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro de atividades";
            // 
            // ListViewAtividade
            // 
            this.ListViewAtividade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ListViewAtividade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Data,
            this.NomeDoAdministrador,
            this.logAtividade});
            this.ListViewAtividade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListViewAtividade.HideSelection = false;
            this.ListViewAtividade.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListViewAtividade.Location = new System.Drawing.Point(11, 24);
            this.ListViewAtividade.Name = "ListViewAtividade";
            this.ListViewAtividade.Size = new System.Drawing.Size(618, 303);
            this.ListViewAtividade.TabIndex = 1;
            this.ListViewAtividade.UseCompatibleStateImageBehavior = false;
            this.ListViewAtividade.View = System.Windows.Forms.View.Details;
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
            // NomeDoAdministrador
            // 
            this.NomeDoAdministrador.Text = "Nome do Administrador";
            this.NomeDoAdministrador.Width = 200;
            // 
            // logAtividade
            // 
            this.logAtividade.Text = "Log Atividade";
            this.logAtividade.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscarAtividade);
            this.groupBox1.Controls.Add(this.TxtBoxID);
            this.groupBox1.Controls.Add(this.idAtividade);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.groupBox1.Location = new System.Drawing.Point(457, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 74);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // BtnBuscarAtividade
            // 
            this.BtnBuscarAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.BtnBuscarAtividade.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBuscarAtividade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.BtnBuscarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAtividade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscarAtividade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscarAtividade.Location = new System.Drawing.Point(142, 29);
            this.BtnBuscarAtividade.Name = "BtnBuscarAtividade";
            this.BtnBuscarAtividade.Size = new System.Drawing.Size(112, 35);
            this.BtnBuscarAtividade.TabIndex = 107;
            this.BtnBuscarAtividade.Text = "BUSCAR";
            this.BtnBuscarAtividade.UseVisualStyleBackColor = false;
            this.BtnBuscarAtividade.Click += new System.EventHandler(this.BtnBuscarAtividade_Click);
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxID.Location = new System.Drawing.Point(21, 39);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(115, 14);
            this.TxtBoxID.TabIndex = 98;
            this.TxtBoxID.TextChanged += new System.EventHandler(this.TxtBoxID_TextChanged);
            this.TxtBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxID_KeyPress);
            // 
            // idAtividade
            // 
            this.idAtividade.AutoSize = true;
            this.idAtividade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.idAtividade.Location = new System.Drawing.Point(21, 20);
            this.idAtividade.Name = "idAtividade";
            this.idAtividade.Size = new System.Drawing.Size(21, 17);
            this.idAtividade.TabIndex = 73;
            this.idAtividade.Text = "ID";
            // 
            // LogDeAtividaes
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
            this.Name = "LogDeAtividaes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacita Desk";
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
        private System.Windows.Forms.ListView ListViewAtividade;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader NomeDoAdministrador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscarAtividade;
        private System.Windows.Forms.Label idAtividade;
        private System.Windows.Forms.TextBox TxtBoxID;
        private System.Windows.Forms.ColumnHeader logAtividade;
    }
}