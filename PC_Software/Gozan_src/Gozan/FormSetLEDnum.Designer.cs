namespace Gozan
{
    partial class FormSetLEDnum
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxLEDnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(184, 35);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxLEDnum
            // 
            this.textBoxLEDnum.Location = new System.Drawing.Point(103, 6);
            this.textBoxLEDnum.Name = "textBoxLEDnum";
            this.textBoxLEDnum.Size = new System.Drawing.Size(65, 23);
            this.textBoxLEDnum.TabIndex = 2;
            this.textBoxLEDnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLEDnum_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "number of LED";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(184, 6);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "SET";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // FormSetLEDnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 66);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLEDnum);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSetLEDnum";
            this.Text = "LED number setting";
            this.Shown += new System.EventHandler(this.FormSetLEDnum_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonCancel;
        private TextBox textBoxLEDnum;
        private Label label1;
        private Button buttonSet;
    }
}