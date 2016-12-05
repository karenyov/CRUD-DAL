using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        protected void abrirConexao()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=.\sqlexpress;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void fecharConexao()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    
    }
}
