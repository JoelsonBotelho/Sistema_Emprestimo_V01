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
    public partial class frmCategoria : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable TabelaCategoria = new DataTable();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Visible = true;
            this.Visible = false;
        }
        private void PegarCategorias()
        {
            TabelaCategoria.Clear();
            string cod = "SELECT *FROM TbCategoria";
            OleDbCommand Comando = new OleDbCommand(cod, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaCategoria);
            dgvCategorias.DataSource = TabelaCategoria;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            PegarCategorias();
        }

        private void btnCategoriasInserir_Click(object sender, EventArgs e)
        {
            if (txtCategoriasNome.Text != "")
            {
                string query = "INSERT INTO TbCategoria (Categoria) VALUES (@Categoria)";
                OleDbCommand Comando = new OleDbCommand(query, Conexao);
                Comando.Parameters.Add("@Categoria", OleDbType.VarChar).Value = txtCategoriasNome.Text;
                try
                {
                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRADA");
                    PegarCategorias();
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

        private void btnCategoriasEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvCategorias.CurrentRow.Index;;
            int cod = int.Parse(TabelaCategoria.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "UPDATE TbCategoria SET Categoria = '" + txtCategoriasNome.Text + "'  WHERE CódigoCategoria = " + cod;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarCategorias();
        }

        private void btnCategoriasRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvCategorias.CurrentRow.Index;
            int id = int.Parse(TabelaCategoria.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "DELETE  FROM TbCategoria WHERE CódigoCategoria = " + id;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarCategorias();
        }
    }
}
