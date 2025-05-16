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

            // Aqui você abre a conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection("SUA_STRING_DE_CONEXAO"))
            {
                conn.Open();
                string query = "SELECT id, nome FROM usuarios WHERE login = @usuario AND senha = @senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha); // Lembre de criptografar na versão final!

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                       
                        IdUsuario.IDUsuario = reader.GetInt32(0);
                        IdUsuario.NomeUsuario = reader.GetString(1);

                        MessageBox.Show("Login bem-sucedido!");

                        
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
        }
    }
}
