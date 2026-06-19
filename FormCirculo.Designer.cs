namespace FigurasFlow
{
    partial class FormCirculo
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblCircunferencia = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCircunferenciaLabel = new System.Windows.Forms.Label();
            this.lblAreaLabel = new System.Windows.Forms.Label();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();

            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(20, 22);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(38, 13);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio:";

            this.txtRadio.Location = new System.Drawing.Point(80, 19);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 1;

            this.btnCalcular.Location = new System.Drawing.Point(200, 17);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;

            this.gbResultados.Controls.Add(this.lblCircunferencia);
            this.gbResultados.Controls.Add(this.lblArea);
            this.gbResultados.Controls.Add(this.lblCircunferenciaLabel);
            this.gbResultados.Controls.Add(this.lblAreaLabel);
            this.gbResultados.Location = new System.Drawing.Point(20, 60);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(300, 100);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";

            this.lblAreaLabel.AutoSize = true;
            this.lblAreaLabel.Location = new System.Drawing.Point(20, 30);
            this.lblAreaLabel.Name = "lblAreaLabel";
            this.lblAreaLabel.Size = new System.Drawing.Size(32, 13);
            this.lblAreaLabel.TabIndex = 0;
            this.lblAreaLabel.Text = "Área:";

            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(120, 30);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 1;

            this.lblCircunferenciaLabel.AutoSize = true;
            this.lblCircunferenciaLabel.Location = new System.Drawing.Point(20, 60);
            this.lblCircunferenciaLabel.Name = "lblCircunferenciaLabel";
            this.lblCircunferenciaLabel.Size = new System.Drawing.Size(82, 13);
            this.lblCircunferenciaLabel.TabIndex = 2;
            this.lblCircunferenciaLabel.Text = "Circunferencia:";

            this.lblCircunferencia.AutoSize = true;
            this.lblCircunferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircunferencia.Location = new System.Drawing.Point(120, 60);
            this.lblCircunferencia.Name = "lblCircunferencia";
            this.lblCircunferencia.Size = new System.Drawing.Size(0, 13);
            this.lblCircunferencia.TabIndex = 3;

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCirculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Círculo";
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCircunferencia;
        private System.Windows.Forms.Label lblAreaLabel;
        private System.Windows.Forms.Label lblCircunferenciaLabel;
    }
}
