namespace zadanie13
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
            description = new TextBox();
            exits = new ComboBox();
            goThoughTheDoor = new Button();
            goHere = new Button();
            SuspendLayout();
            // 
            // description
            // 
            description.Location = new Point(12, 12);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(398, 186);
            description.TabIndex = 0;
            description.TextChanged += description_TextChanged;
            // 
            // exits
            // 
            exits.DropDownStyle = ComboBoxStyle.DropDownList;
            exits.FormattingEnabled = true;
            exits.Location = new Point(201, 204);
            exits.Name = "exits";
            exits.Size = new Size(209, 33);
            exits.TabIndex = 1;
            exits.SelectedIndexChanged += exits_SelectedIndexChanged;
            // 
            // goThoughTheDoor
            // 
            goThoughTheDoor.Location = new Point(12, 243);
            goThoughTheDoor.Name = "goThoughTheDoor";
            goThoughTheDoor.Size = new Size(398, 34);
            goThoughTheDoor.TabIndex = 2;
            goThoughTheDoor.Text = "Przejdź przez drzwi!";
            goThoughTheDoor.UseVisualStyleBackColor = true;
            goThoughTheDoor.Click += goThoughTheDoor_Click;
            // 
            // goHere
            // 
            goHere.Location = new Point(12, 204);
            goHere.Name = "goHere";
            goHere.Size = new Size(183, 33);
            goHere.TabIndex = 3;
            goHere.Text = "Idż tutaj:";
            goHere.UseVisualStyleBackColor = true;
            goHere.Click += goHere_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(goHere);
            Controls.Add(goThoughTheDoor);
            Controls.Add(exits);
            Controls.Add(description);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox description;
        private ComboBox exits;
        private Button goThoughTheDoor;
        private Button goHere;
    }
}
