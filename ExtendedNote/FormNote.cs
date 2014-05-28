using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

namespace ExtendedNote
{
    public partial class FormNote : Form
    {
        string pathFile;
        string sign;
        bool isSafeExit = false;

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
                this.fontFamilyToolStripButton.Items.Add(font.Name);
            }
            // Font Size
            for (int i = 8; i <= 32; i++)
            {
                this.fontSizeToolStripButton.Items.Add(i);
            }
            richTextBoxText_Click(null, null);
            // Add event
            // Change font style
            this.fontFamilyToolStripButton.SelectedIndexChanged += new EventHandler(changeFont);
            this.fontSizeToolStripButton.SelectedIndexChanged += new EventHandler(changeFont);
            this.italicToolStripButton.Click += new EventHandler(eventToolbarFontStyle);
            this.underlineToolStripButton.Click += new EventHandler(eventToolbarFontStyle);
            this.strikeoutToolStripButton.Click += new EventHandler(eventToolbarFontStyle);
            // Toolbar
            this.newToolStripButton.Click += new EventHandler(newToolStripMenuItem_Click);
            this.openToolStripButton.Click += new EventHandler(openToolStripMenuItem_Click);
            this.saveToolStripButton.Click += new EventHandler(saveToolStripMenuItem_Click);
            this.printToolStripButton.Click += new EventHandler(printToolStripMenuItem_Click);
            this.cutToolStripButton.Click += new EventHandler(cutToolStripMenuItem_Click);
            this.copyToolStripButton.Click += new EventHandler(copyToolStripMenuItem_Click);
            this.pasteToolStripButton.Click += new EventHandler(pasteToolStripMenuItem_Click);
        }

        #region Form

        private void FormNote_Load(object sender, EventArgs e)
        {
            this.richTextBoxText.Clear();
            refreshData("");
        }

        private void FormNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isSafeExit)
                exitToolStripMenuItem_Click(null, null);
        }

        private void eventToolbarFontStyle(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Checked ^= true;
            changeFont(null, null);
        }

        private void richTextBoxText_Click(object sender, EventArgs e)
        {
            Font font = this.richTextBoxText.SelectionFont;
            this.boldToolStripButton.Checked = font.Bold;
            this.italicToolStripButton.Checked = font.Italic;
            this.underlineToolStripButton.Checked = font.Underline;
            this.strikeoutToolStripButton.Checked = font.Strikeout;
            this.fontFamilyToolStripButton.Text = font.Name;
            this.fontSizeToolStripButton.Text = font.Size.ToString();
        }

        #endregion

        #region Function

        public string GetSHA1(string _string)
        {
            SHA1 _sha1 = SHA1.Create();
            byte[] _input = Encoding.ASCII.GetBytes(_string);
            byte[] _hash = _sha1.ComputeHash(_input);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < _hash.Length; i++)
            {
                output.Append(_hash[i].ToString("X2"));
            }
            return output.ToString();
        }

        private void refreshData(string fileName)
        {
            this.sign = GetSHA1(richTextBoxText.Rtf);
            this.pathFile = fileName;
            if (this.pathFile.Equals(""))
                this.Text = "New - Extended Note";
            else
                this.Text = this.pathFile + " - Extended Note";
        }

        private bool isDocumentSaved()
        {
            if (this.sign != GetSHA1(richTextBoxText.Rtf))
            {
                DialogResult result = MessageBox.Show("Perubahan file belum disimpan.\nSimpan file?", "Simpan file", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                {
                    return false;
                }
                else if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
            }
            return true;
        }

        private void openFile(string fileName)
        {
            if (isDocumentSaved())
            {
                if (fileName.ToLower().EndsWith(".rtf"))
                    this.richTextBoxText.LoadFile(fileName);
                else
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        this.richTextBoxText.Text = reader.ReadToEnd();
                    }
                }
                refreshData(fileName);
            }
        }

        private void saveFile(string fileName)
        {
            if (fileName.ToLower().EndsWith(".rtf"))
                this.richTextBoxText.SaveFile(fileName);
            else
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(this.richTextBoxText.Text);
                }
            }
            refreshData(fileName);
        }

        private void changeFont(object sender, EventArgs e)
        {
            float fontSize;
            if (!float.TryParse(fontSizeToolStripButton.Text, out fontSize))
                fontSize = this.richTextBoxText.Font.Size;
            FontStyle fontStyle = richTextBoxText.Font.Style;
            if (boldToolStripButton.Checked)
                fontStyle |= FontStyle.Bold;
            if (italicToolStripButton.Checked)
                fontStyle |= FontStyle.Italic;
            if (underlineToolStripButton.Checked)
                fontStyle |= FontStyle.Underline;
            if (strikeoutToolStripButton.Checked)
                fontStyle |= FontStyle.Strikeout;
            this.richTextBoxText.SelectionFont = new Font(fontFamilyToolStripButton.Text, fontSize, fontStyle);
            this.richTextBoxText.Focus();
        }

        #endregion

        #region File

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isDocumentSaved())
            {
                this.richTextBoxText.Clear();
                refreshData("");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialogNote.FilterIndex = 0;
            this.openFileDialogNote.FileName = "";
            if (this.openFileDialogNote.ShowDialog() == DialogResult.OK)
                openFile(this.openFileDialogNote.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pathFile.Equals(""))
                saveAsToolStripMenuItem_Click(null, null);
            else
                saveFile(this.pathFile);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialogNote.FilterIndex = 0;
            this.saveFileDialogNote.FileName = "";
            if (this.pathFile == "" && this.saveFileDialogNote.ShowDialog() == DialogResult.OK)
                saveFile(this.saveFileDialogNote.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isDocumentSaved())
            {
                this.isSafeExit = true;
                this.Close();
            }
        }

        #endregion

        #region Edit

        private void moreFontOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialogNote.ShowDialog() == DialogResult.OK)
            {
                this.richTextBoxText.SelectionFont = fontDialogNote.Font;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxText.SelectAll();
        }

        #endregion

        #region Print

        int checkPrint;

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pageSetupDialogNote.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialogNote.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialogNote.ShowDialog() == DialogResult.OK)
                this.printDocumentNote.Print();
        }

        private void printDocumentNote_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.checkPrint = 0;
        }

        private void printDocumentNote_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.checkPrint = this.richTextBoxText.Print(this.checkPrint, this.richTextBoxText.TextLength, e);
            if (this.checkPrint < this.richTextBoxText.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        #endregion
    }
}
