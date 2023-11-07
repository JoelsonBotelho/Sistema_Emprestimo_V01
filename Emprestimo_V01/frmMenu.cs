using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprestimo_V01
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            frmItens frmitens = new frmItens();
            frmitens.Visible = true;
            this.Visible = false;
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            frmAmigos frmamigos = new frmAmigos();
            frmamigos.Visible = true;
            this.Visible = false;
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            frmGrupos frmgrupos = new frmGrupos();
            frmgrupos.Visible = true;
            this.Visible = false;
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            frmContactos frmcontactos = new frmContactos();
            frmcontactos.Visible = true;
            this.Visible = false;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria frmcategoria = new frmCategoria();
            frmcategoria.Visible = true;
            this.Visible = false;
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            frmEmprestimos frmemprestimos = new frmEmprestimos();
            frmemprestimos.Visible = true;
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Visible = true;
            this.Visible = false;
        }
    }
}
