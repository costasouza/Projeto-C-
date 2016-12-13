using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeModelosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastroModelos Formulario1 = new CadastroModelos();
            Formulario1.Show();
        }

        private void consultaDeModelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaModelos Formulario3 = new ConsultaModelos();
            Formulario3.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmTeste FormularioTeste = new frmTeste();
            FormularioTeste.Show();

            //CadastroModeloFisico FormularioModeloFisico = new CadastroModeloFisico();
            //FormularioModeloFisico.Show();
        }

        private void cadastroDeParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroParceiros CadastroParceiros = new FrmCadastroParceiros(); 
            CadastroParceiros.Show ();
        }

        private void consultaDeParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaParceiros ConsultaParceiros = new FrmConsultaParceiros();
            ConsultaParceiros.Show();
        }

        private void cadastroDeColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColaboradores CadastroColaboradores = new FrmColaboradores();
            CadastroColaboradores.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
