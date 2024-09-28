namespace Tarea
{
    partial class Form4
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
            Velocidad = new TextBox();
            Tiempo = new TextBox();
            Resultado = new TextBox();
            Calcular = new Button();
            Salir = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la Velocidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el Tiempo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 125);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 2;
            label3.Text = "La distancia recorrida es:";
            // 
            // Velocidad
            // 
            Velocidad.Location = new Point(239, 31);
            Velocidad.Name = "Velocidad";
            Velocidad.Size = new Size(100, 23);
            Velocidad.TabIndex = 3;
            Velocidad.TextChanged += Velocidad_TextChanged;
            // 
            // Tiempo
            // 
            Tiempo.Location = new Point(239, 74);
            Tiempo.Name = "Tiempo";
            Tiempo.Size = new Size(100, 23);
            Tiempo.TabIndex = 4;
            Tiempo.TextChanged += Tiempo_TextChanged;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(239, 125);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 5;
            Resultado.TextChanged += Resultado_TextChanged;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(93, 190);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 6;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(239, 190);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 7;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(169, 252);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 8;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(Tiempo);
            Controls.Add(Velocidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Velocidad;
        private TextBox Tiempo;
        private TextBox Resultado;
        private Button Calcular;
        private Button Salir;
        private Button Limpiar;
    }
}