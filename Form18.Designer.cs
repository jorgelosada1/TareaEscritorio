namespace Tarea
{
    partial class Form18
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Opcion = new TextBox();
            Porcentaje = new TextBox();
            Monto = new TextBox();
            Total = new TextBox();
            Calcular = new Button();
            Salir = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 15);
            label1.TabIndex = 0;
            label1.Text = "Para el monto entre 0 y 999 seleccione 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(288, 15);
            label2.TabIndex = 1;
            label2.Text = "Para el monto mayores o iguales a 20000 seleccione 4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(247, 15);
            label3.TabIndex = 2;
            label3.Text = "Para el monto entre 5000 y 19999 seleccione 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 38);
            label4.Name = "label4";
            label4.Size = new Size(241, 15);
            label4.TabIndex = 3;
            label4.Text = "Para el monto entre 1000 y 4999 seleccione 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 153);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 4;
            label5.Text = "Seleccione su Opcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 192);
            label6.Name = "label6";
            label6.Size = new Size(144, 15);
            label6.TabIndex = 5;
            label6.Text = "Ingrese el monto de venta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 234);
            label7.Name = "label7";
            label7.Size = new Size(388, 15);
            label7.TabIndex = 6;
            label7.Text = "La opcion seleccionada corresponde a un porcentaje de bonificacion de:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 285);
            label8.Name = "label8";
            label8.Size = new Size(145, 15);
            label8.TabIndex = 7;
            label8.Text = "El total de bonificacion es:";
            // 
            // Opcion
            // 
            Opcion.Location = new Point(474, 145);
            Opcion.Name = "Opcion";
            Opcion.Size = new Size(100, 23);
            Opcion.TabIndex = 8;
            // 
            // Porcentaje
            // 
            Porcentaje.Location = new Point(474, 226);
            Porcentaje.Name = "Porcentaje";
            Porcentaje.Size = new Size(100, 23);
            Porcentaje.TabIndex = 9;
            // 
            // Monto
            // 
            Monto.Location = new Point(474, 184);
            Monto.Name = "Monto";
            Monto.Size = new Size(100, 23);
            Monto.TabIndex = 10;
            // 
            // Total
            // 
            Total.Location = new Point(474, 277);
            Total.Name = "Total";
            Total.Size = new Size(100, 23);
            Total.TabIndex = 11;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(281, 341);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 12;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(377, 400);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 13;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(474, 341);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 14;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(Total);
            Controls.Add(Monto);
            Controls.Add(Porcentaje);
            Controls.Add(Opcion);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form18";
            Text = "Form18";
            Load += Form18_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Opcion;
        private TextBox Porcentaje;
        private TextBox Monto;
        private TextBox Total;
        private Button Calcular;
        private Button Salir;
        private Button Limpiar;
    }
}