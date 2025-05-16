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
using System.Windows.Forms.DataVisualization.Charting;

namespace SuporteChamados
{
    public partial class frmprincipal : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbSuporteChamados;Integrated Security=True";
        SqlConnection objConexao;
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void AbrirCriarChamado(object sender, EventArgs e)
        {
            this.Hide();
            frmCriarChamado FrmCriarChamado = new frmCriarChamado();
            FrmCriarChamado.ShowDialog();
            this.Show();
        }

        private void AbrirListagemChamados(object sender, EventArgs e)
        {
            this.Hide();
            frmListagemChamados FrmListagemChamados = new frmListagemChamados();
            FrmListagemChamados.ShowDialog();
            this.Show();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            AtualizarDashboard();
            CarregarGraficoPrioridade();
        }

        private void AtualizarDashboard()
        {
            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT COUNT(*) FROM tblTicket WHERE statusTicket = 'Aberto' ";

            objConexao.Open();

            lbNumAberto.Text = cmd.ExecuteScalar().ToString();
            
            cmd.CommandText = "SELECT COUNT(*) FROM tblTicket WHERE statusTicket = 'Em Andamento' ";
            lbNumEmAndamento.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT COUNT(*) FROM tblTicket WHERE statusTicket = 'Pendente' ";
            lbNumPendente.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT COUNT(*) FROM tblTicket WHERE statusTicket = 'Resolvido' ";
            lbNumResolvido.Text = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT COUNT(*) FROM tblTicket WHERE statusTicket = 'Fechado' ";
            lbNumFechado.Text = cmd.ExecuteScalar().ToString();

            objConexao.Close();
        }

        private void CarregarGraficoPrioridade()
        {
            chartPrioridade.Series["Prioridade"].Points.Clear();

            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT prioridade, COUNT(*) AS quantidade FROM tblTicket WHERE statusTicket NOT IN ('Resolvido', 'Fechado') GROUP BY prioridade;";

            objConexao.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string prioridade = reader["prioridade"].ToString();
                int quantidade = Convert.ToInt32(reader["quantidade"]);

                chartPrioridade.Series["Prioridade"].Points.AddXY(prioridade, quantidade);
            }

            reader.Close();
            objConexao.Close();
        }
    }
}
