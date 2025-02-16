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
    public partial class FormListarAutor : Form
    {
        public FormListarAutor()
        {
            InitializeComponent();
            AutorContext context = new AutorContext();//prepara a conexão com o banco
            dtTabela.DataSource = context.ListarAutores();
        }
    }
}
