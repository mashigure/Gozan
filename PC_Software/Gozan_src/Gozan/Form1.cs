namespace Gozan
{
    public partial class Form1 : Form
    {
        private string FilePath = "";
        private string SoftwareName = "";

        public Form1()
        {
            InitializeComponent();
            SoftwareName = this.Text;
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text.Substring(0, 1) == "*")
            {
                string MessageTitle = FilePath.Split("\\")[FilePath.Split("\\").Length - 1];
                if (MessageTitle == "")
                {
                    MessageTitle = SoftwareName;
                }

                DialogResult result = MessageBox.Show("保存してへんけど変更破棄してええの？", MessageTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK != result)
                {
                    return;
                }
            }

            CSVtextBox.Text = "";
            this.FilePath = "";
            this.Text = SoftwareName;
            comboBoxLine.Text = "";
            CheckLEDnumber();
            setLEDNumber();
        }

        private void openCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 開く
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                OpenFile(openFileDialog1.FileName);
            }
        }

        private void CSVtextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CSVtextBox_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.Data != null) && (e.Data.GetDataPresent(DataFormats.FileDrop)))
            {
                // ドラッグ中のファイルやディレクトリの取得
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (System.IO.File.Exists(files[0]))
                {
                    OpenFile(files[0]);
                }
            }
        }

        private void OpenFile(string file_name)
        {
            if (this.Text.Substring(0, 1) == "*")
            {
                string MessageTitle = FilePath.Split("\\")[FilePath.Split("\\").Length - 1];
                if (MessageTitle == "")
                {
                    MessageTitle = SoftwareName;
                }

                DialogResult result = MessageBox.Show("保存してへんけど新しく開いてええの？", MessageTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK != result)
                {
                    return;
                }
            }

            LoadCSVFile(file_name);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FilePath == "")
            {
                // 上書くファイルが無いので名前を付けて保存させる
                if (DialogResult.OK == saveFileDialog1.ShowDialog())
                {
                    SaveCSVFile(saveFileDialog1.FileName);
                }
            }
            else
            {
                if (this.Text.Substring(0, 1) == "*")
                {
                    // 上書き保存
                    SaveCSVFile(this.FilePath);
                }
            }
        }

        private void saveAsACSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 名前を付けて保存
            saveFileDialog1.FileName = System.IO.Path.GetFileName(this.FilePath);

            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                SaveCSVFile(saveFileDialog1.FileName);
            }
        }

        private void CheckLEDnumber()
        {
            labelLEDnumber.Text = (CSVtextBox.Text.Split("\n")[0].Split(",").Length - 1).ToString();
        }


        private void LoadCSVFile(string value)
        {
            CSVtextBox.Text = File.ReadAllText(value);
            UpdateFileName(value);
            CheckLEDnumber();
            comboBoxLine.Text = "";
        }


        private void SaveCSVFile(string value)
        {
            System.IO.File.WriteAllText(value, CSVtextBox.Text);
            UpdateFileName(value);
        }


        private void UpdateFileName(string value)
        {
            this.FilePath = value;
            string FileName = value.Split("\\")[value.Split("\\").Length - 1];
            this.Text = FileName + " - " + SoftwareName;
        }

        private void closeXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CSVtextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Substring(0, 1) != "*")
            {
                this.Text = "*" + this.Text;
            }
        }

        private void convertToArduinoCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArduinoCode formCode = new FormArduinoCode();
            string data_label = "data0";
            string FileName = this.FilePath.Split("\\")[this.FilePath.Split("\\").Length - 1];
            if (FileName != "")
            {
                data_label = FileName.Split(".")[0];
            }

            formCode.setInoCode(labelLEDnumber.Text, data_label);
            formCode.setDataCode(labelLEDnumber.Text, data_label, CSVtextBox.Text);
            formCode.ShowDialog();
        }

        private void setLEDNumberLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLEDNumber();
        }

        private void setLEDNumber()
        {
            CheckLEDnumber();

            int current_lednum = int.Parse(labelLEDnumber.Text);
            FormSetLEDnum formLED = new FormSetLEDnum();

            formLED.led_num = current_lednum;

            DialogResult result = formLED.ShowDialog();
            if (DialogResult.OK == result)
            {
                if (formLED.led_num < current_lednum)
                {
                    // LED数削減
                    string[] csv_data = CSVtextBox.Text.Split("\r\n");
                    CSVtextBox.Text = "";

                    for (int i = 0; i < csv_data.Length; i++)
                    {
                        string[] onshot_data = csv_data[i].Split(",");
                        if (formLED.led_num <= onshot_data.Length)
                        {
                            for (int j = 0; j < formLED.led_num; j++)
                            {
                                CSVtextBox.Text += onshot_data[j];
                                CSVtextBox.Text += ",";
                            }
                            CSVtextBox.Text += onshot_data[formLED.led_num] + "\r\n";
                        }
                    }
                }
                else if (current_lednum < formLED.led_num)
                {
                    // LED数増加
                    string[] csv_data = CSVtextBox.Text.Split("\r\n");
                    CSVtextBox.Text = "";

                    for (int i = 0; i < csv_data.Length; i++)
                    {
                        CSVtextBox.Text += csv_data[i];

                        for (int j = 0; j < (formLED.led_num - current_lednum); j++)
                        {
                            CSVtextBox.Text += ",";
                        }

                        CSVtextBox.Text += "\r\n";
                    }
                }
                else
                {
                    // LED数据え置き（nothing to do）
                }

                CheckLEDnumber();
            }
        }

        private void howToEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHowTo formHowTo = new FormHowTo();
            formHowTo.Show();
        }

        private void aboutGozanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformation formInfo = new FormInformation();
            formInfo.ShowDialog();
        }

        private void button_LEDnum_Click(object sender, EventArgs e)
        {
            CheckLEDnumber();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Text.Substring(0, 1) == "*")
            {
                string MessageTitle = FilePath.Split("\\")[FilePath.Split("\\").Length - 1];
                if (MessageTitle == "")
                {
                    MessageTitle = SoftwareName;
                }

                DialogResult result = MessageBox.Show("保存してへんけど閉じてええの？", MessageTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK != result)
                {
                    e.Cancel = true;
                }
            }
        }

        private void addNewLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((0 < CSVtextBox.Text.Length) && (CSVtextBox.Text.ToCharArray()[CSVtextBox.Text.Length - 1] != '\n'))
            {
                CSVtextBox.Text += "\r\n";
            }

            for (int i = 0; i < int.Parse(labelLEDnumber.Text); i++)
            {
                CSVtextBox.Text += ",";
            }

            CSVtextBox.Text += "\r\n";
        }

        private void comboBoxLine_DropDown(object sender, EventArgs e)
        {
            comboBoxLine.Items.Clear();
            int line_num = CSVtextBox.Text.Count(f => f == '\n');

            for (int i = 0; i < line_num; i++)
            {
                comboBoxLine.Items.Add(i.ToString());
            }
        }

        private void comboBoxLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_line;
            if (int.TryParse(comboBoxLine.Text, out selected_line))
            {
                textBoxShowTime.Text = getShowTime(selected_line);
            }
        }

        private void textBoxShowTime_TextChanged(object sender, EventArgs e)
        {
            int selected_line;
            if (int.TryParse(comboBoxLine.Text, out selected_line))
            {
                setShowTime(selected_line, textBoxShowTime.Text);
            }
        }

        private string getShowTime(int line)
        {
            string[] lines = CSVtextBox.Text.Split("\r\n");

            if (lines.Length < line)
            {
                return "";
            }

            return lines[line].Split(",")[0];
        }

        private void setShowTime(int line, string show_time)
        {
            string[] lines = CSVtextBox.Text.Split("\r\n");

            if (lines.Length < line)
            {
                return;
            }

            int pos = 0;
            for (int i = 0; i < line; i++)
            {
                pos += lines[i].Length + 2;
            }

            String current_showtime = lines[line].Split(",")[0];

            if (current_showtime != show_time)
            {
                CSVtextBox.Text = CSVtextBox.Text.Substring(0, pos) + show_time + CSVtextBox.Text.Substring(pos + current_showtime.Length);
            }
        }
    }
}
