namespace Q3_PassagemPorDistancia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResultado = new Label();
            txtDistancia = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 0;
            label1.Text = "Simulação de corrida: Distancia em KM:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(156, 113);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "0";
            lblResultado.Click += label2_Click;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(110, 58);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 2;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(124, 87);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 153);
            Controls.Add(btncalcular);
            Controls.Add(txtDistancia);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtDistancia;
        private Button btncalcular;
    }
}
