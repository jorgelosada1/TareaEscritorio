﻿namespace Tarea
{
    partial class Form5
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
            label2 = new Label();
            label3 = new Label();
            Nota1 = new TextBox();
            Nota2 = new TextBox();
            Nota3 = new TextBox();
            Resultado = new TextBox();
            label4 = new Label();
            Calcular = new Button();
            Limpiar = new Button();
            Salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Primera Nota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Segunda Nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 159);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Tercera Nota";
            // 
            // Nota1
            // 
            Nota1.Location = new Point(203, 35);
            Nota1.Name = "Nota1";
            Nota1.Size = new Size(100, 23);
            Nota1.TabIndex = 3;
            // 
            // Nota2
            // 
            Nota2.Location = new Point(203, 96);
            Nota2.Name = "Nota2";
            Nota2.Size = new Size(100, 23);
            Nota2.TabIndex = 4;
            // 
            // Nota3
            // 
            Nota3.Location = new Point(203, 159);
            Nota3.Name = "Nota3";
            Nota3.Size = new Size(100, 23);
            Nota3.TabIndex = 5;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(554, 88);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 96);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "Su promedio es:";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(165, 237);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(356, 237);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 9;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(262, 279);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 10;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(label4);
            Controls.Add(Resultado);
            Controls.Add(Nota3);
            Controls.Add(Nota2);
            Controls.Add(Nota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Nota1;
        private TextBox Nota2;
        private TextBox Nota3;
        private TextBox Resultado;
        private Label label4;
        private Button Calcular;
        private Button Limpiar;
        private Button Salir;
    }
}