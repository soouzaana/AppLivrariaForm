using AppLivrariaForm.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLivrariaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarGenero_Click(object sender, EventArgs e)
        {
            FormCadastrarGenero form = new FormCadastrarGenero();
            form.ShowDialog();
        }

        private void btCadastrarLivro_Click(object sender, EventArgs e)
        {
            FormCadastrarLivro form = new FormCadastrarLivro();
            form.ShowDialog();
        }
        private void btCadastrarAutor_Click(object sender, EventArgs e)
        {
            FormCadastrarAutor form = new FormCadastrarAutor();
            form.ShowDialog();
        }


        private void btGerenciarAutor_Click(object sender, EventArgs e)
        {
            FormGerenciarAutor form = new FormGerenciarAutor();
            form.ShowDialog();
        }

        private void btListarGeneros_Click(object sender, EventArgs e)
        {
            FormListarGenero form = new FormListarGenero();
            form.ShowDialog();
        }

        private void btListarAutores_Click(object sender, EventArgs e)
        {
            FormListarAutor form = new FormListarAutor();
            form.ShowDialog();
        }

        private void btListarLivros_Click(object sender, EventArgs e)
        {
            FormListarLivro form = new FormListarLivro();
            form.ShowDialog();
        }

        private void btPesquisarAutor_Click(object sender, EventArgs e)
        {
            FormPesquisarAutor form = new FormPesquisarAutor();
            form.ShowDialog();
        }

        private void btGerenciarGenero_Click(object sender, EventArgs e)
        {
            FormGerenciarGeneros form = new FormGerenciarGeneros();
            form.ShowDialog();
        }

        private void btPesquisarGenero_Click(object sender, EventArgs e)
        {
            FormPesquisarGenero form = new FormPesquisarGenero();
            form.ShowDialog();
        }

        private void btConsultarLivro_Click(object sender, EventArgs e)
        {
            FormConsultarLivro form = new FormConsultarLivro();
            form.ShowDialog();
        }

        private void btGerenciarLivro_Click(object sender, EventArgs e)
        {
            FormGerenciarLivro form = new FormGerenciarLivro();
            form.ShowDialog();
        }

        private void btPesquisarLivro_Click(object sender, EventArgs e)
        {
            FormPesquisarLivro form = new FormPesquisarLivro();
            form.ShowDialog();
        }
    }
}
