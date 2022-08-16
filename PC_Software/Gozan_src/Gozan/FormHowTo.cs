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
    public partial class FormHowTo : Form
    {
        public FormHowTo()
        {
            InitializeComponent();
        }

        private void FormHowTo_Shown(object sender, EventArgs e)
        {
            this.buttonClose.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
