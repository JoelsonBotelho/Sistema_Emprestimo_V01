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
    public partial class frmItens : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable TabelaItens = new DataTable();
        DataTable TabelaCategoria = new DataTable();
        int linhaItensCategoria;
        public frmItens()
        {
            InitializeComponent();
        }
        private void PegarItens()
        {
            TabelaItens.Clear();
            string cod = "SELECT *FROM TbItens";
            Adaptador.SelectCommand = new OleDbCommand(cod, Conexao);
            Adaptador.Fill(TabelaItens);
            dgvItens.DataSource = TabelaItens;
        }
        private void CarregarCategoria()
        {
            string query = "SELECT *FROM TbCategoria";
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaCategoria);
            for (int i = 0; i < TabelaCategoria.Rows.Count; i++)
            {
                cmbItensCategoria.Items.Add(TabelaCategoria.Rows[i][1].ToString());
            }
        }
        private void cmbItensCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            linhaItensCategoria = cmbItensCategoria.SelectedIndex;
        }

        private void frmItens_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            PegarItens();
        }

        private void btnItensInserir_Click(object sender, EventArgs e)
        {
            if (txtItensNome.Text != "" )
            {


                int id = int.Parse(TabelaCategoria.Rows[linhaItensCategoria][0].ToString());

                string query = "INSERT INTO TbItens (Nome, Quantidade, Categoria) VALUES (@Nome, @Quantidade, @Categoria)";
                OleDbCommand Comando = new OleDbCommand(query, Conexao);
                Comando.Parameters.Add("@Nome", OleDbType.VarChar).Value = txtItensNome.Text;
                Comando.Parameters.Add("@Quantidade", OleDbType.Numeric).Value = nudItensQuantidade.Value;
                Comando.Parameters.Add("@Categoria", OleDbType.Numeric).Value = id;
                try
                {
                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRADO");
                    PegarItens();
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

        private void btnItensEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvItens.CurrentRow.Index;
            int id = int.Parse(TabelaCategoria.Rows[linhaItensCategoria][0].ToString());
            int cod = int.Parse(TabelaItens.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "UPDATE TbItens SET Nome = '" + txtItensNome.Text + "', Quantidade = '" + nudItensQuantidade.Value + "', Categoria = '" + id + "'  WHERE CódigoItens = " + cod;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarItens();
        }

        private void btnItensRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvItens.CurrentRow.Index;
            int id = int.Parse(TabelaItens.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "DELETE  FROM TbItens WHERE CódigoItens = " + id;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarItens();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Visible = true;
            this.Visible = false;
        }
    }
}
