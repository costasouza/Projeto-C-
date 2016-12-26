namespace WindowsFormsApplication3
{
    partial class ConsultaModelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaModelos));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncancela = new System.Windows.Forms.Button();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblalt = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCorPele = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.txtBusto = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtQuadril = new System.Windows.Forms.TextBox();
            this.lblbus = new System.Windows.Forms.Label();
            this.lblman = new System.Windows.Forms.Label();
            this.txtCintura = new System.Windows.Forms.TextBox();
            this.txtManequim = new System.Windows.Forms.TextBox();
            this.lblquad = new System.Windows.Forms.Label();
            this.txtCorCabelo = new System.Windows.Forms.TextBox();
            this.lblco = new System.Windows.Forms.Label();
            this.txtCorolhos = new System.Windows.Forms.TextBox();
            this.lblcin = new System.Windows.Forms.Label();
            this.lblcc = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCodigoModelo);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.btnsair);
            this.GroupBox1.Controls.Add(this.btncancela);
            this.GroupBox1.Controls.Add(this.btnconsulta);
            this.GroupBox1.Controls.Add(this.txtNome);
            this.GroupBox1.Controls.Add(this.lblnome);
            this.GroupBox1.Controls.Add(this.lblalt);
            this.GroupBox1.Controls.Add(this.txtAltura);
            this.GroupBox1.Controls.Add(this.txtCorPele);
            this.GroupBox1.Controls.Add(this.lblpeso);
            this.GroupBox1.Controls.Add(this.lblcp);
            this.GroupBox1.Controls.Add(this.txtBusto);
            this.GroupBox1.Controls.Add(this.txtPeso);
            this.GroupBox1.Controls.Add(this.txtQuadril);
            this.GroupBox1.Controls.Add(this.lblbus);
            this.GroupBox1.Controls.Add(this.lblman);
            this.GroupBox1.Controls.Add(this.txtCintura);
            this.GroupBox1.Controls.Add(this.txtManequim);
            this.GroupBox1.Controls.Add(this.lblquad);
            this.GroupBox1.Controls.Add(this.txtCorCabelo);
            this.GroupBox1.Controls.Add(this.lblco);
            this.GroupBox1.Controls.Add(this.txtCorolhos);
            this.GroupBox1.Controls.Add(this.lblcin);
            this.GroupBox1.Controls.Add(this.lblcc);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(547, 232);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Consulta de Modelos";
            // 
            // txtCodigoModelo
            // 
            this.txtCodigoModelo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoModelo.Location = new System.Drawing.Point(123, 20);
            this.txtCodigoModelo.Name = "txtCodigoModelo";
            this.txtCodigoModelo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigoModelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo da Modelo(a):";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(432, 186);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 12;
            this.btnsair.Text = "Sair:";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncancela
            // 
            this.btncancela.Location = new System.Drawing.Point(210, 186);
            this.btncancela.Name = "btncancela";
            this.btncancela.Size = new System.Drawing.Size(75, 23);
            this.btncancela.TabIndex = 11;
            this.btncancela.Text = "Cancelar:";
            this.btncancela.UseVisualStyleBackColor = true;
            this.btncancela.Click += new System.EventHandler(this.btncancela_Click);
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(12, 186);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(75, 23);
            this.btnconsulta.TabIndex = 2;
            this.btnconsulta.Text = "Consultar:";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(56, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 59);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Location = new System.Drawing.Point(12, 85);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(37, 13);
            this.lblalt.TabIndex = 1;
            this.lblalt.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAltura.Location = new System.Drawing.Point(56, 82);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(54, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // txtCorPele
            // 
            this.txtCorPele.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorPele.Location = new System.Drawing.Point(405, 85);
            this.txtCorPele.Name = "txtCorPele";
            this.txtCorPele.Size = new System.Drawing.Size(83, 20);
            this.txtCorPele.TabIndex = 7;
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(116, 85);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(34, 13);
            this.lblpeso.TabIndex = 2;
            this.lblpeso.Text = "Peso:";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(334, 85);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(65, 13);
            this.lblcp.TabIndex = 9;
            this.lblcp.Text = "Cor da Pele:";
            // 
            // txtBusto
            // 
            this.txtBusto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBusto.Location = new System.Drawing.Point(316, 134);
            this.txtBusto.Name = "txtBusto";
            this.txtBusto.Size = new System.Drawing.Size(83, 20);
            this.txtBusto.TabIndex = 12;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPeso.Location = new System.Drawing.Point(156, 82);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(46, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // txtQuadril
            // 
            this.txtQuadril.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuadril.Location = new System.Drawing.Point(217, 134);
            this.txtQuadril.Name = "txtQuadril";
            this.txtQuadril.Size = new System.Drawing.Size(50, 20);
            this.txtQuadril.TabIndex = 11;
            // 
            // lblbus
            // 
            this.lblbus.AutoSize = true;
            this.lblbus.Location = new System.Drawing.Point(273, 137);
            this.lblbus.Name = "lblbus";
            this.lblbus.Size = new System.Drawing.Size(37, 13);
            this.lblbus.TabIndex = 8;
            this.lblbus.Text = "Busto:";
            // 
            // lblman
            // 
            this.lblman.AutoSize = true;
            this.lblman.Location = new System.Drawing.Point(208, 85);
            this.lblman.Name = "lblman";
            this.lblman.Size = new System.Drawing.Size(59, 13);
            this.lblman.TabIndex = 3;
            this.lblman.Text = "Manequim:";
            // 
            // txtCintura
            // 
            this.txtCintura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCintura.Location = new System.Drawing.Point(94, 134);
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(68, 20);
            this.txtCintura.TabIndex = 10;
            // 
            // txtManequim
            // 
            this.txtManequim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtManequim.Location = new System.Drawing.Point(273, 82);
            this.txtManequim.Name = "txtManequim";
            this.txtManequim.Size = new System.Drawing.Size(50, 20);
            this.txtManequim.TabIndex = 6;
            // 
            // lblquad
            // 
            this.lblquad.AutoSize = true;
            this.lblquad.Location = new System.Drawing.Point(168, 137);
            this.lblquad.Name = "lblquad";
            this.lblquad.Size = new System.Drawing.Size(43, 13);
            this.lblquad.TabIndex = 7;
            this.lblquad.Text = "Quadril:";
            // 
            // txtCorCabelo
            // 
            this.txtCorCabelo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorCabelo.Location = new System.Drawing.Point(291, 108);
            this.txtCorCabelo.Name = "txtCorCabelo";
            this.txtCorCabelo.Size = new System.Drawing.Size(108, 20);
            this.txtCorCabelo.TabIndex = 9;
            // 
            // lblco
            // 
            this.lblco.AutoSize = true;
            this.lblco.Location = new System.Drawing.Point(12, 111);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(76, 13);
            this.lblco.TabIndex = 4;
            this.lblco.Text = "Cor dos Olhos:";
            // 
            // txtCorolhos
            // 
            this.txtCorolhos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorolhos.Location = new System.Drawing.Point(94, 108);
            this.txtCorolhos.Name = "txtCorolhos";
            this.txtCorolhos.Size = new System.Drawing.Size(108, 20);
            this.txtCorolhos.TabIndex = 8;
            // 
            // lblcin
            // 
            this.lblcin.AutoSize = true;
            this.lblcin.Location = new System.Drawing.Point(12, 137);
            this.lblcin.Name = "lblcin";
            this.lblcin.Size = new System.Drawing.Size(43, 13);
            this.lblcin.TabIndex = 6;
            this.lblcin.Text = "Cintura:";
            // 
            // lblcc
            // 
            this.lblcc.AutoSize = true;
            this.lblcc.Location = new System.Drawing.Point(208, 111);
            this.lblcc.Name = "lblcc";
            this.lblcc.Size = new System.Drawing.Size(77, 13);
            this.lblcc.TabIndex = 5;
            this.lblcc.Text = "Cor do Cabelo:";
            // 
            // ConsultaModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 262);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Modelos";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnsair;
        internal System.Windows.Forms.Button btncancela;
        internal System.Windows.Forms.Button btnconsulta;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label lblnome;
        internal System.Windows.Forms.Label lblalt;
        internal System.Windows.Forms.TextBox txtAltura;
        internal System.Windows.Forms.TextBox txtCorPele;
        internal System.Windows.Forms.Label lblpeso;
        internal System.Windows.Forms.Label lblcp;
        internal System.Windows.Forms.TextBox txtBusto;
        internal System.Windows.Forms.TextBox txtPeso;
        internal System.Windows.Forms.TextBox txtQuadril;
        internal System.Windows.Forms.Label lblbus;
        internal System.Windows.Forms.Label lblman;
        internal System.Windows.Forms.TextBox txtCintura;
        internal System.Windows.Forms.TextBox txtManequim;
        internal System.Windows.Forms.Label lblquad;
        internal System.Windows.Forms.TextBox txtCorCabelo;
        internal System.Windows.Forms.Label lblco;
        internal System.Windows.Forms.TextBox txtCorolhos;
        internal System.Windows.Forms.Label lblcin;
        internal System.Windows.Forms.Label lblcc;
        private System.Windows.Forms.TextBox txtCodigoModelo;
        private System.Windows.Forms.Label label1;
    }
}