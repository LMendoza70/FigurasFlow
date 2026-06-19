using System.Windows.Forms;

namespace FigurasFlow
{
    public partial class FormRectangulo : Form
    {
        private Clsrectangulo rectangulo;
        public FormRectangulo()
        {
            InitializeComponent();
            rectangulo = new Clsrectangulo();
        }

        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            rectangulo.ladoMayor = double.Parse(txtBase.Text.Trim());
            rectangulo.ladoMenor = double.Parse(txtAltura.Text.Trim());
            lblArea.Text = "Area:" + rectangulo.CalcularArea().ToString();
            lblPerimetro.Text = "Perimetro:" + rectangulo.CalcularPerimetro().ToString();
        }
    }
}
