﻿using Segundo_Parcial_EnmanuelPaulino.BLL;
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
    public partial class CAsignatura : Form
    {
        public CAsignatura()
        {
            InitializeComponent();
            FiltrosComboBox.SelectedIndex = 0;
        }

        private void ConsultaButton_Click(object sender, EventArgs e)
        {
            var Listado = new List<Asignaturas>();
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            if (CriteriosTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrosComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        Listado = db.GetList(p => true);
                        break;
                    case 1://EstudianteId
                        int.TryParse(CriteriosTextBox.Text, out int Id);
                        Listado = db.GetList(p => p.AsignaturasId == Id);
                        break;
                    case 2: //Nombres
                        Listado = db.GetList(p => p.Descripcion.Contains(CriteriosTextBox.Text));
                        break;
                    case 3:// balance
                        int.TryParse(CriteriosTextBox.Text, out int balance);
                        Listado = db.GetList(p => p.Creditos == balance);
                        break;
                }
                
            }
            else
                Listado = db.GetList(p => true);

            if (FechaCheckBox.Checked == true)
                Listado = Listado.Where(x => x.FechaAsignatura.Date >= DesdeDateTimePicker.Value.Date && x.FechaAsignatura.Date <= HastaDateTimePicker.Value.Date).ToList();

            DataGridView.DataSource = null;
            DataGridView.DataSource = Listado;
        }
  
    }
}
