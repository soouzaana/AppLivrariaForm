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
    public class GeneroContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        // método construtor para carregar as informações dentro do objeto "conexao" para conectar com o banco MySql

        public GeneroContext()
        {
            dados_conexao = "server=localhost;port=3306;database=bd_livraria;user=root;password=root;Persist Security Info=False;Connect Timeout=300";
            conexao = new MySqlConnection(dados_conexao); // conexao preparada => objeto criado e pronto para conectar ao banco
        }//fim do metodo construtor

        public List<Genero> ListarGeneros()
        {
            List<Genero> listaGenerosParaExportar = new List<Genero>();
            string sql = "SELECT * FROM GENERO";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao); // objeto "comando" responsável por ir até o banco e realizar ações

                conexao.Open(); // abrir a porta do banco para realizar a consulta

                MySqlDataReader dados = comando.ExecuteReader();

                while (dados.Read())
                {
                    Genero genero = new Genero();
                    genero.IdGenero = Convert.ToInt32(dados["id"]);
                    genero.Nome = dados["Nome"].ToString();
                    genero.Descricao = dados["Descricao"].ToString();
                    genero.Popularidade = dados["Popularidade"].ToString();
                    genero.PublicoAlvo = dados["PublicoAlvo"].ToString();
                    listaGenerosParaExportar.Add(genero);
                }
                conexao.Close(); // fechar a porta do banco
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return listaGenerosParaExportar;
        } // fim do método ListarGeneros

        public void InserirGenero(Genero genero)
        {
            string sql = "INSERT INTO GENERO (Nome, Descricao, Popularidade, PublicoAlvo) VALUES (@Nome, @Descricao, @Popularidade, @PublicoAlvo)";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Nome", genero.Nome);
                comando.Parameters.AddWithValue("@Descricao", genero.Descricao);
                comando.Parameters.AddWithValue("@Popularidade", genero.Popularidade);
                comando.Parameters.AddWithValue("@PublicoAlvo", genero.PublicoAlvo);
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
        }//fim do método InserirGenero

        public void AtualizarGenero(Genero genero)
        {
            string sql = "UPDATE GENERO SET Nome = @Nome, Descricao = @Descricao, Popularidade = @Popularidade, PublicoAlvo = @PublicoAlvo WHERE Id = @id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@Nome", genero.Nome);
                comando.Parameters.AddWithValue("@Descricao", genero.Descricao);
                comando.Parameters.AddWithValue("@Popularidade", genero.Popularidade);
                comando.Parameters.AddWithValue("@PublicoAlvo", genero.PublicoAlvo);
                comando.Parameters.AddWithValue("@id", genero.IdGenero);
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

        }//fim do método AtualizarGenero

        public void DeletarGenero(Genero genero)
        {
            string sql = "DELETE FROM GENERO WHERE Id = @id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", genero.IdGenero);
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Genero excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o genero!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }//fim do método ExcluirGenero
    
    }// fim da classe
} // fim do namespace
