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
        public frmCriarChamado()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objConexao = new SqlConnection();
            objConexao.ConnectionString = strConexao;

            objConexao.Open();

            objConexao.Close();
        }
    }
}
