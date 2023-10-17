namespace BasicFacebookFeatures
{
    public partial class MyOptionalMatchesForm
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
            this.listBoxOptionalMatches = new System.Windows.Forms.ListBox();
            this.radioButtonShowMyOptionalMatchesWithoutOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxOptionalMatches
            // 
            this.listBoxOptionalMatches.FormattingEnabled = true;
            this.listBoxOptionalMatches.ItemHeight = 16;
            this.listBoxOptionalMatches.Location = new System.Drawing.Point(30, 145);
            this.listBoxOptionalMatches.Name = "listBoxOptionalMatches";
            this.listBoxOptionalMatches.Size = new System.Drawing.Size(716, 276);
            this.listBoxOptionalMatches.TabIndex = 0;
            this.listBoxOptionalMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxOptionalMatches_SelectedIndexChanged);
            // 
            // radioButtonShowMyOptionalMatchesWithoutOrder
            // 
            this.radioButtonShowMyOptionalMatchesWithoutOrder.AutoSize = true;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Checked = true;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Enabled = false;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Font = new System.Drawing.Font("MV Boli", 7.3F, System.Drawing.FontStyle.Bold);
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Location = new System.Drawing.Point(12, 86);
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Name = "radioButtonShowMyOptionalMatchesWithoutOrder";
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Size = new System.Drawing.Size(322, 21);
            this.radioButtonShowMyOptionalMatchesWithoutOrder.TabIndex = 1;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.TabStop = true;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.Text = "Show my optional matches without order";
            this.radioButtonShowMyOptionalMatchesWithoutOrder.UseVisualStyleBackColor = false;
            this.radioButtonShowMyOptionalMatchesWithoutOrder.CheckedChanged += new System.EventHandler(this.radioButtonShowMyOptionalMatchesWithoutOrder_CheckedChanged);
            // 
            // radioButtonShowMyOptionalMatchesSortedByTheHighestMatch
            // 
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.AutoSize = true;
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Enabled = false;
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Font = new System.Drawing.Font("MV Boli", 7.3F, System.Drawing.FontStyle.Bold);
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Location = new System.Drawing.Point(357, 86);
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Name = "radioButtonShowMyOptionalMatchesSortedByTheHighestMatch";
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Size = new System.Drawing.Size(424, 21);
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.TabIndex = 2;
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.Text = "Show my optional matches sorted by the highest match";
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.UseVisualStyleBackColor = false;
            this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch.CheckedChanged += new System.EventHandler(this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "If you want to sort the list of optional matches that was found for you, you can " +
    "click on one of the following buttons:";
            // 
            // MyOptionalMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.הורדה;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonShowMyOptionalMatchesSortedByTheHighestMatch);
            this.Controls.Add(this.radioButtonShowMyOptionalMatchesWithoutOrder);
            this.Controls.Add(this.listBoxOptionalMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MyOptionalMatchesForm";
            this.Text = "MyOptionalMatchesForm";
            this.Load += new System.EventHandler(this.MyOptionalMatchesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOptionalMatches;
        private System.Windows.Forms.RadioButton radioButtonShowMyOptionalMatchesWithoutOrder;
        private System.Windows.Forms.RadioButton radioButtonShowMyOptionalMatchesSortedByTheHighestMatch;
        private System.Windows.Forms.Label label1;
    }
}