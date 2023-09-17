namespace FigProyecto
{
    partial class frmTRIANGULO
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
            lblPerimetroTriangulo = new Label();
            lblAreaTriangulo = new Label();
            btnCalcular = new Button();
            label2 = new Label();
            txtBaseTriangulo = new TextBox();
            txtAlturaTriangulo = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPerimetroTriangulo
            // 
            lblPerimetroTriangulo.AutoSize = true;
            lblPerimetroTriangulo.Location = new Point(68, 253);
            lblPerimetroTriangulo.Name = "lblPerimetroTriangulo";
            lblPerimetroTriangulo.Size = new Size(69, 15);
            lblPerimetroTriangulo.TabIndex = 10;
            lblPerimetroTriangulo.Text = "PERIMETRO";
            // 
            // lblAreaTriangulo
            // 
            lblAreaTriangulo.AutoSize = true;
            lblAreaTriangulo.Location = new Point(68, 214);
            lblAreaTriangulo.Name = "lblAreaTriangulo";
            lblAreaTriangulo.Size = new Size(36, 15);
            lblAreaTriangulo.TabIndex = 9;
            lblAreaTriangulo.Text = "AREA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(346, 134);
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
            label2.Location = new Point(23, 32);
            label2.Name = "label2";
            label2.Size = new Size(243, 16);
            label2.TabIndex = 7;
            label2.Text = "INGRESE LA BASE DEL TRIANGULO";
            // 
            // txtBaseTriangulo
            // 
            txtBaseTriangulo.Location = new Point(293, 32);
            txtBaseTriangulo.Name = "txtBaseTriangulo";
            txtBaseTriangulo.Size = new Size(128, 23);
            txtBaseTriangulo.TabIndex = 6;
            // 
            // txtAlturaTriangulo
            // 
            txtAlturaTriangulo.Location = new Point(293, 74);
            txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            txtAlturaTriangulo.Size = new Size(128, 23);
            txtAlturaTriangulo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 77);
            label1.Name = "label1";
            label1.Size = new Size(262, 16);
            label1.TabIndex = 13;
            label1.Text = "INGRESE LA ALTURA DEL TRIANGULO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_equilateral_triangle_black_and_white_png_image_4585163;
            pictureBox1.Location = new Point(229, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // frmTRIANGULO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 374);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtAlturaTriangulo);
            Controls.Add(lblPerimetroTriangulo);
            Controls.Add(lblAreaTriangulo);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtBaseTriangulo);
            Name = "frmTRIANGULO";
            Text = "TRIANGULO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPerimetroTriangulo;
        private Label lblAreaTriangulo;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtBaseTriangulo;
        private TextBox txtAlturaTriangulo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}