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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            //string de conexão
            string stringdeConexao = @"Data Source =.\SQLEXPRESS; Initial Catalog = dbSuporteChamados; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(stringdeConexao))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT idUsuario, nome FROM tblUsuario WHERE loginUsuario = @usuario AND senha = @senha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            IdUsuario.IDUsuario = reader.GetInt32(0);
                            IdUsuario.NomeUsuario = reader.GetString(1);

                            this.Hide();
                            frmprincipal Frmprincipal = new frmprincipal();
                            Frmprincipal.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }
            }
        }
    }
}
