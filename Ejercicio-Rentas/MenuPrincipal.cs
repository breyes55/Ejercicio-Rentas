using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Rentas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ppeliculas Fpelicula = new Ppeliculas();
            Fpelicula.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pclientes Fclientes = new Pclientes();
            Fclientes.Show();
        }

        private void rentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRentas Frentas = new PRentas();
            Frentas.Show();

        }
    }
}
