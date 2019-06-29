using Segundo_Parcial_EnmanuelPaulino.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_EnmanuelPaulino
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignaturas f = new Asignaturas();
            f.Show();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantes f = new Estudiantes();
            f.Show();
        }
    }
}
