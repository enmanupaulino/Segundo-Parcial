﻿namespace Segundo_Parcial_EnmanuelPaulino.UI.Consultas
{
    partial class CAsignatura
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
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.CriteriosTextBox = new System.Windows.Forms.TextBox();
            this.FiltrosComboBox = new System.Windows.Forms.ComboBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Criterios";
            // 
            // Filtros
            // 
            this.Filtros.AutoSize = true;
            this.Filtros.Location = new System.Drawing.Point(385, 20);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(34, 13);
            this.Filtros.TabIndex = 13;
            this.Filtros.Text = "Filtros";
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Location = new System.Drawing.Point(230, 20);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(35, 13);
            this.Hasta.TabIndex = 14;
            this.Hasta.Text = "Hasta";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(61, 20);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 15;
            this.Desde.Text = "Desde";
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Location = new System.Drawing.Point(661, 38);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(97, 21);
            this.ConsultaButton.TabIndex = 11;
            this.ConsultaButton.Text = "Consultar";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            this.ConsultaButton.Click += new System.EventHandler(this.ConsultaButton_Click);
            // 
            // CriteriosTextBox
            // 
            this.CriteriosTextBox.Location = new System.Drawing.Point(505, 37);
            this.CriteriosTextBox.Name = "CriteriosTextBox";
            this.CriteriosTextBox.Size = new System.Drawing.Size(123, 20);
            this.CriteriosTextBox.TabIndex = 10;
            // 
            // FiltrosComboBox
            // 
            this.FiltrosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrosComboBox.FormattingEnabled = true;
            this.FiltrosComboBox.Items.AddRange(new object[] {
            "Todo",
            "AsignaturaId",
            "Descripcion",
            "Creditos"});
            this.FiltrosComboBox.Location = new System.Drawing.Point(345, 37);
            this.FiltrosComboBox.Name = "FiltrosComboBox";
            this.FiltrosComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrosComboBox.TabIndex = 9;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(201, 38);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.HastaDateTimePicker.TabIndex = 7;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(33, 38);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.DesdeDateTimePicker.TabIndex = 8;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 85);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(776, 345);
            this.DataGridView.TabIndex = 6;
            // 
            // CAsignatura
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
            this.Name = "CAsignatura";
            this.Text = "CAsignatura";
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
    }
}