namespace Gozan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsACSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToArduinoCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLEDNumberLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGozanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxShowTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_LEDnum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLEDnumber = new System.Windows.Forms.Label();
            this.CSVtextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "pattern_file.csv";
            this.openFileDialog1.Filter = "CSV|*.csv|すべてのファイル|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV|*.csv";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.convertCToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openCSVToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsACSVToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeXToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(&F)";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.newFileToolStripMenuItem.Text = "New File(&N)";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openCSVToolStripMenuItem
            // 
            this.openCSVToolStripMenuItem.Name = "openCSVToolStripMenuItem";
            this.openCSVToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openCSVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openCSVToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.openCSVToolStripMenuItem.Text = "Open CSV(&O)";
            this.openCSVToolStripMenuItem.Click += new System.EventHandler(this.openCSVToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveToolStripMenuItem.Text = "Save(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsACSVToolStripMenuItem
            // 
            this.saveAsACSVToolStripMenuItem.Name = "saveAsACSVToolStripMenuItem";
            this.saveAsACSVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsACSVToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveAsACSVToolStripMenuItem.Text = "Save as a new CSV(&A)";
            this.saveAsACSVToolStripMenuItem.Click += new System.EventHandler(this.saveAsACSVToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // closeXToolStripMenuItem
            // 
            this.closeXToolStripMenuItem.Name = "closeXToolStripMenuItem";
            this.closeXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeXToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.closeXToolStripMenuItem.Text = "Close(&X)";
            this.closeXToolStripMenuItem.Click += new System.EventHandler(this.closeXToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLineToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewLineToolStripMenuItem
            // 
            this.addNewLineToolStripMenuItem.Name = "addNewLineToolStripMenuItem";
            this.addNewLineToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addNewLineToolStripMenuItem.Text = "Add new line";
            this.addNewLineToolStripMenuItem.Click += new System.EventHandler(this.addNewLineToolStripMenuItem_Click);
            // 
            // convertCToolStripMenuItem
            // 
            this.convertCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToArduinoCodeToolStripMenuItem,
            this.setLEDNumberLengthToolStripMenuItem});
            this.convertCToolStripMenuItem.Name = "convertCToolStripMenuItem";
            this.convertCToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.convertCToolStripMenuItem.Text = "Convert(&C)";
            // 
            // convertToArduinoCodeToolStripMenuItem
            // 
            this.convertToArduinoCodeToolStripMenuItem.Name = "convertToArduinoCodeToolStripMenuItem";
            this.convertToArduinoCodeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.convertToArduinoCodeToolStripMenuItem.Text = "Create Code for Arduino";
            this.convertToArduinoCodeToolStripMenuItem.Click += new System.EventHandler(this.convertToArduinoCodeToolStripMenuItem_Click);
            // 
            // setLEDNumberLengthToolStripMenuItem
            // 
            this.setLEDNumberLengthToolStripMenuItem.Name = "setLEDNumberLengthToolStripMenuItem";
            this.setLEDNumberLengthToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.setLEDNumberLengthToolStripMenuItem.Text = "Change LED number";
            this.setLEDNumberLengthToolStripMenuItem.Click += new System.EventHandler(this.setLEDNumberLengthToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToEditToolStripMenuItem,
            this.aboutGozanToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // howToEditToolStripMenuItem
            // 
            this.howToEditToolStripMenuItem.Name = "howToEditToolStripMenuItem";
            this.howToEditToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.howToEditToolStripMenuItem.Text = "How to edit";
            this.howToEditToolStripMenuItem.Click += new System.EventHandler(this.howToEditToolStripMenuItem_Click);
            // 
            // aboutGozanToolStripMenuItem
            // 
            this.aboutGozanToolStripMenuItem.Name = "aboutGozanToolStripMenuItem";
            this.aboutGozanToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutGozanToolStripMenuItem.Text = "about Gozan";
            this.aboutGozanToolStripMenuItem.Click += new System.EventHandler(this.aboutGozanToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button_LEDnum);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelLEDnumber);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CSVtextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 837);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxShowTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "one shot of illumination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ms";
            // 
            // textBoxShowTime
            // 
            this.textBoxShowTime.Location = new System.Drawing.Point(226, 22);
            this.textBoxShowTime.Name = "textBoxShowTime";
            this.textBoxShowTime.Size = new System.Drawing.Size(80, 23);
            this.textBoxShowTime.TabIndex = 6;
            this.textBoxShowTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxShowTime.TextChanged += new System.EventHandler(this.textBoxShowTime_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "show time:";
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Location = new System.Drawing.Point(53, 22);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(82, 23);
            this.comboBoxLine.TabIndex = 3;
            this.comboBoxLine.DropDown += new System.EventHandler(this.comboBoxLine_DropDown);
            this.comboBoxLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxLine_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Line:";
            // 
            // button_LEDnum
            // 
            this.button_LEDnum.Location = new System.Drawing.Point(168, 6);
            this.button_LEDnum.Name = "button_LEDnum";
            this.button_LEDnum.Size = new System.Drawing.Size(128, 23);
            this.button_LEDnum.TabIndex = 2;
            this.button_LEDnum.Text = "check LED number";
            this.button_LEDnum.UseVisualStyleBackColor = true;
            this.button_LEDnum.Click += new System.EventHandler(this.button_LEDnum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of LEDs:";
            // 
            // labelLEDnumber
            // 
            this.labelLEDnumber.AutoSize = true;
            this.labelLEDnumber.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLEDnumber.Location = new System.Drawing.Point(113, 5);
            this.labelLEDnumber.Name = "labelLEDnumber";
            this.labelLEDnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLEDnumber.Size = new System.Drawing.Size(19, 21);
            this.labelLEDnumber.TabIndex = 0;
            this.labelLEDnumber.Text = "0";
            // 
            // CSVtextBox
            // 
            this.CSVtextBox.AllowDrop = true;
            this.CSVtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CSVtextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CSVtextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CSVtextBox.Location = new System.Drawing.Point(0, 0);
            this.CSVtextBox.Multiline = true;
            this.CSVtextBox.Name = "CSVtextBox";
            this.CSVtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CSVtextBox.Size = new System.Drawing.Size(1184, 733);
            this.CSVtextBox.TabIndex = 0;
            this.CSVtextBox.WordWrap = false;
            this.CSVtextBox.TextChanged += new System.EventHandler(this.CSVtextBox_TextChanged);
            this.CSVtextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.CSVtextBox_DragDrop);
            this.CSVtextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.CSVtextBox_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gozan - LED Illumination Development Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openCSVToolStripMenuItem;
        private ToolStripMenuItem saveAsACSVToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeXToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem convertCToolStripMenuItem;
        private ToolStripMenuItem convertToArduinoCodeToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TextBox CSVtextBox;
        private ToolStripMenuItem helpHToolStripMenuItem;
        private ToolStripMenuItem aboutGozanToolStripMenuItem;
        private Label label1;
        private Label labelLEDnumber;
        private Button button_LEDnum;
        private ToolStripMenuItem setLEDNumberLengthToolStripMenuItem;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNewLineToolStripMenuItem;
        private Label label2;
        private ComboBox comboBoxLine;
        private GroupBox groupBox1;
        private TextBox textBoxShowTime;
        private Label label3;
        private Label label4;
        private ToolStripMenuItem howToEditToolStripMenuItem;
    }
}