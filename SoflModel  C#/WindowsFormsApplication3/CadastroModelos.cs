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
    public partial class CadastroModelos : Form
    {
        public CadastroModelos()
        {
            InitializeComponent();
        }


        private void CadastroModelos_Load(object sender, EventArgs e)
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
                 comboEstado.Items.Add(Estados[i].ToString());

               }

            for (int i = 0; i < 26; i++)
                {
                    comboUF.Items.Add(UF[i].ToString());
                }

            // ADD VALORES NO COMBOSEXO
            comboSexo.Items.Add ("selecionar");
            comboSexo.Items.Add("M");
            comboSexo.Items.Add("F");
            comboSexo.SelectedIndex = 0;

        }

        private void CheckBoxMenorIdade_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxMenorIdade.Checked == true)
            {
                PanelResponsavel.Visible = true;
                txtNomeResponsavel.Focus();

            }
            else 
            {
                PanelResponsavel.Visible = false;
            }

        }

        private void btnsal_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("O campo nome não pode estar vazio","Atenção");
                    txtNome.Focus();
                    
                }
               
            //Banco de Dados em SQLServer  
               // 1 forma  
            //string conec = @"Data Source=ricardo\SQL; Initial Catalog=Cadastro; User ID=sa; Password=ricardo; Language=Portuguese";
            //SqlConnection cn = new SqlConnection(conec);
            //cn.Open();

                // 2 forma
                Conexao conexao = new Conexao();
                conexao.conectar();

            // prepara um comando SQL para incluir dados usando a instrução INSERT INTO
            if (CheckBoxMenorIdade.Checked == true)
            {

                string SQL = "insert into CadastroModelo (Nome ,Sexo ,RG ,CPF ,Data_Nascimento,Nome_Responsavel ,RG_Responsavel ,CPF_Responsavel ,";
                        SQL += "Telefone ,Celular ,Email ,Endereco ,Numero ,Complemento ,Cep ,Cidade ,Estado ,UF)";
                        SQL += "values ('" + txtNome.Text + "','" + comboSexo.Text + "','" + maskedRG.Text + "','" + maskedCPF.Text + "',";
                        SQL += "'" + DateTimeNASCIMENTO.Value + "','" + txtNomeResponsavel.Text + "','" + maskedRG_Responsavel.Text + "',";
                        SQL += "'"+maskedCPF_Responsavel.Text + "','" + maskedTELEFONE.Text + "' , '" + maskedCELULAR.Text + "','" + txtEMAIL.Text + "',";
                        SQL += "'" + txtENDERECO.Text + "', " + txtNUMERO.Text + ", '" + txtCOMPLEMENTO.Text + "', '" + maskedCEP.Text + "','" + txtCIDADE.Text + "',";
                        SQL += "'" + comboEstado.Text + "', '" + comboUF.Text + "')";

               
                // 1. Instancia um novo comando com uma consulta e uma conexão
                        SqlCommand cmd = new SqlCommand(SQL, conexao.cnString);

                 
                // 2. Chama o método ExecuteNonQuery para enviar o comando
               cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Cadastro efetuado com sucesso","Atenção",MessageBoxButtons.OKCancel);
                    LimparCampos();
                    conexao.desconectar();


                    this.Visible = false;
                    CadastroModeloFisico  formulario2 = new CadastroModeloFisico();
                    formulario2.Show();
            
            }

            else 
            {

                string SQL = @"insert into CadastroModelo (Nome ,Sexo ,RG ,CPF ,Telefone ,Celular ,Email ,Endereco ,Numero ,";
                        SQL += "Complemento ,Cep ,Cidade ,Estado ,UF,Data_Nascimento) values ('" + txtNome.Text + "','" + comboSexo.Text + "','" + maskedRG.Text + "',"; 
                        SQL += "'" + maskedCPF.Text + "', '" + maskedTELEFONE.Text + "', '" + maskedCELULAR.Text + "',";
                        SQL += "'" + txtEMAIL.Text + "','" + txtENDERECO.Text + "', " + txtNUMERO.Text + ", '" + txtCOMPLEMENTO.Text + "',";
                        SQL += "'" + maskedCEP.Text + "','" + txtCIDADE.Text + "', '" + comboEstado.Text + "', '" + comboUF.Text + "','" + DateTimeNASCIMENTO.Text + "')";



 
                // 1. Instancia um novo comando com uma consulta e uma conexão
                        SqlCommand cmd = new SqlCommand(SQL, conexao.cnString);

              
                // 2. Chama o método ExecuteNonQuery para enviar o comando
                cmd.ExecuteNonQuery();

              
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    LimparCampos();
                    conexao.desconectar();

                    this.Visible = false;
                    CadastroModeloFisico formulario2 = new CadastroModeloFisico();
                    formulario2.Show();
            }

            }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("Ocorreu algum erro na gravação!","Atenção",MessageBoxButtons.OK );
            }

           
        }
        

        private void LimparCampos()
        {
            txtNome.Text = "";
            comboSexo.Text = "";
            maskedRG.Text = "";
            maskedCPF.Text = "";
            txtNomeResponsavel.Text = "";
            maskedCPF_Responsavel.Text = "";
            maskedRG_Responsavel.Text = "";
            maskedTELEFONE.Text = "";
            maskedCELULAR.Text = "";
            txtEMAIL.Text = "";
            txtENDERECO.Text = "";
            txtCOMPLEMENTO.Text = "";
            maskedCEP.Text = "";
            txtCIDADE.Text = "";
            comboEstado.Text = "";
            comboUF.Text = "";
            txtNome.Focus();
        }

        /*
        private void NaoPodeEstarVazio()
        {
            if (txtNome.Text == "" || comboSexo.Text == "" || maskedRG.Text == "" || maskedCPF.Text == "" || txtNomeResponsavel.Text == "" || maskedCPF_Responsavel.Text == "" || maskedRG_Responsavel.Text == "" || maskedTELEFONE.Text == "" || maskedCELULAR.Text == "" || txtEMAIL.Text == "" || txtENDERECO.Text == "" || txtCOMPLEMENTO.Text == "" || maskedCEP.Text == "" || txtCIDADE.Text == "" || comboEstado.Text == "" || comboUF.Text == "")
            {
                MessageBox.Show("Existem campos vazio");
                Application.Exit();  
            }        
        }
        */

        private void btnsair_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static bool validarCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        
        }

   
    }
}
