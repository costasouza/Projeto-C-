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
    public partial class FrmConsultaParceiros : Form
    {
        public FrmConsultaParceiros()
        {
            InitializeComponent();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            //Banco de Dados em SQLServer
            // 1 forma
            //string conec = @"Data Source=ricardo;Initial Catalog=Modelo;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(conec);
            //cn.Open();

            // 2 forma
            Conexao conexao = new Conexao();
            conexao.conectar();

            string SQL = " Select * from CadastroParceiros where RazaoSocial like '%" + txtRazaoSocial.Text + "%'";


            //  Instancia um novo comando com uma consulta e uma conexão
            SqlCommand cmd = new SqlCommand(SQL, conexao.cnString);

            //  Chama o método ExecuteNonQuery para enviar o comando
            cmd.ExecuteNonQuery();

            //instância do leitor 
            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.Read ())
            {

                txtResponsavel.Text = (leitor["RazaoSocial"].ToString ());
                maskedCNPJ.Text = (leitor["CNPJ"].ToString());
                txtResponsavel.Text = (leitor ["Nome_Responsavel"].ToString ());
                maskedTelefone.Text = (leitor["Telefone"].ToString());
                txtEmail.Text = (leitor["Email"].ToString());
                txtEndereco.Text = (leitor["Endereco"].ToString());
                txtNumero.Text = (leitor["Numero"].ToString());
                txtComplemento.Text = (leitor["Complemento"].ToString());
                maskedCEP.Text = (leitor["CEP"].ToString());
                txtCidade.Text = (leitor["Cidade"].ToString());
                comboBoxEstado.Text = (leitor["Estado"].ToString());
                comboBoxUF.Text = (leitor["UF"].ToString());

            }
            else
            {
                MessageBox.Show("Não existe informações","Verificar", MessageBoxButtons.OKCancel);
            }


        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            txtRazaoSocial.Text = "";
            txtResponsavel.Text = "";
            maskedCNPJ.Text = "";
            txtResponsavel.Text ="";
            maskedTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            maskedCEP.Text = "";
            txtCidade.Text = "";
            comboBoxEstado.Text = "";
            comboBoxUF.Text = "";
            txtRazaoSocial.Focus();

        }

 
       
    }
}
