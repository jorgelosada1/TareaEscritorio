namespace Tarea
{
    partial class Form10
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
            Resultado = new TextBox();
            label4 = new Label();
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            Cantidad = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Resultado
            // 
            Resultado.Location = new Point(406, 158);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 166);
            label4.Name = "label4";
            label4.Size = new Size(252, 15);
            label4.TabIndex = 25;
            label4.Text = "La cantidad de Micro Discos para el Backup es:";
            // 
            // Salir
            // 
            Salir.Location = new Point(350, 333);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 24;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(454, 265);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 23;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(238, 265);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 22;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Cantidad
            // 
            Cantidad.Location = new Point(406, 89);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(100, 23);
            Cantidad.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 97);
            label3.Name = "label3";
            label3.Size = new Size(226, 15);
            label3.TabIndex = 20;
            label3.Text = "Ingrese la capacidad del disco duro en GB";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(Cantidad);
            Controls.Add(label3);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Resultado;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
        private TextBox Cantidad;
        private Label label3;
    }
}