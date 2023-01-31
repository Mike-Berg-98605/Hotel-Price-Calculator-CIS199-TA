namespace Prog2_S22
{
    partial class Prog2Form
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
            this.calcCostButton = new System.Windows.Forms.Button();
            this.peopleTextBox = new System.Windows.Forms.TextBox();
            this.nightsTextBox = new System.Windows.Forms.TextBox();
            this.starsComboBox = new System.Windows.Forms.ComboBox();
            this.numGuestsLabel = new System.Windows.Forms.Label();
            this.numNightsLabel = new System.Windows.Forms.Label();
            this.starsLabel = new System.Windows.Forms.Label();
            this.hotelCostLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcCostButton
            // 
            this.calcCostButton.Location = new System.Drawing.Point(143, 155);
            this.calcCostButton.Name = "calcCostButton";
            this.calcCostButton.Size = new System.Drawing.Size(75, 23);
            this.calcCostButton.TabIndex = 0;
            this.calcCostButton.Text = "Calculate Cost";
            this.calcCostButton.UseVisualStyleBackColor = true;
            this.calcCostButton.Click += new System.EventHandler(this.calcCostButton_Click);
            // 
            // peopleTextBox
            // 
            this.peopleTextBox.Location = new System.Drawing.Point(184, 52);
            this.peopleTextBox.Name = "peopleTextBox";
            this.peopleTextBox.Size = new System.Drawing.Size(100, 20);
            this.peopleTextBox.TabIndex = 1;
            // 
            // nightsTextBox
            // 
            this.nightsTextBox.Location = new System.Drawing.Point(184, 78);
            this.nightsTextBox.Name = "nightsTextBox";
            this.nightsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nightsTextBox.TabIndex = 2;
            // 
            // starsComboBox
            // 
            this.starsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starsComboBox.FormattingEnabled = true;
            this.starsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.starsComboBox.Location = new System.Drawing.Point(184, 105);
            this.starsComboBox.Name = "starsComboBox";
            this.starsComboBox.Size = new System.Drawing.Size(100, 21);
            this.starsComboBox.TabIndex = 3;
            // 
            // numGuestsLabel
            // 
            this.numGuestsLabel.AutoSize = true;
            this.numGuestsLabel.Location = new System.Drawing.Point(77, 52);
            this.numGuestsLabel.Name = "numGuestsLabel";
            this.numGuestsLabel.Size = new System.Drawing.Size(95, 13);
            this.numGuestsLabel.TabIndex = 4;
            this.numGuestsLabel.Text = "Number of Guests:";
            // 
            // numNightsLabel
            // 
            this.numNightsLabel.AutoSize = true;
            this.numNightsLabel.Location = new System.Drawing.Point(77, 78);
            this.numNightsLabel.Name = "numNightsLabel";
            this.numNightsLabel.Size = new System.Drawing.Size(92, 13);
            this.numNightsLabel.TabIndex = 5;
            this.numNightsLabel.Text = "Number of Nights:";
            // 
            // starsLabel
            // 
            this.starsLabel.AutoSize = true;
            this.starsLabel.Location = new System.Drawing.Point(77, 105);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.Size = new System.Drawing.Size(62, 13);
            this.starsLabel.TabIndex = 6;
            this.starsLabel.Text = "Hotel Stars:";
            // 
            // hotelCostLabel
            // 
            this.hotelCostLabel.AutoSize = true;
            this.hotelCostLabel.Location = new System.Drawing.Point(77, 224);
            this.hotelCostLabel.Name = "hotelCostLabel";
            this.hotelCostLabel.Size = new System.Drawing.Size(59, 13);
            this.hotelCostLabel.TabIndex = 8;
            this.hotelCostLabel.Text = "Hotel Cost:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(184, 224);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputTextBox.TabIndex = 7;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 283);
            this.Controls.Add(this.hotelCostLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.starsLabel);
            this.Controls.Add(this.numNightsLabel);
            this.Controls.Add(this.numGuestsLabel);
            this.Controls.Add(this.starsComboBox);
            this.Controls.Add(this.nightsTextBox);
            this.Controls.Add(this.peopleTextBox);
            this.Controls.Add(this.calcCostButton);
            this.Name = "Prog2Form";
            this.Text = "Program 2 - Hotel Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcCostButton;
        private System.Windows.Forms.TextBox peopleTextBox;
        private System.Windows.Forms.TextBox nightsTextBox;
        private System.Windows.Forms.ComboBox starsComboBox;
        private System.Windows.Forms.Label numGuestsLabel;
        private System.Windows.Forms.Label numNightsLabel;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label hotelCostLabel;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

