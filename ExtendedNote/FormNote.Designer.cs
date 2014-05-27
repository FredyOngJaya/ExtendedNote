namespace ExtendedNote
{
    partial class FormNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNote));
            this.menuStripNote = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.toolStripNote = new System.Windows.Forms.ToolStrip();
            this.toolbarFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.toolbarFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbarBold = new System.Windows.Forms.ToolStripButton();
            this.toolbarItalic = new System.Windows.Forms.ToolStripButton();
            this.toolbarUnderline = new System.Windows.Forms.ToolStripButton();
            this.openFileDialogNote = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogNote = new System.Windows.Forms.SaveFileDialog();
            this.menuStripNote.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripNote
            // 
            this.menuStripNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripNote.Location = new System.Drawing.Point(0, 0);
            this.menuStripNote.Name = "menuStripNote";
            this.menuStripNote.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripNote.Size = new System.Drawing.Size(948, 24);
            this.menuStripNote.TabIndex = 2;
            this.menuStripNote.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBoxText);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(948, 360);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(948, 385);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripNote);
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxText.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(948, 360);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            // 
            // toolStripNote
            // 
            this.toolStripNote.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarFontFamily,
            this.toolbarFontSize,
            this.toolStripSeparator1,
            this.toolbarBold,
            this.toolbarItalic,
            this.toolbarUnderline});
            this.toolStripNote.Location = new System.Drawing.Point(3, 0);
            this.toolStripNote.Name = "toolStripNote";
            this.toolStripNote.Size = new System.Drawing.Size(316, 25);
            this.toolStripNote.TabIndex = 0;
            // 
            // toolbarFontFamily
            // 
            this.toolbarFontFamily.Name = "toolbarFontFamily";
            this.toolbarFontFamily.Size = new System.Drawing.Size(150, 25);
            // 
            // toolbarFontSize
            // 
            this.toolbarFontSize.Name = "toolbarFontSize";
            this.toolbarFontSize.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarBold
            // 
            this.toolbarBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolbarBold.Image = ((System.Drawing.Image)(resources.GetObject("toolbarBold.Image")));
            this.toolbarBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarBold.Name = "toolbarBold";
            this.toolbarBold.Size = new System.Drawing.Size(23, 22);
            this.toolbarBold.Text = "B";
            this.toolbarBold.Click += new System.EventHandler(this.eventToolbarFontStyle);
            // 
            // toolbarItalic
            // 
            this.toolbarItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolbarItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolbarItalic.Image")));
            this.toolbarItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarItalic.Name = "toolbarItalic";
            this.toolbarItalic.Size = new System.Drawing.Size(23, 22);
            this.toolbarItalic.Text = "I";
            // 
            // toolbarUnderline
            // 
            this.toolbarUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolbarUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolbarUnderline.Image")));
            this.toolbarUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarUnderline.Name = "toolbarUnderline";
            this.toolbarUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolbarUnderline.Text = "U";
            // 
            // openFileDialogNote
            // 
            this.openFileDialogNote.FileName = "openFileDialog1";
            // 
            // FormNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(948, 409);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStripNote);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNote";
            this.ShowIcon = false;
            this.Text = "Note";
            this.Load += new System.EventHandler(this.FormNote_Load);
            this.menuStripNote.ResumeLayout(false);
            this.menuStripNote.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripNote.ResumeLayout(false);
            this.toolStripNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripNote;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripNote;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogNote;
        private System.Windows.Forms.SaveFileDialog saveFileDialogNote;
        private System.Windows.Forms.ToolStripComboBox toolbarFontFamily;
        private System.Windows.Forms.ToolStripComboBox toolbarFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolbarBold;
        private System.Windows.Forms.ToolStripButton toolbarItalic;
        private System.Windows.Forms.ToolStripButton toolbarUnderline;

    }
}

