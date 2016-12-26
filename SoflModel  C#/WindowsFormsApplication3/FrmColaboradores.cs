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
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            // 1 forma de conexao com Banco SQL
            //string conec2 = @"Data Source=RICARDO\SQL;Initial Catalog=Cadastro;Integrated Security=True";
            //SqlConnection cn = new SqlConnection(conec2);
            //cn.Open();

            // 2 forma
            Conexao conexao = new Conexao();
            conexao.conectar();

          

            string SQL = "Insert into CadastroColaborador (Nome , RG, CPF, Nascimento, Cargo , Profissao , Email,Telefone , Endereco , Numero ,";
                   SQL += "CEP , Cidade , Estado , UF )";
                   SQL += "values ('" + txtNome.Text + "','" + maskedRG.Text + "', '" + maskedCPF.Text + "' , '" + MaskNascimento.Text + "', '" + txtcargo.Text + "',";
                   SQL += "'" + txtProfissao.Text + "', '" + txtemail.Text + "', '" + maskedTELEFONE.Text + "', '" + txtEndereco.Text + "',";
                   SQL += "" + txtnumero.Text + ",'" + maskedCEP.Text + "', '" + txtcidade.Text + "', '" + cmbestado.Text + "', '" + cmbUF.Text + "') ";

                   // 1. Instancia um novo comando com uma consulta e uma conexão
                   SqlCommand cmd = new SqlCommand(SQL, conexao.cnString);


                   // 2. Chama o método ExecuteNonQuery para enviar o comando
                   cmd.ExecuteNonQuery();


                   MessageBox.Show("Cadastro efetuado com sucesso");
                   LimparCampos();
                   conexao.desconectar();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmColaboradores_Load(object sender, EventArgs e)
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
                cmbUF.Items.Add(UF[i].ToString());
            }
        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            maskedRG.Text = "";
            maskedCPF.Text = "";
            txtcargo.Text = "";
            txtProfissao.Text = "";
            txtemail.Text = "";
            maskedTELEFONE.Text = "";
            txtEndereco.Text = "";
            txtnumero.Text = "";
            maskedCEP.Text = "";
            txtcidade.Text = "";
            cmbestado.Text = "";
            cmbUF.Text = "";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
