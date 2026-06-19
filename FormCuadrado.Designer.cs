namespace FigurasFlow
{
    partial class FormCuadrado
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
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetroLabel = new System.Windows.Forms.Label();
            this.lblAreaLabel = new System.Windows.Forms.Label();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(20, 22);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(34, 13);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(80, 19);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(200, 17);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.lblPerimetro);
            this.gbResultados.Controls.Add(this.lblArea);
            this.gbResultados.Controls.Add(this.lblPerimetroLabel);
            this.gbResultados.Controls.Add(this.lblAreaLabel);
            this.gbResultados.Location = new System.Drawing.Point(20, 60);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(300, 100);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(120, 60);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(120, 30);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 1;
            // 
            // lblPerimetroLabel
            // 
            this.lblPerimetroLabel.AutoSize = true;
            this.lblPerimetroLabel.Location = new System.Drawing.Point(20, 60);
            this.lblPerimetroLabel.Name = "lblPerimetroLabel";
            this.lblPerimetroLabel.Size = new System.Drawing.Size(56, 13);
            this.lblPerimetroLabel.TabIndex = 2;
            this.lblPerimetroLabel.Text = "Perímetro:";
            // 
            // lblAreaLabel
            // 
            this.lblAreaLabel.AutoSize = true;
            this.lblAreaLabel.Location = new System.Drawing.Point(20, 30);
            this.lblAreaLabel.Name = "lblAreaLabel";
            this.lblAreaLabel.Size = new System.Drawing.Size(32, 13);
            this.lblAreaLabel.TabIndex = 0;
            this.lblAreaLabel.Text = "Área:";
            // 
            // FormCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cuadrado";
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblAreaLabel;
        private System.Windows.Forms.Label lblPerimetroLabel;
    }
}
