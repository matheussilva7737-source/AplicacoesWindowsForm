namespace Q2
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
            txtcotacao = new TextBox();
            label2 = new Label();
            txtDolares = new TextBox();
            lblResultado = new Label();
            btnconverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 55);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação do Dolar R$:";
            // 
            // txtcotacao
            // 
            txtcotacao.Location = new Point(166, 55);
            txtcotacao.Name = "txtcotacao";
            txtcotacao.Size = new Size(100, 23);
            txtcotacao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade em Dolares US$:";
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(175, 101);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(217, 137);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "0";
            // 
            // btnconverter
            // 
            btnconverter.Location = new Point(191, 168);
            btnconverter.Name = "btnconverter";
            btnconverter.Size = new Size(75, 23);
            btnconverter.TabIndex = 5;
            btnconverter.Text = "Converter";
            btnconverter.UseVisualStyleBackColor = true;
            btnconverter.Click += btnconverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 241);
            Controls.Add(btnconverter);
            Controls.Add(lblResultado);
            Controls.Add(txtDolares);
            Controls.Add(label2);
            Controls.Add(txtcotacao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtcotacao;
        private Label label2;
        private TextBox txtDolares;
        private Label lblResultado;
        private Button btnconverter;
    }
}
