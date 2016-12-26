namespace WindowsFormsApplication3
{
    partial class CadastroModeloFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroModeloFisico));
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.combotipocabelo = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.combocabelo = new System.Windows.Forms.ComboBox();
            this.comboOlho = new System.Windows.Forms.ComboBox();
            this.combopele = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblalt = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.btnsal = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnanex = new System.Windows.Forms.Button();
            this.lblman = new System.Windows.Forms.Label();
            this.txtManequim = new System.Windows.Forms.TextBox();
            this.txtBusto = new System.Windows.Forms.TextBox();
            this.lblco = new System.Windows.Forms.Label();
            this.lblbus = new System.Windows.Forms.Label();
            this.txtQuadril = new System.Windows.Forms.TextBox();
            this.txtCintura = new System.Windows.Forms.TextBox();
            this.lblquad = new System.Windows.Forms.Label();
            this.lblcc = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.File = new System.Windows.Forms.OpenFileDialog();
            this.btnsair = new System.Windows.Forms.Button();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(74, 19);
            this.txtAltura.Mask = "9.99";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(51, 20);
            this.txtAltura.TabIndex = 1;
            // 
            // combotipocabelo
            // 
            this.combotipocabelo.FormattingEnabled = true;
            this.combotipocabelo.Location = new System.Drawing.Point(351, 77);
            this.combotipocabelo.Name = "combotipocabelo";
            this.combotipocabelo.Size = new System.Drawing.Size(98, 21);
            this.combotipocabelo.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(265, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Tipo De Cabelo";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(28, 132);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(171, 147);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 24;
            this.pbFoto.TabStop = false;
            // 
            // combocabelo
            // 
            this.combocabelo.FormattingEnabled = true;
            this.combocabelo.Location = new System.Drawing.Point(352, 50);
            this.combocabelo.Name = "combocabelo";
            this.combocabelo.Size = new System.Drawing.Size(97, 21);
            this.combocabelo.TabIndex = 8;
            // 
            // comboOlho
            // 
            this.comboOlho.FormattingEnabled = true;
            this.comboOlho.Location = new System.Drawing.Point(352, 106);
            this.comboOlho.Name = "comboOlho";
            this.comboOlho.Size = new System.Drawing.Size(98, 21);
            this.comboOlho.TabIndex = 10;
            // 
            // combopele
            // 
            this.combopele.FormattingEnabled = true;
            this.combopele.Location = new System.Drawing.Point(352, 19);
            this.combopele.Name = "combopele";
            this.combopele.Size = new System.Drawing.Size(98, 21);
            this.combopele.TabIndex = 7;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtAltura);
            this.GroupBox1.Controls.Add(this.combotipocabelo);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.pbFoto);
            this.GroupBox1.Controls.Add(this.combocabelo);
            this.GroupBox1.Controls.Add(this.comboOlho);
            this.GroupBox1.Controls.Add(this.combopele);
            this.GroupBox1.Controls.Add(this.lblalt);
            this.GroupBox1.Controls.Add(this.lblpeso);
            this.GroupBox1.Controls.Add(this.btnsal);
            this.GroupBox1.Controls.Add(this.txtPeso);
            this.GroupBox1.Controls.Add(this.btnanex);
            this.GroupBox1.Controls.Add(this.lblman);
            this.GroupBox1.Controls.Add(this.txtManequim);
            this.GroupBox1.Controls.Add(this.txtBusto);
            this.GroupBox1.Controls.Add(this.lblco);
            this.GroupBox1.Controls.Add(this.lblbus);
            this.GroupBox1.Controls.Add(this.txtQuadril);
            this.GroupBox1.Controls.Add(this.txtCintura);
            this.GroupBox1.Controls.Add(this.lblquad);
            this.GroupBox1.Controls.Add(this.lblcc);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.lblcp);
            this.GroupBox1.Location = new System.Drawing.Point(12, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(462, 285);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Dados Fisicos";
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Location = new System.Drawing.Point(14, 23);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(54, 13);
            this.lblalt.TabIndex = 0;
            this.lblalt.Text = "Altura (m):";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(163, 22);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(34, 13);
            this.lblpeso.TabIndex = 1;
            this.lblpeso.Text = "Peso:";
            // 
            // btnsal
            // 
            this.btnsal.Location = new System.Drawing.Point(375, 259);
            this.btnsal.Name = "btnsal";
            this.btnsal.Size = new System.Drawing.Size(75, 23);
            this.btnsal.TabIndex = 12;
            this.btnsal.Text = "Salvar:";
            this.btnsal.UseVisualStyleBackColor = true;
            this.btnsal.Click += new System.EventHandler(this.btnsal_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(203, 16);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(57, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // btnanex
            // 
            this.btnanex.Location = new System.Drawing.Point(294, 259);
            this.btnanex.Name = "btnanex";
            this.btnanex.Size = new System.Drawing.Size(75, 23);
            this.btnanex.TabIndex = 11;
            this.btnanex.Text = "Anexar:";
            this.btnanex.UseVisualStyleBackColor = true;
            this.btnanex.Click += new System.EventHandler(this.btnanex_Click);
            // 
            // lblman
            // 
            this.lblman.AutoSize = true;
            this.lblman.Location = new System.Drawing.Point(138, 54);
            this.lblman.Name = "lblman";
            this.lblman.Size = new System.Drawing.Size(59, 13);
            this.lblman.TabIndex = 2;
            this.lblman.Text = "Manequim:";
            // 
            // txtManequim
            // 
            this.txtManequim.Location = new System.Drawing.Point(203, 47);
            this.txtManequim.Name = "txtManequim";
            this.txtManequim.Size = new System.Drawing.Size(57, 20);
            this.txtManequim.TabIndex = 5;
            // 
            // txtBusto
            // 
            this.txtBusto.Location = new System.Drawing.Point(201, 87);
            this.txtBusto.Name = "txtBusto";
            this.txtBusto.Size = new System.Drawing.Size(58, 20);
            this.txtBusto.TabIndex = 6;
            // 
            // lblco
            // 
            this.lblco.AutoSize = true;
            this.lblco.Location = new System.Drawing.Point(270, 114);
            this.lblco.Name = "lblco";
            this.lblco.Size = new System.Drawing.Size(76, 13);
            this.lblco.TabIndex = 3;
            this.lblco.Text = "Cor dos Olhos:";
            // 
            // lblbus
            // 
            this.lblbus.AutoSize = true;
            this.lblbus.Location = new System.Drawing.Point(160, 94);
            this.lblbus.Name = "lblbus";
            this.lblbus.Size = new System.Drawing.Size(37, 13);
            this.lblbus.TabIndex = 8;
            this.lblbus.Text = "Busto:";
            // 
            // txtQuadril
            // 
            this.txtQuadril.Location = new System.Drawing.Point(74, 51);
            this.txtQuadril.Name = "txtQuadril";
            this.txtQuadril.Size = new System.Drawing.Size(51, 20);
            this.txtQuadril.TabIndex = 2;
            // 
            // txtCintura
            // 
            this.txtCintura.Location = new System.Drawing.Point(74, 87);
            this.txtCintura.Name = "txtCintura";
            this.txtCintura.Size = new System.Drawing.Size(51, 20);
            this.txtCintura.TabIndex = 3;
            // 
            // lblquad
            // 
            this.lblquad.AutoSize = true;
            this.lblquad.Location = new System.Drawing.Point(19, 58);
            this.lblquad.Name = "lblquad";
            this.lblquad.Size = new System.Drawing.Size(43, 13);
            this.lblquad.TabIndex = 7;
            this.lblquad.Text = "Quadril:";
            // 
            // lblcc
            // 
            this.lblcc.AutoSize = true;
            this.lblcc.Location = new System.Drawing.Point(269, 58);
            this.lblcc.Name = "lblcc";
            this.lblcc.Size = new System.Drawing.Size(77, 13);
            this.lblcc.TabIndex = 4;
            this.lblcc.Text = "Cor do Cabelo:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(25, 94);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Cintura:";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(281, 27);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(65, 13);
            this.lblcp.TabIndex = 5;
            this.lblcp.Text = "Cor da Pele:";
            // 
            // File
            // 
            this.File.FileName = "file";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(252, 216);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 24;
            this.btnsair.Text = "Sair:";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // CadastroModeloFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 298);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnsair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroModeloFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fisico  Modelo";
            this.Load += new System.EventHandler(this.CadastroModeloFisico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.MaskedTextBox txtAltura;
        internal System.Windows.Forms.ComboBox combotipocabelo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox pbFoto;
        internal System.Windows.Forms.ComboBox combocabelo;
        internal System.Windows.Forms.ComboBox comboOlho;
        internal System.Windows.Forms.ComboBox combopele;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblalt;
        internal System.Windows.Forms.Label lblpeso;
        internal System.Windows.Forms.Button btnsal;
        internal System.Windows.Forms.TextBox txtPeso;
        internal System.Windows.Forms.Button btnanex;
        internal System.Windows.Forms.Label lblman;
        internal System.Windows.Forms.TextBox txtManequim;
        internal System.Windows.Forms.TextBox txtBusto;
        internal System.Windows.Forms.Label lblco;
        internal System.Windows.Forms.Label lblbus;
        internal System.Windows.Forms.TextBox txtQuadril;
        internal System.Windows.Forms.TextBox txtCintura;
        internal System.Windows.Forms.Label lblquad;
        internal System.Windows.Forms.Label lblcc;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lblcp;
        internal System.Windows.Forms.OpenFileDialog File;
        internal System.Windows.Forms.Button btnsair;
        internal System.Windows.Forms.HelpProvider HelpProvider1;
    }
}