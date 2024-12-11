namespace Aplikacja2
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
            textBox1 = new TextBox();
            numericUpdDown1 = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpdDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Witaj!";
            // 
            // numericUpdDown1
            // 
            numericUpdDown1.Location = new Point(145, 120);
            numericUpdDown1.Name = "numericUpdDown1";
            numericUpdDown1.Size = new Size(95, 31);
            numericUpdDown1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(177, 175);
            button1.Name = "button1";
            button1.Size = new Size(203, 34);
            button1.TabIndex = 2;
            button1.Text = "Mów do mnie!";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 60);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 3;
            label1.Text = "Powiedz to:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 120);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 4;
            label2.Text = "Liczba razy:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 263);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numericUpdDown1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Test gadania";
            ((System.ComponentModel.ISupportInitialize)numericUpdDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpdDown1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
