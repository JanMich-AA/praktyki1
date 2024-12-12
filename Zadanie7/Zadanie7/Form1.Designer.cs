namespace Zadanie7
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
            numericUpDown1 = new NumericUpDown();
            fancyBox = new CheckBox();
            healthyBox = new CheckBox();
            costLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Ilość osób";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(23, 47);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(85, 31);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Checked = true;
            fancyBox.CheckState = CheckState.Checked;
            fancyBox.Location = new Point(23, 84);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(227, 29);
            fancyBox.TabIndex = 2;
            fancyBox.Text = "Dekorowanie fantazyjne";
            fancyBox.UseVisualStyleBackColor = true;
            fancyBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(23, 119);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(147, 29);
            healthyBox.TabIndex = 3;
            healthyBox.Text = "Opcja zdrowa";
            healthyBox.UseVisualStyleBackColor = true;
            healthyBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // costLabel
            // 
            costLabel.BorderStyle = BorderStyle.Fixed3D;
            costLabel.Location = new Point(84, 151);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(98, 28);
            costLabel.TabIndex = 4;
            costLabel.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 152);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 5;
            label2.Text = "Koszt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 225);
            Controls.Add(label2);
            Controls.Add(costLabel);
            Controls.Add(healthyBox);
            Controls.Add(fancyBox);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private CheckBox fancyBox;
        private CheckBox healthyBox;
        private Label costLabel;
        private Label label2;
    }
}
