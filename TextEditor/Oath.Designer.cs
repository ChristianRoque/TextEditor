namespace TextEditor
{
    partial class Oath
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
            this.pledge1 = new HW3Main.HW3Controls.Pledge();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pledge1);
            this.panel1.Size = new System.Drawing.Size(936, 129);
            // 
            // pledge1
            // 
            this.pledge1.BackColor = System.Drawing.Color.Transparent;
            this.pledge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pledge1.Location = new System.Drawing.Point(0, 0);
            this.pledge1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pledge1.Name = "pledge1";
            this.pledge1.Size = new System.Drawing.Size(936, 129);
            this.pledge1.TabIndex = 0;
            // 
            // Oath
            // 
            this.BackgroundImage = global::TextEditor.Properties.Resources.back_wallpaper_2014_045241594;
            this.ClientSize = new System.Drawing.Size(936, 456);
            this.Name = "Oath";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HW3Main.HW3Controls.Pledge pledge1;
    }
}