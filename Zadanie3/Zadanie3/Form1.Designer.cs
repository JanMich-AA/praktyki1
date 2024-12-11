namespace Zadanie3
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
            joesCashLabel = new Label();
            bankCashLabel = new Label();
            bobsCashLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // joesCashLabel
            // 
            joesCashLabel.Location = new Point(0, 36);
            joesCashLabel.Name = "joesCashLabel";
            joesCashLabel.Size = new Size(253, 25);
            joesCashLabel.TabIndex = 0;
            joesCashLabel.Text = "Joe";
            joesCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            joesCashLabel.Click += label1_Click;
            // 
            // bankCashLabel
            // 
            bankCashLabel.Location = new Point(0, 132);
            bankCashLabel.Name = "bankCashLabel";
            bankCashLabel.Size = new Size(253, 30);
            bankCashLabel.TabIndex = 1;
            bankCashLabel.Text = "Bank";
            bankCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bobsCashLabel
            // 
            bobsCashLabel.Location = new Point(0, 82);
            bobsCashLabel.Name = "bobsCashLabel";
            bobsCashLabel.Size = new Size(253, 32);
            bobsCashLabel.TabIndex = 2;
            bobsCashLabel.Text = "Bob";
            bobsCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(38, 198);
            button1.Name = "button1";
            button1.Size = new Size(166, 34);
            button1.TabIndex = 3;
            button1.Text = "Daj 10 zł Joemu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(40, 238);
            button2.Name = "button2";
            button2.Size = new Size(164, 34);
            button2.TabIndex = 5;
            button2.Text = "Weź 5 zł od Boba";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 289);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bobsCashLabel);
            Controls.Add(bankCashLabel);
            Controls.Add(joesCashLabel);
            Name = "Form1";
            Text = "  ";
            ResumeLayout(false);
        }

        #endregion

        private Label joesCashLabel;
        private Label bankCashLabel;
        private Label bobsCashLabel;
        private Button button1;
    
        private Button button2;
    }
}
