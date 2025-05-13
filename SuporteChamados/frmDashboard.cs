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
    public partial class frmprincipal : Form
    {
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
    }
}
