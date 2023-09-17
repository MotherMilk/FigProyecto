namespace FigProyecto
{
    partial class frmTETRAEDRO
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
            lblVolumenTetraedro = new Label();
            lblAreaTetraedro = new Label();
            btnCalcular = new Button();
            label2 = new Label();
            txtLadoTetraedro = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblVolumenTetraedro
            // 
            lblVolumenTetraedro.AutoSize = true;
            lblVolumenTetraedro.Location = new Point(62, 181);
            lblVolumenTetraedro.Name = "lblVolumenTetraedro";
            lblVolumenTetraedro.Size = new Size(63, 15);
            lblVolumenTetraedro.TabIndex = 16;
            lblVolumenTetraedro.Text = "VOLUMEN";
            // 
            // lblAreaTetraedro
            // 
            lblAreaTetraedro.AutoSize = true;
            lblAreaTetraedro.Location = new Point(62, 121);
            lblAreaTetraedro.Name = "lblAreaTetraedro";
            lblAreaTetraedro.Size = new Size(36, 15);
            lblAreaTetraedro.TabIndex = 15;
            lblAreaTetraedro.Text = "AREA";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(320, 69);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 22);
            label2.Name = "label2";
            label2.Size = new Size(245, 16);
            label2.TabIndex = 13;
            label2.Text = "INGRESE EL LADO DEL TETRAEDRO";
            // 
            // txtLadoTetraedro
            // 
            txtLadoTetraedro.Location = new Point(295, 22);
            txtLadoTetraedro.Name = "txtLadoTetraedro";
            txtLadoTetraedro.Size = new Size(100, 23);
            txtLadoTetraedro.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._220px_Tetrahedron__PSF__svg;
            pictureBox1.Location = new Point(211, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // frmTETRAEDRO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 343);
            Controls.Add(pictureBox1);
            Controls.Add(lblVolumenTetraedro);
            Controls.Add(lblAreaTetraedro);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtLadoTetraedro);
            Name = "frmTETRAEDRO";
            Text = "TETRAEDRO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVolumenTetraedro;
        private Label lblAreaTetraedro;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtLadoTetraedro;
        private PictureBox pictureBox1;
    }
}