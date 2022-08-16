using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gozan
{
    public partial class FormArduinoCode : Form
    {

        public FormArduinoCode()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 名前を付けて保存
            if (DialogResult.OK == saveFileDialog1.ShowDialog())
            {
                string[] split_path = saveFileDialog1.FileName.Split("\\");

                int filename_length = split_path[split_path.Length - 1].Length;
                string path = saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.Length - filename_length);

                // 拡張子を削除したものをプロジェクト名とする
                string project_name = split_path[split_path.Length - 1];
                if (project_name.Substring(project_name.Length - 4) == ".ino")
                {
                    project_name = project_name.Substring(0, project_name.Length - 4);
                }

                // ファイルを置こうとしている直下のフォルダ名がプロジェクト名と異なる場合は、そこに放りこむ
                if (split_path[split_path.Length - 2] != project_name)
                {
                    Directory.CreateDirectory(path + project_name);
                    System.IO.Directory.SetCreationTime(path + project_name, DateTime.Now);
                    System.IO.Directory.SetLastWriteTime(path + project_name, DateTime.Now);
                    System.IO.Directory.SetLastAccessTime(path + project_name, DateTime.Now);
                    path += project_name;
                }

                string ino_file = path + "\\" + project_name + ".ino";
                string dat_file = path + "\\" + tabPage2.Text;

                System.IO.File.WriteAllText(ino_file, textBox1.Text);
                System.IO.File.WriteAllText(dat_file, textBox2.Text);
            }

        }

        public void setInoCode(string led_num, string data_var_name)
        {
            textBox1.Text =
                "#include <Gozan.h>\r\n" +
                "\r\n" +
                "#define NEOPIXEL_NUM (" + led_num + ")\r\n" +
                "#define NEOPIXEL_PIN (6)    // please rewrite for your hardware.\r\n" +
                "\r\n" +
                "extern PatternData " + data_var_name + ";\r\n" +
                "\r\n" +
                "Gozan pixels(NEOPIXEL_NUM, NEOPIXEL_PIN);\r\n" +
                "\r\n" +
                "void setup()\r\n" +
                "{\r\n" +
                "    pixels.begin();\r\n" +
                "    pixels.setPattern(&" + data_var_name + ");\r\n" +
                "}\r\n" +
                "\r\n" +
                "void loop()\r\n" +
                "{\r\n" +
                "    pixels.update();\r\n" +
                "}\r\n";

        }

        public void setDataCode(string led_num, string data_var_name, string csv_data)
        {
            UInt32 seq_num = getNumSequence(csv_data);

            tabPage2.Text = data_var_name + ".cpp";

            textBox2.Text =
                "#include <Gozan.h>\r\n" +
                "\r\n" +
                "#define SEQUENCE_NUM (" + seq_num.ToString() + ")\r\n" +
                "#define PIXELS_NUM   (" + led_num.ToString() + ")\r\n" +
                "\r\n" +
                "const int32_t show_time[" + "] = { " + getShowTimesString(csv_data) + " };\r\n" +
                "\r\n" +
                "const uint32_t pixels[SEQUENCE_NUM][SEQUENCE_NUM] = {\r\n";

            textBox2.Text += getPixelsString(csv_data);

            textBox2.Text +=
                "};\r\n" +
                "\r\n" +
                "const Pixel sequence[SEQUENCE_NUM] = {\r\n    ";

            for (int i=0; i< seq_num; i++)
            {
                if (i != 0)
                {
                    textBox2.Text += ", ";
                }
                textBox2.Text += "pixels[" + i.ToString() + "]";
            }

            textBox2.Text +=
                "\r\n" +
                "};\r\n" +
                "\r\n" +
                "PatternData " + data_var_name + " = {\r\n" +
                "    SEQUENCE_NUM,\r\n" +
                "    PIXELS_NUM,\r\n" +
                "    show_time,\r\n" +
                "    sequence\r\n" +
                "};\r\n";
        }

        private UInt32 getNumSequence(string csv_data)
        {
            UInt32 num = 0;

            for (int i=0; i <  csv_data.Split("\n").Length; i++)
            {
                // count valid lines
                if (1 < csv_data.Split("\n")[i].Split(",").Length)
                {
                    num++;
                }
            }

            return num;
        }

        private string getShowTimesString(string csv_data)
        {
            string show_times = "";

            for (int i = 0; i < csv_data.Split("\r\n").Length; i++)
            {
                if (csv_data.Split("\r\n")[i].Split(",").Length <= 1)
                {
                    // invalid line (after last line?)
                    break;
                }

                if (i != 0)
                {
                    show_times += ", ";
                }

                show_times += csv_data.Split("\r\n")[i].Split(",")[0];
            }

            return show_times;
        }

        private string getPixelsString(string csv_data)
        {
            string pixels = "";

            for (int i = 0; i < csv_data.Split("\r\n").Length; i++)
            {
                if (csv_data.Split("\r\n")[i].Split(",").Length <= 1)
                {
                    // invalid line (after last line?)
                    break;
                }

                if (i != 0)
                {
                    pixels += ",\r\n";
                }

                pixels += getOneShotPixelsString(csv_data.Split("\r\n")[i]);
            }

            pixels += "\r\n";
            return pixels;
        }

        private string getOneShotPixelsString(string csv_one_line)
        {
            string pixels = "    { ";

            for (int i = 1; i < csv_one_line.Split(",").Length; i++)
            {
                if (i != 1)
                {
                    pixels += ", ";
                }

                pixels += getOnePixelString(csv_one_line.Split(",")[i]);
            }

            pixels += "}";

            return pixels;
        }

        private string getOnePixelString(string csv_one_data)
        {
            if ((csv_one_data.Length <= 0) || (csv_one_data.ToCharArray()[0] != '#'))
            {
                return "";
            }

            string pixel = "RGB2PIXEL(";

            if (csv_one_data.Length == 7)
            {
                pixel += "0x" + csv_one_data.ToCharArray()[1].ToString() + csv_one_data.ToCharArray()[2].ToString() + ", ";
                pixel += "0x" + csv_one_data.ToCharArray()[3].ToString() + csv_one_data.ToCharArray()[4].ToString() + ", ";
                pixel += "0x" + csv_one_data.ToCharArray()[5].ToString() + csv_one_data.ToCharArray()[6].ToString() + ")";
            }
            else if (csv_one_data.Length == 4)
            {
                pixel += "0x" + csv_one_data.ToCharArray()[1].ToString() + ", ";
                pixel += "0x" + csv_one_data.ToCharArray()[2].ToString() + ", ";
                pixel += "0x" + csv_one_data.ToCharArray()[3].ToString() + ")";
            }
            else
            {
                return "";
            }

            return pixel;
        }

        private void buttonClipBoard_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Clipboard.SetText(textBox1.Text);
            }
            else
            {
                Clipboard.SetText(textBox2.Text);
            }
        }
    }
}
