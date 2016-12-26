namespace WindowsFormsApplication3
{
    partial class CadastroModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroModelos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedCEP = new System.Windows.Forms.MaskedTextBox();
            this.maskedCELULAR = new System.Windows.Forms.MaskedTextBox();
            this.maskedTELEFONE = new System.Windows.Forms.MaskedTextBox();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedRG = new System.Windows.Forms.MaskedTextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DateTimeNASCIMENTO = new System.Windows.Forms.DateTimePicker();
            this.lblnas = new System.Windows.Forms.Label();
            this.txtCOMPLEMENTO = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblest = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbluf = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.lblcid = new System.Windows.Forms.Label();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.CheckBoxMenorIdade = new System.Windows.Forms.CheckBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtNUMERO = new System.Windows.Forms.TextBox();
            this.txtENDERECO = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.PanelResponsavel = new System.Windows.Forms.Panel();
            this.maskedCPF_Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.maskedRG_Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.lblnr = new System.Windows.Forms.Label();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.lblrg1 = new System.Windows.Forms.Label();
            this.lblcpf1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PanelResponsavel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedCEP);
            this.groupBox1.Controls.Add(this.maskedCELULAR);
            this.groupBox1.Controls.Add(this.maskedTELEFONE);
            this.groupBox1.Controls.Add(this.maskedCPF);
            this.groupBox1.Controls.Add(this.maskedRG);
            this.groupBox1.Controls.Add(this.txtEMAIL);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.lblCel);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.comboSexo);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.DateTimeNASCIMENTO);
            this.groupBox1.Controls.Add(this.lblnas);
            this.groupBox1.Controls.Add(this.txtCOMPLEMENTO);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.comboUF);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.lblest);
            this.groupBox1.Controls.Add(this.btnsair);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.lbluf);
            this.groupBox1.Controls.Add(this.btnsalvar);
            this.groupBox1.Controls.Add(this.lblcid);
            this.groupBox1.Controls.Add(this.txtCIDADE);
            this.groupBox1.Controls.Add(this.CheckBoxMenorIdade);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblrg);
            this.groupBox1.Controls.Add(this.lblcep);
            this.groupBox1.Controls.Add(this.txtNUMERO);
            this.groupBox1.Controls.Add(this.txtENDERECO);
            this.groupBox1.Controls.Add(this.lblnum);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.lblend);
            this.groupBox1.Controls.Add(this.PanelResponsavel);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // maskedCEP
            // 
            this.maskedCEP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedCEP.Location = new System.Drawing.Point(13, 266);
            this.maskedCEP.Mask = "00000-000";
            this.maskedCEP.Name = "maskedCEP";
            this.maskedCEP.Size = new System.Drawing.Size(93, 20);
            this.maskedCEP.TabIndex = 16;
            // 
            // maskedCELULAR
            // 
            this.maskedCELULAR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedCELULAR.Location = new System.Drawing.Point(83, 188);
            this.maskedCELULAR.Mask = "(99) 00000-0000";
            this.maskedCELULAR.Name = "maskedCELULAR";
            this.maskedCELULAR.Size = new System.Drawing.Size(100, 20);
            this.maskedCELULAR.TabIndex = 11;
            // 
            // maskedTELEFONE
            // 
            this.maskedTELEFONE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedTELEFONE.Location = new System.Drawing.Point(83, 157);
            this.maskedTELEFONE.Mask = "0000-0000";
            this.maskedTELEFONE.Name = "maskedTELEFONE";
            this.maskedTELEFONE.Size = new System.Drawing.Size(100, 20);
            this.maskedTELEFONE.TabIndex = 10;
            // 
            // maskedCPF
            // 
            this.maskedCPF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedCPF.Location = new System.Drawing.Point(145, 52);
            this.maskedCPF.Mask = "000.000.000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF.TabIndex = 4;
            // 
            // maskedRG
            // 
            this.maskedRG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedRG.Location = new System.Drawing.Point(17, 52);
            this.maskedRG.Mask = "00.000.000-00";
            this.maskedRG.Name = "maskedRG";
            this.maskedRG.Size = new System.Drawing.Size(110, 20);
            this.maskedRG.TabIndex = 3;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEMAIL.Location = new System.Drawing.Point(199, 183);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(268, 20);
            this.txtEMAIL.TabIndex = 12;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(303, 157);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 13);
            this.Label4.TabIndex = 77;
            this.Label4.Text = "E-Mail";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.CausesValidation = false;
            this.lblCel.Location = new System.Drawing.Point(22, 188);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(42, 13);
            this.lblCel.TabIndex = 76;
            this.lblCel.Text = "Celular:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 157);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 75;
            this.Label3.Text = "Telefone:";
            // 
            // comboSexo
            // 
            this.comboSexo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Location = new System.Drawing.Point(372, 14);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(95, 21);
            this.comboSexo.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(331, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 73;
            this.Label2.Text = "Sexo:";
            // 
            // DateTimeNASCIMENTO
            // 
            this.DateTimeNASCIMENTO.CalendarFont = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeNASCIMENTO.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.DateTimeNASCIMENTO.CustomFormat = "";
            this.DateTimeNASCIMENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeNASCIMENTO.Location = new System.Drawing.Point(255, 52);
            this.DateTimeNASCIMENTO.Name = "DateTimeNASCIMENTO";
            this.DateTimeNASCIMENTO.Size = new System.Drawing.Size(105, 20);
            this.DateTimeNASCIMENTO.TabIndex = 5;
            this.DateTimeNASCIMENTO.Value = new System.DateTime(2016, 4, 21, 0, 0, 0, 0);
            // 
            // lblnas
            // 
            this.lblnas.AutoSize = true;
            this.lblnas.Location = new System.Drawing.Point(279, 36);
            this.lblnas.Name = "lblnas";
            this.lblnas.Size = new System.Drawing.Size(63, 13);
            this.lblnas.TabIndex = 71;
            this.lblnas.Text = "Nascimento";
            // 
            // txtCOMPLEMENTO
            // 
            this.txtCOMPLEMENTO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCOMPLEMENTO.Location = new System.Drawing.Point(331, 227);
            this.txtCOMPLEMENTO.Name = "txtCOMPLEMENTO";
            this.txtCOMPLEMENTO.Size = new System.Drawing.Size(100, 20);
            this.txtCOMPLEMENTO.TabIndex = 15;
            this.txtCOMPLEMENTO.Tag = "oi";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(344, 211);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 69;
            this.Label1.Text = "Complemento";
            // 
            // comboUF
            // 
            this.comboUF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Location = new System.Drawing.Point(369, 265);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(46, 21);
            this.comboUF.TabIndex = 19;
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(225, 266);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 18;
            // 
            // lblest
            // 
            this.lblest.AutoSize = true;
            this.lblest.Location = new System.Drawing.Point(257, 250);
            this.lblest.Name = "lblest";
            this.lblest.Size = new System.Drawing.Size(48, 13);
            this.lblest.TabIndex = 66;
            this.lblest.Text = "Estados:";
            // 
            // btnsair
            // 
            this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(368, 305);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(99, 23);
            this.btnsair.TabIndex = 22;
            this.btnsair.Text = "Limpar";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(199, 305);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(97, 23);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar:";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(366, 250);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(24, 13);
            this.lbluf.TabIndex = 64;
            this.lbluf.Text = "UF:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(13, 305);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(98, 23);
            this.btnsalvar.TabIndex = 20;
            this.btnsalvar.Text = "Salvar:";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsal_Click);
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.Location = new System.Drawing.Point(127, 250);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(43, 13);
            this.lblcid.TabIndex = 63;
            this.lblcid.Text = "Cidade:";
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCIDADE.Location = new System.Drawing.Point(112, 266);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(100, 20);
            this.txtCIDADE.TabIndex = 17;
            // 
            // CheckBoxMenorIdade
            // 
            this.CheckBoxMenorIdade.AutoSize = true;
            this.CheckBoxMenorIdade.Location = new System.Drawing.Point(372, 52);
            this.CheckBoxMenorIdade.Name = "CheckBoxMenorIdade";
            this.CheckBoxMenorIdade.Size = new System.Drawing.Size(104, 17);
            this.CheckBoxMenorIdade.TabIndex = 6;
            this.CheckBoxMenorIdade.Text = "Menor de Idade:";
            this.CheckBoxMenorIdade.UseVisualStyleBackColor = true;
            this.CheckBoxMenorIdade.CheckedChanged += new System.EventHandler(this.CheckBoxMenorIdade_CheckedChanged);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(17, 16);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 50;
            this.lblnome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(61, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(58, 36);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(26, 13);
            this.lblrg.TabIndex = 51;
            this.lblrg.Text = "RG:";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(39, 250);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 58;
            this.lblcep.Text = "CEP:";
            // 
            // txtNUMERO
            // 
            this.txtNUMERO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNUMERO.Location = new System.Drawing.Point(238, 227);
            this.txtNUMERO.Name = "txtNUMERO";
            this.txtNUMERO.Size = new System.Drawing.Size(58, 20);
            this.txtNUMERO.TabIndex = 14;
            // 
            // txtENDERECO
            // 
            this.txtENDERECO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtENDERECO.Location = new System.Drawing.Point(14, 227);
            this.txtENDERECO.Name = "txtENDERECO";
            this.txtENDERECO.Size = new System.Drawing.Size(198, 20);
            this.txtENDERECO.TabIndex = 13;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(249, 211);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(47, 13);
            this.lblnum.TabIndex = 56;
            this.lblnum.Text = "Numero:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(175, 36);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 52;
            this.lblcpf.Text = "CPF:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(78, 211);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(56, 13);
            this.lblend.TabIndex = 55;
            this.lblend.Text = "Endereço:";
            // 
            // PanelResponsavel
            // 
            this.PanelResponsavel.Controls.Add(this.maskedCPF_Responsavel);
            this.PanelResponsavel.Controls.Add(this.maskedRG_Responsavel);
            this.PanelResponsavel.Controls.Add(this.lblnr);
            this.PanelResponsavel.Controls.Add(this.txtNomeResponsavel);
            this.PanelResponsavel.Controls.Add(this.lblrg1);
            this.PanelResponsavel.Controls.Add(this.lblcpf1);
            this.PanelResponsavel.Location = new System.Drawing.Point(17, 78);
            this.PanelResponsavel.Name = "PanelResponsavel";
            this.PanelResponsavel.Size = new System.Drawing.Size(439, 70);
            this.PanelResponsavel.TabIndex = 65;
            this.PanelResponsavel.Visible = false;
            // 
            // maskedCPF_Responsavel
            // 
            this.maskedCPF_Responsavel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedCPF_Responsavel.Location = new System.Drawing.Point(218, 43);
            this.maskedCPF_Responsavel.Mask = "000.000.000-00";
            this.maskedCPF_Responsavel.Name = "maskedCPF_Responsavel";
            this.maskedCPF_Responsavel.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF_Responsavel.TabIndex = 9;
            // 
            // maskedRG_Responsavel
            // 
            this.maskedRG_Responsavel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.maskedRG_Responsavel.Location = new System.Drawing.Point(36, 43);
            this.maskedRG_Responsavel.Mask = "00.000.000-00";
            this.maskedRG_Responsavel.Name = "maskedRG_Responsavel";
            this.maskedRG_Responsavel.Size = new System.Drawing.Size(97, 20);
            this.maskedRG_Responsavel.TabIndex = 8;
            // 
            // lblnr
            // 
            this.lblnr.AutoSize = true;
            this.lblnr.Location = new System.Drawing.Point(4, 15);
            this.lblnr.Name = "lblnr";
            this.lblnr.Size = new System.Drawing.Size(118, 13);
            this.lblnr.TabIndex = 5;
            this.lblnr.Text = "Nome do Responsavel:";
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomeResponsavel.Location = new System.Drawing.Point(128, 12);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(204, 20);
            this.txtNomeResponsavel.TabIndex = 7;
            // 
            // lblrg1
            // 
            this.lblrg1.AutoSize = true;
            this.lblrg1.Location = new System.Drawing.Point(4, 46);
            this.lblrg1.Name = "lblrg1";
            this.lblrg1.Size = new System.Drawing.Size(26, 13);
            this.lblrg1.TabIndex = 6;
            this.lblrg1.Text = "RG:";
            // 
            // lblcpf1
            // 
            this.lblcpf1.AutoSize = true;
            this.lblcpf1.Location = new System.Drawing.Point(182, 49);
            this.lblcpf1.Name = "lblcpf1";
            this.lblcpf1.Size = new System.Drawing.Size(30, 13);
            this.lblcpf1.TabIndex = 7;
            this.lblcpf1.Text = "CPF:";
            // 
            // CadastroModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 356);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Modelos";
            this.Load += new System.EventHandler(this.CadastroModelos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelResponsavel.ResumeLayout(false);
            this.PanelResponsavel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.MaskedTextBox maskedCEP;
        internal System.Windows.Forms.MaskedTextBox maskedCELULAR;
        internal System.Windows.Forms.MaskedTextBox maskedTELEFONE;
        public System.Windows.Forms.MaskedTextBox maskedCPF;
        internal System.Windows.Forms.MaskedTextBox maskedRG;
        internal System.Windows.Forms.TextBox txtEMAIL;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblCel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox comboSexo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker DateTimeNASCIMENTO;
        internal System.Windows.Forms.Label lblnas;
        internal System.Windows.Forms.TextBox txtCOMPLEMENTO;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox comboUF;
        internal System.Windows.Forms.ComboBox comboEstado;
        internal System.Windows.Forms.Label lblest;
        internal System.Windows.Forms.Button btnsair;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.Label lbluf;
        internal System.Windows.Forms.Button btnsalvar;
        internal System.Windows.Forms.Label lblcid;
        internal System.Windows.Forms.TextBox txtCIDADE;
        internal System.Windows.Forms.CheckBox CheckBoxMenorIdade;
        internal System.Windows.Forms.Label lblnome;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label lblrg;
        internal System.Windows.Forms.Label lblcep;
        internal System.Windows.Forms.TextBox txtNUMERO;
        internal System.Windows.Forms.TextBox txtENDERECO;
        internal System.Windows.Forms.Label lblnum;
        internal System.Windows.Forms.Label lblcpf;
        internal System.Windows.Forms.Label lblend;
        internal System.Windows.Forms.Panel PanelResponsavel;
        internal System.Windows.Forms.MaskedTextBox maskedCPF_Responsavel;
        internal System.Windows.Forms.MaskedTextBox maskedRG_Responsavel;
        internal System.Windows.Forms.Label lblnr;
        internal System.Windows.Forms.TextBox txtNomeResponsavel;
        internal System.Windows.Forms.Label lblrg1;
        internal System.Windows.Forms.Label lblcpf1;
    }
}