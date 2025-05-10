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

        private void button2_Click(object sender, EventArgs e)
        {
            frmCriarChamado FrmCriarChamado = new frmCriarChamado();
            FrmCriarChamado.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListagemChamados FrmListagemChamados = new frmListagemChamados();
           FrmListagemChamados.ShowDialog();
            this.Hide();
        }
    }
}
