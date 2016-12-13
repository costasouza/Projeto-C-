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
    
    public partial class CadastrodeModelos : Form
    {
        public CadastrodeModelos()
        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
           ////Banco conexao = new Banco() ;
           ////SqlConnection conexao1 = conexao.abrirConexao();
           ////conexao.fecharConexao(conexao1);

      int cont;
      string estado;
            


        //Dim uf() As String = {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"}
        //Dim estado() As String = {"Acre", "Alagoas", "Amazonas", "Amapá", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goias", "Maranhão", "Minas Gerais", "Mato Grosso Sul", "Mato Grosso", "Pará", "Paraiba", "Pernanbuco", "Piaui", "Parana", "Rio de Janeiro", "Rio Grande do Norte", "Rondônia", "Roraima", "Rio Grande do Sul", "Santa Catarina", "Sergipe", "São Paulo", "Tocantins"}
       // 'Lista de Estado 

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //Banco de Dados em SQLServer
            //string conec = "Data Source= Demeoserver;Initial Catalog=Desenv_demeo;User ID=ricardo;Password=ricardo@2014;Language=Portuguese";
            string conec = "Data Source= Ricardo  ;Initial Catalog=Cadastro  ;User ID=ricardo;   Language=Portuguese";

            SqlConnection cn = new SqlConnection(conec);

            cn.Open();

            // prepara um comando SQL para incluir dados usando a instrução INSERT INTO
            string incluiSQL = @" insert into Modelo (Numero,nome) values ('" + txtEmail.Text + "', '" + txtEndereco.Text + "')";

            // 1. Instancia um novo comando com uma consulta e uma conexão
            SqlCommand cmd = new SqlCommand(incluiSQL, cn);

            // 2. Chama o método ExecuteNonQuery para enviar o comando
            cmd.ExecuteNonQuery();


            cn.Close();

        }

      

    }
}
