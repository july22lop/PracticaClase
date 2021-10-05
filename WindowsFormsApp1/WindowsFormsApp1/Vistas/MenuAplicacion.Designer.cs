
namespace WindowsFormsApp1.Vistas
{
    partial class MenuAplicacion
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
            this.archiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiToolStripMenuItem,
            this.operacionesMatematicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archiToolStripMenuItem
            // 
            this.archiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioProfesorToolStripMenuItem,
            this.formularioAlumnoToolStripMenuItem});
            this.archiToolStripMenuItem.Name = "archiToolStripMenuItem";
            this.archiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archiToolStripMenuItem.Text = "Archivo";
            this.archiToolStripMenuItem.Click += new System.EventHandler(this.archiToolStripMenuItem_Click);
            // 
            // formularioProfesorToolStripMenuItem
            // 
            this.formularioProfesorToolStripMenuItem.Name = "formularioProfesorToolStripMenuItem";
            this.formularioProfesorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formularioProfesorToolStripMenuItem.Text = "Formulario Profesor";
            // 
            // formularioAlumnoToolStripMenuItem
            // 
            this.formularioAlumnoToolStripMenuItem.Name = "formularioAlumnoToolStripMenuItem";
            this.formularioAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formularioAlumnoToolStripMenuItem.Text = "Formulario Alumno";
            // 
            // operacionesMatematicasToolStripMenuItem
            // 
            this.operacionesMatematicasToolStripMenuItem.Name = "operacionesMatematicasToolStripMenuItem";
            this.operacionesMatematicasToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.operacionesMatematicasToolStripMenuItem.Text = "Operaciones Matematicas";
            // 
            // MenuAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAplicacion";
            this.Text = "MenuAplicacion";
            this.Load += new System.EventHandler(this.MenuAplicacion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesMatematicasToolStripMenuItem;
    }
}