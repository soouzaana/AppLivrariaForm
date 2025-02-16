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
    public partial class FormPesquisarLivro: Form
    {
        List<Livro> ListaLivros = new List<Livro>();
        public FormPesquisarLivro()
        {
            InitializeComponent();
            LivroContext context = new LivroContext();
            ListaLivros = context.ListarLivros();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var selecao = ListaLivros.Where(x => x.Titulo.Contains(txtTitulo.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
