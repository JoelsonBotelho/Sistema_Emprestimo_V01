using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Emprestimo_V01
{
    public partial class frmLogin : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable Tabela_Admin = new DataTable();
                    
        public frmLogin()
        {
            InitializeComponent();
            tmrNome.Interval = 400;
            tmrSenha.Interval = 400;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            tmrNome.Enabled = false;
            tmrNome.Enabled = true;
            
        }
        private void Entrar()
        {
            Tabela_Admin.Clear();
            if (txtNome.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios");
            }
            else
            {
                string Nome = txtNome.Text;
                string Senha = txtSenha.Text;

                string CodAdmin = "Select *from tbAdmn where Nome ='" + Nome + "' and Senha ='" + Senha + "'";
                OleDbCommand comando = new OleDbCommand(CodAdmin, Conexao);
                Adaptador.SelectCommand = comando;
                Adaptador.Fill(Tabela_Admin);
                if (Tabela_Admin.Rows.Count <= 0)
                {
                    MessageBox.Show("O Nome ou a Senha está incorreta, Tente Novamente");
                }
                else if (Tabela_Admin.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Login Feito");
                        txtNome.Text = "";
                        txtSenha.Text = "";
                        frmMenu frmmenu = new frmMenu();
                        frmmenu.Visible = true;
                        this.Visible = false;
                    } 
            }
        }
        private void ConsultarSenha() 
        {
            Tabela_Admin.Clear();
            string Senha = txtSenha.Text;
            try
            {
                string CodAdmin = "Select *From tbAdmn where Senha ='" + Senha + "'";
                OleDbCommand comando = new OleDbCommand(CodAdmin, Conexao);
                Adaptador.SelectCommand = comando;
                Adaptador.Fill(Tabela_Admin);
                if (Tabela_Admin.Rows.Count > 0)
                {
                    lblSenha.Visible = true;
                    lblSenha.Text = "√";
                    lblSenha.BackColor = Color.Lime;
                }      
                else   
                {      
                    lblSenha.Visible = true;
                    lblSenha.Text = "X";
                    lblSenha.BackColor = Color.Red;
                }

            }
            catch (FormatException)
            {

            }
        }
        private void ConsultarNome()
        {
            Tabela_Admin.Clear();
            string Nome = txtNome.Text;
            
            try
            {
                string CodAdmin = "Select *From tbAdmn where Nome ='" + Nome + "'";
                OleDbCommand comando = new OleDbCommand(CodAdmin, Conexao);
                Adaptador.SelectCommand = comando;
                Adaptador.Fill(Tabela_Admin);
                if (Tabela_Admin.Rows.Count > 0)
                {
                    lblNome.Visible = true;
                    lblNome.Text = "√";
                    lblNome.BackColor = Color.Lime;
                }
                else
                {
                    lblNome.Visible = true;
                    lblNome.Text = "X";
                    lblNome.BackColor = Color.Red;
                }
 
            }
            catch (FormatException)
            {
            
            }
        }
        private void tmrNome_Tick(object sender, EventArgs e)
        {
            tmrNome.Enabled = false;
            ConsultarNome();
        }

        private void tmrSenha_Tick(object sender, EventArgs e)
        {
            tmrSenha.Enabled = false;
            ConsultarSenha();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            tmrSenha.Enabled = false;
            tmrSenha.Enabled = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacte o Engenheiro Proprietário -- 949835821");
        }

    }
}
