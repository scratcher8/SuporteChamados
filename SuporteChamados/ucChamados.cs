using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteChamados
{
    public partial class ucChamados : UserControl
    {
        public ucChamados()
        {
            InitializeComponent();
        }

        private int idChamado;
        private string titulo;
        private string descricao;
        private string status;
        private string prioridade;
        private string categoria;
        private string nivel;
        private string data;

        public int IdChamado
        {
            get { return idChamado; }
            set { idChamado = value; lbID.Text = value.ToString(); }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; lbTitulo.Text = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; lbStatus.Text = value; }
        }
        public string Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; lbPrioridade.Text = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; lbCategoria.Text = value; }
        }
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; lbNivel.Text = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; lbData.Text = value; }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmExibicaoUsuario FrmExibicaoUsuario = new frmExibicaoUsuario(idChamado,titulo, descricao, status, prioridade, categoria, nivel);
            FrmExibicaoUsuario.ShowDialog();
            this.Show();

            (this.ParentForm as frmListagemChamados).CarregarListagem();
        }
    }
}
