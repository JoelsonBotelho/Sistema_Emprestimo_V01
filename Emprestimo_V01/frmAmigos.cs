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
    public partial class frmAmigos : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable TabelaGrupo = new DataTable();
        DataTable TabelaAmigos = new DataTable();
        int linhaAmigosGrupo;
        public frmAmigos()
        {
            InitializeComponent();
        }
        private void PegarAmigos()
        {
            TabelaAmigos.Clear();
            string cod = "SELECT *FROM TbAmigos";
            OleDbCommand Comando = new OleDbCommand(cod, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaAmigos);
            dgvAmigos.DataSource = TabelaAmigos;
        }
        private void CarregarGrupo()
        {
            string query = "SELECT *FROM TbGrupo";
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaGrupo);
            for (int i = 0; i < TabelaGrupo.Rows.Count; i++)
            {
                cmbAmigosGrupo.Items.Add(TabelaGrupo.Rows[i][1].ToString());
            }
        }
        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Visible = true;
            this.Visible = false;
        }

        private void btnAmigosInserir_Click(object sender, EventArgs e)
        {
            if (txtAmigosNome.Text != "")
            {


                int id = int.Parse(TabelaGrupo.Rows[linhaAmigosGrupo][0].ToString());

                string query = "INSERT INTO TbAmigos (Amigo, Grupo) VALUES (@Amigo, @Grupo)";
                OleDbCommand Comando = new OleDbCommand(query, Conexao);
                Comando.Parameters.Add("@Amigo", OleDbType.VarChar).Value = txtAmigosNome.Text;
                Comando.Parameters.Add("@Grupo", OleDbType.Numeric).Value = id;
                try
                {
                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRADO");
                    PegarAmigos();
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

        private void btnAmigosEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvAmigos.CurrentRow.Index;
            int id = int.Parse(TabelaGrupo.Rows[linhaAmigosGrupo][0].ToString());
            int cod = int.Parse(TabelaAmigos.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "UPDATE TbAmigos SET Amigo = '" + txtAmigosNome.Text + "', Grupo = '" + id + "'  WHERE CódigoAmigos = " + cod;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarAmigos();
        }

        private void btnAmigosRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvAmigos.CurrentRow.Index;
            int id = int.Parse(TabelaAmigos.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "DELETE  FROM TbAmigos WHERE CódigoAmigos = " + id;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarAmigos();
        }

        private void frmAmigos_Load(object sender, EventArgs e)
        {
            PegarAmigos();
            CarregarGrupo();
        }

        private void cmbAmigosGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            linhaAmigosGrupo = cmbAmigosGrupo.SelectedIndex;
        }
    }
}
