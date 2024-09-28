namespace Tarea
{
    partial class Form6
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
            RC = new TextBox();
            RB = new TextBox();
            RI = new TextBox();
            PF = new TextBox();
            Calcular = new Button();
            Salir = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Respuestas correctas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 95);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Respuestas incorrectas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 169);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Respuestas en blanco";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 238);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Puntaje Final";
            // 
            // RC
            // 
            RC.Location = new Point(201, 36);
            RC.Name = "RC";
            RC.Size = new Size(100, 23);
            RC.TabIndex = 4;
            // 
            // RB
            // 
            RB.Location = new Point(201, 161);
            RB.Name = "RB";
            RB.Size = new Size(100, 23);
            RB.TabIndex = 5;
            // 
            // RI
            // 
            RI.Location = new Point(201, 95);
            RI.Name = "RI";
            RI.Size = new Size(100, 23);
            RI.TabIndex = 6;
            // 
            // PF
            // 
            PF.Location = new Point(201, 235);
            PF.Name = "PF";
            PF.Size = new Size(100, 23);
            PF.TabIndex = 7;
            PF.TextChanged += PF_TextChanged;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(477, 84);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 8;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(557, 160);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 9;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(637, 84);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 10;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(PF);
            Controls.Add(RI);
            Controls.Add(RB);
            Controls.Add(RC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox RC;
        private TextBox RB;
        private TextBox RI;
        private TextBox PF;
        private Button Calcular;
        private Button Salir;
        private Button Limpiar;
    }
}