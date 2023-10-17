namespace BasicFacebookFeatures
{
    public partial class LikesPagesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageNormalLabel;
            this.listBoxLikesPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.labelHeadlineForm = new System.Windows.Forms.Label();
            this.panelLikesPagesDetails = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            descriptionLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.panelLikesPagesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.Black;
            descriptionLabel.Location = new System.Drawing.Point(19, 21);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(98, 18);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageNormalLabel.ForeColor = System.Drawing.Color.Black;
            imageNormalLabel.Location = new System.Drawing.Point(19, 116);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(56, 18);
            imageNormalLabel.TabIndex = 4;
            imageNormalLabel.Text = "Image:";
            // 
            // listBoxLikesPages
            // 
            this.listBoxLikesPages.DataSource = this.pageBindingSource;
            this.listBoxLikesPages.DisplayMember = "Name";
            this.listBoxLikesPages.FormattingEnabled = true;
            this.listBoxLikesPages.ItemHeight = 16;
            this.listBoxLikesPages.Location = new System.Drawing.Point(46, 93);
            this.listBoxLikesPages.Name = "listBoxLikesPages";
            this.listBoxLikesPages.Size = new System.Drawing.Size(457, 276);
            this.listBoxLikesPages.TabIndex = 0;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Image = global::BasicFacebookFeatures.Properties.Resources.arrowOfBack;
            this.buttonBack.Location = new System.Drawing.Point(12, 387);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 51);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEvent.Image = global::BasicFacebookFeatures.Properties.Resources.thumb_up;
            this.pictureBoxEvent.Location = new System.Drawing.Point(600, 46);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(134, 120);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 39;
            this.pictureBoxEvent.TabStop = false;
            // 
            // labelHeadlineForm
            // 
            this.labelHeadlineForm.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadlineForm.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadlineForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelHeadlineForm.Location = new System.Drawing.Point(35, 9);
            this.labelHeadlineForm.Name = "labelHeadlineForm";
            this.labelHeadlineForm.Size = new System.Drawing.Size(378, 70);
            this.labelHeadlineForm.TabIndex = 40;
            this.labelHeadlineForm.Text = "Likes pages";
            // 
            // panelLikesPagesDetails
            // 
            this.panelLikesPagesDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelLikesPagesDetails.Controls.Add(descriptionLabel);
            this.panelLikesPagesDetails.Controls.Add(this.descriptionTextBox);
            this.panelLikesPagesDetails.Controls.Add(imageNormalLabel);
            this.panelLikesPagesDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelLikesPagesDetails.Location = new System.Drawing.Point(525, 187);
            this.panelLikesPagesDetails.Name = "panelLikesPagesDetails";
            this.panelLikesPagesDetails.Size = new System.Drawing.Size(316, 237);
            this.panelLikesPagesDetails.TabIndex = 42;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "No Description"));
            this.descriptionTextBox.Location = new System.Drawing.Point(124, 21);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(178, 65);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(124, 116);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(122, 101);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // LikesPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Like;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 458);
            this.Controls.Add(this.panelLikesPagesDetails);
            this.Controls.Add(this.labelHeadlineForm);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxLikesPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LikesPagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LikesPagesForm";
            this.Load += new System.EventHandler(this.LikesPagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.panelLikesPagesDetails.ResumeLayout(false);
            this.panelLikesPagesDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLikesPages;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Label labelHeadlineForm;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panelLikesPagesDetails;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
    }
}