namespace FigProyecto
{
    partial class frmCUADRADO
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
            lblPerimetroCuadrado = new Label();
            lblAreaCuadrado = new Label();
            btnCalcular = new Button();
            label2 = new Label();
            txtLadoCuadrado = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPerimetroCuadrado
            // 
            lblPerimetroCuadrado.AutoSize = true;
            lblPerimetroCuadrado.Location = new Point(57, 182);
            lblPerimetroCuadrado.Name = "lblPerimetroCuadrado";
            lblPerimetroCuadrado.Size = new Size(69, 15);
            lblPerimetroCuadrado.TabIndex = 10;
            lblPerimetroCuadrado.Text = "PERIMETRO";
            // 
            // lblAreaCuadrado
            // 
            lblAreaCuadrado.AutoSize = true;
            lblAreaCuadrado.Location = new Point(57, 129);
            lblAreaCuadrado.Name = "lblAreaCuadrado";
            lblAreaCuadrado.Size = new Size(36, 15);
            lblAreaCuadrado.TabIndex = 9;
            lblAreaCuadrado.Text = "AREA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(347, 71);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 31);
            label2.Name = "label2";
            label2.Size = new Size(236, 16);
            label2.TabIndex = 7;
            label2.Text = "INGRESE EL LADO DEL CUADRADO";
            // 
            // txtLadoCuadrado
            // 
            txtLadoCuadrado.Location = new Point(322, 31);
            txtLadoCuadrado.Name = "txtLadoCuadrado";
            txtLadoCuadrado.Size = new Size(128, 23);
            txtLadoCuadrado.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1570_medium_square_emoji_coloring_page;
            pictureBox1.Location = new Point(219, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmCUADRADO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 337);
            Controls.Add(pictureBox1);
            Controls.Add(lblPerimetroCuadrado);
            Controls.Add(lblAreaCuadrado);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtLadoCuadrado);
            Name = "frmCUADRADO";
            Text = "CUADRADO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPerimetroCuadrado;
        private Label lblAreaCuadrado;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtLadoCuadrado;
        private PictureBox pictureBox1;
    }
}