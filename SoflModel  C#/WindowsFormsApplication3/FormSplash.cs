using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (progressBarSplash.Value < 100)
            {
                progressBarSplash.Value = progressBarSplash.Value + 2;

            }
            else
            {
                timerSplash.Enabled = false;
                FrmPrincipal formulario = new FrmPrincipal();
                formulario.Show();
                this.Visible = false;

            }

        }
    }
}
