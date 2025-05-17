using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteChamados
{
    public partial class frmCriarChamado : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbSuporteChamados;Integrated Security=True";
        SqlConnection objConexao;
        int idUsuario = 1;

        public frmCriarChamado()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            objConexao.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO tblTicket (titulo, descricao, prioridade, categoria, nivel, statusTicket, dataTicket, idSolicitante) VALUES (@titulo, @descricao, @prioridade, @categoria, @nivel, @statusTicket, @dataTicket, @idSolicitante)");
            cmd.Connection = objConexao;
            cmd.Parameters.AddWithValue("@titulo", txtTituloTicket.Text);
            cmd.Parameters.AddWithValue("@descricao", txtDescricaoTicket.Text);
            cmd.Parameters.AddWithValue("@prioridade", cbPrioridadeTicket.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@categoria", cbCategoriaTicket.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@nivel", cbNivel.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@statusTicket", "Aberto");
            cmd.Parameters.AddWithValue("@dataTicket", DateTime.Now);
            cmd.Parameters.AddWithValue("@idSolicitante", IdUsuario.IDUsuario);

            int linhasAfetadas = cmd.ExecuteNonQuery();
            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Chamado registrado com sucesso!","Sucesso",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nenhum registro inserido. Verifique os dados.", "Erro", MessageBoxButtons.OK);
            }

            objConexao.Close();
        }
    }
}
