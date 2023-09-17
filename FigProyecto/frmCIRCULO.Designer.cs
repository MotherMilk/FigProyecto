namespace FigProyecto
{
    partial class frmCIRCULO
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
            txtRadioCirculo = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            lblAreaCirculo = new Label();
            lblPerimetroCirculo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRadioCirculo
            // 
            txtRadioCirculo.Location = new Point(269, 24);
            txtRadioCirculo.Name = "txtRadioCirculo";
            txtRadioCirculo.Size = new Size(128, 23);
            txtRadioCirculo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(231, 16);
            label2.TabIndex = 2;
            label2.Text = "INGRESE EL RADIO DEL CIRCULO";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(322, 76);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblAreaCirculo
            // 
            lblAreaCirculo.AutoSize = true;
            lblAreaCirculo.Location = new Point(87, 136);
            lblAreaCirculo.Name = "lblAreaCirculo";
            lblAreaCirculo.Size = new Size(36, 15);
            lblAreaCirculo.TabIndex = 4;
            lblAreaCirculo.Text = "AREA";
            // 
            // lblPerimetroCirculo
            // 
            lblPerimetroCirculo.AutoSize = true;
            lblPerimetroCirculo.Location = new Point(87, 185);
            lblPerimetroCirculo.Name = "lblPerimetroCirculo";
            lblPerimetroCirculo.Size = new Size(69, 15);
            lblPerimetroCirculo.TabIndex = 5;
            lblPerimetroCirculo.Text = "PERIMETRO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(235, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmCIRCULO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 346);
            Controls.Add(pictureBox1);
            Controls.Add(lblPerimetroCirculo);
            Controls.Add(lblAreaCirculo);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtRadioCirculo);
            Name = "frmCIRCULO";
            Text = "CIRCULO";
            Load += CIRCULO_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRadioCirculo;
        private Label label2;
        private Button btnCalcular;
        private Label lblAreaCirculo;
        private Label lblPerimetroCirculo;
        private PictureBox pictureBox1;
    }
}