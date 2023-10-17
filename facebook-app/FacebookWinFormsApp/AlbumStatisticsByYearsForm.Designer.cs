namespace BasicFacebookFeatures
{
    public partial class AlbumStatisticsByYearsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAlbumStaisticsByYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlbumStaisticsByYear)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAlbumStaisticsByYear
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAlbumStaisticsByYear.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAlbumStaisticsByYear.Legends.Add(legend2);
            this.chartAlbumStaisticsByYear.Location = new System.Drawing.Point(32, 79);
            this.chartAlbumStaisticsByYear.Name = "chartAlbumStaisticsByYear";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Amount of photos";
            this.chartAlbumStaisticsByYear.Series.Add(series2);
            this.chartAlbumStaisticsByYear.Size = new System.Drawing.Size(735, 352);
            this.chartAlbumStaisticsByYear.TabIndex = 0;
            this.chartAlbumStaisticsByYear.Text = "Album ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 67);
            this.label1.TabIndex = 11;
            this.label1.Text = "Album statistics by year";
            // 
            // AlbumStatisticsByYearsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartAlbumStaisticsByYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlbumStatisticsByYearsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumStatisticsByYearForm";
            this.Load += new System.EventHandler(this.AlbumStatisticsByYearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAlbumStaisticsByYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAlbumStaisticsByYear;
        private System.Windows.Forms.Label label1;
    }
}