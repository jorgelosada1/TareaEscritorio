namespace Tarea
{
    partial class Form17
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
            label6 = new Label();
            L1 = new TextBox();
            Resultado = new TextBox();
            label4 = new Label();
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            label1 = new Label();
            L2 = new TextBox();
            label2 = new Label();
            L3 = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 44);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 80;
            label6.Text = "Ingrese el lado 1";
            // 
            // L1
            // 
            L1.Location = new Point(429, 36);
            L1.Name = "L1";
            L1.Size = new Size(100, 23);
            L1.TabIndex = 79;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(429, 209);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(151, 23);
            Resultado.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 217);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 77;
            label4.Text = "El triangulo es:";
            // 
            // Salir
            // 
            Salir.Location = new Point(343, 287);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 76;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(454, 259);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 75;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(238, 259);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 74;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 106);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 82;
            label1.Text = "Ingrese el lado 2";
            // 
            // L2
            // 
            L2.Location = new Point(429, 98);
            L2.Name = "L2";
            L2.Size = new Size(100, 23);
            L2.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 166);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 84;
            label2.Text = "Ingrese el lado 3";
            // 
            // L3
            // 
            L3.Location = new Point(429, 158);
            L3.Name = "L3";
            L3.Size = new Size(100, 23);
            L3.TabIndex = 83;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(L3);
            Controls.Add(label1);
            Controls.Add(L2);
            Controls.Add(label6);
            Controls.Add(L1);
            Controls.Add(Resultado);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Name = "Form17";
            Text = "Form17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox L1;
        private TextBox Resultado;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
        private Label label1;
        private TextBox L2;
        private Label label2;
        private TextBox L3;
    }
}