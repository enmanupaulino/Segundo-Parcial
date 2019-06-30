namespace Segundo_Parcial_EnmanuelPaulino.UI.Consultas
{
    partial class CEstudiante
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrosComboBox = new System.Windows.Forms.ComboBox();
            this.CriteriosTextBox = new System.Windows.Forms.TextBox();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.Desde = new System.Windows.Forms.Label();
            this.Hasta = new System.Windows.Forms.Label();
            this.Filtros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 74);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(776, 345);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(12, 30);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.DesdeDateTimePicker.TabIndex = 1;
            this.DesdeDateTimePicker.ValueChanged += new System.EventHandler(this.DesdeDateTimePicker_ValueChanged);
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(229, 30);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastaDateTimePicker.TabIndex = 1;
            this.HastaDateTimePicker.ValueChanged += new System.EventHandler(this.HastaDateTimePicker_ValueChanged);
            // 
            // FiltrosComboBox
            // 
            this.FiltrosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrosComboBox.FormattingEnabled = true;
            this.FiltrosComboBox.Items.AddRange(new object[] {
            "Todo",
            "EstudianteId",
            "Nombre",
            "Balance"});
            this.FiltrosComboBox.Location = new System.Drawing.Point(435, 29);
            this.FiltrosComboBox.Name = "FiltrosComboBox";
            this.FiltrosComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrosComboBox.TabIndex = 2;
            this.FiltrosComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrosComboBox_SelectedIndexChanged);
            // 
            // CriteriosTextBox
            // 
            this.CriteriosTextBox.Location = new System.Drawing.Point(562, 30);
            this.CriteriosTextBox.Name = "CriteriosTextBox";
            this.CriteriosTextBox.Size = new System.Drawing.Size(123, 20);
            this.CriteriosTextBox.TabIndex = 3;
            this.CriteriosTextBox.TextChanged += new System.EventHandler(this.CriteriosTextBox_TextChanged);
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Location = new System.Drawing.Point(691, 29);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(97, 21);
            this.ConsultaButton.TabIndex = 4;
            this.ConsultaButton.Text = "Consultar";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(98, 9);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 5;
            this.Desde.Text = "Desde";
            this.Desde.Click += new System.EventHandler(this.Desde_Click);
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Location = new System.Drawing.Point(328, 9);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(35, 13);
            this.Hasta.TabIndex = 5;
            this.Hasta.Text = "Hasta";
            this.Hasta.Click += new System.EventHandler(this.Hasta_Click);
            // 
            // Filtros
            // 
            this.Filtros.AutoSize = true;
            this.Filtros.Location = new System.Drawing.Point(474, 9);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(34, 13);
            this.Filtros.TabIndex = 5;
            this.Filtros.Text = "Filtros";
            this.Filtros.Click += new System.EventHandler(this.Filtros_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Criterios";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // CEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "CEstudiante";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.ComboBox FiltrosComboBox;
        private System.Windows.Forms.TextBox CriteriosTextBox;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.Label Filtros;
        private System.Windows.Forms.Label label4;
    }
}