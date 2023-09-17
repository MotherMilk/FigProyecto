namespace FigProyecto
{
    partial class frmESFERA
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
            txtRadioEsfera = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            lblAreaEsfera = new Label();
            lblVolumenEsfera = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRadioEsfera
            // 
            txtRadioEsfera.Location = new Point(268, 73);
            txtRadioEsfera.Name = "txtRadioEsfera";
            txtRadioEsfera.Size = new Size(100, 23);
            txtRadioEsfera.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(236, 16);
            label2.TabIndex = 3;
            label2.Text = "INGRESE EL RADIO DE LA ESFERA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(293, 129);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblAreaEsfera
            // 
            lblAreaEsfera.AutoSize = true;
            lblAreaEsfera.Location = new Point(37, 185);
            lblAreaEsfera.Name = "lblAreaEsfera";
            lblAreaEsfera.Size = new Size(36, 15);
            lblAreaEsfera.TabIndex = 5;
            lblAreaEsfera.Text = "AREA";
            // 
            // lblVolumenEsfera
            // 
            lblVolumenEsfera.AutoSize = true;
            lblVolumenEsfera.Location = new Point(37, 233);
            lblVolumenEsfera.Name = "lblVolumenEsfera";
            lblVolumenEsfera.Size = new Size(63, 15);
            lblVolumenEsfera.TabIndex = 6;
            lblVolumenEsfera.Text = "VOLUMEN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__1_;
            pictureBox1.Location = new Point(185, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmESFERA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 376);
            Controls.Add(pictureBox1);
            Controls.Add(lblVolumenEsfera);
            Controls.Add(lblAreaEsfera);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtRadioEsfera);
            Name = "frmESFERA";
            Text = "ESFERA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRadioEsfera;
        private Label label2;
        private Button btnCalcular;
        private Label lblAreaEsfera;
        private Label lblVolumenEsfera;
        private PictureBox pictureBox1;
    }
}