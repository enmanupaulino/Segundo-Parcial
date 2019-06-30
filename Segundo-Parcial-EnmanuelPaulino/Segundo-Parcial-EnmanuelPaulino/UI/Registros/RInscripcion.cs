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

namespace Segundo_Parcial_EnmanuelPaulino.UI.Registros
{
    public partial class RInscripcion : Form
    {
        public List<InscripcionDetalle> Detalle { get; set; }
        public RInscripcion()
        {
            InitializeComponent();
            this.Detalle = new List<InscripcionDetalle>();
            LlenaComboBox();
            LlenaComboBoxEstudiantes();
        }
        private void Limpiar()
        {
            InscripcionIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            MontoNumericUpDown.Value = 0;

        }
        private Inscripciones LlenaClase()
        {
            Inscripciones inscripcion = new Inscripciones();

            inscripcion.InscripcionId = (int)InscripcionIdNumericUpDown.Value;
            inscripcion.EstudianteId = Convert.ToInt32(EstudianteComboBox.SelectedValue);
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.Monto = Convert.ToDecimal(MontoNumericUpDown.Value);
            inscripcion.PrecCred = Convert.ToDecimal(PrecCredNumericUpdown.Value);
            inscripcion.PrecLab = Convert.ToDecimal(PreclabNumericUpDown.Value);
            inscripcion.CantLab = Convert.ToInt32(CantLabNumericUpdown.Value);
            inscripcion.Asignatura = this.Detalle;
            return inscripcion;
        }
        public void LlenaCampo(Inscripciones inscripcion)
        {
            InscripcionIdNumericUpDown.Value = inscripcion.InscripcionId;
            FechaDateTimePicker.Value = inscripcion.Fecha;
            MontoNumericUpDown.Value = inscripcion.Monto;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();


            if (MontoNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(MontoNumericUpDown, "Los creditos no pueden ser cero");
                paso = false;

            }

            /*if (MontoNumericUpDown.Value > 5)
            {
                MyErrorProvider.SetError(MontoNumericUpDown, "Una Asignatura no puede tener mas de 5 creditos");
                paso = false;

            }*/


            return paso;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            InscripcionBLL db = new InscripcionBLL();
            Inscripciones inscripcion = new Inscripciones();
            inscripcion = LlenaClase();

            try
            {


                if (InscripcionIdNumericUpDown.Value == 0)
                {
                    /* if (db.Repetido(A => A.Descripcion == DescripcionTextBox.Text))
                     {
                         MessageBox.Show("Esta asignatura ya esta registrada", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }*/

                    if (db.Guardar(inscripcion))
                    {
                        Limpiar();
                        MessageBox.Show("Guardado correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (db.Modificar(inscripcion))
                    {
                        Limpiar();
                        MessageBox.Show("Modificado correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo moficar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();
            MyErrorProvider.Clear();
            try
            {
                if (InscripcionIdNumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)InscripcionIdNumericUpDown.Value))
                    {
                        MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Fallido!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MyErrorProvider.SetError(InscripcionIdNumericUpDown, "Este Campo no puede estar vacio");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();
            MyErrorProvider.Clear();
            int.TryParse(InscripcionIdNumericUpDown.Text, out int Id);
            if (!ExisteEnLaBaseDeDatos())
                return;
            else
            {
                Limpiar();
                LlenaCampo(db.Buscar(Id));
            }


        }
        public bool ExisteEnLaBaseDeDatos()
        {
            Inscripciones inscripcion = new Inscripciones();
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();
            int.TryParse(InscripcionIdNumericUpDown.Text, out int Id);
            inscripcion = db.Buscar(Id);
            return inscripcion != null;
        }
        private void CargarGrid()
        {
            Detalledatagrid.DataSource = null;
            Detalledatagrid.DataSource = this.Detalle;
        }
        private void LlenaComboBox()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            List<Asignaturas> asignaturas = db.GetList(x => true);
            AsignaturasComboBox.DataSource = asignaturas;
            AsignaturasComboBox.ValueMember = "AsignaturasId";
            AsignaturasComboBox.DisplayMember = "Descripcion";
        }
        private void LlenaComboBoxEstudiantes()
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            List<Estudiantes> estudiantes = db.GetList(x => true);
            EstudianteComboBox.DataSource = estudiantes;
            EstudianteComboBox.ValueMember = "EstudianteId";
            EstudianteComboBox.DisplayMember = "Nombres";
        }
        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {
            if (Detalledatagrid.DataSource != null)
                this.Detalle = (List<InscripcionDetalle>)Detalledatagrid.DataSource;
            //todo: validar campos del detalle
            /*if (!ValidarAgregarTelefono())
                return;*/
            //Agregar un nuevo detalle con los datos introducidos.
            InscripcionDetalle inscripcionDetalle = new InscripcionDetalle();
            inscripcionDetalle.AsignaturaId = Convert.ToInt32(AsignaturasComboBox.SelectedValue);
            inscripcionDetalle.InscripcionDetallesId = 0;
            inscripcionDetalle.InscripcionId = Convert.ToInt32(InscripcionIdNumericUpDown.Value);
            this.Detalle.Add(inscripcionDetalle);
            MyErrorProvider.Clear();
            CalculoInscripcion();
            CargarGrid();
        }
        private void CalculoInscripcion()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            int totalCred = 0;
            foreach(var item in Detalle)
            {
                totalCred += db.Buscar(item.AsignaturaId).Creditos;
            }
            decimal PrecCredio = Convert.ToDecimal(PrecCredNumericUpdown.Value);
            decimal PrecLab = Convert.ToDecimal(PreclabNumericUpDown.Value);
            decimal CantLab = Convert.ToDecimal(CantLabNumericUpdown.Value);
            decimal MontoTotal = ((PrecLab * CantLab) + (PrecCredio * totalCred));
            MontoNumericUpDown.Value = Convert.ToDecimal(MontoTotal);
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Detalledatagrid.Rows.Count > 0 && Detalledatagrid.CurrentRow != null)
            {
                this.Detalle.RemoveAt(Detalledatagrid.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}

