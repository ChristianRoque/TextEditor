using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

interface IBaseForm
{
    event EventHandler ColorUpdate;
    bool onMouseDown { get; set; }
    Point lastLocation { get; set; }
}

namespace HW3Controls
{
    public partial class BaseForm : Form, IBaseForm
    {
        public event EventHandler ColorUpdate;
        public event EventHandler OnActivated;
        public event EventHandler OnClose;
        public bool onMouseDown { get; set; }
        public Point lastLocation { get; set; }
        public BaseForm()
        {
            InitializeComponent();

        }

        private void colorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = MyDialog.Color;
            }
            if (ColorUpdate != null) ColorUpdate(this, EventArgs.Empty);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            if (OnClose != null) OnClose(this, EventArgs.Empty);
        }

        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            onMouseDown = true;
            lastLocation = e.Location;
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {

            if (onMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            onMouseDown = false;
        }

        private void onColorsClick(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = MyDialog.Color;
            }
            if (ColorUpdate != null) ColorUpdate(this, EventArgs.Empty);
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            this.Close();
            if (OnClose != null) OnClose(this, EventArgs.Empty);
        }

        private void BaseForm_Activated(object sender, EventArgs e)
        {
            if (OnActivated != null) OnActivated(this, EventArgs.Empty);
        }
    }
}
