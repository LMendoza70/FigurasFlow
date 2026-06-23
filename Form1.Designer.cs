namespace FigurasFlow
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoToolStripMenuItem,
                this.mantenimientoToolStripMenuItem,
                this.figurasToolStripMenuItem,
                this.ayudaToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.salirToolStripMenuItem
            });

            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);

            this.mantenimientoToolStripMenuItem.Text = "&Mantenimiento";
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.usuariosToolStripMenuItem
            });

            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);

            this.figurasToolStripMenuItem.Text = "&Figuras";
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cuadradoToolStripMenuItem,
                this.circuloToolStripMenuItem,
                this.rectanguloToolStripMenuItem
            });

            this.cuadradoToolStripMenuItem.Text = "&Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);

            this.circuloToolStripMenuItem.Text = "&Círculo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);

            this.rectanguloToolStripMenuItem.Text = "&Rectángulo";
            this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.rectanguloToolStripMenuItem_Click);

            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.acercaDeToolStripMenuItem
            });

            this.acercaDeToolStripMenuItem.Text = "&Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";

            this.toolStripStatusLabel1.Text = "Listo";

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FigurasFlow - Calculadora Geométrica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
