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
    public partial class CInscripcion : Form
    {
        
        public CInscripcion()
        {
            InitializeComponent();
            FiltrosComboBox.SelectedIndex = 0;

        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Inscripciones>();
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();
            if (CriteriosTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrosComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        Listado = db.GetList(p => true);
                        break;
                    case 1://Inscripcion Idd
                        int.TryParse(CriteriosTextBox.Text, out int Id);
                        Listado = db.GetList(p => p.InscripcionId == Id);
                        break;
                    case 2: //Cantidad Laboratorio
                        int CantiLab = Convert.ToInt32(CriteriosTextBox.Text);
                        Listado = db.GetList(p => p.CantLab == CantiLab );
                        break;
                    case 3:// Precio Creditos
                        int PreciCre = Convert.ToInt32(CriteriosTextBox.Text);
                        Listado = db.GetList(p => p.PrecCred == PreciCre);
                        break;
                    case 4: //
                        int PrecioLab = Convert.ToInt32(CriteriosTextBox.Text);
                        Listado = db.GetList(p => p.PrecLab == PrecioLab);
                        break;
                    

                }  
            }
            else
                Listado = db.GetList(p => true);
            
            if (FechaCheckBox.Checked == true)
                Listado = Listado.Where(x => x.Fecha.Date >= DesdeDateTimePicker.Value.Date && x.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            DataGridView.DataSource = null;
            DataGridView.DataSource = Listado;
        }

        private void FiltrosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
