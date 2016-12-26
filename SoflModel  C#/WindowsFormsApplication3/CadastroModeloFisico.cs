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
    public partial class CadastroModeloFisico : Form
    {
        public CadastroModeloFisico()
        {
            InitializeComponent();
        }

        private void CadastroModeloFisico_Load(object sender, EventArgs e)
        {
            // ADD VALORES NO COMBOPELE
            combopele.Items.Add("selecionar");
            combopele.Items.Add("Branco");
            combopele.Items.Add("Negro");
            combopele.Items.Add("Amarelo");
            combopele.Items.Add("Pardo");
            combopele.SelectedIndex = 0;

            // ADD VALORES NO COMBOCABELO
            combocabelo.Items.Add("selecionar");
            combocabelo.Items.Add("Castanho");
            combocabelo.Items.Add("Loiro");
            combocabelo.Items.Add("Chocolate");
            combocabelo.Items.Add("Loiro");
            combocabelo.SelectedIndex = 0;

            // ADD VALORES NO COMBOTIPOCABELO
            combotipocabelo.Items.Add("selecionar");
            combotipocabelo.Items.Add("Ondulado");
            combotipocabelo.Items.Add("Caxiado");
            combotipocabelo.Items.Add("liso");
            combotipocabelo.SelectedIndex = 0;

            // ADD VALORES NO COMBOOLHO
            comboOlho.Items.Add("selecionar");
            comboOlho.Items.Add("Castanho");
            comboOlho.Items.Add("Verde");
            comboOlho.Items.Add("Preto");
            comboOlho.SelectedIndex = 0;

        }
        private void btnsal_Click(object sender, EventArgs e)
        {

            try
            {

             //Conexao com Banco de Dados em SQLServer

                string conec = @"Data Source=ricardo;Initial Catalog=Modelo;Integrated Security=True";
            
            SqlConnection cn = new SqlConnection(conec);

            cn.Open();
            //---------------------------------------------------------------------------------------------------

            // prepara um comando SQL para incluir dados usando a instrução INSERT INTO
                // procurar quebra de linha em C# - ok
            string SQL = " insert into CadastroModeloFisico (Altura, Quadril, Cintura, Peso, Manequim, Busto, Cor_da_Pele, Cor_do_Cabelo,Tipo_de_Cabelo,Cor_dos_Olhos) values ";
                   SQL += "('" + txtAltura.Text + "','" + txtQuadril.Text + "', '" + txtCintura.Text + "', '" + txtPeso.Text + "','" + txtManequim.Text + "',";
                   SQL += "'" + txtBusto.Text + "', '" + combopele.Text  + "', '" + combocabelo.Text + "', '" + combotipocabelo.Text + "', '" + comboOlho.Text + "')";


            // 1. Instancia um novo comando com uma consulta e uma conexão
                SqlCommand cmd = new SqlCommand(SQL, cn);


                // 2. Chama o método ExecuteNonQuery para enviar o comando
               cmd.ExecuteNonQuery();

                    
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    cn.Close();

            }
            catch (Exception)
            {

                //throw;
                MessageBox.Show("Ocorreu um erro ao gravar", "Verifique", MessageBoxButtons.OKCancel);
            }

        }

        private void btnanex_Click(object sender, EventArgs e)
        {
            //SalvarImagem();
            try
            {

                //Cria um objeto OpenFileDialog
                OpenFileDialog openFile1 = new OpenFileDialog();
                //Ir ao diretorio
                ////openFile1.InitialDirectory = "F:/Projeto c#/SoflModel C#/imagens";
                ////openFile1.FilterIndex = 2;
                ////openFile1.RestoreDirectory = true;

                // Inicializa o OpenFileDialog para procurar arquivos de imagem
                openFile1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";


                // Verifica se o usuário selecionou um arquivo a partir do OpenFileDialog
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    // Carrega o conteúdo do arquivo em um controle PictureBox.
                    pbFoto.Image = System.Drawing.Image.FromFile(openFile1.FileName);

                    Bitmap bmp = new Bitmap(openFile1.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, pbFoto.Size);
                    pbFoto.Image = bmp2;
                    //salva imagem
                    SaveFileDialog salvaimagem = new SaveFileDialog();

                    //criar um direitorio
                    //Directory.CreateDirectory(@"F:/Projeto c#/SoflModel C#/imagens");

                    salvaimagem.Filter = "JPeg Imagem|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

                    //if (salvaimagem.ShowDialog() == System.Windows.Forms.DialogResult.OK && salvaimagem.FileName.Length > 0)
                    //{
                    //    //aqui mandamos salvar a figura que está selecionada no picturebox!

                    //    pbFoto.Image.Save(salvaimagem.FileName);
                    //    pbFoto.Text = salvaimagem.FileName;
                    //}

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir imagem : " + erro);
            }
        
        }            

      


    }
}
