using Segundo_Parcial_EnmanuelPaulino.UI.Consultas;
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
            RAsignaturas f = new RAsignaturas();
            f.Show();
        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REstudiantes f = new REstudiantes();
            f.Show();
        }

        private void ConsultaEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEstudiante f = new CEstudiante();
            f.Show();
        }

        private void ConsultaAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAsignatura f = new CAsignatura();
            f.Show();
        }

        private void InscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RInscripcion f = new RInscripcion();
            f.Show();
        }
    }
}
