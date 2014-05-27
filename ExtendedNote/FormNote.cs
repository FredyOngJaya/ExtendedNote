using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExtendedNote
{
    public partial class FormNote : Form
    {
        string pathFile;

        public FormNote()
        {
            InitializeComponent();
            // Open File Dialog
            this.openFileDialogNote.CheckFileExists = true;
            this.openFileDialogNote.CheckPathExists = true;
            this.openFileDialogNote.Multiselect = false;
            this.openFileDialogNote.Filter = "Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            // Save File Dialog
            this.saveFileDialogNote.CheckPathExists = true;
            this.saveFileDialogNote.Filter = "Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            // Font Family
            foreach (FontFamily font in FontFamily.Families)
            {
                this.toolbarFontFamily.Items.Add(font.Name);
            }
            this.toolbarFontFamily.Text = richTextBoxText.Font.Name;
            // Font Size
            for (int i = 8; i <= 32; i++)
            {
                this.toolbarFontSize.Items.Add(i);
            }
            this.toolbarFontSize.Text = richTextBoxText.Font.Size.ToString();
            // Add event
            // Change font style
            this.toolbarFontFamily.SelectedIndexChanged += new EventHandler(changeFont);
            this.toolbarFontSize.SelectedIndexChanged += new EventHandler(changeFont);
            this.toolbarItalic.Click += new EventHandler(eventToolbarFontStyle);
            this.toolbarUnderline.Click += new EventHandler(eventToolbarFontStyle);
        }

        private void FormNote_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
        }

        private void openFile(string fileName)
        {
            if (fileName.ToLower().EndsWith(".rtf"))
            {
                this.richTextBoxText.LoadFile(fileName);
            }
            else
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    this.richTextBoxText.Text = reader.ReadToEnd();
                }
            }
            this.Text = fileName + " - Note";
        }

        private void saveFile(string fileName)
        {
            if (fileName.ToLower().EndsWith(".rtf"))
            {
                this.richTextBoxText.SaveFile(fileName);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(this.richTextBoxText.Text);
                }
            }
            this.Text = fileName + " - Note";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.Clear();
            this.Text = "New - Note";
            this.pathFile = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialogNote.FilterIndex = 0;
            this.openFileDialogNote.FileName = "";
            if (this.openFileDialogNote.ShowDialog() == DialogResult.OK)
            {
                openFile(this.openFileDialogNote.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pathFile.Equals(""))
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                saveFile(pathFile);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialogNote.FilterIndex = 0;
            this.saveFileDialogNote.FileName = "";
            if (pathFile == "" && this.saveFileDialogNote.ShowDialog() == DialogResult.OK)
            {
                pathFile = this.saveFileDialogNote.FileName;
            }
            saveFile(pathFile);
        }

        private void changeFont(object sender, EventArgs e)
        {
            float fontSize;
            if (!float.TryParse(toolbarFontSize.Text, out fontSize))
            {
                fontSize = this.richTextBoxText.Font.Size;
            }
            FontStyle fontStyle = richTextBoxText.Font.Style;
            if (toolbarBold.Checked)
                fontStyle |= FontStyle.Bold;
            if (toolbarItalic.Checked)
                fontStyle |= FontStyle.Italic;
            if (toolbarUnderline.Checked)
                fontStyle |= FontStyle.Underline;
            this.richTextBoxText.SelectionFont = new Font(toolbarFontFamily.Text, fontSize, fontStyle);
        }

        private void eventToolbarFontStyle(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Checked ^= true;
            changeFont(null, null);
        }
    }
}
