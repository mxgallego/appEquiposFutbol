using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEquiposfutbol
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            FormEquipos formularioEquipo = new FormEquipos();
            formularioEquipo.Show();
        }

        private void btnFutbolistas_Click(object sender, EventArgs e)
        {
            FormFutbolistas formularioFutbolista = new FormFutbolistas();
            formularioFutbolista.Show();
        }
    }
}
