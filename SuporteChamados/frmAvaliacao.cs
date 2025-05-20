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
    public partial class frmAvaliacao : Form
    {
        public frmAvaliacao()
        {
            InitializeComponent();
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            int qualidade = cmbQualidade.SelectedIndex + 1; 
            int tempoEspera = cmbTempodeEspera.SelectedIndex + 1; 
            int tempoAtendimento = cmbTempoAtendimento.SelectedIndex + 1; 

            bool resolvido;
            if (rbResolveu.Checked)
            {
                resolvido = true;
            }
            else if (rbNaoResolveu.Checked)
            {
                resolvido = false;
            }
            else
            {
                MessageBox.Show("Por favor, informe se o problema foi resolvido ou não.");
                return;
            }

            string stringdeConexao = @"Data Source =.\SQLEXPRESS; Initial Catalog = dbSuporteChamados; Integrated Security = True";
            using (SqlConnection conn = new SqlConnection(stringdeConexao)) 
            {
                try
                {
                    conn.Open();        
                    string query = "INSERT INTO tblAvaliacao (qualidade, tempoEspera, tempoAtendimento, resolvido) " +
                                   "VALUES (@qualidade, @tempoEspera, @tempoAtendimento, @resolvido)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@qualidade", qualidade);
                        cmd.Parameters.AddWithValue("@tempoEspera", tempoEspera);
                        cmd.Parameters.AddWithValue("@tempoAtendimento", tempoAtendimento);
                        cmd.Parameters.AddWithValue("@resolvido", resolvido);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Avaliação enviada com sucesso!");
                            LimparFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao enviar avaliação.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de banco de dados: " + ex.Message);
                }
            }
        }
        private void LimparFormulario()
        {
            cmbQualidade.SelectedIndex = -1;
            cmbTempodeEspera.SelectedIndex = -1;
            cmbTempoAtendimento.SelectedIndex = -1;
            rbResolveu.Checked = false;
            rbNaoResolveu.Checked = false;
        }
    }
}
