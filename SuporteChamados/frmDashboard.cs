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

            AtualizarGeral();
        }

        private void AbrirListagemChamados(object sender, EventArgs e)
        {
            this.Hide();
            frmListagemChamados FrmListagemChamados = new frmListagemChamados();
            FrmListagemChamados.ShowDialog();
            this.Show();

            AtualizarGeral();
        }

        private void AtualizarGeral()
        {
            AtualizarDashboard();
            CarregarGraficoPrioridade();
            CarregarGraficoResolucao();
            CarregarTicketsTempo();
            CarregarTicketsCategoria();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            AtualizarGeral();
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

            chartPrioridade.Series["Prioridade"].Label = "#PERCENT{P1}";
            chartPrioridade.Series["Prioridade"].LegendText = "#VALX";            

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

        private void CarregarGraficoResolucao()
        {
            chartTaxaResolucao.Series["TaxaResolucao"].Points.Clear();

            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT statusTicket, COUNT(*) AS quantidade  FROM tblTicket WHERE statusTicket IN ('Resolvido', 'Fechado') GROUP BY statusTicket";

            objConexao.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            int resolvidos = 0;
            int fechados = 0;

            while (reader.Read())
            {
                string status = reader["statusTicket"].ToString();
                int quantidade = Convert.ToInt32(reader["quantidade"]);

                if (status == "Resolvido")
                    resolvidos = quantidade;
                else if (status == "Fechado")
                    fechados = quantidade;
            }

            reader.Close();

            int total = resolvidos + fechados;

            if (total > 0)
            {
                int indexResolvido = chartTaxaResolucao.Series["TaxaResolucao"].Points.AddXY("Resolvidos", resolvidos);
                chartTaxaResolucao.Series["TaxaResolucao"].Points[indexResolvido].Color = Color.SteelBlue;

                int indexFechado = chartTaxaResolucao.Series["TaxaResolucao"].Points.AddXY("Fechados", fechados);
                chartTaxaResolucao.Series["TaxaResolucao"].Points[indexFechado].Color = Color.DarkGray;

                chartTaxaResolucao.Series["TaxaResolucao"].Label = "#PERCENT{P1}";
                chartTaxaResolucao.Series["TaxaResolucao"].LegendText = "#VALX";
            }

            objConexao.Close();
        }

        private void CarregarTicketsTempo()
        {
            chartTicketsTempo.Series["TicketsTempo"].Points.Clear();

            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT DATEFROMPARTS(YEAR(dataTicket), MONTH(dataTicket), 1) AS data, COUNT(*) AS quantidade FROM tblTicket WHERE dataTicket >= DATEADD(MONTH, -6, CAST(GETDATE() AS DATE)) GROUP BY YEAR(dataTicket), MONTH(dataTicket) ORDER BY data;";

            objConexao.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime data = reader.GetDateTime(reader.GetOrdinal("data"));
                int qtd = reader.GetInt32(reader.GetOrdinal("quantidade"));
                chartTicketsTempo.Series["TicketsTempo"].Points.AddXY(data, qtd);
            }

            reader.Close();

            objConexao.Close();

            var areaX = chartTicketsTempo.ChartAreas[0].AxisX;
            areaX.LabelStyle.Format = "MMM/yyyy";
            areaX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            areaX.Interval = 1;
            areaX.MajorGrid.LineColor = Color.LightGray;

            var areaY = chartTicketsTempo.ChartAreas[0].AxisY;
            areaY.MajorGrid.LineColor = Color.LightGray;

            var serie = chartTicketsTempo.Series["TicketsTempo"];
            serie.Color = Color.SteelBlue;
            serie.BorderWidth = 2;
        }

        private void CarregarTicketsCategoria()
        {
            chartCategoria.Series["Categoria"].Points.Clear();

            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT categoria, COUNT(*) AS quantidade FROM tblTicket GROUP BY categoria ORDER BY quantidade DESC";

            objConexao.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string categoria = reader.GetString(reader.GetOrdinal("categoria"));
                int qtd = reader.GetInt32(reader.GetOrdinal("quantidade"));
                chartCategoria.Series["Categoria"].Points.AddXY(categoria, qtd);
            }

            reader.Close();

            objConexao.Close();

            chartCategoria.Series["Categoria"].Label = "#PERCENT{P1}";
            chartCategoria.Series["Categoria"].LegendText = "#VALX";  
            chartCategoria.Legends[0].Docking = Docking.Right;
        }

        private void Avaliacao(object sender, EventArgs e)
        {
            this.Hide();
            frmAvaliacao Frmavaliacao = new frmAvaliacao();
            Frmavaliacao.ShowDialog();
            this.Show();
        }
    }
}
