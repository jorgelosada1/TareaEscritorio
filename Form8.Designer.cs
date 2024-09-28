namespace Tarea
{
    partial class Form8
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
            Horas = new TextBox();
            Total = new TextBox();
            Tarifa = new TextBox();
            Calcular = new Button();
            Limpiar = new Button();
            Salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 81);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Horas Laboras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 153);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Tarifa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 224);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Total";
            // 
            // Horas
            // 
            Horas.Location = new Point(249, 81);
            Horas.Name = "Horas";
            Horas.Size = new Size(100, 23);
            Horas.TabIndex = 3;
            // 
            // Total
            // 
            Total.Location = new Point(249, 216);
            Total.Name = "Total";
            Total.Size = new Size(100, 23);
            Total.TabIndex = 4;
            // 
            // Tarifa
            // 
            Tarifa.Location = new Point(249, 145);
            Tarifa.Name = "Tarifa";
            Tarifa.Size = new Size(100, 23);
            Tarifa.TabIndex = 5;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(137, 294);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 6;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(353, 294);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(249, 362);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 8;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(Tarifa);
            Controls.Add(Total);
            Controls.Add(Horas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Horas;
        private TextBox Total;
        private TextBox Tarifa;
        private Button Calcular;
        private Button Limpiar;
        private Button Salir;
    }
}