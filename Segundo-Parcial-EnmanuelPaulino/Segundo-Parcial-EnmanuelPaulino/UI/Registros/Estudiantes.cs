using Segundo_Parcial_EnmanuelPaulino.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_EnmanuelPaulino.UI.Registros
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            EstudianteIdNumericUpDown.Value = 0;
            FechaIngresoDateTimePicker1.Value = DateTime.Now;
            NombresTextBox.Text = string.Empty;
            BalanceNumericUpDown.Value = 0;
           
        }
        private Entidades.Estudiantes LlenarClase()
        {
           Entidades.Estudiantes estudiantes = new Entidades.Estudiantes();

            estudiantes.Nombres = NombresTextBox.Text;
            estudiantes.EstudianteId = (int)EstudianteIdNumericUpDown.Value;
            estudiantes.FechaIngreso = FechaIngresoDateTimePicker1.Value;
            estudiantes.Balance = BalanceNumericUpDown.Value;

            return estudiantes;
        }
        private void LlenarCampos(Entidades.Estudiantes estudiante)
        {

            EstudianteIdNumericUpDown.Value = estudiante.EstudianteId;
            NombresTextBox.Text = estudiante.Nombres;
            FechaIngresoDateTimePicker1.Value = estudiante.FechaIngreso;
            BalanceNumericUpDown.Value = estudiante.Balance;

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!validar())
                return;

            try
            {
                Entidades.Estudiantes estudiantes = new Entidades.Estudiantes();
                estudiantes = LlenarClase();
                RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

                if (EstudianteIdNumericUpDown.Value == 0)
                {
                    db.Guardar(estudiantes);
                    MessageBox.Show("Guardado Correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.Modificar(estudiantes);
                    MessageBox.Show("Modificado Correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                Limpiar();

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyErrorProvider.SetError(NombresTextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if (FechaIngresoDateTimePicker1.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaIngresoDateTimePicker1, "La fecha no puede ser mayor que la de hoy");
                paso = false;
            }

            return paso;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            try
            {
                if (EstudianteIdNumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)EstudianteIdNumericUpDown.Value))
                    {
                        MessageBox.Show("Eliminado Correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error eliminando", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            try
            {

                if (EstudianteIdNumericUpDown.Value > 0)
                {
                    Entidades.Estudiantes estudiante = new Entidades.Estudiantes();
                    if (( db.Buscar((int)EstudianteIdNumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenarCampos(estudiante);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
