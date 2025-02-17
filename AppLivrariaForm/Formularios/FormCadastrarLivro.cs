using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLivrariaForm.Formularios;
using AppLivrariaForm.Models;
using AppLivrariaForm.Contexto;

namespace AppLivrariaForm.Formularios
{    
    public partial class FormCadastrarLivro : Form
    {
        int contador = 1;
        static int IdLivro = 1; // chave primaria
        int IdGenero = 1;
        int IdAutor = 1;
        List<Genero> ListaGeneros = new List<Genero>();
        List<Livro> ListaLivrosTemp = new List<Livro>();
        List<Autor> ListaAutores = new List<Autor>();
        public FormCadastrarLivro()
        {
            InitializeComponent();
            GeneroContext context = new GeneroContext();
            ListaGeneros = context.ListarGeneros();
            cbGenero.DataSource = ListaGeneros.ToList();
            cbGenero.DisplayMember = "Nome";
            cbGenero.SelectedIndex = -1;

            AutorContext contextAutor = new AutorContext();
            ListaAutores = contextAutor.ListarAutores();
            cbAutor.DataSource = ListaAutores.ToList();
            cbAutor.DisplayMember = "Nome";
            cbAutor.SelectedIndex = -1;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            LivroContext Context = new LivroContext();
            foreach(Livro livro in ListaLivrosTemp)
            {
                Context.InserirLivro(livro);
            }
            MessageBox.Show("SALVO COM SUCESSO!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTitulo.Clear(); txtClassificacao.Clear(); txtISBN.Clear(); txtAno.Clear();
            cbGenero.SelectedIndex = -1;
            cbAutor.SelectedIndex = -1;
            ListaLivrosTemp.Clear();
            dtTabela.DataSource = ListaLivrosTemp.ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.Classificacao = txtClassificacao.Text;
            livro.Titulo = txtTitulo.Text;
            livro.ISBN = Convert.ToInt32(txtISBN.Text);
            livro.Ano = Convert.ToInt32(txtAno.Text);
            livro.Id = IdLivro; // chave primaria
            livro.IdGenero = IdGenero; // chave estrangeira
            livro.IdAutor = IdAutor; // chave estrangeira

            ListaLivrosTemp.Add(livro);
            IdLivro++;
            dtTabela.DataSource = ListaLivrosTemp.ToList();
            txtTitulo.Clear(); txtClassificacao.Clear(); txtISBN.Clear(); txtAno.Clear();
            txtTitulo.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear(); txtClassificacao.Clear(); txtISBN.Clear(); txtAno.Clear();
            cbAutor.SelectedIndex = -1;
            ListaLivrosTemp.Clear();
            dtTabela.DataSource = ListaLivrosTemp.ToList();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int generoSelecionado = cbGenero.SelectedIndex;
            if(generoSelecionado > -1 && contador > 1)
            {
                var genero = ListaGeneros[generoSelecionado];
                IdGenero = genero.IdGenero;
            }
            contador++;
        }

        private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int autorSelecionado = cbAutor.SelectedIndex;
            if(autorSelecionado > -1 && contador > 1)
            {
                var autor = ListaAutores[autorSelecionado];
                IdAutor = autor.IdAutor;
            }
            contador++;
        }
    }
}