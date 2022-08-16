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
    public partial class FormSetLEDnum : Form
    {
        private int m_led_num;
        public int led_num
        {
            get { return m_led_num; }
            set { m_led_num = value; }
        }

        public FormSetLEDnum()
        {
            InitializeComponent();
        }

        private void FormSetLEDnum_Shown(object sender, EventArgs e)
        {
            textBoxLEDnum.Text = led_num.ToString();
            textBoxLEDnum.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            setting();
        }

        private void textBoxLEDnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setting();
            }
        }

        private void setting()
        {
            int setting_num;

            if (int.TryParse(textBoxLEDnum.Text, out setting_num))
            {
                if (setting_num <= 0)
                {
                    MessageBox.Show("1以上の数字（整数）を入力しておくれやす", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (setting_num < led_num)
                    {
                        DialogResult result = MessageBox.Show("設定前より少なくなる分、後ろを削除するけどええの？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (DialogResult.OK == result)
                        {
                            led_num = setting_num;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        led_num = setting_num;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("数字（整数）を入力しておくれやす", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
