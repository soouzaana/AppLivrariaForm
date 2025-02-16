using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//para ter acesso ao MessageBox
using MySql.Data.MySqlClient; // para trabalhar com as classes de conexão com o banco dados MySql
using System.Reflection; // para ter acesso as classes dentro da pasta Models
using AppLivrariaForm.Models; // para ter acesso as classes dentro da pasta Models

namespace AppLivrariaForm.Contexto
{
    public class AutorContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        // método construtor para carregar as informações dentro do objeto "conexao" para conectar com o banco MySql

        public AutorContext()
        {
            dados_conexao = "server=localhost;port=3306;database=bd_livraria;user=root;password=root;Persist Security Info=False;Connect Timeout=300";
            conexao = new MySqlConnection(dados_conexao); // conexao preparada => objeto criado e pronto para conectar ao banco
        }//fim do metodo construtor

        public List<Autor> ListarAutores()
        {
            List<Autor> listaAutoresParaExportar = new List<Autor>();
            string sql = "SELECT * FROM AUTOR";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao); // objeto "comando" responsável por ir até o banco e realizar ações

                conexao.Open(); // abrir a porta do banco para realizar a consulta

                MySqlDataReader dados = comando.ExecuteReader(); // "comando" vai realizar a consulta e enviar tudo para dentro do objeto "dados"

                // laço responsável por percorrer todos os registros que estão dentro do objeto "dados"

                while (dados.Read())
                {
                    Autor autor = new Autor();

                    autor.IdAutor = Convert.ToInt32(dados["id"]);
                    autor.Nome = dados["Nome"].ToString();
                    autor.Nacionalidade = dados["Nacionalidade"].ToString();
                    autor.GenerosAutor = dados["GenerosAutor"].ToString();
                    autor.Nascimento = Convert.ToDateTime(dados["Nascimento"]);
                    listaAutoresParaExportar.Add(autor);
                }
                conexao.Close(); // fechar a porta do banco
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return listaAutoresParaExportar;
        }//fim do método ListarAutores

        public void InserirAutor(Autor autor)
        {
            string sql = "INSERT INTO AUTOR (Nome, Nacionalidade, GenerosAutor, Nascimento) VALUES (@Nome, @Nacionalidade, @GenerosAutor, @Nascimento)";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", autor.Nome);
                comando.Parameters.AddWithValue("@Nacionalidade", autor.Nacionalidade);
                comando.Parameters.AddWithValue("@GenerosAutor", autor.GenerosAutor);
                comando.Parameters.AddWithValue("@Nascimento", autor.Nascimento);

                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        } // fim do método InserirAutor

        public void AtualizarAutor(Autor autor)
        {
            string sql = "UPDATE AUTOR SET Nome = @Nome, Nacionalidade = @Nacionalidade, GenerosAutor = @GenerosAutor, Nascimento = @Nascimento WHERE IdAutor = @id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", autor.Nome);
                comando.Parameters.AddWithValue("@Nacionalidade", autor.Nacionalidade);
                comando.Parameters.AddWithValue("@GenerosAutor", autor.GenerosAutor);
                comando.Parameters.AddWithValue("@Nascimento", autor.Nascimento);
                comando.Parameters.AddWithValue("@id", autor.IdAutor);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        } // fim do método AtualizarAutor

        public void DeletarAutor(Autor autor)
        {
            string sql = "DELETE FROM AUTOR WHERE IdAutor = @id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", autor.IdAutor);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        } // fim do método DeletarAutor
    } // fim da classe   
} // fim do namespace
