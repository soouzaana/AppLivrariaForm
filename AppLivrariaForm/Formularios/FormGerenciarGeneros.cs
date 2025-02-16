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
using Org.BouncyCastle.Asn1.Cmp;

namespace AppLivrariaForm.Formularios
{
    public partial class FormGerenciarGeneros: Form
    {
        int contExc = 0;
        List<Genero> ListaGeneros = new List<Genero>();
        public FormGerenciarGeneros()
        {
            InitializeComponent(); 
            GeneroContext context = new GeneroContext();
            ListaGeneros = context.ListarGeneros();
            cbGenero.DataSource = ListaGeneros.ToList();
            cbGenero.DisplayMember = "Nome";
            cbGenero.SelectedIndex = -1;
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            var linhaSelec = cbGenero.SelectedIndex;
            if(linhaSelec > -1 && contExc > 0)
            {
                var generoSelec = ListaGeneros[linhaSelec];
                txtNome.Text = generoSelec.Nome;
                txtDescricao.Text = generoSelec.Descricao;
                txtPopularidade.Text = generoSelec.Popularidade;
                txtPublicoAlvo.Text = generoSelec.PublicoAlvo;
            }
            contExc++;
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            var linhaSelec = cbGenero.SelectedIndex;
            if(linhaSelec > -1 && contExc > 0)
            {
                var generoSelec = ListaGeneros[linhaSelec];
                generoSelec.Nome = txtNome.Text;
                generoSelec.Descricao = txtDescricao.Text;
                generoSelec.Popularidade = txtPopularidade.Text;
                generoSelec.PublicoAlvo = txtPublicoAlvo.Text;

                GeneroContext context = new GeneroContext();
                context.AtualizarGenero(generoSelec);

                MessageBox.Show("ID: " + generoSelec.IdGenero + "atualizado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtDescricao.Clear(); txtPopularidade.Clear(); txtPublicoAlvo.Clear();
                txtNome.Select();
                contExc = 0;

                ListaGeneros = context.ListarGeneros();
                cbGenero.DataSource = ListaGeneros.ToList();
                cbGenero.SelectedIndex = -1;
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            var linhaSelec = cbGenero.SelectedIndex;
            if(linhaSelec > -1 && contExc > 0)
            {
                var generoSelec = ListaGeneros[linhaSelec];
                GeneroContext context = new GeneroContext();
                context.DeletarGenero(generoSelec);
                MessageBox.Show("ID: " + generoSelec.IdGenero + "deletado com sucesso", "2ºA INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear(); txtDescricao.Clear(); txtPopularidade.Clear(); txtPublicoAlvo.Clear();
                txtNome.Select();
                contExc = 0;
                ListaGeneros = context.ListarGeneros();
                cbGenero.DataSource = ListaGeneros.ToList();
                cbGenero.SelectedIndex = -1;
            }
        }
    }
}
