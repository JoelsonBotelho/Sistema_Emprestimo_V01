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
    public partial class frmGrupos : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable TabelaGrupo = new DataTable();
        public frmGrupos()
        {
            InitializeComponent();
        }
        private void PegarGrupos()
        {
            TabelaGrupo.Clear();
            string cod = "SELECT *FROM TbGrupo";
            OleDbCommand Comando = new OleDbCommand(cod, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaGrupo);
            dgvGrupos.DataSource = TabelaGrupo;
        }
        private void btnGruposInserir_Click(object sender, EventArgs e)
        {
            if (txtGruposNome.Text != "")
            {
                string query = "INSERT INTO TbGrupo (Grupo) VALUES (@Grupo)";
                OleDbCommand Comando = new OleDbCommand(query, Conexao);
                Comando.Parameters.Add("@Categoria", OleDbType.VarChar).Value = txtGruposNome.Text;
                try
                {
                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRADO");
                    PegarGrupos();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha os Campos em Branco");
            }
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Visible = true;
            this.Visible = false;
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            PegarGrupos();
        }

        private void btnGruposEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvGrupos.CurrentRow.Index; ;
            int cod = int.Parse(TabelaGrupo.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "UPDATE TbGrupo SET Grupo = '" + txtGruposNome.Text + "'  WHERE CódigoGrupo = " + cod;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarGrupos();
        }

        private void btnGruposRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvGrupos.CurrentRow.Index;
            int id = int.Parse(TabelaGrupo.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "DELETE  FROM TbGrupo WHERE CódigoGrupo = " + id;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarGrupos();
        }
    }
}
