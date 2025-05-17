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
        //
        private void frmListagemChamados_Load(object sender, EventArgs e)
        {
            CarregarListagem();

            cbStatus.SelectedIndex = 0;
            cbPrioridade.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            cbNivel.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            string status = cbStatus.SelectedItem?.ToString();
            string prioridade = cbPrioridade.SelectedItem?.ToString();
            string categoria = cbCategoria.SelectedItem?.ToString();
            string nivel = cbNivel.SelectedItem?.ToString();

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                string query = "SELECT * FROM tblTicket WHERE 1=1";

                if (status != "Todos")
                    query += " AND statusTicket = @status";

                if (prioridade != "Todos") 
                    query += " AND prioridade = @prioridade";

                if (categoria != "Todos" )
                    query += " AND categoria = @categoria"; 

                if (nivel != "Todos")
                    query += " AND nivel = @nivel";

                query += " ORDER BY dataTicket DESC";

                SqlCommand cmd = new SqlCommand(query, conexao);

                if (status != "Todos")
                    cmd.Parameters.AddWithValue("@status", status);
                if (prioridade != "Todos")
                    cmd.Parameters.AddWithValue("@prioridade", prioridade);
                if (categoria != "Todos")
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                if (nivel != "Todos")
                    cmd.Parameters.AddWithValue("@nivel", nivel);

                conexao.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                flpListagemChamados.Controls.Clear();

                while (reader.Read())
                {
                    ucChamados uc = new ucChamados();
                    uc.IdChamado = Convert.ToInt32(reader["idTicket"]);
                    uc.Titulo = reader["titulo"].ToString();
                    uc.Descricao = reader["descricao"].ToString();
                    uc.Status = reader["statusTicket"].ToString();
                    uc.Prioridade = reader["prioridade"].ToString();
                    uc.Categoria = reader["categoria"].ToString();
                    uc.Nivel = reader["nivel"].ToString();
                    uc.Data = Convert.ToDateTime(reader["dataTicket"]).ToString("dd/MM/yyyy");

                    flpListagemChamados.Controls.Add(uc);
                }

                conexao.Close();
            }



        }
    }
}

