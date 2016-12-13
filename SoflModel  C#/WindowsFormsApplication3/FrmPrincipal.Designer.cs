namespace WindowsFormsApplication3
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeModelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeModelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeParceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeParceirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeColaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Botão Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeloToolStripMenuItem,
            this.parceirosToolStripMenuItem,
            this.colaboradoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeModelosToolStripMenuItem,
            this.consultaDeModelosToolStripMenuItem});
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.modeloToolStripMenuItem.Text = "Modelo";
            // 
            // cadastroDeModelosToolStripMenuItem
            // 
            this.cadastroDeModelosToolStripMenuItem.Name = "cadastroDeModelosToolStripMenuItem";
            this.cadastroDeModelosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cadastroDeModelosToolStripMenuItem.Text = "Cadastro de Modelos";
            this.cadastroDeModelosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeModelosToolStripMenuItem_Click);
            // 
            // consultaDeModelosToolStripMenuItem
            // 
            this.consultaDeModelosToolStripMenuItem.Name = "consultaDeModelosToolStripMenuItem";
            this.consultaDeModelosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultaDeModelosToolStripMenuItem.Text = "Consulta de Modelos";
            this.consultaDeModelosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeModelosToolStripMenuItem_Click);
            // 
            // parceirosToolStripMenuItem
            // 
            this.parceirosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeParceirosToolStripMenuItem,
            this.consultaDeParceirosToolStripMenuItem});
            this.parceirosToolStripMenuItem.Name = "parceirosToolStripMenuItem";
            this.parceirosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.parceirosToolStripMenuItem.Text = "Parceiros";
            // 
            // cadastroDeParceirosToolStripMenuItem
            // 
            this.cadastroDeParceirosToolStripMenuItem.Name = "cadastroDeParceirosToolStripMenuItem";
            this.cadastroDeParceirosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeParceirosToolStripMenuItem.Text = "Cadastro de Parceiros";
            this.cadastroDeParceirosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeParceirosToolStripMenuItem_Click);
            // 
            // consultaDeParceirosToolStripMenuItem
            // 
            this.consultaDeParceirosToolStripMenuItem.Name = "consultaDeParceirosToolStripMenuItem";
            this.consultaDeParceirosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultaDeParceirosToolStripMenuItem.Text = "Consulta de Parceiros";
            this.consultaDeParceirosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeParceirosToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeColaboradoresToolStripMenuItem});
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            // 
            // cadastroDeColaboradoresToolStripMenuItem
            // 
            this.cadastroDeColaboradoresToolStripMenuItem.Name = "cadastroDeColaboradoresToolStripMenuItem";
            this.cadastroDeColaboradoresToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cadastroDeColaboradoresToolStripMenuItem.Text = "Cadastro de Colaboradores";
            this.cadastroDeColaboradoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeColaboradoresToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "SOFTWARE PARA MODELO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeModelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeModelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parceirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeParceirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeParceirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeColaboradoresToolStripMenuItem;
    }
}