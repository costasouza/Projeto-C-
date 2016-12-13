namespace WindowsFormsApplication3
{
    partial class FrmCadastroParceiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroParceiros));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbuf = new System.Windows.Forms.ComboBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lbluf = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblrs = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.txtrazao = new System.Windows.Forms.TextBox();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblnr = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblem = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmbuf);
            this.GroupBox1.Controls.Add(this.cmbestado);
            this.GroupBox1.Controls.Add(this.txtcep);
            this.GroupBox1.Controls.Add(this.txtTelefone);
            this.GroupBox1.Controls.Add(this.txtcnpj);
            this.GroupBox1.Controls.Add(this.txtcomplemento);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnsalvar);
            this.GroupBox1.Controls.Add(this.btnsair);
            this.GroupBox1.Controls.Add(this.lbluf);
            this.GroupBox1.Controls.Add(this.btncancelar);
            this.GroupBox1.Controls.Add(this.txtcidade);
            this.GroupBox1.Controls.Add(this.lblrs);
            this.GroupBox1.Controls.Add(this.lblcid);
            this.GroupBox1.Controls.Add(this.txtnumero);
            this.GroupBox1.Controls.Add(this.txtEndereco);
            this.GroupBox1.Controls.Add(this.lblcep);
            this.GroupBox1.Controls.Add(this.txtemail);
            this.GroupBox1.Controls.Add(this.lblnum);
            this.GroupBox1.Controls.Add(this.txtResponsavel);
            this.GroupBox1.Controls.Add(this.txtrazao);
            this.GroupBox1.Controls.Add(this.lblcnpj);
            this.GroupBox1.Controls.Add(this.lblend);
            this.GroupBox1.Controls.Add(this.lblnr);
            this.GroupBox1.Controls.Add(this.lbltel);
            this.GroupBox1.Controls.Add(this.lblem);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 251);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cadastro de Parceiros";
            // 
            // cmbuf
            // 
            this.cmbuf.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbuf.FormattingEnabled = true;
            this.cmbuf.Location = new System.Drawing.Point(443, 154);
            this.cmbuf.Name = "cmbuf";
            this.cmbuf.Size = new System.Drawing.Size(45, 21);
            this.cmbuf.TabIndex = 12;
            // 
            // cmbestado
            // 
            this.cmbestado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(295, 154);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(85, 21);
            this.cmbestado.TabIndex = 11;
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcep.Location = new System.Drawing.Point(43, 156);
            this.txtcep.Mask = "99999-999";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(64, 20);
            this.txtcep.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AsciiOnly = true;
            this.txtTelefone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelefone.Location = new System.Drawing.Point(373, 57);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(122, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TabStop = false;
            // 
            // txtcnpj
            // 
            this.txtcnpj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcnpj.Location = new System.Drawing.Point(347, 27);
            this.txtcnpj.Mask = "000.000.000-00";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(148, 20);
            this.txtcnpj.TabIndex = 2;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcomplemento.Location = new System.Drawing.Point(376, 129);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(126, 20);
            this.txtcomplemento.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(344, 136);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 13);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Comp.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(246, 159);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Estado:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(9, 217);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 13;
            this.btnsalvar.Text = "Salvar:";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(414, 211);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 15;
            this.btnsair.Text = "Sair:";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(413, 159);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(24, 13);
            this.lbluf.TabIndex = 18;
            this.lbluf.Text = "UF:";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(217, 217);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar:";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcidade.Location = new System.Drawing.Point(151, 155);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(88, 20);
            this.txtcidade.TabIndex = 10;
            // 
            // lblrs
            // 
            this.lblrs.AutoSize = true;
            this.lblrs.Location = new System.Drawing.Point(6, 30);
            this.lblrs.Name = "lblrs";
            this.lblrs.Size = new System.Drawing.Size(73, 13);
            this.lblrs.TabIndex = 0;
            this.lblrs.Text = "Razao Social:";
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Location = new System.Drawing.Point(113, 159);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(43, 13);
            this.lblcid.TabIndex = 8;
            this.lblcid.Text = "Cidade:";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnumero.Location = new System.Drawing.Point(301, 130);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(36, 20);
            this.txtnumero.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEndereco.Location = new System.Drawing.Point(61, 127);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(192, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(6, 162);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 6;
            this.lblcep.Text = "CEP:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtemail.Location = new System.Drawing.Point(61, 93);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(289, 20);
            this.txtemail.TabIndex = 5;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(259, 130);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(47, 13);
            this.lblnum.TabIndex = 7;
            this.lblnum.Text = "Numero:";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResponsavel.Location = new System.Drawing.Point(130, 60);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(176, 20);
            this.txtResponsavel.TabIndex = 3;
            // 
            // txtrazao
            // 
            this.txtrazao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtrazao.Location = new System.Drawing.Point(85, 27);
            this.txtrazao.Name = "txtrazao";
            this.txtrazao.Size = new System.Drawing.Size(207, 20);
            this.txtrazao.TabIndex = 1;
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.Location = new System.Drawing.Point(310, 30);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(37, 13);
            this.lblcnpj.TabIndex = 5;
            this.lblcnpj.Text = "CNPJ:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(6, 130);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(56, 13);
            this.lblend.TabIndex = 4;
            this.lblend.Text = "Endereço:";
            // 
            // lblnr
            // 
            this.lblnr.AutoSize = true;
            this.lblnr.Location = new System.Drawing.Point(6, 63);
            this.lblnr.Name = "lblnr";
            this.lblnr.Size = new System.Drawing.Size(118, 13);
            this.lblnr.TabIndex = 3;
            this.lblnr.Text = "Nome do Responsavel:";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(317, 60);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(52, 13);
            this.lbltel.TabIndex = 2;
            this.lbltel.Text = "Telefone:";
            // 
            // lblem
            // 
            this.lblem.AutoSize = true;
            this.lblem.Location = new System.Drawing.Point(6, 96);
            this.lblem.Name = "lblem";
            this.lblem.Size = new System.Drawing.Size(38, 13);
            this.lblem.TabIndex = 1;
            this.lblem.Text = "E-mail:";
            // 
            // FrmCadastroParceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 275);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroParceiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Parceiros";
            this.Load += new System.EventHandler(this.FrmCadastroParceiros_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cmbuf;
        internal System.Windows.Forms.ComboBox cmbestado;
        internal System.Windows.Forms.MaskedTextBox txtcep;
        internal System.Windows.Forms.MaskedTextBox txtTelefone;
        internal System.Windows.Forms.MaskedTextBox txtcnpj;
        internal System.Windows.Forms.TextBox txtcomplemento;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnsalvar;
        internal System.Windows.Forms.Button btnsair;
        internal System.Windows.Forms.Label lbluf;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.TextBox txtcidade;
        internal System.Windows.Forms.Label lblrs;
        internal System.Windows.Forms.Label lblcid;
        internal System.Windows.Forms.TextBox txtnumero;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.Label lblcep;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Label lblnum;
        internal System.Windows.Forms.TextBox txtResponsavel;
        internal System.Windows.Forms.TextBox txtrazao;
        internal System.Windows.Forms.Label lblcnpj;
        internal System.Windows.Forms.Label lblend;
        internal System.Windows.Forms.Label lblnr;
        internal System.Windows.Forms.Label lbltel;
        internal System.Windows.Forms.Label lblem;
    }
}