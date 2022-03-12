namespace WindowsFormsApplication4
{
    partial class ContrastForm
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
            this.contrast_textBox = new System.Windows.Forms.TextBox();
            this.Contrast = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contrast_textBox
            // 
            this.contrast_textBox.Location = new System.Drawing.Point(12, 49);
            this.contrast_textBox.Name = "contrast_textBox";
            this.contrast_textBox.Size = new System.Drawing.Size(153, 20);
            this.contrast_textBox.TabIndex = 0;
            // 
            // Contrast
            // 
            this.Contrast.AutoSize = true;
            this.Contrast.Location = new System.Drawing.Point(64, 23);
            this.Contrast.Name = "Contrast";
            this.Contrast.Size = new System.Drawing.Size(46, 13);
            this.Contrast.TabIndex = 1;
            this.Contrast.Text = "Contrast";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(12, 87);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(53, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(112, 87);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(53, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 132);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.Contrast);
            this.Controls.Add(this.contrast_textBox);
            this.Name = "ContrastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contrast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contrast_textBox;
        private System.Windows.Forms.Label Contrast;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}