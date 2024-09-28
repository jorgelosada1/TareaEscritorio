namespace Tarea
{
    partial class Form11
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
            ABA = new TextBox();
            label3 = new Label();
            ORDB = new TextBox();
            label1 = new Label();
            ORDA = new TextBox();
            ABB = new TextBox();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Resultado
            // 
            Resultado.Location = new Point(410, 254);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 23);
            Resultado.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 262);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 32;
            label4.Text = "La distancia entre A y B es:";
            // 
            // Salir
            // 
            Salir.Location = new Point(318, 405);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 31;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(422, 337);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 30;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(206, 337);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 29;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // ABA
            // 
            ABA.Location = new Point(410, 39);
            ABA.Name = "ABA";
            ABA.Size = new Size(100, 23);
            ABA.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 47);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 27;
            label3.Text = "Ingrese la Abcisa A";
            // 
            // ORDB
            // 
            ORDB.Location = new Point(410, 179);
            ORDB.Name = "ORDB";
            ORDB.Size = new Size(100, 23);
            ORDB.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 140);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 34;
            label1.Text = "Ingrese la Ordenada A";
            // 
            // ORDA
            // 
            ORDA.Location = new Point(410, 132);
            ORDA.Name = "ORDA";
            ORDA.Size = new Size(100, 23);
            ORDA.TabIndex = 37;
            // 
            // ABB
            // 
            ABB.Location = new Point(410, 86);
            ABB.Name = "ABB";
            ABB.Size = new Size(100, 23);
            ABB.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 94);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 38;
            label5.Text = "Ingrese la Abcisa B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 187);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 36;
            label2.Text = "Ingrese la Ordenada B";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ABB);
            Controls.Add(label5);
            Controls.Add(ORDA);
            Controls.Add(label2);
            Controls.Add(ORDB);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(label4);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(ABA);
            Controls.Add(label3);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Resultado;
        private Label label4;
        private Button Salir;
        private Button Limpiar;
        private Button Calcular;
        private TextBox ABA;
        private Label label3;
        private TextBox ORDB;
        private Label label1;
        private TextBox ORDA;
        private TextBox ABB;
        private Label label5;
        private Label label2;
    }
}