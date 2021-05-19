using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza2
{
    public partial class frmListaLudzi : Form
    {
        Model1Container dane = new Model1Container();
        public frmListaLudzi()
        {
            InitializeComponent();
            PobierzDane();
        }
        private void PobierzDane()
        {
            czlowiekSetBindingSource.DataSource = dane.czlowiekSet.ToList();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            frmCzlowiek edytor = new frmCzlowiek(-1);
            edytor.StartPosition = FormStartPosition.CenterScreen;
            edytor.ShowDialog();
            PobierzDane();
        }
    }
}
