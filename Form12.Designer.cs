namespace Tarea
{
    partial class Form12
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
            NACIMIENTO = new TextBox();
            label2 = new Label();
            ACTUAL = new TextBox();
            label1 = new Label();
            MENSAJE = new TextBox();
            label4 = new Label();
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            SuspendLayout();
            // 
            // NACIMIENTO
            // 
            NACIMIENTO.Location = new Point(394, 77);
            NACIMIENTO.Name = "NACIMIENTO";
            NACIMIENTO.Size = new Size(100, 23);
            NACIMIENTO.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 132);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 45;
            label2.Text = "Año Actual";
            // 
            // ACTUAL
            // 
            ACTUAL.Location = new Point(394, 124);
            ACTUAL.Name = "ACTUAL";
            ACTUAL.Size = new Size(100, 23);
            ACTUAL.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 77);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 43;
            label1.Text = "Ingrese el año de nacimiento";
            // 
            // MENSAJE
            // 
            MENSAJE.Location = new Point(394, 199);
            MENSAJE.Name = "MENSAJE";
            MENSAJE.Size = new Size(223, 23);
            MENSAJE.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 199);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 41;
            label4.Text = "Mensaje";
            label4.Click += label4_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(370, 350);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 40;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(474, 282);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 39;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(258, 282);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 38;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NACIMIENTO);
            Controls.Add(label2);
            Controls.Add(ACTUAL);
            Controls.Add(label1);
            Controls.Add(MENSAJE);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NACIMIENTO;
        private Label label2;
        private TextBox ACTUAL;
        private Label label1;
        private TextBox MENSAJE;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
    }
}