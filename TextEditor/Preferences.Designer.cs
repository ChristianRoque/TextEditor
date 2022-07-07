namespace TextEditor
{
    partial class Preferences
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
            this.apply = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.fileTitle = new System.Windows.Forms.TextBox();
            this.fontStyle = new System.Windows.Forms.TextBox();
            this.saveLocation = new System.Windows.Forms.Button();
            this.saveSize = new System.Windows.Forms.Button();
            this.fontColor = new System.Windows.Forms.Button();
            this.Backcolor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Backcolor);
            this.panel1.Controls.Add(this.fontColor);
            this.panel1.Controls.Add(this.saveSize);
            this.panel1.Controls.Add(this.saveLocation);
            this.panel1.Controls.Add(this.fontStyle);
            this.panel1.Controls.Add(this.fileTitle);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.apply);
            this.panel1.Size = new System.Drawing.Size(1080, 411);
            // 
            // apply
            // 
            this.apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.apply.Location = new System.Drawing.Point(521, 332);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(150, 46);
            this.apply.TabIndex = 0;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            this.apply.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.apply_HelpRequested);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(711, 332);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(150, 46);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            this.cancel.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cancel_HelpRequested);
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(906, 332);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(150, 46);
            this.ok.TabIndex = 2;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.ok_HelpRequested);
            // 
            // fileTitle
            // 
            this.fileTitle.Location = new System.Drawing.Point(858, 43);
            this.fileTitle.Name = "fileTitle";
            this.fileTitle.Size = new System.Drawing.Size(200, 39);
            this.fileTitle.TabIndex = 3;
            this.fileTitle.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.fileTitle_HelpRequested);
            // 
            // fontStyle
            // 
            this.fontStyle.Location = new System.Drawing.Point(595, 43);
            this.fontStyle.Name = "fontStyle";
            this.fontStyle.Size = new System.Drawing.Size(204, 39);
            this.fontStyle.TabIndex = 4;
            this.fontStyle.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.fontStyle_HelpRequested);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(333, 150);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(200, 46);
            this.saveLocation.TabIndex = 3;
            this.saveLocation.Text = "Save Location";
            this.saveLocation.UseVisualStyleBackColor = true;
            this.saveLocation.Click += new System.EventHandler(this.saveLocation_Click);
            this.saveLocation.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.saveLocation_HelpRequested);
            // 
            // saveSize
            // 
            this.saveSize.Location = new System.Drawing.Point(59, 150);
            this.saveSize.Name = "saveSize";
            this.saveSize.Size = new System.Drawing.Size(200, 46);
            this.saveSize.TabIndex = 5;
            this.saveSize.Text = "Save Size";
            this.saveSize.UseVisualStyleBackColor = true;
            this.saveSize.Click += new System.EventHandler(this.saveSize_Click);
            this.saveSize.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.saveSize_HelpRequested);
            // 
            // fontColor
            // 
            this.fontColor.Location = new System.Drawing.Point(333, 43);
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(200, 46);
            this.fontColor.TabIndex = 6;
            this.fontColor.Text = "Font Color";
            this.fontColor.UseVisualStyleBackColor = true;
            this.fontColor.Click += new System.EventHandler(this.fontColor_Click);
            this.fontColor.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.fontColor_HelpRequested);
            // 
            // Backcolor
            // 
            this.Backcolor.AutoSize = true;
            this.Backcolor.Location = new System.Drawing.Point(59, 43);
            this.Backcolor.Name = "Backcolor";
            this.Backcolor.Size = new System.Drawing.Size(200, 46);
            this.Backcolor.TabIndex = 7;
            this.Backcolor.Text = "Back Color";
            this.Backcolor.UseVisualStyleBackColor = true;
            this.Backcolor.Click += new System.EventHandler(this.Backcolor_Click_1);
            this.Backcolor.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Backcolor_HelpRequested);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(633, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Font Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(929, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextEditor.Properties.Resources.back_wallpaper_2014_045241594;
            this.ClientSize = new System.Drawing.Size(1080, 738);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox fontStyle;
        private TextBox fileTitle;
        private Button ok;
        private Button cancel;
        private Button apply;
        private Label label2;
        private Label label1;
        private Button Backcolor;
        private Button fontColor;
        private Button saveSize;
        private Button saveLocation;
    }
}