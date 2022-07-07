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
        public event EventHandler Apply;
        public Preferences()
        {
            InitializeComponent();
        }
    }
}
