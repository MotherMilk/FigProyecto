namespace FigProyecto
{
    partial class frmFigurasTridimensionales
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
            btnTetraedro = new Button();
            btnCubo = new Button();
            btnEsfera = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnTetraedro
            // 
            btnTetraedro.Location = new Point(611, 66);
            btnTetraedro.Name = "btnTetraedro";
            btnTetraedro.Size = new Size(79, 57);
            btnTetraedro.TabIndex = 8;
            btnTetraedro.Text = "TETRAEDRO";
            btnTetraedro.UseVisualStyleBackColor = true;
            // 
            // btnCubo
            // 
            btnCubo.Location = new Point(346, 66);
            btnCubo.Name = "btnCubo";
            btnCubo.Size = new Size(79, 57);
            btnCubo.TabIndex = 7;
            btnCubo.Text = "CUBO";
            btnCubo.UseVisualStyleBackColor = true;
            // 
            // btnEsfera
            // 
            btnEsfera.Location = new Point(100, 66);
            btnEsfera.Name = "btnEsfera";
            btnEsfera.Size = new Size(75, 57);
            btnEsfera.TabIndex = 6;
            btnEsfera.Text = "ESFERA";
            btnEsfera.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 19);
            label1.Name = "label1";
            label1.Size = new Size(368, 29);
            label1.TabIndex = 5;
            label1.Text = "FIGURAS TRIDIMENSIONALES";
            // 
            // button1
            // 
            button1.Location = new Point(319, 395);
            button1.Name = "button1";
            button1.Size = new Size(166, 43);
            button1.TabIndex = 9;
            button1.Text = "VOLVER AL MENU PRINCIPAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmFigurasTridimensionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnTetraedro);
            Controls.Add(btnCubo);
            Controls.Add(btnEsfera);
            Controls.Add(label1);
            Name = "frmFigurasTridimensionales";
            Text = "FigurasTridimensionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTetraedro;
        private Button btnCubo;
        private Button btnEsfera;
        private Label label1;
        private Button button1;
    }
}