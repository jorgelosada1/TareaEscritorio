namespace Tarea
{
    partial class Form7
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
            Limpiar = new Button();
            Salir = new Button();
            Calcular = new Button();
            PF = new TextBox();
            PartidosE = new TextBox();
            PartidosP = new TextBox();
            PartidosG = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(667, 162);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 21;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(587, 238);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 20;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(507, 162);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 19;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // PF
            // 
            PF.Location = new Point(231, 313);
            PF.Name = "PF";
            PF.Size = new Size(100, 23);
            PF.TabIndex = 18;
            PF.TextChanged += PF_TextChanged;
            // 
            // PartidosE
            // 
            PartidosE.Location = new Point(231, 173);
            PartidosE.Name = "PartidosE";
            PartidosE.Size = new Size(100, 23);
            PartidosE.TabIndex = 17;
            PartidosE.TextChanged += RI_TextChanged;
            // 
            // PartidosP
            // 
            PartidosP.Location = new Point(231, 239);
            PartidosP.Name = "PartidosP";
            PartidosP.Size = new Size(100, 23);
            PartidosP.TabIndex = 16;
            // 
            // PartidosG
            // 
            PartidosG.Location = new Point(231, 114);
            PartidosG.Name = "PartidosG";
            PartidosG.Size = new Size(100, 23);
            PartidosG.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 321);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 14;
            label4.Text = "Puntaje Final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 242);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 13;
            label3.Text = "Numero de partidos perdidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 173);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 12;
            label2.Text = "Numero de partidos empatados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 114);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 11;
            label1.Text = "Numero de partidos ganados";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Salir);
            Controls.Add(Calcular);
            Controls.Add(PF);
            Controls.Add(PartidosE);
            Controls.Add(PartidosP);
            Controls.Add(PartidosG);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Limpiar;
        private Button Salir;
        private Button Calcular;
        private TextBox PF;
        private TextBox PartidosE;
        private TextBox PartidosP;
        private TextBox PartidosG;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}