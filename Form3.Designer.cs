namespace Tarea
{
    partial class Form3
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
            Temperatura = new TextBox();
            Resultado = new TextBox();
            CAF = new Button();
            FAC = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Limpiar = new Button();
            Salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 37);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa la Temperatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Resultado";
            // 
            // Temperatura
            // 
            Temperatura.Location = new Point(252, 37);
            Temperatura.Name = "Temperatura";
            Temperatura.Size = new Size(100, 23);
            Temperatura.TabIndex = 2;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(252, 79);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 3;
            // 
            // CAF
            // 
            CAF.Location = new Point(88, 134);
            CAF.Name = "CAF";
            CAF.Size = new Size(75, 23);
            CAF.TabIndex = 4;
            CAF.Text = "C a F";
            CAF.UseVisualStyleBackColor = true;
            CAF.Click += CAF_Click;
            // 
            // FAC
            // 
            FAC.Location = new Point(277, 134);
            FAC.Name = "FAC";
            FAC.Size = new Size(75, 23);
            FAC.TabIndex = 5;
            FAC.Text = "F a C";
            FAC.UseVisualStyleBackColor = true;
            FAC.Click += FAC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 206);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 6;
            label3.Text = "Presiona el boton adecuado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 254);
            label4.Name = "label4";
            label4.Size = new Size(203, 15);
            label4.TabIndex = 7;
            label4.Text = "C a F convierte de Celcius a Farenheit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 297);
            label5.Name = "label5";
            label5.Size = new Size(203, 15);
            label5.TabIndex = 8;
            label5.Text = "F a C convierte de Farenheit a Celcius";
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(88, 350);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 9;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(277, 350);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 10;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FAC);
            Controls.Add(CAF);
            Controls.Add(Resultado);
            Controls.Add(Temperatura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Temperatura;
        private TextBox Resultado;
        private Button CAF;
        private Button FAC;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Limpiar;
        private Button Salir;
    }
}