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
    public partial class frmContactos : Form
    {
        OleDbConnection Conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hp\Documents\Joelson Botelho\TLP\Emprestimo_V01\BD_Emprestimo_V01.mdb");
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        DataTable TabelaContacto = new DataTable();
        DataTable TabelaAmigo = new DataTable();
        int linhaContactoAmigo;
        public frmContactos()
        {
            InitializeComponent();
        }
        private void PegarContactos()
        {
            TabelaContacto.Clear();
            string cod = "SELECT *FROM TbContacto";
            Adaptador.SelectCommand = new OleDbCommand(cod, Conexao);
            Adaptador.Fill(TabelaContacto);
            dgvContactos.DataSource = TabelaContacto;
        }

        private void CarregarAmigos()
        {
            string query = "SELECT *FROM TbAmigos";
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Adaptador.SelectCommand = Comando;
            Adaptador.Fill(TabelaAmigo);
            for (int i = 0; i < TabelaAmigo.Rows.Count; i++)
            {
                cmbContactosNome.Items.Add(TabelaAmigo.Rows[i][1].ToString());
            }
        }
        private void frmContactos_Load(object sender, EventArgs e)
        {
            PegarContactos();
            CarregarAmigos();
        }

        private void btnContactosInserir_Click(object sender, EventArgs e)
        {
            if (txtContactosNumero.Text != "" )
            {


                int id = int.Parse(TabelaAmigo.Rows[linhaContactoAmigo][0].ToString());

                string query = "INSERT INTO TbContacto (Números, Amigos) VALUES (@Números, @Amigos)";
                OleDbCommand Comando = new OleDbCommand(query, Conexao);
                Comando.Parameters.Add("@Números", OleDbType.VarChar).Value = txtContactosNumero.Text;
                Comando.Parameters.Add("@Amigos", OleDbType.Numeric).Value = id;
                try
                {
                    Conexao.Open();
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("CADASTRADO");
                    PegarContactos();
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

        private void btnContactosEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvContactos.CurrentRow.Index;
            int id = int.Parse(TabelaAmigo.Rows[linhaContactoAmigo][0].ToString());
            int cod = int.Parse(TabelaContacto.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "UPDATE TbContacto SET Números = '" + txtContactosNumero.Text +"', Amigos = '" + id + "'  WHERE CódigoContactos = " + cod;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarContactos();
        }

        private void btnContactosRemover_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvContactos.CurrentRow.Index;
            int id = int.Parse(TabelaContacto.Rows[linhaSelecionada][0].ToString());
            Conexao.Open();
            string query = "DELETE  FROM TbContacto WHERE CódigoContactos = " + id;
            OleDbCommand Comando = new OleDbCommand(query, Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            PegarContactos();
        }

        private void btnMenuInicial_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Visible = true;
            this.Visible = false;
        }

        private void cmbContactosNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            linhaContactoAmigo = cmbContactosNome.SelectedIndex;
        }
    }
}
