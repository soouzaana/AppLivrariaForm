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
    public partial class FormListarLivro: Form
    {
        public FormListarLivro()
        {
            InitializeComponent();
            LivroContext context = new LivroContext();//prepara a conexão com o banco
            dtTabela.DataSource = context.ListarLivros();
        }
    }
}
