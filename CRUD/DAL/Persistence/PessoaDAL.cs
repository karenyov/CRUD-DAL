using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        public void inserir(Pessoa p)
        {
            try
            {
                abrirConexao();
                cmd = new SqlCommand("insert into pessoa (nome, endereco, email) values(@nome, @endereco, @email)", conn);
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@endereco", p.endereco);
                cmd.Parameters.AddWithValue("@email", p.email);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir a pessoa. " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void atualizar(Pessoa p)
        {
            try
            {
                abrirConexao();
                cmd = new SqlCommand("update pessoa set nome=@nome, endereco=@endereco, email=@email where id=@id", conn);
                cmd.Parameters.AddWithValue("@nome", p.nome);
                cmd.Parameters.AddWithValue("@endereco", p.endereco);
                cmd.Parameters.AddWithValue("@email", p.email);
                cmd.Parameters.AddWithValue("@id", p.id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a pessoa. " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void excluir(int id)
        {
            try
            {
                abrirConexao();
                cmd = new SqlCommand("delete from pessoa where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir a pessoa. " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public Pessoa consultarPorId(int id)
        {
            try
            {
                abrirConexao();
                cmd = new SqlCommand("select * from pessoa where id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                Pessoa p = null;

                if (dr.Read())
                {
                    p = new Pessoa();
                    p.id = Convert.ToInt32(dr["id"]);
                    p.nome = Convert.ToString(dr["nome"]);
                    p.endereco = Convert.ToString(dr["endereco"]);
                    p.email = Convert.ToString(dr["email"]);
                }

                return p;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pessoa por id. " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public List<Pessoa> consultarTodos()
        {
            try
            {
                abrirConexao();
                cmd = new SqlCommand("select * from pessoa", conn);
                dr = cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.id = Convert.ToInt32(dr["id"]);
                    p.nome = Convert.ToString(dr["nome"]);
                    p.endereco = Convert.ToString(dr["endereco"]);
                    p.email = Convert.ToString(dr["email"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar as pessoas. " + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
