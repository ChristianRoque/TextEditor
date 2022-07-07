using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW3Controls;

interface IPreferences
{
    event EventHandler Apply;
}

namespace TextEditor
{
    
    public partial class Preferences : DialogForm
    {
        public textProperties properties;
        public event EventHandler Apply;
        public Preferences(textProperties properties)
        {
            InitializeComponent();
            this.properties = properties;
            this.fontStyle.Text = properties.font;
            this.fileTitle.Text = properties.title;
      
        }

        private void fontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = properties.fontColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                properties.fontColor= colorDialog.Color;
            }
        }

        private void Backcolor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = properties.backColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                properties.backColor = colorDialog.Color;
            }
        }

        private void saveSize_Click(object sender, EventArgs e)
        {
            properties.formSize = this.Size;
        }

        private void saveLocation_Click(object sender, EventArgs e)
        {
            properties.formLocation = this.Location;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            this.properties.font = this.fontStyle.Text;
            this.properties.title = this.fileTitle.Text;
            if (Apply != null) Apply(this, EventArgs.Empty);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Backcolor_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Click to open a dialog to pick the background color for the editor.");
        }

        private void fontColor_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Click to open a dialog to pick the font color for the editor.");
        }

        private void saveSize_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Click to save the size of the file editor.(mirrors the size of preferences)");
        }

        private void saveLocation_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Click to save the location of the file editor.(mirrors the size of preferences)");
        }

        private void fontStyle_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Input for the desired font style.");
        }

        private void fileTitle_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Input for the desired title.");
        }

        private void apply_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Click to apply the desired changes to editor without exiting the preferences window.");
        }

        private void cancel_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Close the preferences window.");
        }

        private void ok_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            hlpevent.Handled = true;
            MessageBox.Show("Save your preferences and close the preferences window.");
        }
    }
}
