namespace BasicFacebookFeatures
{
    public partial class FindMyMatchForm
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
            this.labelHeadlineForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.labelAgeRange = new System.Windows.Forms.Label();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.checkedListBoxCities = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.radioButtonWithoutFilter = new System.Windows.Forms.RadioButton();
            this.comboBoxWithoutFilterOrWithFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeadlineForm
            // 
            this.labelHeadlineForm.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadlineForm.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadlineForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelHeadlineForm.Location = new System.Drawing.Point(190, 9);
            this.labelHeadlineForm.Name = "labelHeadlineForm";
            this.labelHeadlineForm.Size = new System.Drawing.Size(485, 73);
            this.labelHeadlineForm.TabIndex = 6;
            this.labelHeadlineForm.Text = "Find my match";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "What is your preference?";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(28, 172);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(76, 29);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.Text = "male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(28, 207);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(95, 29);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.Text = "female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // labelAgeRange
            // 
            this.labelAgeRange.BackColor = System.Drawing.Color.Transparent;
            this.labelAgeRange.Font = new System.Drawing.Font("MV Boli", 14.2F, System.Drawing.FontStyle.Bold);
            this.labelAgeRange.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelAgeRange.Location = new System.Drawing.Point(14, 262);
            this.labelAgeRange.Name = "labelAgeRange";
            this.labelAgeRange.Size = new System.Drawing.Size(363, 34);
            this.labelAgeRange.TabIndex = 10;
            this.labelAgeRange.Text = "Age range:";
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(97, 322);
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownFrom.TabIndex = 11;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(24, 322);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(54, 22);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(197, 319);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(32, 22);
            this.labelTo.TabIndex = 13;
            this.labelTo.Text = "To";
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(257, 319);
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownTo.TabIndex = 14;
            // 
            // labelCity
            // 
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("MV Boli", 14.2F, System.Drawing.FontStyle.Bold);
            this.labelCity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelCity.Location = new System.Drawing.Point(457, 82);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(320, 34);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "City:";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(529, 384);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(207, 56);
            this.buttonContinue.TabIndex = 16;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // checkedListBoxCities
            // 
            this.checkedListBoxCities.FormattingEnabled = true;
            this.checkedListBoxCities.Location = new System.Drawing.Point(463, 153);
            this.checkedListBoxCities.Name = "checkedListBoxCities";
            this.checkedListBoxCities.Size = new System.Drawing.Size(324, 225);
            this.checkedListBoxCities.Sorted = true;
            this.checkedListBoxCities.TabIndex = 18;
            this.checkedListBoxCities.Visible = false;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEvent.Image = global::BasicFacebookFeatures.Properties.Resources.two_hearts;
            this.pictureBoxEvent.Location = new System.Drawing.Point(383, 169);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(74, 93);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 39;
            this.pictureBoxEvent.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.two_hearts;
            this.pictureBox1.Location = new System.Drawing.Point(590, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = global::BasicFacebookFeatures.Properties.Resources.arrowOfBack;
            this.buttonBack.Location = new System.Drawing.Point(70, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 54);
            this.buttonBack.TabIndex = 41;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // radioButtonWithoutFilter
            // 
            this.radioButtonWithoutFilter.AutoSize = true;
            this.radioButtonWithoutFilter.Checked = true;
            this.radioButtonWithoutFilter.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWithoutFilter.Location = new System.Drawing.Point(28, 137);
            this.radioButtonWithoutFilter.Name = "radioButtonWithoutFilter";
            this.radioButtonWithoutFilter.Size = new System.Drawing.Size(171, 29);
            this.radioButtonWithoutFilter.TabIndex = 42;
            this.radioButtonWithoutFilter.TabStop = true;
            this.radioButtonWithoutFilter.Text = "without filter";
            this.radioButtonWithoutFilter.UseVisualStyleBackColor = true;
            // 
            // comboBoxWithoutFilterOrWithFilter
            // 
            this.comboBoxWithoutFilterOrWithFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWithoutFilterOrWithFilter.FormattingEnabled = true;
            this.comboBoxWithoutFilterOrWithFilter.Items.AddRange(new object[] {
            "without filter",
            "with filter"});
            this.comboBoxWithoutFilterOrWithFilter.Location = new System.Drawing.Point(537, 92);
            this.comboBoxWithoutFilterOrWithFilter.Name = "comboBoxWithoutFilterOrWithFilter";
            this.comboBoxWithoutFilterOrWithFilter.Size = new System.Drawing.Size(186, 24);
            this.comboBoxWithoutFilterOrWithFilter.TabIndex = 43;
            this.comboBoxWithoutFilterOrWithFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxWithoutFilterOrWithFilter_SelectedIndexChanged);
            // 
            // FindMyMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.matchImage;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.comboBoxWithoutFilterOrWithFilter);
            this.Controls.Add(this.radioButtonWithoutFilter);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.checkedListBoxCities);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.numericUpDownTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.numericUpDownFrom);
            this.Controls.Add(this.labelAgeRange);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeadlineForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindMyMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindMyMatchForm";
            this.Load += new System.EventHandler(this.FindMyMatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeadlineForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label labelAgeRange;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.CheckedListBox checkedListBoxCities;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RadioButton radioButtonWithoutFilter;
        private System.Windows.Forms.ComboBox comboBoxWithoutFilterOrWithFilter;
    }
}