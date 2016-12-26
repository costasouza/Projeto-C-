namespace WindowsFormsApplication3
{
    partial class FrmColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColaboradores));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedRG = new System.Windows.Forms.MaskedTextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblnas = new System.Windows.Forms.Label();
            this.MaskNascimento = new System.Windows.Forms.DateTimePicker();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbluf = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.lblend = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblcar = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            this.lblem = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox1.Controls.Add(this.maskedCEP);
            this.GroupBox1.Controls.Add(this.maskedTELEFONE);
            this.GroupBox1.Controls.Add(this.maskedCPF);
            this.GroupBox1.Controls.Add(this.maskedRG);
            this.GroupBox1.Controls.Add(this.txtcidade);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblnas);
            this.GroupBox1.Controls.Add(this.MaskNascimento);
            this.GroupBox1.Controls.Add(this.cmbUF);
            this.GroupBox1.Controls.Add(this.cmbestado);
            this.GroupBox1.Controls.Add(this.btnLimpar);
            this.GroupBox1.Controls.Add(this.btnCancelar);
            this.GroupBox1.Controls.Add(this.lbluf);
            this.GroupBox1.Controls.Add(this.btnSalvar);
            this.GroupBox1.Controls.Add(this.lblnome);
            this.GroupBox1.Controls.Add(this.txtNome);
            this.GroupBox1.Controls.Add(this.lblcid);
            this.GroupBox1.Controls.Add(this.lblrg);
            this.GroupBox1.Controls.Add(this.txtnumero);
            this.GroupBox1.Controls.Add(this.txtEndereco);
            this.GroupBox1.Controls.Add(this.lblcep);
            this.GroupBox1.Controls.Add(this.lblnum);
            this.GroupBox1.Controls.Add(this.txtemail);
            this.GroupBox1.Controls.Add(this.txtProfissao);
            this.GroupBox1.Controls.Add(this.lblend);
            this.GroupBox1.Controls.Add(this.txtcargo);
            this.GroupBox1.Controls.Add(this.lbltel);
            this.GroupBox1.Controls.Add(this.lblcpf);
            this.GroupBox1.Controls.Add(this.lblcar);
            this.GroupBox1.Controls.Add(this.lblpro);
            this.GroupBox1.Controls.Add(this.lblem);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(472, 261);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cadastro de Colaboradores";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // maskedCEP
            // 
            this.maskedCEP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedCEP.Location = new System.Drawing.Point(34, 189);
            this.maskedCEP.Mask = "00000-000";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(69, 20);
            this.maskedCEP.TabIndex = 11;
            // 
            // maskedTELEFONE
            // 
            this.maskedTELEFONE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTELEFONE.Location = new System.Drawing.Point(321, 123);
            this.maskedTELEFONE.Mask = "0000-0000";
            this.maskedTELEFONE.Name = "maskedTELEFONE";
            this.maskedTELEFONE.Size = new System.Drawing.Size(100, 20);
            this.maskedTELEFONE.TabIndex = 8;
            // 
            // maskedCPF
            // 
            this.maskedCPF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedCPF.Location = new System.Drawing.Point(182, 57);
            this.maskedCPF.Mask = "000.000.000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF.TabIndex = 3;
            // 
            // maskedRG
            // 
            this.maskedRG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedRG.Location = new System.Drawing.Point(50, 58);
            this.maskedRG.Mask = "00.000.000-00";
            this.maskedRG.Name = "maskedRG";
            this.maskedRG.Size = new System.Drawing.Size(91, 20);
            this.maskedRG.TabIndex = 2;
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcidade.Location = new System.Drawing.Point(150, 192);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(68, 20);
            this.txtcidade.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(224, 196);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Estado";
            // 
            // lblnas
            // 
            this.lblnas.AutoSize = true;
            this.lblnas.Location = new System.Drawing.Point(290, 64);
            this.lblnas.Name = "lblnas";
            this.lblnas.Size = new System.Drawing.Size(63, 13);
            this.lblnas.TabIndex = 37;
            this.lblnas.Text = "Nascimento";
            // 
            // MaskNascimento
            // 
            this.MaskNascimento.CalendarFont = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaskNascimento.CustomFormat = "\"DD-MM-YYYY\"";
            this.MaskNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MaskNascimento.Location = new System.Drawing.Point(359, 61);
            this.MaskNascimento.Name = "MaskNascimento";
            this.MaskNascimento.Size = new System.Drawing.Size(87, 20);
            this.MaskNascimento.TabIndex = 4;
            this.MaskNascimento.Value = new System.DateTime(2014, 12, 27, 0, 0, 0, 0);
            // 
            // cmbUF
            // 
            this.cmbUF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Location = new System.Drawing.Point(397, 196);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(49, 21);
            this.cmbUF.TabIndex = 14;
            // 
            // cmbestado
            // 
            this.cmbestado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(266, 193);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(104, 21);
            this.cmbestado.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(378, 232);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar:";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(182, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar:";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(367, 199);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(24, 13);
            this.lbluf.TabIndex = 24;
            this.lbluf.Text = "UF:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 230);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar:";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 29);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(50, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(396, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Location = new System.Drawing.Point(109, 196);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(43, 13);
            this.lblcid.TabIndex = 23;
            this.lblcid.Text = "Cidade:";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(6, 64);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(26, 13);
            this.lblrg.TabIndex = 1;
            this.lblrg.Text = "RG:";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnumero.Location = new System.Drawing.Point(255, 159);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(60, 20);
            this.txtnumero.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEndereco.Location = new System.Drawing.Point(68, 159);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(128, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(6, 196);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 22;
            this.lblcep.Text = "CEP:";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(202, 162);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(47, 13);
            this.lblnum.TabIndex = 8;
            this.lblnum.Text = "Numero:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtemail.Location = new System.Drawing.Point(50, 127);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(207, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtProfissao
            // 
            this.txtProfissao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtProfissao.Location = new System.Drawing.Point(242, 92);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(117, 20);
            this.txtProfissao.TabIndex = 6;
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(6, 162);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(56, 13);
            this.lblend.TabIndex = 7;
            this.lblend.Text = "Endereço:";
            // 
            // txtcargo
            // 
            this.txtcargo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcargo.Location = new System.Drawing.Point(50, 92);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(127, 20);
            this.txtcargo.TabIndex = 5;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(263, 130);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(52, 13);
            this.lbltel.TabIndex = 6;
            this.lbltel.Text = "Telefone:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(147, 61);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF:";
            // 
            // lblcar
            // 
            this.lblcar.AutoSize = true;
            this.lblcar.Location = new System.Drawing.Point(6, 95);
            this.lblcar.Name = "lblcar";
            this.lblcar.Size = new System.Drawing.Size(38, 13);
            this.lblcar.TabIndex = 3;
            this.lblcar.Text = "Cargo:";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Location = new System.Drawing.Point(183, 95);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(53, 13);
            this.lblpro.TabIndex = 4;
            this.lblpro.Text = "Profissao:";
            // 
            // lblem
            // 
            this.lblem.AutoSize = true;
            this.lblem.Location = new System.Drawing.Point(6, 130);
            this.lblem.Name = "lblem";
            this.lblem.Size = new System.Drawing.Size(38, 13);
            this.lblem.TabIndex = 5;
            this.lblem.Text = "E-mail:";
            // 
            // FrmColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 285);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Colaboradores";
            this.Load += new System.EventHandler(this.FrmColaboradores_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtcidade;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblnas;
        internal System.Windows.Forms.DateTimePicker MaskNascimento;
        internal System.Windows.Forms.ComboBox cmbUF;
        internal System.Windows.Forms.ComboBox cmbestado;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Label lbluf;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.Label lblnome;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label lblcid;
        internal System.Windows.Forms.Label lblrg;
        internal System.Windows.Forms.TextBox txtnumero;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label lblcep;
        internal System.Windows.Forms.Label lblnum;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.TextBox txtProfissao;
        internal System.Windows.Forms.Label lblend;
        internal System.Windows.Forms.TextBox txtcargo;
        internal System.Windows.Forms.Label lbltel;
        internal System.Windows.Forms.Label lblcpf;
        internal System.Windows.Forms.Label lblcar;
        internal System.Windows.Forms.Label lblpro;
        internal System.Windows.Forms.Label lblem;
        internal System.Windows.Forms.MaskedTextBox maskedRG;
        public System.Windows.Forms.MaskedTextBox maskedCPF;
        internal System.Windows.Forms.MaskedTextBox maskedTELEFONE;
        internal System.Windows.Forms.MaskedTextBox maskedCEP;
    }
}