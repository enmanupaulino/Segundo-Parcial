using Segundo_Parcial_EnmanuelPaulino.BLL;
using Segundo_Parcial_EnmanuelPaulino.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_EnmanuelPaulino.UI.Consultas
{
    public partial class CEstudiante : Form
    {
        public CEstudiante()
        {
            InitializeComponent();
            FiltrosComboBox.SelectedIndex = 0;
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Estudiantes>();
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            if (CriteriosTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrosComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        Listado = db.GetList(p => true);
                        break;
                    case 1://EstudianteId
                        int.TryParse(CriteriosTextBox.Text, out int Id);
                        Listado = db.GetList(p => p.EstudianteId == Id);
                        break;
                    case 2: //Nombres
                        Listado = db.GetList(p => p.Nombres.Contains(CriteriosTextBox.Text));
                        break;
                    case 3:// balance
                        int balance = Convert.ToInt32(CriteriosTextBox.Text);
                        Listado = db.GetList(p => p.Balance == balance);
                        break;
                }
                Listado = Listado.Where(C => C.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && C.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                Listado = db.GetList(p => true);

            }
            DataGridView.DataSource = null;
            DataGridView.DataSource = Listado;
        }

        private void Filtros_Click(object sender, EventArgs e)
        {

        }

        private void Hasta_Click(object sender, EventArgs e)
        {

        }

        private void Desde_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CriteriosTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltrosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
