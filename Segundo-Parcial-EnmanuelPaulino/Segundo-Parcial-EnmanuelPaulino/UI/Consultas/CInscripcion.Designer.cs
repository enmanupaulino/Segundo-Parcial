namespace Segundo_Parcial_EnmanuelPaulino.UI.Consultas
{
    partial class CInscripcion
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
            this.label4 = new System.Windows.Forms.Label();
            this.Filtros = new System.Windows.Forms.Label();
            this.Hasta = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.CriteriosTextBox = new System.Windows.Forms.TextBox();
            this.FiltrosComboBox = new System.Windows.Forms.ComboBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.FechaCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Criterios";
            // 
            // Filtros
            // 
            this.Filtros.AutoSize = true;
            this.Filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtros.Location = new System.Drawing.Point(322, 8);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(49, 18);
            this.Filtros.TabIndex = 23;
            this.Filtros.Text = "Filtros";
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta.Location = new System.Drawing.Point(170, 8);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(47, 18);
            this.Hasta.TabIndex = 24;
            this.Hasta.Text = "Hasta";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(36, 8);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(51, 18);
            this.Desde.TabIndex = 25;
            this.Desde.Text = "Desde";
            // 
            // CriteriosTextBox
            // 
            this.CriteriosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriteriosTextBox.Location = new System.Drawing.Point(412, 31);
            this.CriteriosTextBox.Name = "CriteriosTextBox";
            this.CriteriosTextBox.Size = new System.Drawing.Size(123, 24);
            this.CriteriosTextBox.TabIndex = 20;
            // 
            // FiltrosComboBox
            // 
            this.FiltrosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrosComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrosComboBox.FormattingEnabled = true;
            this.FiltrosComboBox.Items.AddRange(new object[] {
            "Todo",
            "Incripcion Id",
            "Cantidad Laboratorio",
            "Precio Credito",
            "Precio Laboratorio"});
            this.FiltrosComboBox.Location = new System.Drawing.Point(269, 29);
            this.FiltrosComboBox.Name = "FiltrosComboBox";
            this.FiltrosComboBox.Size = new System.Drawing.Size(121, 26);
            this.FiltrosComboBox.TabIndex = 19;
            this.FiltrosComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrosComboBox_SelectedIndexChanged);
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(144, 29);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(96, 24);
            this.HastaDateTimePicker.TabIndex = 17;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(17, 29);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(95, 24);
            this.DesdeDateTimePicker.TabIndex = 18;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 73);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(662, 327);
            this.DataGridView.TabIndex = 16;
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaButton.Image = global::Segundo_Parcial_EnmanuelPaulino.Properties.Resources.iconfinder_search_322497;
            this.ConsultaButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ConsultaButton.Location = new System.Drawing.Point(571, 21);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(103, 35);
            this.ConsultaButton.TabIndex = 21;
            this.ConsultaButton.Text = "Consultar";
            this.ConsultaButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.Location = new System.Drawing.Point(17, 60);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(99, 17);
            this.FechaCheckBox.TabIndex = 26;
            this.FechaCheckBox.Text = "Filtrar por fecha";
            this.FechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // CInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 415);
            this.Controls.Add(this.FechaCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Filtros);
            this.Controls.Add(this.Hasta);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.ConsultaButton);
            this.Controls.Add(this.CriteriosTextBox);
            this.Controls.Add(this.FiltrosComboBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.DataGridView);
            this.Name = "CInscripcion";
            this.Text = "CInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Filtros;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.TextBox CriteriosTextBox;
        private System.Windows.Forms.ComboBox FiltrosComboBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.CheckBox FechaCheckBox;
    }
}