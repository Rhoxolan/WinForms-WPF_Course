using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2022._04._29
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public bool WMPEnabled()
        {
            if(MP3_Button.Checked)
            {
                return true;
            }
            return false;
        }
    }
}
