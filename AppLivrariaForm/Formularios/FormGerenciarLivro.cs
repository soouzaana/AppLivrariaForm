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
    public partial class FormGerenciarLivro: Form
    {
        int contExc = 1;
        int idLivro = 1;
        List<Livro> ListaLivros = new List<Livro>();
        List<Genero> ListaGeneros = new List<Genero>();
        public FormGerenciarLivro()
        {
            InitializeComponent();
            GeneroContext generoContext = new GeneroContext();
            ListaGeneros = generoContext.ListarGeneros();
            cbGenero.DataSource = ListaGeneros.ToList();
            cbGenero.DisplayMember = "Nome";
            cbGenero.SelectedIndex = -1;

            LivroContext livroContext = new LivroContext();
            ListaLivros = livroContext.ListarLivros();
            cbLivro.DataSource = ListaLivros.ToList();
            cbLivro.DisplayMember = "Titulo";
            cbLivro.SelectedIndex = -1;

            txtTitulo.Clear(); txtClassificacao.Clear(); txtISBN.Clear(); txtAno.Clear();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int generoSelec = cbGenero.SelectedIndex;
            if(generoSelec > -1 && contExc > 1)
            {
                var genero = ListaGeneros[generoSelec];
                var listaLivrosVinc = ListaLivros.Where(x => x.IdGenero == genero.IdGenero).ToList();
                cbLivro.DataSource = listaLivrosVinc;
                cbLivro.DisplayMember = "Titulo";
                cbLivro.ValueMember = "Id";
            }
            contExc++;
        }

        private void cbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int livroSelec = cbLivro.SelectedIndex;
            if(livroSelec > -1 && contExc > 1)
            {
                var livro = ListaLivros[livroSelec];
                idLivro = livro.Id;
                txtTitulo.Text = livro.Titulo;
                txtClassificacao.Text = livro.Classificacao;
                txtISBN.Text = livro.ISBN.ToString();
                txtAno.Text = livro.Ano.ToString();
            }
            contExc++;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = cbLivro.SelectedIndex;
            int generoSelecionado = cbGenero.SelectedIndex;

            if(linhaSelecionada > -1 && generoSelecionado > -1 && contExc > 0)
            {
                var livro = (Livro)cbLivro.SelectedItem;

                livro.Titulo = txtTitulo.Text;
                livro.Classificacao = txtClassificacao.Text;
                livro.ISBN = Convert.ToInt32(txtISBN.Text);
                livro.Ano = Convert.ToInt32(txtAno.Text);

                LivroContext livroContext = new LivroContext();
                livroContext.AtualizarLivro(livro);

                MessageBox.Show($"ID: {livro.Id} atualizado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTitulo.Clear(); txtClassificacao.Clear(); txtISBN.Clear(); txtAno.Clear();

                var genero = ListaGeneros[generoSelecionado];
                ListaLivros = livroContext.ListarLivros();
                var listaLivrosVinc = ListaLivros.Where(x => x.IdGenero == genero.IdGenero).ToList();

                cbLivro.DataSource = listaLivrosVinc;
                cbLivro.DisplayMember = "Titulo";
                cbLivro.ValueMember = "Id";
                cbLivro.SelectedIndex = -1;

            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            var linhaSelec = cbLivro.SelectedIndex;
            if(linhaSelec > -1 && contExc > 0)
            {
                var livroSelec = ListaLivros[linhaSelec];

                LivroContext livroContext = new LivroContext();
                livroContext.DeletarLivro(livroSelec);

                ListaLivros = livroContext.ListarLivros();
                cbLivro.DataSource = null;
                cbLivro.DataSource = ListaLivros;
                cbLivro.DisplayMember = "Titulo";
                cbLivro.ValueMember = "Id";
                cbLivro.SelectedIndex = -1;

                MessageBox.Show($"ID: {livroSelec.Id} deletado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTitulo.Clear(); txtClassificacao.Clear(); txtISBN.Clear(); txtAno.Clear();
                contExc = 0;
            }
        }
    }
}
