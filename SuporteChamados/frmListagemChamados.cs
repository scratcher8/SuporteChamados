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
    public partial class frmListagemChamados : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=dbSuporteChamados;Integrated Security=True";
        SqlConnection objConexao;

        public frmListagemChamados()
        {
            InitializeComponent();
        }

        public void CarregarListagem()
        {
            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao;
            cmd.CommandText = "SELECT * FROM tblTicket ORDER BY dataTicket DESC";

            objConexao.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            flpListagemChamados.Controls.Clear();

            while (reader.Read())
            {
                ucChamados ucChamado = new ucChamados();
                ucChamado.IdChamado = Convert.ToInt32(reader["idTicket"]);
                ucChamado.Titulo = reader["titulo"].ToString();
                ucChamado.Descricao = reader["descricao"].ToString();
                ucChamado.Status = reader["statusTicket"].ToString();
                ucChamado.Prioridade = reader["prioridade"].ToString();
                ucChamado.Categoria = reader["categoria"].ToString();
                ucChamado.Nivel = reader["nivel"].ToString();
                ucChamado.Data = reader["dataTicket"].ToString();

                flpListagemChamados.Controls.Add(ucChamado);
            }

            objConexao.Close();
        }

        private void frmListagemChamados_Load(object sender, EventArgs e)
        {
            CarregarListagem();
        }
    }
}
