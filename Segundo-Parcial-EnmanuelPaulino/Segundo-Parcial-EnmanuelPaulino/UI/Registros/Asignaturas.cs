﻿using Segundo_Parcial_EnmanuelPaulino.BLL;
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
    public partial class Asignaturas : Form
    {
        public string Descripcion { get; private set; }

        public Asignaturas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            AsignaturaIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CreditosNumericUpDown.Value = 0;

        }
        private Entidades.Asignaturas LlenaClase()
        {
            Entidades.Asignaturas asignaturas = new Entidades.Asignaturas();

            asignaturas.AsignaturasId = (int)AsignaturaIdNumericUpDown.Value;
            asignaturas.Descripcion = DescripcionTextBox.Text;
            asignaturas.Creditos = (int)CreditosNumericUpDown.Value;

            /*   AsignaturaIdNumericUpDown.Value = asignaturas.AsignaturasId;
               DescripcionTextBox.Text = asignaturas.Descripcion;
               CreditosNumericUpDown.Value = asignaturas.Creditos;*/

            return asignaturas;
        }
        public void LlenaCampo(Entidades.Asignaturas asignaturas)
        {
            AsignaturaIdNumericUpDown.Value = asignaturas.AsignaturasId;
            DescripcionTextBox.Text = asignaturas.Descripcion;
            CreditosNumericUpDown.Value = asignaturas.Creditos;
        }
       
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if (CreditosNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CreditosNumericUpDown, "Los creditos no pueden ser cero");
                paso = false;

            }

            if (CreditosNumericUpDown.Value > 5)
            {
                MyErrorProvider.SetError(CreditosNumericUpDown, "Una Asignatura no puede tener mas de 5 creditos");
                paso = false;

            }


            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Entidades.Asignaturas asiganturas = new Entidades.Asignaturas();
            asiganturas = LlenaClase();

            try
            {


                if (AsignaturaIdNumericUpDown.Value == 0)
                {
                    if (db.Repetido(A => A.Descripcion == DescripcionTextBox.Text))
                    {
                        MessageBox.Show("Esta asignatura ya esta registrada", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (db.Guardar(asiganturas))
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
                    if (db.Modificar(asiganturas))
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
                MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            MyErrorProvider.Clear();

            try
            {
                if (AsignaturaIdNumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)AsignaturaIdNumericUpDown.Value))
                    {
                        Limpiar();
                        MessageBox.Show("Eliminado correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "Este campo no puede ser cero");
                    ;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Entidades.Asignaturas asignatura;
            MyErrorProvider.Clear();

            try
            {

                if (AsignaturaIdNumericUpDown.Value > 0)
                {
                    if (( db.Buscar((int)AsignaturaIdNumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenaCampo(asignatura);
                    }
                    else
                    {
                        MessageBox.Show("No se encontro la asignatura", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "Este campo no puede ser cero");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
