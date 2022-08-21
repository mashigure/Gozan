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
        private string led_num;
        private string seq_num;
        private string data_name;
        private string csv_data;

        public FormArduinoCode()
        {
            led_num = "1";
            seq_num = "0";
            data_name = "";
            csv_data = "";
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

                System.IO.File.WriteAllText(ino_file, textBoxCode.Text);
            }
        }

        private void buttonClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCode.Text);
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            writeSampleCode();
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            writeSampleCode();
        }

        private void checkBoxUseMacro_CheckedChanged(object sender, EventArgs e)
        {
            writeSampleCode();
        }

        public void setCode(string led_num, string data_var_name, string csv_data)
        {
            this.led_num   = led_num;
            this.seq_num   = getNumSequence(csv_data).ToString();
            this.data_name = data_var_name;
            this.csv_data  = csv_data;

            writeSampleCode();
        }

        private void writeSampleCode()
        {
            string data_part = getDataString(csv_data);

            textBoxCode.Text =
                "#include <SerialLED_Array.h>\r\n" +
                "\r\n" +
                "#define NEOPIXEL_NUM   (" + led_num + ")\r\n" +
                "#define NEOPIXEL_PIN   (6)    // please rewrite for your hardware.\r\n" +
                "#define DATA01_SEQ_NUM (" + seq_num + ")\r\n" +
                "\r\n" +
                "SerialLED_Array pixel(NEOPIXEL_NUM, NEOPIXEL_PIN);\r\n" +
                "\r\n" +
                "const uint32_t data01[NEOPIXEL_NUM * DATA01_SEQ_NUM] = {\r\n" +
                data_part+
                "};\r\n" +
                "\r\n" +
                "void setup()\r\n" +
                "{\r\n" +
                "    pixel.begin();\r\n" +
                "    pixel.autoPlay(data01, DATA01_SEQ_NUM, 100, true);\r\n" +
                "}\r\n" +
                "\r\n" +
                "void loop()\r\n" +
                "{\r\n" +
                "    pixel.update();\r\n" +
                "}\r\n";
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

        private string getDataString(string csv_data)
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

                pixels += "    " + getOneShotDataString(csv_data.Split("\r\n")[i]);
            }

            pixels += "\r\n";
            return pixels;
        }

        private string getOneShotDataString(string csv_one_line)
        {
            string pixels = "";

            for (int i = 0; i < csv_one_line.Split(",").Length; i++)
            {
                if (i != 0)
                {
                    pixels += ", ";
                }

                pixels += getOnePixelString(csv_one_line.Split(",")[i]);
            }

            return pixels;
        }

        private string getOnePixelString(string csv_one_data)
        {
            string red;
            string green;
            string blue;

            if (csv_one_data.Length <= 0)
            {
                return "";
            }

            if (csv_one_data.ToCharArray()[0] == '#')
            {
                if (csv_one_data.Length == 7)
                {
                    red   = csv_one_data.ToCharArray()[1].ToString() + csv_one_data.ToCharArray()[2].ToString();
                    green = csv_one_data.ToCharArray()[3].ToString() + csv_one_data.ToCharArray()[4].ToString();
                    blue  = csv_one_data.ToCharArray()[5].ToString() + csv_one_data.ToCharArray()[6].ToString();
                }
                else if (csv_one_data.Length == 4)
                {
                    red   = csv_one_data.ToCharArray()[1].ToString();
                    green = csv_one_data.ToCharArray()[2].ToString();
                    blue  = csv_one_data.ToCharArray()[3].ToString();
                }
                else
                {
                    return csv_one_data;
                }
            }
            else if ((csv_one_data.ToCharArray()[0] == '0') && (csv_one_data.ToCharArray()[1] == 'x'))
            {
                if (csv_one_data.Length == 8)
                {
                    red   = csv_one_data.ToCharArray()[2].ToString() + csv_one_data.ToCharArray()[3].ToString();
                    green = csv_one_data.ToCharArray()[4].ToString() + csv_one_data.ToCharArray()[5].ToString();
                    blue  = csv_one_data.ToCharArray()[6].ToString() + csv_one_data.ToCharArray()[7].ToString();
                }
                else if (csv_one_data.Length == 5)
                {
                    red   = csv_one_data.ToCharArray()[2].ToString();
                    green = csv_one_data.ToCharArray()[3].ToString();
                    blue  = csv_one_data.ToCharArray()[4].ToString();
                }
                else
                {
                    return csv_one_data;
                }
            }
            else
            {
                return csv_one_data;
            }

            string pixel;

            if (checkBoxUseMacro.Checked)
            {

                pixel = getOnePixelString_usingRGB2PIXEL(red, green, blue);
            }
            else
            {
                pixel = getOnePixelString_withoutRGB2PIXEL(red, green, blue);
            }

            return pixel;
        }

        private string getOnePixelString_usingRGB2PIXEL(string red, string green, string blue)
        {
            string pixel = "RGB2PIXEL(";

            if (radioButtonDec.Checked)
            {
                pixel += calcHexToDec(red).ToString()   + ", ";
                pixel += calcHexToDec(green).ToString() + ", ";
                pixel += calcHexToDec(blue).ToString()  + ")";
            }
            else
            {
                pixel += "0x" + red   + ", ";
                pixel += "0x" + green + ", ";
                pixel += "0x" + blue  + ")";
            }

            return pixel;
        }

        private string getOnePixelString_withoutRGB2PIXEL(string red, string green, string blue)
        {
            string pixel = "";
            UInt32 val_r;
            UInt32 val_g;
            UInt32 val_b;
            UInt32 value;

            val_r = calcHexToDec(red);
            val_g = calcHexToDec(green);
            val_b = calcHexToDec(blue);

            value = (((val_r) << 16) | ((val_g) << 8) | (val_b));

            if (radioButtonDec.Checked)
            {
                pixel = value.ToString();
            }
            else
            {
                pixel = "0x" + value.ToString("X6");
            }

            return pixel;
        }

        private UInt32 calcHexToDec(string hex)
        {
            UInt32 dec = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                char value = hex.ToCharArray()[i];

                dec *= 16;
                if (('0' <= value) && (value <= '9'))
                {
                    dec += (UInt32)(value - '0');
                }
                else if (('a' <= value) && (value <= 'f'))
                {
                    dec += (UInt32)(value - 'a') + 10;
                }
                else if (('A' <= value) && (value <= 'F'))
                {
                    dec += (UInt32)(value - 'A') + 10;
                }
                else
                {
                    /* invalid char */
                    return 0;
                }
            }

            return dec;
        }
    }
}
