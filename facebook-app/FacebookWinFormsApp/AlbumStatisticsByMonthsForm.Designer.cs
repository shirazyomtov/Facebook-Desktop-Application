namespace BasicFacebookFeatures
{
    public partial class AlbumStatisticsByMonthsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartAlbumStaisticsByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHeadlineForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAlbumStaisticsByMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAlbumStaisticsByMonth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAlbumStaisticsByMonth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAlbumStaisticsByMonth.Legends.Add(legend1);
            this.chartAlbumStaisticsByMonth.Location = new System.Drawing.Point(33, 86);
            this.chartAlbumStaisticsByMonth.Name = "chartAlbumStaisticsByMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount of photos";
            this.chartAlbumStaisticsByMonth.Series.Add(series1);
            this.chartAlbumStaisticsByMonth.Size = new System.Drawing.Size(735, 352);
            this.chartAlbumStaisticsByMonth.TabIndex = 1;
            this.chartAlbumStaisticsByMonth.Text = "chartAlbumStaisticsByMonth";
            // 
            // labelHeadlineForm
            // 
            this.labelHeadlineForm.BackColor = System.Drawing.Color.Transparent;
            this.labelHeadlineForm.Font = new System.Drawing.Font("MV Boli", 24.2F, System.Drawing.FontStyle.Bold);
            this.labelHeadlineForm.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelHeadlineForm.Location = new System.Drawing.Point(85, 16);
            this.labelHeadlineForm.Name = "labelHeadlineForm";
            this.labelHeadlineForm.Size = new System.Drawing.Size(648, 67);
            this.labelHeadlineForm.TabIndex = 10;
            this.labelHeadlineForm.Text = "Album statistics by month";
            // 
            // AlbumStatisticsByMonthsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHeadlineForm);
            this.Controls.Add(this.chartAlbumStaisticsByMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlbumStatisticsByMonthsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumStatisticsByMonthForm";
            this.Load += new System.EventHandler(this.AlbumStatisticsByMonthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAlbumStaisticsByMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAlbumStaisticsByMonth;
        private System.Windows.Forms.Label labelHeadlineForm;
    }
}