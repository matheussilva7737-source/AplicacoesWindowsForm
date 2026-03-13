namespace Q1
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
            txtCelsius = new TextBox();
            btnconverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 67);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Celsius:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(149, 108);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "0";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(114, 64);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 2;
            txtCelsius.TextChanged += txtCelsius_TextChanged;
            // 
            // btnconverter
            // 
            btnconverter.Location = new Point(114, 136);
            btnconverter.Name = "btnconverter";
            btnconverter.Size = new Size(75, 23);
            btnconverter.TabIndex = 4;
            btnconverter.Text = "Converter";
            btnconverter.UseVisualStyleBackColor = true;
            btnconverter.Click += btnconverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 239);
            Controls.Add(btnconverter);
            Controls.Add(txtCelsius);
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
        private TextBox txtCelsius;
        private Button btnconverter;
    }
}
