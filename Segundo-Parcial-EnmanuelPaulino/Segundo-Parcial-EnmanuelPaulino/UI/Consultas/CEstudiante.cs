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
                        decimal.TryParse(CriteriosTextBox.Text, out decimal balance);
                        Listado = db.GetList(p => p.Balance == balance);
                        break;
                }
                
            }
            else
            
                Listado = db.GetList(p => true);

                if (FechaCheckBox.Checked == true)
                    Listado = Listado.Where(x => x.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && x.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
                DataGridView.DataSource = null;
            DataGridView.DataSource = Listado;
        }

        private void Hasta_Click(object sender, EventArgs e)
        {

        }
    }
}
