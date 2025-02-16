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
using AppLivrariaForm.Models;
using AppLivrariaForm.Contexto;

namespace AppLivrariaForm.Formularios
{
    public partial class FormGerenciarAutor: Form
    {
        int contExc = 0;
        List<Autor> ListaAutores = new List<Autor>();
        public FormGerenciarAutor()
        {
            InitializeComponent();
            AutorContext context = new AutorContext();
            ListaAutores = context.ListarAutores();
            cbAutor.DataSource = ListaAutores.ToList();
            cbAutor.DisplayMember = "Nome";
            cbAutor.SelectedIndex = -1;
        }

        private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbAutor.SelectedIndex;
            if(linhaSelec > -1 && contExc > 0)
            {
                var autorSelec = ListaAutores[linhaSelec];
                txtNome.Text = autorSelec.Nome;
                txtGeneros.Text = autorSelec.GenerosAutor;
                txtNacionalidade.Text = autorSelec.Nacionalidade;
                txtNascimento.Text = autorSelec.Nascimento.ToString();
            }
            contExc++;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = cbAutor.SelectedIndex;
            if( linhaSelec > -1 && contExc > 0)
            {
                var autorSelec = ListaAutores[linhaSelec];
                autorSelec.Nome = txtNome.Text;
                autorSelec.GenerosAutor = txtGeneros.Text;
                autorSelec.Nacionalidade = txtNacionalidade.Text;
                autorSelec.Nascimento = Convert.ToDateTime(txtNascimento.Text);

                // chamar a classe contexto para inserir os dados no banco
                AutorContext context = new AutorContext();
                context.AtualizarAutor(autorSelec);

                MessageBox.Show("ID: " + autorSelec.IdAutor + "atualizado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtGeneros.Clear(); txtNacionalidade.Clear(); txtNascimento.Clear();
                txtNome.Select();
                contExc = 0;
                ListaAutores = context.ListarAutores();
                cbAutor.DataSource = ListaAutores.ToList();
                cbAutor.SelectedIndex = -1;
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            var linhaSelec = cbAutor.SelectedIndex;
            if(linhaSelec > -1 && contExc > 0)
            {
                var autorSelec = ListaAutores[linhaSelec];

                // chamar a classe contexto para deletar os dados no banco
                AutorContext context = new AutorContext();
                context.DeletarAutor(autorSelec);
                MessageBox.Show("ID: " + autorSelec.IdAutor + "deletado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtGeneros.Clear(); txtNacionalidade.Clear(); txtNascimento.Clear();
                txtNome.Select();
                contExc = 0;
                ListaAutores = context.ListarAutores();
                cbAutor.DataSource = ListaAutores.ToList();
                cbAutor.SelectedIndex = -1;
            }
        }
    }
}
