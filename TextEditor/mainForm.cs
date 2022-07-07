using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TextEditor
{
    public partial class mainForm : Form
    {
        string fileName;
        FileStream fs;
        textProperties textFormat = new textProperties();

        public mainForm()
        {
            InitializeComponent();
        }
        public static mainForm CreateTopLevelWindow(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                foreach (mainForm openForm in Application.OpenForms)
                {
                    if (string.Compare(openForm.FileName, fileName, true) == 0)
                    {
                        openForm.Activate();
                        return openForm;
                    }
                }
            }

            mainForm form = new mainForm();

            if (fileName != null)
            {
                form.fileName = fileName;
                form.OpenFile(fileName);
                form.toolStripStatusLabel1.Text = fileName;
                form.toolStripStatusLabel1.Text = Path.GetFileName(fileName);
            }

           
            form.Show();
            form.Activate();
            return form;
        }

        void OpenFile(string fileName)
        {
            
            if (fileName.Substring(fileName.Length - 3) != "dat")
            {
                this.fileName = fileName;
                using (StreamReader reader = new StreamReader(fileName))
                {
                    this.textBox1.Text = reader.ReadToEnd();
                }
                this.statusStrip1.Text = this.fileName;
            }

            fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                textFormat = (textProperties)formatter.Deserialize(fs);
                //this.textBox1.Font = textFormat.font;
                this.textBox1.Text = textFormat.text;
                this.Location = textFormat.formLocation;
                this.Size = textFormat.formSize;
                this.textBox1.ForeColor = textFormat.fontColor;
                this.textBox1.BackColor = textFormat.backColor;
            }
            catch (SerializationException error)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + error.Message);
                throw;
            }
        }
        string FileName
        {
            get { return this.fileName; }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Closing instance of opened file before new SDI instance
                if (fs != null)
                {
                    fs.Close();
                }
                mainForm.CreateTopLevelWindow(this.openFileDialog1.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1 = new SaveFileDialog();
            this.saveFileDialog1.Filter = "Binary|*.dat|Text|*.txt";
            this.saveFileDialog1.Title = "Save text file";
            this.saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    textFormat.font = this.textBox1.Font.ToString();
                    textFormat.text = this.textBox1.Text;
                    textFormat.formLocation = this.Location;
                    textFormat.formSize = this.Size;
                    textFormat.fontColor = this.textBox1.ForeColor;
                    textFormat.backColor = this.textBox1.BackColor;
                    #pragma warning disable SYSLIB0011
                    formatter.Serialize(fs, textFormat);
                    this.toolStripStatusLabel1.Text = Path.GetFileName(saveFileDialog1.FileName);

                }
                catch (SerializationException error)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + error.Message);
                    throw;
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBox1.SelectionLength > 0)
            {
                textBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox1.Paste();
        }

        private void openNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closing instance of opened file before new SDI instance
            if (fs != null)
            {
                fs.Close();
            }
            mainForm.CreateTopLevelWindow(null);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fs == null)
            {
                MessageBox.Show( 
                    "Please save current changes as a new file using - Save As",
                    "No opened file detected.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            } else
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    fs.Close();
                    fs = new FileStream(this.fileName, FileMode.Create);
                    textFormat.font = this.textBox1.Font.ToString();
                    textFormat.text = this.textBox1.Text;
                    textFormat.formLocation = this.Location;
                    textFormat.formSize = this.Size;
                    textFormat.fontColor = this.textBox1.ForeColor;
                    textFormat.backColor = this.textBox1.BackColor;
                    #pragma warning disable SYSLIB0011
                    formatter.Serialize(fs, textFormat);
                }
                catch (SerializationException error)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + error.Message);
                    throw;
                }
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fs != null)
            {
                fs.Close();
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences myPrefDialog = new Preferences();
            myPrefDialog.Apply += applyChanges;
            // Event handler to update mainform values modelessly
            DialogResult result = myPrefDialog.ShowDialog();
            // Update all values if dialog was updated using the OK button
            if (result == DialogResult.OK)
            {
                textFormat.font = this.textBox1.Font.ToString();
                textFormat.text = this.textBox1.Text;
                textFormat.formLocation = this.Location;
                textFormat.formSize = this.Size;
                textFormat.fontColor = this.textBox1.ForeColor;
                textFormat.backColor = this.textBox1.BackColor;
            }
        }

        private void applyChanges(object sender, EventArgs e)
        {
            Preferences myPrefDialog = (Preferences)sender;
        }
    }
}
