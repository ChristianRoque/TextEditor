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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Size = new System.Drawing.Size(1080, 411);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(521, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.apply_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(711, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(906, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ok_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(858, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(595, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 39);
            this.textBox2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save Location";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.saveLocation_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(59, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Save Size";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.saveSize_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(333, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Font Color";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.fontColor_Click);
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

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button Backcolor;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}