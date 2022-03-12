namespace WindowsFormsApplication4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PictureSource = new System.Windows.Forms.PictureBox();
            this.PictureResult = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.savePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.exitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.equalHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toEDGE = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToGray = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureHistogram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureSource
            // 
            this.PictureSource.Image = ((System.Drawing.Image)(resources.GetObject("PictureSource.Image")));
            this.PictureSource.Location = new System.Drawing.Point(12, 46);
            this.PictureSource.Name = "PictureSource";
            this.PictureSource.Size = new System.Drawing.Size(256, 256);
            this.PictureSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSource.TabIndex = 0;
            this.PictureSource.TabStop = false;
            // 
            // PictureResult
            // 
            this.PictureResult.Image = ((System.Drawing.Image)(resources.GetObject("PictureResult.Image")));
            this.PictureResult.Location = new System.Drawing.Point(284, 46);
            this.PictureResult.Name = "PictureResult";
            this.PictureResult.Size = new System.Drawing.Size(255, 256);
            this.PictureResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureResult.TabIndex = 1;
            this.PictureResult.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPicture,
            this.savePicture,
            this.exitForm});
            this.tToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tToolStripMenuItem.Image")));
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tToolStripMenuItem.Text = "File";
            // 
            // openPicture
            // 
            this.openPicture.BackColor = System.Drawing.SystemColors.Control;
            this.openPicture.Image = ((System.Drawing.Image)(resources.GetObject("openPicture.Image")));
            this.openPicture.Name = "openPicture";
            this.openPicture.Size = new System.Drawing.Size(152, 22);
            this.openPicture.Text = "Open";
            this.openPicture.Click += new System.EventHandler(this.openImages_Click);
            // 
            // savePicture
            // 
            this.savePicture.Image = ((System.Drawing.Image)(resources.GetObject("savePicture.Image")));
            this.savePicture.Name = "savePicture";
            this.savePicture.Size = new System.Drawing.Size(152, 22);
            this.savePicture.Text = "Save";
            this.savePicture.Click += new System.EventHandler(this.saveImages_Click);
            // 
            // exitForm
            // 
            this.exitForm.Image = ((System.Drawing.Image)(resources.GetObject("exitForm.Image")));
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(152, 22);
            this.exitForm.Text = "Exit";
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHistogram,
            this.equalHistogram});
            this.histogramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("histogramToolStripMenuItem.Image")));
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // showHistogram
            // 
            this.showHistogram.Image = ((System.Drawing.Image)(resources.GetObject("showHistogram.Image")));
            this.showHistogram.Name = "showHistogram";
            this.showHistogram.Size = new System.Drawing.Size(138, 22);
            this.showHistogram.Text = "Histogram";
            this.showHistogram.Click += new System.EventHandler(this.showHistogram_Click);
            // 
            // equalHistogram
            // 
            this.equalHistogram.Image = ((System.Drawing.Image)(resources.GetObject("equalHistogram.Image")));
            this.equalHistogram.Name = "equalHistogram";
            this.equalHistogram.Size = new System.Drawing.Size(138, 22);
            this.equalHistogram.Text = "Equalization";
            this.equalHistogram.Click += new System.EventHandler(this.equalHistogram_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEDGE});
            this.filterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filterToolStripMenuItem.Image")));
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // toEDGE
            // 
            this.toEDGE.Image = ((System.Drawing.Image)(resources.GetObject("toEDGE.Image")));
            this.toEDGE.Name = "toEDGE";
            this.toEDGE.Size = new System.Drawing.Size(102, 22);
            this.toEDGE.Text = "EDGE";
            this.toEDGE.Click += new System.EventHandler(this.toEDGE_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToGray,
            this.convertToNegative});
            this.convertToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("convertToolStripMenuItem.Image")));
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // convertToGray
            // 
            this.convertToGray.Image = ((System.Drawing.Image)(resources.GetObject("convertToGray.Image")));
            this.convertToGray.Name = "convertToGray";
            this.convertToGray.Size = new System.Drawing.Size(121, 22);
            this.convertToGray.Text = "Gray";
            this.convertToGray.Click += new System.EventHandler(this.convertToGray_Click);
            // 
            // convertToNegative
            // 
            this.convertToNegative.Image = ((System.Drawing.Image)(resources.GetObject("convertToNegative.Image")));
            this.convertToNegative.Name = "convertToNegative";
            this.convertToNegative.Size = new System.Drawing.Size(121, 22);
            this.convertToNegative.Text = "Negative";
            this.convertToNegative.Click += new System.EventHandler(this.convertToNegative_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBrightness,
            this.contrastToolStripMenuItem});
            this.optionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionToolStripMenuItem.Image")));
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.optionToolStripMenuItem.Text = "Increase";
            // 
            // changeBrightness
            // 
            this.changeBrightness.Image = ((System.Drawing.Image)(resources.GetObject("changeBrightness.Image")));
            this.changeBrightness.Name = "changeBrightness";
            this.changeBrightness.Size = new System.Drawing.Size(129, 22);
            this.changeBrightness.Text = "Brightness";
            this.changeBrightness.Click += new System.EventHandler(this.changeBrightness_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contrastToolStripMenuItem.Image")));
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // about
            // 
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(68, 20);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // PictureHistogram
            // 
            this.PictureHistogram.Image = ((System.Drawing.Image)(resources.GetObject("PictureHistogram.Image")));
            this.PictureHistogram.Location = new System.Drawing.Point(12, 310);
            this.PictureHistogram.Name = "PictureHistogram";
            this.PictureHistogram.Size = new System.Drawing.Size(256, 60);
            this.PictureHistogram.TabIndex = 3;
            this.PictureHistogram.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(551, 382);
            this.Controls.Add(this.PictureHistogram);
            this.Controls.Add(this.PictureResult);
            this.Controls.Add(this.PictureSource);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureSource;
        private System.Windows.Forms.PictureBox PictureResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPicture;
        private System.Windows.Forms.ToolStripMenuItem savePicture;
        private System.Windows.Forms.ToolStripMenuItem exitForm;
        private System.Windows.Forms.PictureBox PictureHistogram;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToGray;
        private System.Windows.Forms.ToolStripMenuItem convertToNegative;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem showHistogram;
        private System.Windows.Forms.ToolStripMenuItem equalHistogram;
        private System.Windows.Forms.ToolStripMenuItem changeBrightness;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toEDGE;
    }
}

