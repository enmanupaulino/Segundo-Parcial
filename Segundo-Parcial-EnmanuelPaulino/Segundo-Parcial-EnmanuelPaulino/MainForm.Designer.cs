namespace Segundo_Parcial_EnmanuelPaulino
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaInscripcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.asignaturaToolStripMenuItem,
            this.inscripcionToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estudiantesToolStripMenuItem.Text = "Asignaturas";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.asignaturaToolStripMenuItem.Text = "Estudiantes";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.AsignaturaToolStripMenuItem_Click);
            // 
            // inscripcionToolStripMenuItem
            // 
            this.inscripcionToolStripMenuItem.Name = "inscripcionToolStripMenuItem";
            this.inscripcionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.inscripcionToolStripMenuItem.Text = "Inscripcion";
            this.inscripcionToolStripMenuItem.Click += new System.EventHandler(this.InscripcionToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaEstudianteToolStripMenuItem,
            this.consultaAsignaturaToolStripMenuItem,
            this.consultaInscripcionToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaEstudianteToolStripMenuItem
            // 
            this.consultaEstudianteToolStripMenuItem.Name = "consultaEstudianteToolStripMenuItem";
            this.consultaEstudianteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaEstudianteToolStripMenuItem.Text = "Consulta Estudiante";
            this.consultaEstudianteToolStripMenuItem.Click += new System.EventHandler(this.ConsultaEstudianteToolStripMenuItem_Click);
            // 
            // consultaAsignaturaToolStripMenuItem
            // 
            this.consultaAsignaturaToolStripMenuItem.Name = "consultaAsignaturaToolStripMenuItem";
            this.consultaAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaAsignaturaToolStripMenuItem.Text = "Consulta Asignatura";
            this.consultaAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaAsignaturaToolStripMenuItem_Click);
            // 
            // consultaInscripcionToolStripMenuItem
            // 
            this.consultaInscripcionToolStripMenuItem.Name = "consultaInscripcionToolStripMenuItem";
            this.consultaInscripcionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultaInscripcionToolStripMenuItem.Text = "Consulta Inscripcion";
            this.consultaInscripcionToolStripMenuItem.Click += new System.EventHandler(this.ConsultaInscripcionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 304);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaInscripcionToolStripMenuItem;
    }
}