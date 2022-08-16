namespace Gozan
{
    partial class FormHowTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHowTo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSVファイルの仕様";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "CSVファイルには、1行にLEDの数分の発光させる色とその点灯時間を記載します。Arduino側ライブラリでは、\r\n一度に1行分を読み込んで点灯させ、指定時間が経" +
    "過すると次の行を読み込むという処理を繰り返し行います。\r\n\r\n１行の要素は、１列目がその行の点灯時間です。\r\n２列目以降がLEDの発光色指定で、LEDが接続され" +
    "ている順番にLEDの数だけ記載します。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "What is Gozan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 120);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(581, 60);
            this.label5.TabIndex = 4;
            this.label5.Text = "１列目がその行の点灯時間、２列目以降がLEDの発光色指定で、LEDが接続されている順番にLEDの数だけ記載します。\r\n時間の単位はミリ秒[ms]\r\n発光色は「#」" +
    "の後ろにRGBを16進数2桁ずつ6文字（#00000000～#FFFFFF）\r\nまたは1桁ずつ3文字（#000～#FFF）で記載してください。";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 46);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "1000,#000000,#FF0000,#00FF00,#0000FF,#FFFFFF\r\n1000,#000,#100,#300,#700,#F00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "例：";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(529, 446);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "OK";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormHowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHowTo";
            this.Text = "How to edit";
            this.Shown += new System.EventHandler(this.FormHowTo_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Button buttonClose;
    }
}