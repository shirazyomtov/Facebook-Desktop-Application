namespace BasicFacebookFeatures
{
    public partial class AlbumsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelAmountOfPhotos = new System.Windows.Forms.Label();
            this.buttonPhotosInTheAlbum = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelHeadlineForm = new System.Windows.Forms.Label();
            this.radioButtonSortoByAmountsOfPhotos = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByAmountsOfComments = new System.Windows.Forms.RadioButton();
            this.radioButtonSortByLastUpdatedAlbum = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonShowWithoutOrder = new System.Windows.Forms.RadioButton();
            this.buttonAlbumStatistics = new System.Windows.Forms.Button();
            this.comboBoxYearOrMonth = new System.Windows.Forms.ComboBox();
            this.labelAmountOfComments = new System.Windows.Forms.Label();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(10, 142);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(400, 228);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // labelAmountOfPhotos
            // 
            this.labelAmountOfPhotos.AutoSize = true;
            this.labelAmountOfPhotos.BackColor = System.Drawing.Color.Transparent;
            this.labelAmountOfPhotos.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountOfPhotos.Location = new System.Drawing.Point(253, 373);
            this.labelAmountOfPhotos.Name = "labelAmountOfPhotos";
            this.labelAmountOfPhotos.Size = new System.Drawing.Size(178, 20);
            this.labelAmountOfPhotos.TabIndex = 2;
            this.labelAmountOfPhotos.Text = "labelAmountOfPhotos";
            this.labelAmountOfPhotos.Visible = false;
            // 
            // buttonPhotosInTheAlbum
            // 
            this.buttonPhotosInTheAlbum.Enabled = false;
            this.buttonPhotosInTheAlbum.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhotosInTheAlbum.Location = new System.Drawing.Point(581, 168);
            this.buttonPhotosInTheAlbum.Name = "buttonPhotosInTheAlbum";
            this.buttonPhotosInTheAlbum.Size = new System.Drawing.Size(210, 61);
            this.buttonPhotosInTheAlbum.TabIndex = 3;
            this.buttonPhotosInTheAlbum.Text = "Go to the photos in the album";
            this.buttonPhotosInTheAlbum.UseVisualStyleBackColor = true;
            this.buttonPhotosInTheAlbum.Click += new System.EventHandler(this.buttonPhotosInTheAlbum_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(614, 287);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(158, 151);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 4;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(604, 237);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(79, 39);
            this.buttonPrev.TabIndex = 5;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Visible = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(702, 235);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(86, 41);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Enabled = false;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(12, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 54);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelHeadlineForm
            // 
            this.labelHeadlineForm.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadlineForm.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadlineForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelHeadlineForm.Location = new System.Drawing.Point(573, 9);
            this.labelHeadlineForm.Name = "labelHeadlineForm";
            this.labelHeadlineForm.Size = new System.Drawing.Size(218, 67);
            this.labelHeadlineForm.TabIndex = 8;
            this.labelHeadlineForm.Text = "Albums";
            // 
            // radioButtonSortoByAmountsOfPhotos
            // 
            this.radioButtonSortoByAmountsOfPhotos.AutoSize = true;
            this.radioButtonSortoByAmountsOfPhotos.Enabled = false;
            this.radioButtonSortoByAmountsOfPhotos.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortoByAmountsOfPhotos.Location = new System.Drawing.Point(12, 112);
            this.radioButtonSortoByAmountsOfPhotos.Name = "radioButtonSortoByAmountsOfPhotos";
            this.radioButtonSortoByAmountsOfPhotos.Size = new System.Drawing.Size(229, 22);
            this.radioButtonSortoByAmountsOfPhotos.TabIndex = 9;
            this.radioButtonSortoByAmountsOfPhotos.Text = "Sort by amount of photos";
            this.radioButtonSortoByAmountsOfPhotos.UseVisualStyleBackColor = true;
            this.radioButtonSortoByAmountsOfPhotos.CheckedChanged += new System.EventHandler(this.radioButtonSortoByAmountsOfPhotos_CheckedChanged);
            // 
            // radioButtonSortByAmountsOfComments
            // 
            this.radioButtonSortByAmountsOfComments.AutoSize = true;
            this.radioButtonSortByAmountsOfComments.Enabled = false;
            this.radioButtonSortByAmountsOfComments.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortByAmountsOfComments.Location = new System.Drawing.Point(270, 112);
            this.radioButtonSortByAmountsOfComments.Name = "radioButtonSortByAmountsOfComments";
            this.radioButtonSortByAmountsOfComments.Size = new System.Drawing.Size(253, 22);
            this.radioButtonSortByAmountsOfComments.TabIndex = 10;
            this.radioButtonSortByAmountsOfComments.Text = "Sort by amount of comments";
            this.radioButtonSortByAmountsOfComments.UseVisualStyleBackColor = true;
            this.radioButtonSortByAmountsOfComments.CheckedChanged += new System.EventHandler(this.radioButtonSortByAmountsOfComments_CheckedChanged);
            // 
            // radioButtonSortByLastUpdatedAlbum
            // 
            this.radioButtonSortByLastUpdatedAlbum.AutoSize = true;
            this.radioButtonSortByLastUpdatedAlbum.Enabled = false;
            this.radioButtonSortByLastUpdatedAlbum.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSortByLastUpdatedAlbum.Location = new System.Drawing.Point(270, 76);
            this.radioButtonSortByLastUpdatedAlbum.Name = "radioButtonSortByLastUpdatedAlbum";
            this.radioButtonSortByLastUpdatedAlbum.Size = new System.Drawing.Size(241, 22);
            this.radioButtonSortByLastUpdatedAlbum.TabIndex = 11;
            this.radioButtonSortByLastUpdatedAlbum.Text = "Sort by last updated album";
            this.radioButtonSortByLastUpdatedAlbum.UseVisualStyleBackColor = true;
            this.radioButtonSortByLastUpdatedAlbum.CheckedChanged += new System.EventHandler(this.radioButtonSortByLastUpdatedAlbum_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "If you want to sort the list of albums you can click on one of the following butt" +
    "ons:";
            // 
            // radioButtonShowWithoutOrder
            // 
            this.radioButtonShowWithoutOrder.AutoSize = true;
            this.radioButtonShowWithoutOrder.Checked = true;
            this.radioButtonShowWithoutOrder.Enabled = false;
            this.radioButtonShowWithoutOrder.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShowWithoutOrder.Location = new System.Drawing.Point(12, 76);
            this.radioButtonShowWithoutOrder.Name = "radioButtonShowWithoutOrder";
            this.radioButtonShowWithoutOrder.Size = new System.Drawing.Size(180, 22);
            this.radioButtonShowWithoutOrder.TabIndex = 13;
            this.radioButtonShowWithoutOrder.TabStop = true;
            this.radioButtonShowWithoutOrder.Text = "Show without order";
            this.radioButtonShowWithoutOrder.UseVisualStyleBackColor = true;
            this.radioButtonShowWithoutOrder.CheckedChanged += new System.EventHandler(this.radioButtonShowWithoutOrder_CheckedChanged);
            // 
            // buttonAlbumStatistics
            // 
            this.buttonAlbumStatistics.Enabled = false;
            this.buttonAlbumStatistics.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbumStatistics.Location = new System.Drawing.Point(554, 83);
            this.buttonAlbumStatistics.Name = "buttonAlbumStatistics";
            this.buttonAlbumStatistics.Size = new System.Drawing.Size(109, 53);
            this.buttonAlbumStatistics.TabIndex = 14;
            this.buttonAlbumStatistics.Text = "Album statistics";
            this.buttonAlbumStatistics.UseVisualStyleBackColor = true;
            this.buttonAlbumStatistics.Click += new System.EventHandler(this.buttonAlbumStatistics_Click);
            // 
            // comboBoxYearOrMonth
            // 
            this.comboBoxYearOrMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYearOrMonth.Enabled = false;
            this.comboBoxYearOrMonth.FormattingEnabled = true;
            this.comboBoxYearOrMonth.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.comboBoxYearOrMonth.Location = new System.Drawing.Point(670, 94);
            this.comboBoxYearOrMonth.Name = "comboBoxYearOrMonth";
            this.comboBoxYearOrMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYearOrMonth.TabIndex = 16;
            // 
            // labelAmountOfComments
            // 
            this.labelAmountOfComments.AutoSize = true;
            this.labelAmountOfComments.BackColor = System.Drawing.Color.Transparent;
            this.labelAmountOfComments.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountOfComments.Location = new System.Drawing.Point(253, 418);
            this.labelAmountOfComments.Name = "labelAmountOfComments";
            this.labelAmountOfComments.Size = new System.Drawing.Size(204, 20);
            this.labelAmountOfComments.TabIndex = 17;
            this.labelAmountOfComments.Text = "labelAmountOfComments";
            this.labelAmountOfComments.Visible = false;
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoverPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(428, 195);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(136, 148);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 18;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 458);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.labelAmountOfComments);
            this.Controls.Add(this.comboBoxYearOrMonth);
            this.Controls.Add(this.buttonAlbumStatistics);
            this.Controls.Add(this.radioButtonShowWithoutOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonSortByLastUpdatedAlbum);
            this.Controls.Add(this.radioButtonSortByAmountsOfComments);
            this.Controls.Add(this.radioButtonSortoByAmountsOfPhotos);
            this.Controls.Add(this.labelHeadlineForm);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.buttonPhotosInTheAlbum);
            this.Controls.Add(this.labelAmountOfPhotos);
            this.Controls.Add(this.listBoxAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlbumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumsForm";
            this.Load += new System.EventHandler(this.LikeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAmountOfPhotos;
        private System.Windows.Forms.Button buttonPhotosInTheAlbum;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelHeadlineForm;
        private System.Windows.Forms.RadioButton radioButtonSortoByAmountsOfPhotos;
        private System.Windows.Forms.RadioButton radioButtonSortByAmountsOfComments;
        private System.Windows.Forms.RadioButton radioButtonSortByLastUpdatedAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonShowWithoutOrder;
        private System.Windows.Forms.Button buttonAlbumStatistics;
        private System.Windows.Forms.ComboBox comboBoxYearOrMonth;
        private System.Windows.Forms.Label labelAmountOfComments;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
    }
}