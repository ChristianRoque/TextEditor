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
            this.textBox2.Text = properties.font;
            this.textBox1.Text = properties.title;
      
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
            this.properties.font = this.textBox2.Text;
            this.properties.title = this.textBox1.Text;
            if (Apply != null) Apply(this, EventArgs.Empty);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
