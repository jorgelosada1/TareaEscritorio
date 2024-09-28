namespace Tarea
{
    partial class Form13
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
            Primer = new TextBox();
            label2 = new Label();
            Segundo = new TextBox();
            label1 = new Label();
            MENSAJE = new TextBox();
            label4 = new Label();
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            Años = new TextBox();
            SuspendLayout();
            // 
            // Primer
            // 
            Primer.Location = new Point(402, 77);
            Primer.Name = "Primer";
            Primer.Size = new Size(100, 23);
            Primer.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 132);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 54;
            label2.Text = "Edad del segundo hermano";
            // 
            // Segundo
            // 
            Segundo.Location = new Point(402, 124);
            Segundo.Name = "Segundo";
            Segundo.Size = new Size(100, 23);
            Segundo.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 77);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 52;
            label1.Text = "Edad del primer hermano";
            // 
            // MENSAJE
            // 
            MENSAJE.Location = new Point(402, 199);
            MENSAJE.Name = "MENSAJE";
            MENSAJE.Size = new Size(223, 23);
            MENSAJE.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 199);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 50;
            label4.Text = "Mensaje";
            // 
            // Salir
            // 
            Salir.Location = new Point(378, 350);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 49;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(482, 282);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 48;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(266, 282);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 47;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Años
            // 
            Años.Location = new Point(642, 199);
            Años.Name = "Años";
            Años.Size = new Size(100, 23);
            Años.TabIndex = 56;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Años);
            Controls.Add(Primer);
            Controls.Add(label2);
            Controls.Add(Segundo);
            Controls.Add(label1);
            Controls.Add(MENSAJE);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Primer;
        private Label label2;
        private TextBox Segundo;
        private Label label1;
        private TextBox MENSAJE;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
        private TextBox Años;
    }
}