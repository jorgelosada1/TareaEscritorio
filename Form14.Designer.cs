namespace Tarea
{
    partial class Form14
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
            Martes = new TextBox();
            label5 = new Label();
            Miercoles = new TextBox();
            label2 = new Label();
            Jueves = new TextBox();
            label1 = new Label();
            Incentivos = new TextBox();
            label4 = new Label();
            Salir = new Button();
            Limpiar = new Button();
            Calcular = new Button();
            Lunes = new TextBox();
            label3 = new Label();
            Viernes = new TextBox();
            label6 = new Label();
            Sabado = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // Martes
            // 
            Martes.Location = new Point(462, 78);
            Martes.Name = "Martes";
            Martes.Size = new Size(100, 23);
            Martes.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 86);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 51;
            label5.Text = "Ingrese produccion del Martes";
            // 
            // Miercoles
            // 
            Miercoles.Location = new Point(462, 124);
            Miercoles.Name = "Miercoles";
            Miercoles.Size = new Size(100, 23);
            Miercoles.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 179);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 49;
            label2.Text = "Ingrese produccion del Jueves";
            // 
            // Jueves
            // 
            Jueves.Location = new Point(462, 171);
            Jueves.Name = "Jueves";
            Jueves.Size = new Size(100, 23);
            Jueves.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 132);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 47;
            label1.Text = "Ingrese produccion del Miercoles";
            // 
            // Incentivos
            // 
            Incentivos.Location = new Point(462, 337);
            Incentivos.Name = "Incentivos";
            Incentivos.Size = new Size(151, 23);
            Incentivos.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 345);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 45;
            label4.Text = "Respecto a Incentivos";
            // 
            // Salir
            // 
            Salir.Location = new Point(376, 415);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 44;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(487, 387);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 43;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(271, 387);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 42;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Lunes
            // 
            Lunes.Location = new Point(462, 31);
            Lunes.Name = "Lunes";
            Lunes.Size = new Size(100, 23);
            Lunes.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 39);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 40;
            label3.Text = "Ingrese produccion del Lunes";
            // 
            // Viernes
            // 
            Viernes.Location = new Point(462, 221);
            Viernes.Name = "Viernes";
            Viernes.Size = new Size(100, 23);
            Viernes.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 276);
            label6.Name = "label6";
            label6.Size = new Size(169, 15);
            label6.TabIndex = 55;
            label6.Text = "Ingrese produccion del sabado";
            // 
            // Sabado
            // 
            Sabado.Location = new Point(462, 268);
            Sabado.Name = "Sabado";
            Sabado.Size = new Size(100, 23);
            Sabado.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(229, 229);
            label7.Name = "label7";
            label7.Size = new Size(169, 15);
            label7.TabIndex = 53;
            label7.Text = "Ingrese produccion del Viernes";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Viernes);
            Controls.Add(label6);
            Controls.Add(Sabado);
            Controls.Add(label7);
            Controls.Add(Martes);
            Controls.Add(label5);
            Controls.Add(Miercoles);
            Controls.Add(label2);
            Controls.Add(Jueves);
            Controls.Add(label1);
            Controls.Add(Incentivos);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(Lunes);
            Controls.Add(label3);
            Name = "Form14";
            Text = "Form14";
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Martes;
        private Label label5;
        private TextBox Miercoles;
        private Label label2;
        private TextBox Jueves;
        private Label label1;
        private TextBox Incentivos;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
        private TextBox Lunes;
        private Label label3;
        private TextBox Viernes;
        private Label label6;
        private TextBox Sabado;
        private Label label7;
    }
}