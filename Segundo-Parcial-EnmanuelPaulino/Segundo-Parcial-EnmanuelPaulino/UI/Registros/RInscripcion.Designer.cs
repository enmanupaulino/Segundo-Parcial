namespace Segundo_Parcial_EnmanuelPaulino.UI.Registros
{
    partial class RInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MontoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InscripcionIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AsignaturasComboBox = new System.Windows.Forms.ComboBox();
            this.Detalledatagrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CantLabNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PreclabNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecCredNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AgregarDetalleButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detalledatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantLabNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreclabNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecCredNumericUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // MontoNumericUpDown
            // 
            this.MontoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoNumericUpDown.Location = new System.Drawing.Point(360, 133);
            this.MontoNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.ReadOnly = true;
            this.MontoNumericUpDown.Size = new System.Drawing.Size(90, 24);
            this.MontoNumericUpDown.TabIndex = 23;
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(166, 12);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.InscripcionIdNumericUpDown.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inscripcion Id";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(358, 103);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(92, 24);
            this.FechaDateTimePicker.TabIndex = 25;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AsignaturasComboBox);
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.AgregarDetalleButton);
            this.groupBox1.Controls.Add(this.Detalledatagrid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 276);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaturas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asignatura";
            // 
            // AsignaturasComboBox
            // 
            this.AsignaturasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsignaturasComboBox.FormattingEnabled = true;
            this.AsignaturasComboBox.Location = new System.Drawing.Point(89, 19);
            this.AsignaturasComboBox.Name = "AsignaturasComboBox";
            this.AsignaturasComboBox.Size = new System.Drawing.Size(151, 26);
            this.AsignaturasComboBox.TabIndex = 3;
            // 
            // Detalledatagrid
            // 
            this.Detalledatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detalledatagrid.Location = new System.Drawing.Point(16, 51);
            this.Detalledatagrid.Name = "Detalledatagrid";
            this.Detalledatagrid.Size = new System.Drawing.Size(389, 179);
            this.Detalledatagrid.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cant de laboratorios";
            // 
            // CantLabNumericUpdown
            // 
            this.CantLabNumericUpdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantLabNumericUpdown.Location = new System.Drawing.Point(166, 42);
            this.CantLabNumericUpdown.Name = "CantLabNumericUpdown";
            this.CantLabNumericUpdown.Size = new System.Drawing.Size(120, 24);
            this.CantLabNumericUpdown.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio X laboratorio";
            // 
            // PreclabNumericUpDown
            // 
            this.PreclabNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreclabNumericUpDown.Location = new System.Drawing.Point(166, 72);
            this.PreclabNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PreclabNumericUpDown.Name = "PreclabNumericUpDown";
            this.PreclabNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.PreclabNumericUpDown.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio X credito";
            // 
            // PrecCredNumericUpdown
            // 
            this.PrecCredNumericUpdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecCredNumericUpdown.Location = new System.Drawing.Point(166, 102);
            this.PrecCredNumericUpdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PrecCredNumericUpdown.Name = "PrecCredNumericUpdown";
            this.PrecCredNumericUpdown.Size = new System.Drawing.Size(120, 24);
            this.PrecCredNumericUpdown.TabIndex = 23;
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudianteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(166, 132);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(121, 26);
            this.EstudianteComboBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Estudiante";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_meanicons_24_197210;
            this.RemoveButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RemoveButton.Location = new System.Drawing.Point(18, 236);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(128, 34);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove File";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AgregarDetalleButton
            // 
            this.AgregarDetalleButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_add_134224;
            this.AgregarDetalleButton.Location = new System.Drawing.Point(360, 12);
            this.AgregarDetalleButton.Name = "AgregarDetalleButton";
            this.AgregarDetalleButton.Size = new System.Drawing.Size(45, 37);
            this.AgregarDetalleButton.TabIndex = 1;
            this.AgregarDetalleButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.AgregarDetalleButton.UseVisualStyleBackColor = true;
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarDetalleButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_search_322497;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BuscarButton.Location = new System.Drawing.Point(292, 7);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 32);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.TabStop = false;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_delete_227590;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EliminarButton.Location = new System.Drawing.Point(360, 450);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 32);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.NuevoButton.Location = new System.Drawing.Point(200, 450);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(86, 32);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_save_326688;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.GuardarButton.Location = new System.Drawing.Point(28, 450);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(94, 32);
            this.GuardarButton.TabIndex = 18;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // RInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 503);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EstudianteComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.PrecCredNumericUpdown);
            this.Controls.Add(this.PreclabNumericUpDown);
            this.Controls.Add(this.CantLabNumericUpdown);
            this.Controls.Add(this.MontoNumericUpDown);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Name = "RInscripcion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Detalledatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantLabNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreclabNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecCredNumericUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown MontoNumericUpDown;
        private System.Windows.Forms.NumericUpDown InscripcionIdNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Detalledatagrid;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AgregarDetalleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AsignaturasComboBox;
        private System.Windows.Forms.NumericUpDown PrecCredNumericUpdown;
        private System.Windows.Forms.NumericUpDown PreclabNumericUpDown;
        private System.Windows.Forms.NumericUpDown CantLabNumericUpdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
    }
}