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
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conec = @"Data Source=RICARDO\SQL;Initial Catalog=BancoDesenvolvimento;Integrated Security=True";

            SqlConnection cn = new SqlConnection(conec);

            cn.Open();


            /*  */

            string resul;

            if (comboBox1.Text == "000000 - Teste01")
            {
                string SQL1 = @"SELECT  TOP 1 * FROM Teste WHERE IDUSUARIO LIKE '00%' ORDER BY IDUSUARIO DESC";

                SqlCommand cmd1 = new SqlCommand(SQL1, cn);

                cmd1.ExecuteNonQuery();

                resul = "IDUSUARIO";
                resul = resul + 10;

            
                string SQL = @"insert into Teste (IDUSUARIO,NOME ) values ('" + textBox1.Text + "','" + resul + "')";

                ////// 1. Instancia um novo comando com uma consulta e uma conexão
                SqlCommand cmd = new SqlCommand(SQL, cn);

                ////// 2. Chama o método ExecuteNonQuery para enviar o comando
                cmd.ExecuteNonQuery();


                //instância do leitor 
                //SqlDataReader leitor = cmd.ExecuteReader(); 

                ////enquanto leitor lê 
                //while (leitor.Read()) 
                //{ 
                //    //para cada iteração adiciono o nome 
                //    //ao listbox 
                //    listBox1.Items.Add(leitor["Nome"].ToString()); 
                //} 

                MessageBox.Show("Cadastro efetuado com sucesso");
                //////LimparCampos();
                cn.Close();
            }
        }


        private string ToBoolean(string p)
        {
            throw new NotImplementedException();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTeste_Load(object sender, EventArgs e)
        {

        }



        
            //public Form1() 
            //  { 
            //      InitializeComponent(); 
            //  } 
 
            //  //classe cliente e suas propriedades 
            //  public class Cliente 
            //  { 
            //      public int IdCliente { get; set; } 
            //      public string Nome { get; set; } 
            //      public string Email { get; set; } 
            //      public DateTime DataNascimento { get; set; } 
            //  } 
 
            //  private void Form1_Load(object sender, EventArgs e) 
            //  { 
            //      CarregaListBox(); 
            //  } 
 
            //  private void CarregaListBox() 
            //  { 
            //      //instância da conexão 
            //      SqlConnection conn = new SqlConnection(@"Data Source=|DataDirectory|\Clientes.sdf"); 
 
            //      //string com o comando a ser executado 
            //      string sql = "SELECT Nome from Cliente"; 
 
            //      //instância do comando recebendo como parâmetro 
            //      //a string com o comando e a conexão 
            //      SqlCommand cmd = new SqlCommand(sql, conn); 
 
            //      //abro conexão 
            //      conn.Open(); 
 
            //      //instância do leitor 
            //      SqlDataReader leitor = cmd.ExecuteReader(); 
 
            //      //enquanto leitor lê 
            //      while (leitor.Read()) 
            //      { 
            //          //para cada iteração adiciono o nome 
            //          //ao listbox 
            //          listBox1.Items.Add(leitor["Nome"].ToString()); 
            //      } 
 
            //      //fecha conexão 
            //      conn.Close(); 
            //  } 
 
 
            //  //método que faz a consulta no bd e obtém o cliente 
            //  //cujo o nome é informado pelo parâmetro 
            //  private Cliente ObterClientePorNome(string nome) 
            //  { 
            //      //objeto cliente que será retornado pelo método 
            //      Cliente cliente = new Cliente(); 
 
            //      //instância da conexão 
            //      SqlConnection conn = new SqlConnection(@"Data Source=|DataDirectory|\Clientes.sdf"); 
 
            //      //string com o comando a ser executado 
            //      string sql = "SELECT * from Cliente WHERE Nome=@Nome"; 
 
            //      //instância do comando recebendo como parâmetro 
            //      //a string com o comando e a conexão 
            //      SqlCommand cmd = new SqlCommand(sql, conn); 
 
            //      //informo o parâmetro do comando 
            //      cmd.Parameters.AddWithValue("@Nome", nome); 
 
            //      //abro conexão 
            //      conn.Open(); 
 
            //      //instância do leitor 
            //      SqlDataReader leitor = cmd.ExecuteReader(); 
 
            //      //enquanto leitor lê 
            //      while (leitor.Read()) 
            //      { 
            //          //passo os valores para o objeto cliente 
            //          //que será retornado 
            //          cliente.IdCliente = Convert.ToInt32(leitor["IdCliente"].ToString()); 
            //          cliente.Nome = leitor["Nome"].ToString(); 
            //          cliente.Email = leitor["Email"].ToString(); 
            //          cliente.DataNascimento = Convert.ToDateTime(leitor["DataNascimento"].ToString()); 
            //      } 
 
            //      //fecha conexão 
            //      conn.Close(); 
 
            //      //Retorno o objeto cliente cujo o  
            //      //nome é igual ao informado no parâmetro 
            //      return cliente; 
            //  } 
 
            //  //evento mouseclick do listbox 
            //  private void listBox1_MouseClick(object sender, MouseEventArgs e) 
            //  { 
            //      //variável recebe o objeto cliente retornado pelo método 
            //      Cliente cliente = ObterClientePorNome(listBox1.SelectedItem.ToString()); 
 
            //      //passo os valores para os textbox 
            //      txtCodigo.Text = cliente.IdCliente.ToString(); 
            //      txtNome.Text = cliente.Nome; 
            //      txtEmail.Text = cliente.Email; 
            //      txtDataNascimento.Text = cliente.DataNascimento.ToShortDateString(); 
            //  }
       
    }
}
