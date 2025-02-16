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
    public partial class FormCadastrarAutor : Form
    {
        static int idAutor = 1;
        public FormCadastrarAutor()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {         
            Autor autor = new Autor();
            autor.IdAutor = idAutor; // chave primária
            autor.Nome = txtNome.Text;
            autor.Nacionalidade = txtNacionalidade.Text;
            autor.GenerosAutor = txtGeneros.Text;
            autor.Nascimento = Convert.ToDateTime(txtDataNascimento.Text);

            // chamar a classse contexto para inserir os dados no banco
            AutorContext context = new AutorContext();
            context.InserirAutor(autor);
            idAutor++;

            MessageBox.Show("Autor salvo com sucesso!", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Clear(); txtNacionalidade.Clear(); txtGeneros.Clear(); txtDataNascimento.Clear();
            txtNome.Select();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); txtNacionalidade.Clear(); txtGeneros.Clear(); txtDataNascimento.Clear();
            txtNome.Select();
        }
    }
}
