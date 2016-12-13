using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;



namespace WindowsFormsApplication3
{
    public partial class ConsultaModelos : Form
    {
        public ConsultaModelos()
        {
            InitializeComponent();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {

            try
            {

                //Conexao conec = new Conexao();
                //conec.conectar();


                //Banco de Dados em SQLServer
                string conec = @"Data Source=ricardo\SQL; Initial Catalog=Cadastro; User ID=sa; Password=ricardo; Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);

            cn.Open();

            // prepara um comando SQL 
            string SQL = "select CadastroModelo.Cod_Modelo, CadastroModelo.Nome , CadastroModeloFisico.Altura,";
                   SQL += "CadastroModeloFisico.Peso,CadastroModeloFisico.Manequim,CadastroModeloFisico.Cor_da_Pele,";
                   SQL += "CadastroModeloFisico.Cor_dos_Olhos,CadastroModeloFisico.Cor_do_Cabelo,CadastroModeloFisico.Cintura,";
                   SQL += "CadastroModeloFisico.Quadril,CadastroModeloFisico.Busto" ;
                   SQL += " from CadastroModelo,CadastroModeloFisico ";
                   SQL += "where CadastroModelo.Cod_Modelo = '" + txtCodigoModelo.Text + "'";
                        


                //  Instancia um novo comando com uma consulta e uma conexão
                SqlCommand cmd = new SqlCommand(SQL, cn);

                //  Chama o método ExecuteNonQuery para enviar o comando
               cmd.ExecuteNonQuery();

               //instância do leitor 
               SqlDataReader leitor = cmd.ExecuteReader();

              
               //enquanto leitor lê 
               if (leitor.Read())
               {
                   //para cada iteração adiciono o nome 
                   //ao TextBox 
                   txtNome.Text = (leitor["Nome"].ToString());
                   txtAltura.Text = (leitor["Altura"].ToString());
                   txtPeso.Text = (leitor["Peso"].ToString());
                   txtManequim.Text = (leitor["Manequim"].ToString());
                   txtCorPele.Text = (leitor["Cor_da_Pele"].ToString());
                   txtCorolhos.Text = (leitor["Cor_dos_Olhos"].ToString());
                   txtCorCabelo.Text = (leitor["Cor_do_Cabelo"].ToString());
                   txtCintura.Text = (leitor["Cintura"].ToString());
                   txtQuadril.Text = (leitor["Quadril"].ToString());
                   txtBusto.Text = (leitor["Busto"].ToString());

                   //para cada iteração adiciono o nome 
                   //ao dataGrid 
                   //dataGrid.Rows.Add(leitor["Nome"].ToString());

               }
               else
               {
                   MessageBox.Show("NÃO EXISTE  MODELO COM ESSE CODIGO","Verificar", MessageBoxButtons.OKCancel );
                   txtCodigoModelo.Text = "";
                   txtCodigoModelo.Focus();
                
               }
                      cn.Close();
     
               }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("Ocorreu um erro na instrução", "Verificar", MessageBoxButtons.OKCancel);

            }
            
        }
     
         
        private void btncancela_Click(object sender, EventArgs e)
        {
            txtCodigoModelo.Text = "";
            txtNome.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtManequim.Text = "";
            txtCorPele.Text = "";
            txtCorolhos.Text = "";
            txtCorCabelo.Text = "";
            txtCintura.Text = "";
            txtQuadril.Text = "";
            txtBusto.Text = "";
            txtCodigoModelo.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void ConsultaModelos_Load(object sender, EventArgs e)
        {

        }
        
     
    }
 
}
