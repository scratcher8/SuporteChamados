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
    public partial class frmExibicaoUsuario : Form
    {
        string strConexao = @"Data Source=CATEAS21104172\SQLEXPRESS;Initial Catalog = dbSuporteChamados; Integrated Security = True";
        SqlConnection objConexao;

        private int idChamado;

        public frmExibicaoUsuario(int idChamado)
        {
            InitializeComponent();
            this.idChamado = idChamado;
        }
       

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                objConexao = new SqlConnection();
                objConexao.ConnectionString = strConexao;

                objConexao.Open();

                SqlCommand cmd = new SqlCommand("UPDATE tblTicket SET titulo = @titulo, descricao = @descricao, prioridade = @prioridade," +
                    " categoria = @categoria, nivel = @nivel, statusTicket = @statusTicket, dataFechamento = @DataFechamento WHERE idTicket = @idChamado", objConexao);

                cmd.Parameters.AddWithValue("@titulo", txtTituloTicket.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricaoTicket.Text);
                cmd.Parameters.AddWithValue("@prioridade", cbPrioridadeTicket.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@categoria", cbCategoriaTicket.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@nivel", cbNivel.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@statusTicket", cbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@idChamado", idChamado);

                if (cbStatus.SelectedItem.ToString() == "Resolvido" || cbStatus.SelectedItem.ToString() == "Fechado")
                {
                    cmd.Parameters.AddWithValue("@DataFechamento", DateTime.Now);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DataFechamento", DBNull.Value);
                }

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Chamado atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nenhum registro inserido. Verifique os dados.", "Erro", MessageBoxButtons.OK);
                }


                objConexao.Close();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar chamado: " + ex.Message);
            }

           
        }
    }

   

}
    

