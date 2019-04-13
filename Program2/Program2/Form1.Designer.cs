namespace Program2
{
    partial class Form1
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
            this.freshmanButton = new System.Windows.Forms.RadioButton();
            this.sophomoreButton = new System.Windows.Forms.RadioButton();
            this.juniorButton = new System.Windows.Forms.RadioButton();
            this.seniorButton = new System.Windows.Forms.RadioButton();
            this.selectLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // freshmanButton
            // 
            this.freshmanButton.AutoSize = true;
            this.freshmanButton.Location = new System.Drawing.Point(59, 25);
            this.freshmanButton.Name = "freshmanButton";
            this.freshmanButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanButton.TabIndex = 0;
            this.freshmanButton.TabStop = true;
            this.freshmanButton.Text = "Freshman";
            this.freshmanButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreButton
            // 
            this.sophomoreButton.AutoSize = true;
            this.sophomoreButton.Location = new System.Drawing.Point(59, 49);
            this.sophomoreButton.Name = "sophomoreButton";
            this.sophomoreButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreButton.TabIndex = 1;
            this.sophomoreButton.TabStop = true;
            this.sophomoreButton.Text = "Sophomore";
            this.sophomoreButton.UseVisualStyleBackColor = true;
            // 
            // juniorButton
            // 
            this.juniorButton.AutoSize = true;
            this.juniorButton.Location = new System.Drawing.Point(59, 72);
            this.juniorButton.Name = "juniorButton";
            this.juniorButton.Size = new System.Drawing.Size(53, 17);
            this.juniorButton.TabIndex = 2;
            this.juniorButton.TabStop = true;
            this.juniorButton.Text = "Junior";
            this.juniorButton.UseVisualStyleBackColor = true;
            // 
            // seniorButton
            // 
            this.seniorButton.AutoSize = true;
            this.seniorButton.Location = new System.Drawing.Point(59, 95);
            this.seniorButton.Name = "seniorButton";
            this.seniorButton.Size = new System.Drawing.Size(55, 17);
            this.seniorButton.TabIndex = 3;
            this.seniorButton.TabStop = true;
            this.seniorButton.Text = "Senior";
            this.seniorButton.UseVisualStyleBackColor = true;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(59, 6);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(70, 13);
            this.selectLabel.TabIndex = 4;
            this.selectLabel.Text = "Select grade:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(62, 132);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Enter last initial of last name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(208, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(44, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(117, 165);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 7;
            this.outputButton.Text = "Click";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(52, 212);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(200, 23);
            this.outputLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.seniorButton);
            this.Controls.Add(this.juniorButton);
            this.Controls.Add(this.sophomoreButton);
            this.Controls.Add(this.freshmanButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton freshmanButton;
        private System.Windows.Forms.RadioButton sophomoreButton;
        private System.Windows.Forms.RadioButton juniorButton;
        private System.Windows.Forms.RadioButton seniorButton;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

