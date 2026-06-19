using System;
using System.Windows.Forms;

namespace FigurasFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(Form formHijo)
        {
            formHijo.MdiParent = this;
            formHijo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCuadrado());
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCirculo());
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormRectangulo());
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "FigurasFlow v1.0\n\nProyecto educativo para aprender\ntrabajo colaborativo con Git y GitHub.",
                "Acerca de FigurasFlow",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
