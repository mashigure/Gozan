namespace Gozan
{
    partial class FormArduinoCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArduinoCode));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBoxUseMacro = new System.Windows.Forms.CheckBox();
            this.radioButtonDec = new System.Windows.Forms.RadioButton();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClipBoard = new System.Windows.Forms.Button();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxUseMacro);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonDec);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonHex);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClipBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCode);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkBoxUseMacro
            // 
            this.checkBoxUseMacro.AutoSize = true;
            this.checkBoxUseMacro.Location = new System.Drawing.Point(357, 8);
            this.checkBoxUseMacro.Name = "checkBoxUseMacro";
            this.checkBoxUseMacro.Size = new System.Drawing.Size(105, 19);
            this.checkBoxUseMacro.TabIndex = 4;
            this.checkBoxUseMacro.Text = "Use RGB2PIXEL";
            this.checkBoxUseMacro.UseVisualStyleBackColor = true;
            this.checkBoxUseMacro.CheckedChanged += new System.EventHandler(this.checkBoxUseMacro_CheckedChanged);
            // 
            // radioButtonDec
            // 
            this.radioButtonDec.AutoSize = true;
            this.radioButtonDec.Location = new System.Drawing.Point(295, 7);
            this.radioButtonDec.Name = "radioButtonDec";
            this.radioButtonDec.Size = new System.Drawing.Size(45, 19);
            this.radioButtonDec.TabIndex = 3;
            this.radioButtonDec.Text = "Dec";
            this.radioButtonDec.UseVisualStyleBackColor = true;
            this.radioButtonDec.CheckedChanged += new System.EventHandler(this.radioButtonDec_CheckedChanged);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Checked = true;
            this.radioButtonHex.Location = new System.Drawing.Point(243, 7);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(46, 19);
            this.radioButtonHex.TabIndex = 2;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            this.radioButtonHex.CheckedChanged += new System.EventHandler(this.radioButtonHex_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClipBoard
            // 
            this.buttonClipBoard.Location = new System.Drawing.Point(84, 3);
            this.buttonClipBoard.Name = "buttonClipBoard";
            this.buttonClipBoard.Size = new System.Drawing.Size(128, 23);
            this.buttonClipBoard.TabIndex = 1;
            this.buttonClipBoard.Text = "Copy to Clip Board";
            this.buttonClipBoard.UseVisualStyleBackColor = true;
            this.buttonClipBoard.Click += new System.EventHandler(this.buttonClipBoard_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.AcceptsTab = true;
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCode.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxCode.Location = new System.Drawing.Point(0, 0);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCode.Size = new System.Drawing.Size(800, 414);
            this.textBoxCode.TabIndex = 0;
            this.textBoxCode.WordWrap = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arduino project|*.ino|すべてのファイル|*.*";
            // 
            // FormArduinoCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArduinoCode";
            this.Text = "Code for Arduino";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonSave;
        private TextBox textBoxCode;
        private SaveFileDialog saveFileDialog1;
        private Button buttonClipBoard;
        private RadioButton radioButtonDec;
        private RadioButton radioButtonHex;
        private CheckBox checkBoxUseMacro;
    }
}