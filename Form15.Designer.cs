namespace Tarea
{
    partial class Form15
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
            N2 = new TextBox();
            label6 = new Label();
            N3 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            N1 = new TextBox();
            Mayor = new TextBox();
            label4 = new Label();
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            SuspendLayout();
            // 
            // N2
            // 
            N2.Location = new Point(441, 142);
            N2.Name = "N2";
            N2.Size = new Size(100, 23);
            N2.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 197);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 66;
            label6.Text = "Ingrese N3";
            // 
            // N3
            // 
            N3.Location = new Point(441, 189);
            N3.Name = "N3";
            N3.Size = new Size(100, 23);
            N3.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 150);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 64;
            label7.Text = "Ingrese N2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 100);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 63;
            label2.Text = "Ingrese N1";
            // 
            // N1
            // 
            N1.Location = new Point(441, 92);
            N1.Name = "N1";
            N1.Size = new Size(100, 23);
            N1.TabIndex = 62;
            // 
            // Mayor
            // 
            Mayor.Location = new Point(441, 258);
            Mayor.Name = "Mayor";
            Mayor.Size = new Size(151, 23);
            Mayor.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 266);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 60;
            label4.Text = "El numero mayor es:";
            // 
            // Salir
            // 
            Salir.Location = new Point(355, 336);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 59;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(466, 308);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 58;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(250, 308);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 57;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(N2);
            Controls.Add(label6);
            Controls.Add(N3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(N1);
            Controls.Add(Mayor);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Name = "Form15";
            Text = "Form15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox N2;
        private Label label6;
        private TextBox N3;
        private Label label7;
        private Label label2;
        private TextBox N1;
        private TextBox Mayor;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
    }
}