using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class Conexao
    {
        private const string conec =  @"Data Source=ricardo\SQL; Initial Catalog=Cadastro; User ID=sa; Password=ricardo; Language=Portuguese";
        
        SqlConnection objconec = null;

        #region "Metodo de conexao com o Banco"
        public void conectar()
        {
            
                objconec.Open();
                  
        }

        private bool desconectar()
        {
            if (objconec.State != ConnectionState.Closed)
            {
                objconec.Close();
                objconec.Dispose();
                return true;
            }
            else
            {
                objconec.Dispose();
                return false;
            }
        }
        #endregion

        #region "Metodo de execução de SQL"


        #endregion

    }
}
