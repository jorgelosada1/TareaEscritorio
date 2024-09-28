namespace Tarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Operador1 = new TextBox();
            Operador2 = new TextBox();
            Resultado = new TextBox();
            Multiplicar = new Button();
            Limpiar = new Button();
            Salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 49);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Operador1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Operador2";
            // 
            // Operador1
            // 
            Operador1.Location = new Point(261, 49);
            Operador1.Name = "Operador1";
            Operador1.Size = new Size(100, 23);
            Operador1.TabIndex = 2;
            Operador1.TextChanged += Operador1_TextChanged;
            // 
            // Operador2
            // 
            Operador2.Location = new Point(261, 121);
            Operador2.Name = "Operador2";
            Operador2.Size = new Size(100, 23);
            Operador2.TabIndex = 3;
            Operador2.TextChanged += Operador2_TextChanged;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(261, 201);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 4;
            Resultado.TextChanged += Resultado_TextChanged;
            // 
            // Multiplicar
            // 
            Multiplicar.Location = new Point(165, 201);
            Multiplicar.Name = "Multiplicar";
            Multiplicar.Size = new Size(75, 23);
            Multiplicar.TabIndex = 5;
            Multiplicar.Text = "Multiplicar";
            Multiplicar.UseVisualStyleBackColor = true;
            Multiplicar.Click += Multiplicar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(165, 270);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 6;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(286, 270);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 7;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Multiplicar);
            Controls.Add(Resultado);
            Controls.Add(Operador2);
            Controls.Add(Operador1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Operador1;
        private TextBox Operador2;
        private TextBox Resultado;
        private Button Multiplicar;
        private Button Limpiar;
        private Button Salir;
    }
}
