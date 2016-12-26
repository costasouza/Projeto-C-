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
        
      public SqlConnection cnString = new SqlConnection();


        public void conectar()
        {
            cnString.ConnectionString = @"Data Source=ricardo;Initial Catalog=Modelo;Integrated Security=True";
            cnString.Open();
        }

        public void desconectar()
        {
            if (cnString.State != ConnectionState.Closed)
            {
                cnString.Close();
            }
            
        }
       
    }
}
