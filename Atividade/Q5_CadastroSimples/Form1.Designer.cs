namespace Q5_CadastroSimples
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
            label2 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            button1 = new Button();
            lstpessoas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 83);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 114);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Idade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(203, 23);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(96, 114);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(203, 23);
            txtIdade.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(310, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lstpessoas
            // 
            lstpessoas.FormattingEnabled = true;
            lstpessoas.ItemHeight = 15;
            lstpessoas.Location = new Point(54, 143);
            lstpessoas.Name = "lstpessoas";
            lstpessoas.Size = new Size(331, 214);
            lstpessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstpessoas);
            Controls.Add(button1);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button button1;
        private ListBox lstpessoas;
    }
}
