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
    public partial class FormPesquisarAutor: Form
    {
        List<Autor> ListaAutores = new List<Autor>();
        public FormPesquisarAutor()
        {
            InitializeComponent();
            AutorContext context = new AutorContext();
            ListaAutores = context.ListarAutores();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var selecao = ListaAutores.Where(x => x.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
