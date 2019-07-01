using Segundo_Parcial_EnmanuelPaulino.BLL;
using Segundo_Parcial_EnmanuelPaulino.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_EnmanuelPaulino.UI.Registros
{
    public partial class REstudiantes : Form
    {
        public REstudiantes()
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
            estudiantes.Balance = (int)BalanceNumericUpDown.Value;

            return estudiantes;
        }
        private void LlenaCampo(Entidades.Estudiantes estudiante)
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

      
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!validar())
                return;
            Estudiantes estudiantes = new Estudiantes();
            estudiantes = LlenarClase();
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            try
            {
               

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
                throw;
            }
        }

        private bool validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            var regex = new Regex(@"^[A-Za-z ]+$");
            if (!(regex.IsMatch(NombresTextBox.Text)))
            {
                MyErrorProvider.SetError(NombresTextBox, "El nombre solo debe contener letras"); 
                paso = false;
            }
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
                        MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Fallido!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            MyErrorProvider.Clear();
            int.TryParse(EstudianteIdNumericUpDown.Text, out int Id);
            if (!ExisteEnLaBaseDeDatos())
                return;
            else
            {
                Limpiar();
                LlenaCampo(db.Buscar(Id));
            }
            /* RepositorioBase<REstudiantes> db = new RepositorioBase<REstudiantes>();
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
            }*/
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            Estudiantes estudiantes = new Estudiantes();
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            int.TryParse(EstudianteIdNumericUpDown.Text, out int Id);
            estudiantes = db.Buscar(Id);
            return estudiantes != null;
        }

        private void FechaIngresoDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
