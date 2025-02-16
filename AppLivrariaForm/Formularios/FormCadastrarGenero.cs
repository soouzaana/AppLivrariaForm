using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLivrariaForm.Formularios;
using AppLivrariaForm.Models;
using AppLivrariaForm.Contexto;

namespace AppLivrariaForm.Formularios
{
    public partial class FormCadastrarGenero : Form
    {
        static int idGenero = 1;
        public FormCadastrarGenero()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.IdGenero = idGenero; // chave primária
            genero.Nome = txtNomeGenero.Text;
            genero.Descricao = txtDescricao.Text;
            genero.Popularidade = txtPopularidade.Text;
            genero.PublicoAlvo = txtPublicoAlvo.Text;

            GeneroContext context = new GeneroContext();
            context.InserirGenero(genero);
            idGenero++;

            MessageBox.Show("Gênero salvo com sucesso!", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNomeGenero.Clear(); txtDescricao.Clear(); txtPopularidade.Clear(); txtPublicoAlvo.Clear();
            txtNomeGenero.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNomeGenero.Clear(); txtDescricao.Clear(); txtPopularidade.Clear(); txtPublicoAlvo.Clear();
            txtNomeGenero.Select();
        }
    }
}
