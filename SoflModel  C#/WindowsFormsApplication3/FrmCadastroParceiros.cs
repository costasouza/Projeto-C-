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
    public partial class FrmCadastroParceiros : Form
    {
        public FrmCadastroParceiros()
        {
            InitializeComponent();
        }

          private void FrmCadastroParceiros_Load(object sender, EventArgs e)
        {
            /// array em c#

            string[] UF;
            UF = new string[27];

            UF[0] = "AC";
            UF[1] = "AL";
            UF[2] = "AM";
            UF[3] = "AP";
            UF[4] = "BA";
            UF[5] = "CE";
            UF[6] = "DF";
            UF[7] = "ES";
            UF[8] = "GO";
            UF[9] = "MA";
            UF[10] = "MG";
            UF[11] = "MS";
            UF[12] = "MT";
            UF[13] = "PA";
            UF[14] = "PB";
            UF[15] = "PE";
            UF[16] = "PI";
            UF[17] = "PR";
            UF[18] = "RJ";
            UF[19] = "RN";
            UF[20] = "RO";
            UF[21] = "RR";
            UF[22] = "RS";
            UF[23] = "SC";
            UF[24] = "SE";
            UF[25] = "SP";
            UF[26] = "TO";
            

            string[] Estados;
            Estados = new string[27];

            Estados[0] = "ACRE";
            Estados[1] = "ALAGOAS";
            Estados[2] = "AMAZONAS";
            Estados[3] = "AMAPÁ";
            Estados[4] = "BAHIA";
            Estados[5] = "CEARÁ";
            Estados[6] = "DISTRITO FEDERAL";
            Estados[7] = "ESPIRITO SANTO";
            Estados[8] = "GOIAS";
            Estados[9] = "MARANHÃO";
            Estados[10] = "MINAS GERAIS";
            Estados[11] = "MATO GROSSO SUL";
            Estados[12] = "MATO GROSSO";
            Estados[13] = "PARÁ";
            Estados[14] = "PARAIBA";
            Estados[15] = "PERNAMBUCO";
            Estados[16] = "PIAUI";
            Estados[17] = "PARANA";
            Estados[18] = "RIO DE JANEIRO";
            Estados[19] = "RIO GRANDE DO NORTE";
            Estados[20] = "RONDÔNIA";
            Estados[21] = "RORAIMA";
            Estados[22] = "RIO GRANDE DO SUL";
            Estados[23] = "SANTA CATARINA";
            Estados[24] = "SERGIPE";
            Estados[25] = "SÃO PAULO";
            Estados[26] = "TOCANTIS";
            

            for (int i = 0; i < 26; i++)
               {
                 cmbestado.Items.Add(Estados[i].ToString());

               }

            for (int i = 0; i < 26; i++)
            {
                cmbuf.Items.Add(UF[i].ToString());
            }
          }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            try
            {

           // string conec = @"Data Source=ricardo\SQL; Initial Catalog=Cadastro; User ID=sa; Password=ricardo; Language=Portuguese";
            string conec = @"Data Source=RICARDO\SQL;Initial Catalog=Cadastro;Integrated Security=True";

            SqlConnection cn = new SqlConnection(conec);

            cn.Open();


            string sql =  " Insert into CadastroParceiros (RazaoSocial ,CNPJ ,Nome_Responsavel ,Telefone ,Email ,Endereco ,";
                   sql += " Numero , Complemento ,CEP ,Cidade ,Estado ,UF )";
                   sql += " values ('" + txtrazao.Text  + "', '" + txtcnpj.Text + "', '" + txtResponsavel.Text  + "',";
                   sql += " '" + txtTelefone.Text  + "' , '" + txtemail.Text  + "' , '" + txtEndereco.Text + "', ";
                   sql += " " + txtnumero.Text + ", '" + txtcomplemento.Text + "',' " + txtcep.Text + "', '" + txtcidade.Text + "',";
                   sql += " '" + cmbestado.Text  + "', '" + cmbuf.Text  + "') ";

                   // 1. Instancia um novo comando com uma consulta e uma conexão
                   SqlCommand cmd = new SqlCommand(sql, cn);

                   // 2. Chama o método ExecuteNonQuery para enviar o comando
                   cmd.ExecuteNonQuery();


                   MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso");
                   LimparCampos();
                   txtrazao.Focus();

            }
            catch (Exception)
            {

               // throw;
                MessageBox.Show("Ocorreu algum erro", "Verificar",MessageBoxButtons.OKCancel);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtrazao.Text = "";
            txtcnpj.Text = "";
            txtResponsavel.Text = "";
            txtTelefone.Text = "";
            txtemail.Text = "";
            txtEndereco.Text = "";
            txtnumero.Text = "";
            txtcomplemento.Text = "";
            txtcep.Text = "";
            txtcidade.Text = "";
           
        }

        

    }
}
      


