namespace FigProyecto
{
    partial class frmCUBO
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
            lblVolumenCubo = new Label();
            lblAreaCubo = new Label();
            btnCalcular = new Button();
            label2 = new Label();
            txtRadioCubo = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVolumenCubo
            // 
            lblVolumenCubo.AutoSize = true;
            lblVolumenCubo.Location = new Point(66, 191);
            lblVolumenCubo.Name = "lblVolumenCubo";
            lblVolumenCubo.Size = new Size(63, 15);
            lblVolumenCubo.TabIndex = 11;
            lblVolumenCubo.Text = "VOLUMEN";
            // 
            // lblAreaCubo
            // 
            lblAreaCubo.AutoSize = true;
            lblAreaCubo.Location = new Point(66, 131);
            lblAreaCubo.Name = "lblAreaCubo";
            lblAreaCubo.Size = new Size(36, 15);
            lblAreaCubo.TabIndex = 10;
            lblAreaCubo.Text = "AREA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(299, 77);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 32);
            label2.Name = "label2";
            label2.Size = new Size(200, 16);
            label2.TabIndex = 8;
            label2.Text = "INGRESE EL LADO DEL CUBO";
            // 
            // txtRadioCubo
            // 
            txtRadioCubo.Location = new Point(274, 32);
            txtRadioCubo.Name = "txtRadioCubo";
            txtRadioCubo.Size = new Size(100, 23);
            txtRadioCubo.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Figura_17_Dibujo_de_un_cubo_en_perspectiva;
            pictureBox1.Location = new Point(226, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmCUBO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 331);
            Controls.Add(pictureBox1);
            Controls.Add(lblVolumenCubo);
            Controls.Add(lblAreaCubo);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtRadioCubo);
            Name = "frmCUBO";
            Text = "CUBO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVolumenCubo;
        private Label lblAreaCubo;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtRadioCubo;
        private PictureBox pictureBox1;
    }
}