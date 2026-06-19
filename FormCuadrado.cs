using System.Windows.Forms;

namespace FigurasFlow
{
    public partial class FormCuadrado : Form
    {
        private Cuadrado cuadrado;
        public FormCuadrado()
        {
            InitializeComponent();
            cuadrado = new Cuadrado();
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            cuadrado.lado = double.Parse(txtLado.Text);
            lblArea.Text = "Area: " + cuadrado.CalcularArea();
            lblPerimetro.Text = "Perimetro: " + cuadrado.CalcularPerimetro();
            
        }
    }
}
