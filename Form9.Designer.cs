namespace Tarea
{
    partial class Form9
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
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            LadoB = new TextBox();
            LadoC = new TextBox();
            LadoA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Resultado = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Salir
            // 
            Salir.Location = new Point(375, 407);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 17;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(479, 339);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 16;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(263, 339);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 15;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // LadoB
            // 
            LadoB.Location = new Point(408, 96);
            LadoB.Name = "LadoB";
            LadoB.Size = new Size(100, 23);
            LadoB.TabIndex = 14;
            // 
            // LadoC
            // 
            LadoC.Location = new Point(408, 167);
            LadoC.Name = "LadoC";
            LadoC.Size = new Size(100, 23);
            LadoC.TabIndex = 13;
            // 
            // LadoA
            // 
            LadoA.Location = new Point(408, 32);
            LadoA.Name = "LadoA";
            LadoA.Size = new Size(100, 23);
            LadoA.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 175);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "Lado C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 104);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Lado B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 40);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 9;
            label1.Text = "Lado A";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(408, 239);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 247);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 18;
            label4.Text = "El area del triangulo es:";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(LadoB);
            Controls.Add(LadoC);
            Controls.Add(LadoA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
        private TextBox LadoB;
        private TextBox LadoC;
        private TextBox LadoA;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Resultado;
        private Label label4;
    }
}