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
    public partial class FormPesquisarGenero: Form
    {
        List<Genero> ListaGeneros = new List<Genero>();
        public FormPesquisarGenero()
        {
            InitializeComponent();
            GeneroContext context = new GeneroContext();
            ListaGeneros = context.ListarGeneros();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            var selecao = ListaGeneros.Where(x => x.Nome.Contains(txtNome.Text)).ToList();
            dtTabela.DataSource = selecao.ToList();
        }
    }
}
