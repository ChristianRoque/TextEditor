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
            form.fileName = "example";

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
                applyFormat();
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

        public void createFormat()
        {
            this.textFormat.backColor = this.textBox1.BackColor;
            this.textFormat.fontColor = this.textBox1.ForeColor;
            this.textFormat.formLocation = this.Location;
            this.textFormat.formSize = this.Size;
            this.textFormat.title = this.fileName.Split('.')[0];
            this.textFormat.text = this.textBox1.Text;
            this.textFormat.font = this.textBox1.Font.Name;
        }

        public void applyFormat()
        {
            this.textBox1.BackColor = this.textFormat.backColor;
            this.textBox1.ForeColor = this.textFormat.fontColor;
            this.Location = this.textFormat.formLocation;
            this.Size = this.textFormat.formSize;
            this.fileName.Split('.')[0] = this.textFormat.title;
            this.textBox1.Text = this.textFormat.text;
            this.textBox1.Font = new Font(this.textFormat.font,this.textBox1.Font.Size);
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
                    createFormat();
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
                    createFormat();
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
            Preferences myPrefDialog = new Preferences(textFormat);
            myPrefDialog.Apply += applyChanges;
            // Event handler to update mainform values modelessly
            DialogResult result = myPrefDialog.ShowDialog();
            // Update all values if dialog was updated using the OK button
            if (result == DialogResult.OK)
            {
                textFormat.font = myPrefDialog.properties.font;
                textFormat.formLocation = myPrefDialog.properties.formLocation;
                textFormat.formSize = myPrefDialog.properties.formSize;
                textFormat.fontColor = myPrefDialog.properties.fontColor;
                textFormat.backColor = myPrefDialog.properties.backColor;
                textFormat.title = myPrefDialog.properties.title;
                applyFormat();
            }
        }

        private void applyChanges(object sender, EventArgs e)
        {
            Preferences myPrefDialog = (Preferences)sender;
            textFormat.font = myPrefDialog.properties.font;
            textFormat.formLocation = myPrefDialog.properties.formLocation;
            textFormat.formSize = myPrefDialog.properties.formSize;
            textFormat.fontColor = myPrefDialog.properties.fontColor;
            textFormat.backColor = myPrefDialog.properties.backColor;
            textFormat.title = myPrefDialog.properties.title;
            applyFormat();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            foreach (Form form in Application.OpenForms)
                if (form is About)
                    isFormOpen = true;
            if (!isFormOpen)
            {
                About dialog = new About();
                int x_cooridnate = this.Location.X + this.Size.Width;
                int y_coordinate = this.Location.Y;
                dialog.Location = new Point(x_cooridnate, y_coordinate);
                dialog.Show();
            }
            else
                MessageBox.Show("1 too many dialogs open, friend");
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isFormOpen = false;
            foreach (Form form in Application.OpenForms)
                if (form is Oath)
                    isFormOpen = true;
            if (!isFormOpen)
            {
                Oath dialog = new Oath();
                int x_cooridnate = this.Location.X + this.Size.Width;
                int y_coordinate = this.Location.Y;
                dialog.Location = new Point(x_cooridnate, y_coordinate);
                dialog.Show();
            }
            else
                MessageBox.Show("1 too many dialogs open, friend");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            createFormat();
        }
    }
}
