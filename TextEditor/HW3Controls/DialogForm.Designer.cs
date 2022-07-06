namespace HW3Controls
{
    partial class DialogForm
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
            this.groupInfo1 = new HW3.GroupInfo();
            this.courseInfo2 = new HW3.CourseInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // groupInfo1
            // 
            this.groupInfo1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupInfo1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupInfo1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupInfo1.Location = new System.Drawing.Point(0, 231);
            this.groupInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.groupInfo1.Name = "groupInfo1";
            this.groupInfo1.Size = new System.Drawing.Size(476, 115);
            this.groupInfo1.TabIndex = 0;
            // 
            // courseInfo2
            // 
            this.courseInfo2.BackColor = System.Drawing.Color.Transparent;
            this.courseInfo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseInfo2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseInfo2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.courseInfo2.Location = new System.Drawing.Point(0, 0);
            this.courseInfo2.Margin = new System.Windows.Forms.Padding(5);
            this.courseInfo2.Name = "courseInfo2";
            this.courseInfo2.Size = new System.Drawing.Size(476, 68);
            this.courseInfo2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 163);
            this.panel1.TabIndex = 2;
            // 
            // DialogForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(476, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.courseInfo2);
            this.Controls.Add(this.groupInfo1);
            this.Name = "DialogForm";
            this.Text = "Dialogs";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HW3.GroupInfo groupInfo1;
        private HW3.CourseInfo courseInfo1;
        private HW3.CourseInfo courseInfo2;
        public Panel panel1;
    }
}