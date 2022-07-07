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
            this.fileTitle.Text = properties.title.Split('.')[0];
            this.label3.BackColor = properties.backColor;
            this.label4.BackColor = properties.fontColor;
      
        }

        private bool contrast(Color firstColor, Color secondColor)
        {
            double ratio;
            double firstColorLum = (0.2126 * firstColor.R + 0.7152 * firstColor.G + 0.0722 * firstColor.G);
            double secondColorLum = (0.2126 * secondColor.R + 0.7152 * secondColor.G + 0.0722 * secondColor.G);
            if (firstColorLum > secondColorLum)
            {
                ratio = (firstColorLum + 0.05) / (secondColorLum + 0.05);
            } else
            {
                ratio = (secondColorLum + 0.05) / (firstColorLum + 0.05);
            }
            if (ratio >= 4.0)
            {
                return true;
            }
            return false;
        }
        

        private void fontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = properties.fontColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (contrast(colorDialog.Color, properties.backColor))
                {
                    this.label4.BackColor = colorDialog.Color;
                    properties.fontColor = colorDialog.Color;
                } else
                {
                    MessageBox.Show("Contrast between colors not high enough.");
                }
                
            }
        }

        private void Backcolor_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = properties.backColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (contrast(colorDialog.Color, properties.fontColor))
                {
                    this.label3.BackColor = colorDialog.Color;
                    properties.backColor = colorDialog.Color;
                } else
                {
                    MessageBox.Show("Contrast between colors not high enough.");
                }
                    
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
            if (this.properties.font == new Font(this.fontStyle.Text,20).Name)
            {
                this.properties.font = this.fontStyle.Text;
            } else
            {
                MessageBox.Show("Font does not exist. Please try again.");
            }
            if (this.fileTitle.Text.Length != 0)
            {
                this.properties.title = this.fileTitle.Text;
            } else
            {
                MessageBox.Show("Empty value for title.");
            }
            
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
