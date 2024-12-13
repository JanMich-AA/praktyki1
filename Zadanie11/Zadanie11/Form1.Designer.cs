namespace Zadanie11
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
            nextShift = new Button();
            shifts = new NumericUpDown();
            workerBeeJob = new ComboBox();
            assignJob = new Button();
            report = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)shifts).BeginInit();
            SuspendLayout();
            // 
            // nextShift
            // 
            nextShift.Location = new Point(387, 9);
            nextShift.Name = "nextShift";
            nextShift.Size = new Size(193, 151);
            nextShift.TabIndex = 0;
            nextShift.Text = "Przepracuj następna zmiane";
            nextShift.UseVisualStyleBackColor = true;
            nextShift.Click += button1_Click;
            // 
            // shifts
            // 
            shifts.Location = new Point(222, 71);
            shifts.Name = "shifts";
            shifts.Size = new Size(159, 31);
            shifts.TabIndex = 1;
            shifts.ValueChanged += shifts_ValueChanged;
            // 
            // workerBeeJob
            // 
            workerBeeJob.DropDownStyle = ComboBoxStyle.DropDownList;
            workerBeeJob.FormattingEnabled = true;
            workerBeeJob.Items.AddRange(new object[] { "Nauczanie pszczółek", "Pielęgnacja jaj", "Utrzymanie ula", "Wytwarzanie miodu", "Zbireanie nektaru", "Patrol z żądłami" });
            workerBeeJob.Location = new Point(12, 69);
            workerBeeJob.Name = "workerBeeJob";
            workerBeeJob.Size = new Size(196, 33);
            workerBeeJob.TabIndex = 2;
            workerBeeJob.SelectedIndexChanged += workerBeeJob_SelectedIndexChanged;
            // 
            // assignJob
            // 
            assignJob.Location = new Point(12, 108);
            assignJob.Name = "assignJob";
            assignJob.Size = new Size(369, 34);
            assignJob.TabIndex = 4;
            assignJob.Text = "Przypisz  tę prace pszczole";
            assignJob.UseVisualStyleBackColor = true;
            assignJob.Click += button2_Click;
            // 
            // report
            // 
            report.BorderStyle = BorderStyle.FixedSingle;
            report.Location = new Point(12, 166);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(568, 267);
            report.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 6;
            label1.Text = "Zadanie robotnicy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 41);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 7;
            label2.Text = "Zmiany";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(220, 25);
            label3.TabIndex = 8;
            label3.Text = "Przydział prac robotnicom";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(report);
            Controls.Add(assignJob);
            Controls.Add(workerBeeJob);
            Controls.Add(shifts);
            Controls.Add(nextShift);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextShift;
        private NumericUpDown shifts;
        private ComboBox workerBeeJob;
        private Button assignJob;
        private TextBox report;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
