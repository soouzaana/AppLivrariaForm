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
    public class LivroContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        // método construtor para carregar as informações dentro do objeto "conexao" para conectar com o banco MySql
        public LivroContext()
        {
            dados_conexao = "server=localhost;port=3306;database=bd_livraria;user=root;password=root;Persist Security Info=False;Connect Timeout=300";
            conexao = new MySqlConnection(dados_conexao); // conexao preparada => objeto criado e pronto para conectar ao banco
        }//fim do metodo construtor

        public List<Livro> ListarLivros()
        {
            List<Livro> listaLivrosParaExportar = new List<Livro>(); // para retornar (return) o resultado e ser utilizado na aplicação
            string sql = "SELECT * FROM LIVRO"; // consulta SQL para trazer todas as pessoas
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao); // objeto "comando" responsável por ir até o banco e realizar ações

                conexao.Open(); // abrir a porta do banco para realizar a consulta

                MySqlDataReader dados = comando.ExecuteReader(); // "comando" vai realizar a consulta e enviar tudo para dentro do objeto "dados"

                // laço responsável por percorrer todos os registros que estão dentro do objeto "dados"
                while (dados.Read())
                {
                    Livro livro = new Livro();
                    livro.Id = Convert.ToInt32(dados["Id"]);
                    livro.IdGenero = Convert.ToInt32(dados["GeneroId"]);
                    livro.Titulo = dados["Titulo"].ToString();
                    livro.Classificacao = dados["Classificacao"].ToString();
                    livro.ISBN = Convert.ToInt32(dados["ISBN"]);
                    livro.Ano = Convert.ToInt32(dados["Ano"]);
                    listaLivrosParaExportar.Add(livro);
                }
                conexao.Close(); // fechar a porta do banco após resultado da consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return listaLivrosParaExportar; // retornar o resultado (exportar para aplicação)

        }// fim do método para consultar e listar livros (ListarLivros)

        public void InserirLivro(Livro livro)
        {
            string sql = "INSERT INTO LIVRO (GeneroId, Titulo, Classificacao, ISBN, Ano) VALUES (@GeneroId, @Titulo, @Classificacao, @ISBN, @Ano)";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                    
                comando.Parameters.AddWithValue("@GeneroId", livro.IdGenero);
                comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@Classificacao", livro.Classificacao);
                comando.Parameters.AddWithValue("@ISBN", livro.ISBN);
                comando.Parameters.AddWithValue("@Ano", livro.Ano);

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
        }//fim do método para inserir livro (InserirLivro)

        public void AtualizarLivro(Livro livro)
        {
            string sql = "UPDATE LIVRO SET GeneroId = @GeneroId, Titulo = @Titulo, Classificacao = @Classificacao, ISBN = @ISBN, Ano = @Ano WHERE Id = @Id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@GeneroId", livro.IdGenero);
                comando.Parameters.AddWithValue("@Titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@Classificacao", livro.Classificacao);
                comando.Parameters.AddWithValue("@ISBN", livro.ISBN);
                comando.Parameters.AddWithValue("@Ano", livro.Ano);
                comando.Parameters.AddWithValue("@Id", livro.Id);

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
        }// fim do atualizar livro

        public void DeletarLivro(Livro livro)
        {
            string sql = "DELETE FROM LIVRO WHERE Id = @Id";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@Id", livro.Id);
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
        }// fim do deletar livro

    } // fim da classe
} // fim do namespace