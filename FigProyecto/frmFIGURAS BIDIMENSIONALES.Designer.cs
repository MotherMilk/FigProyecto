namespace FigProyecto
{
    partial class FIGURAS_BIDIMENSIONALES
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 28);
            label1.Name = "label1";
            label1.Size = new Size(352, 29);
            label1.TabIndex = 0;
            label1.Text = "FIGURAS BIDIMENSIONALES";
            // 
            // button1
            // 
            button1.Location = new Point(94, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 57);
            button1.TabIndex = 2;
            button1.Text = "CIRCULO";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(349, 92);
            button2.Name = "button2";
            button2.Size = new Size(79, 57);
            button2.TabIndex = 3;
            button2.Text = "CUADRADO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(617, 92);
            button3.Name = "button3";
            button3.Size = new Size(79, 57);
            button3.TabIndex = 4;
            button3.Text = "TRIANGULO";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(373, 418);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FIGURAS_BIDIMENSIONALES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FIGURAS_BIDIMENSIONALES";
            Text = "FIGURAS BIDIMENSIONALES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}