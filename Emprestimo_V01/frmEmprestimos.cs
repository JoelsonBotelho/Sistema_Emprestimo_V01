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
    public partial class frmEmprestimos : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable TabelaItens = new DataTable();
        DataTable TabelaEmprestar = new DataTable();
        DataTable TabelaAmigos = new DataTable();
        int linhaEmprestarNome, linhaEmprestarAmigos;
        public frmEmprestimos()
        {
            InitializeComponent();
        }
        private void CarregarItens()
        {
            cmbEmprestarNome.Items.Clear();
            string cod = "SELECT *FROM TbItens";
            Adaptador.SelectCommand = new OleDbCommand(cod, Conexao);
            Adaptador.Fill(TabelaItens);
            for (int i = 0; i < TabelaItens.Rows.Count; i++)
            {
                cmbEmprestarNome.Items.Add(TabelaItens.Rows[i][1].ToString());

            }
        }
        private void CarregarAmigos()
        {
            cmbEmprestarAmigos.Items.Clear();
            string cod = "SELECT *FROM TbAmigos";
            OleDbCommand Comando = new OleDbCommand(cod, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaAmigos);
            for (int i = 0; i < TabelaAmigos.Rows.Count; i++)
            {
                cmbEmprestarAmigos.Items.Add(TabelaAmigos.Rows[i][1].ToString());
            }
        }
        private void PegarEmprestar()
        {
            TabelaEmprestar.Clear();
            string cod = "SELECT *FROM TbEmprestimos";
            OleDbCommand Comando = new OleDbCommand(cod, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaEmprestar);
            dgvEmprestar.DataSource = TabelaEmprestar;
        }
        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Visible = true;
            this.Visible = false;
        }

        private void frmEmprestimos_Load(object sender, EventArgs e)
        {
            CarregarAmigos();
            CarregarItens();
            PegarEmprestar();
        }

        private void btnEmprestarEditar_Click(object sender, EventArgs e)
        {
            if (DataEmprestar.Value < DataDevolver.Value)
            {
                int EmprQuant = int.Parse(nudEmprestimosQuantidade.Value.ToString());
                int ItensQuant = int.Parse(TabelaItens.Rows[linhaEmprestarNome][2].ToString());
                int linhaSelecionada = dgvEmprestar.CurrentRow.Index;
                int id = int.Parse(TabelaItens.Rows[linhaEmprestarNome][0].ToString());
                int id2 = int.Parse(TabelaAmigos.Rows[linhaEmprestarAmigos][0].ToString());
                int cod = int.Parse(TabelaEmprestar.Rows[linhaSelecionada][0].ToString());
                int Quantidade = ItensQuant - EmprQuant;
                int cod1 = int.Parse(TabelaItens.Rows[linhaEmprestarNome][0].ToString());
                Conexao.Open();
                string query1 = "UPDATE TbItens SET  Quantidade = '" + Quantidade + "'  WHERE CódigoItens = " + cod1;
                OleDbCommand Comando1 = new OleDbCommand(query1, Conexao);
                Comando1.ExecuteNonQuery();
                Conexao.Close();
                Conexao.Open();
                string query = "UPDATE TbEmprestimos SET Nome = '" + id + "', Quantidade = '" + nudEmprestimosQuantidade.Value + "', Amigos = '" + id2 + "', DataEmpr = '" + DataEmprestar.Value.ToShortDateString() + "', DataDev = '" + DataDevolver.Value.ToShortDateString() + "'  WHERE CódigoItens = " + cod;
                OleDbCommand Comando = new OleDbCommand(query, Conexao);
                Comando.ExecuteNonQuery();
                Conexao.Close();
                PegarEmprestar();
            }
            else
            {
                MessageBox.Show("A Data da Devolução não pode ser menor que a Data de Emprestimo");
            }
        }

        private void cmbEmprestarAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            linhaEmprestarAmigos = cmbEmprestarAmigos.SelectedIndex;
        }

        private void cmbEmprestarNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            linhaEmprestarNome = cmbEmprestarNome.SelectedIndex;
            AtualizarQuant();
        }

        private void AtualizarQuant() 
        {
            nudEmprestimosQuantidade.Maximum = int.Parse(TabelaItens.Rows[linhaEmprestarNome][2].ToString());
        }
        private void Atualizar()
        {
            nudDevolver.Maximum = int.Parse(TabelaEmprestar.Rows[dgvEmprestar.CurrentRow.Index][2].ToString());
        }
        private void btnEmprestarRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvEmprestar.CurrentRow.Index;
            int id = int.Parse(TabelaEmprestar.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "DELETE  FROM TbEmprestimos WHERE CódigoItens = " + id;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarEmprestar();
        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            if (cmbEmprestarNome.SelectedIndex >= 0 || cmbEmprestarAmigos.SelectedIndex >= 0 || nudEmprestimosQuantidade.Value != 0)
            {
                int EmprQuant = int.Parse(nudEmprestimosQuantidade.Value.ToString());
                int ItensQuant = int.Parse(TabelaItens.Rows[linhaEmprestarNome][2].ToString());
                int idN = int.Parse(TabelaItens.Rows[linhaEmprestarNome][0].ToString());
                int idA = int.Parse(TabelaAmigos.Rows[linhaEmprestarAmigos][0].ToString());

                if (EmprQuant != 0)
                {
                    if (DataEmprestar.Value <= DataDevolver.Value)
                    {
                        int Quantidade = 0;
                        Quantidade = ItensQuant - EmprQuant;
                        int cod1 = int.Parse(TabelaItens.Rows[linhaEmprestarNome][0].ToString());
                        Conexao.Open();
                        string query1 = "UPDATE TbItens SET  Quantidade = '" + Quantidade + "'  WHERE CódigoItens = " + cod1;
                        OleDbCommand Comando1 = new OleDbCommand(query1, Conexao);
                        Comando1.ExecuteNonQuery();
                        Conexao.Close();
                        string query = "INSERT INTO TbEmprestimos (Nome, Quantidade, Amigos, DataEmpr, DataDev) VALUES (@Nome, @Quantidade, @Amigos, @DataEmpr, @DataDev)";
                        OleDbCommand Comando = new OleDbCommand(query, Conexao);
                        Comando.Parameters.Add("@Nome", OleDbType.VarChar).Value = idN;
                        Comando.Parameters.Add("@Quantidade", OleDbType.Numeric).Value = EmprQuant;
                        Comando.Parameters.Add("@Amigos", OleDbType.VarChar).Value = idA;
                        Comando.Parameters.Add("@DataEmpr", OleDbType.VarChar).Value = DataEmprestar.Value.ToShortDateString();
                        Comando.Parameters.Add("@DataDev", OleDbType.VarChar).Value = DataDevolver.Value.ToShortDateString();
                        try
                        {
                            Conexao.Open();
                            Comando.ExecuteNonQuery();
                            MessageBox.Show("Emprestado");
                            PegarEmprestar();
                            Atualizar();
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
                        MessageBox.Show("A Data da Devolução não pode ser menor que a Data de Emprestimo");
                    }
                }
                else
                {
                    MessageBox.Show("Adicione Quantidade");
                }
            }
            else
            {
                MessageBox.Show("Preencha os Campos em Branco");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvEmprestar.CurrentRow.Index;
            int id = int.Parse(TabelaItens.Rows[linhaEmprestarNome][0].ToString());
            int cod = int.Parse(TabelaEmprestar.Rows[linhaSelecionada][0].ToString());
            int EmprQuant = int.Parse(nudDevolver.Value.ToString());
            int ItensQuant = int.Parse(TabelaItens.Rows[linhaEmprestarNome][2].ToString());
            int Quant = int.Parse(TabelaEmprestar.Rows[linhaSelecionada][2].ToString());
            int cod1 = int.Parse(TabelaEmprestar.Rows[dgvEmprestar.CurrentRow.Index][1].ToString());

            if (id == cod1)
            {
                if (EmprQuant != 0)
                {
                    if (Quant < EmprQuant)
                    {
                        MessageBox.Show("Reduza a Quantidade a Devolver");
                    }
                    else
                    {
                        int QuantidadeFinal = 0;
                        QuantidadeFinal = Quant - EmprQuant;
                        int Quantidade = 0;
                        Quantidade = ItensQuant + EmprQuant;
                        Conexao.Open();
                        string query1 = "UPDATE TbItens SET  Quantidade = '" + Quantidade + "'  WHERE CódigoItens = " + cod1;
                        OleDbCommand Comando1 = new OleDbCommand(query1, Conexao);
                        Comando1.ExecuteNonQuery();
                        Conexao.Close();
                        Conexao.Open();
                        string query = "UPDATE TbEmprestimos SET Quantidade = '" + QuantidadeFinal + "'  WHERE CódigoItens = " + cod;
                        OleDbCommand Comando = new OleDbCommand(query, Conexao);
                        Comando.ExecuteNonQuery();
                        Conexao.Close();
                        PegarEmprestar(); 
                        if (QuantidadeFinal == 0)
                        {
                            Conexao.Open();
                            string query2 = "DELETE  FROM TbEmprestimos WHERE CódigoItens = " + cod;
                            OleDbCommand Comando2 = new OleDbCommand(query2, Conexao);
                            Comando2.ExecuteNonQuery();
                            Conexao.Close();
                            PegarEmprestar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Adicione Quantidade");
                }
            }
            else
            {
                MessageBox.Show("Esse Item Não Foi Emprestado");
            }
        }
    }
}
