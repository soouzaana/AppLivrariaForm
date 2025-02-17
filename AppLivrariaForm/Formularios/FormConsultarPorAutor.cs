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
    public partial class FormConsultarPorAutor: Form
    {
        int contExc = 1;
        List<Livro> ListaLivros = new List<Livro>();
        List<Autor> ListaAutores = new List<Autor>();
        public FormConsultarPorAutor()
        {
            InitializeComponent();
            AutorContext context = new AutorContext();
            ListaAutores = context.ListarAutores();
            cbAutor.DataSource = ListaAutores.ToList();
            cbAutor.DisplayMember = "Nome";
            cbAutor.SelectedIndex = -1;

            LivroContext contextLivro = new LivroContext();
            ListaLivros = contextLivro.ListarLivros();
        }

        private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linhaSelec = cbAutor.SelectedIndex;
            if (linhaSelec > -1 && contExc > 1)
            {
                var autor = ListaAutores[linhaSelec];
                var listaLivrosVinc = ListaLivros.Where(livro => livro.IdAutor == autor.IdAutor).ToList();
                txtNome.Text = autor.Nome;
                txtNacionalidade.Text = autor.Nacionalidade;
                txtNascimento.Text = autor.Nascimento.ToString("dd/MM/yyyy");
                txtGeneros.Text = autor.GenerosAutor;

                dtTabela.DataSource = listaLivrosVinc.ToList();
            }
            else
            {
                txtNome.Clear(); txtNacionalidade.Clear(); txtGeneros.Clear(); txtNascimento.Clear();                
                dtTabela.DataSource = new List<Livro>();
            }
            contExc++;
        }
    }
}
