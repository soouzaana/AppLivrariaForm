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
    public partial class FormConsultarLivro : Form
    {
        int contExc = 1;
        List<Livro> ListaLivros = new List<Livro>();
        List<Genero> ListaGeneros = new List<Genero>();
        public FormConsultarLivro()
        {
            InitializeComponent();
            GeneroContext context = new GeneroContext();
            ListaGeneros = context.ListarGeneros();
            cbGenero.DataSource = ListaGeneros.ToList();
            cbGenero.DisplayMember = "Nome";
            cbGenero.SelectedIndex = -1;

            LivroContext contextLivro = new LivroContext();
            ListaLivros = contextLivro.ListarLivros();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linhaSelec = cbGenero.SelectedIndex;
            if (linhaSelec > -1 && contExc > 1)
            {
                var genero = ListaGeneros[linhaSelec];
                var listaLivrosVinc = ListaLivros.Where(livro => livro.IdGenero == genero.IdGenero).ToList();
                txtNomeGenero.Text = genero.Nome;
                txtDescricao.Text = genero.Descricao;

                dtTabela.DataSource = listaLivrosVinc.ToList();
            }
            else
            {
                txtNomeGenero.Clear(); txtDescricao.Clear();
                dtTabela.DataSource = new List<Livro>();
            }
            contExc++;
        }
    }
}
