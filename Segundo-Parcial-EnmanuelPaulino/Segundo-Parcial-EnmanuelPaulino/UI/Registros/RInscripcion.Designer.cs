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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AsignaturasComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AgregarDetalleButton = new System.Windows.Forms.Button();
            this.Detalledatagrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.CantLabNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PreclabNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecCredNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.MontoNumericUpDown.Location = new System.Drawing.Point(496, 129);
            this.MontoNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MontoNumericUpDown.TabIndex = 23;
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(190, 45);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.InscripcionIdNumericUpDown.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inscripcion Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(379, 20);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 15;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(366, 422);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(215, 422);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(77, 422);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 18;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(508, 47);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(120, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(60, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 237);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaturas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asignatura";
            // 
            // AsignaturasComboBox
            // 
            this.AsignaturasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsignaturasComboBox.FormattingEnabled = true;
            this.AsignaturasComboBox.Location = new System.Drawing.Point(69, 14);
            this.AsignaturasComboBox.Name = "AsignaturasComboBox";
            this.AsignaturasComboBox.Size = new System.Drawing.Size(121, 21);
            this.AsignaturasComboBox.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(6, 214);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove File";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AgregarDetalleButton
            // 
            this.AgregarDetalleButton.Location = new System.Drawing.Point(416, 12);
            this.AgregarDetalleButton.Name = "AgregarDetalleButton";
            this.AgregarDetalleButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarDetalleButton.TabIndex = 1;
            this.AgregarDetalleButton.Text = "Agregar";
            this.AgregarDetalleButton.UseVisualStyleBackColor = true;
            this.AgregarDetalleButton.Click += new System.EventHandler(this.AgregarDetalleButton_Click);
            // 
            // Detalledatagrid
            // 
            this.Detalledatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detalledatagrid.Location = new System.Drawing.Point(9, 41);
            this.Detalledatagrid.Name = "Detalledatagrid";
            this.Detalledatagrid.Size = new System.Drawing.Size(485, 167);
            this.Detalledatagrid.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cant de laboratorios";
            // 
            // CantLabNumericUpdown
            // 
            this.CantLabNumericUpdown.Location = new System.Drawing.Point(190, 71);
            this.CantLabNumericUpdown.Name = "CantLabNumericUpdown";
            this.CantLabNumericUpdown.Size = new System.Drawing.Size(120, 20);
            this.CantLabNumericUpdown.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio X laboratorio";
            // 
            // PreclabNumericUpDown
            // 
            this.PreclabNumericUpDown.Location = new System.Drawing.Point(190, 96);
            this.PreclabNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PreclabNumericUpDown.Name = "PreclabNumericUpDown";
            this.PreclabNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PreclabNumericUpDown.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio X credito";
            // 
            // PrecCredNumericUpdown
            // 
            this.PrecCredNumericUpdown.Location = new System.Drawing.Point(190, 122);
            this.PrecCredNumericUpdown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PrecCredNumericUpdown.Name = "PrecCredNumericUpdown";
            this.PrecCredNumericUpdown.Size = new System.Drawing.Size(120, 20);
            this.PrecCredNumericUpdown.TabIndex = 23;
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(190, 149);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(121, 21);
            this.EstudianteComboBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "EstudianteId";
            // 
            // RInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 457);
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