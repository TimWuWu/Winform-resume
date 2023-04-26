using MyResume.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyResume
{
    public partial class BasicPersonInfo : UserControl
    {
        public BasicPersonInfo()
        {
            InitializeComponent();
        }

        private void BasicPersonInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            
        }

        private void BasicPersonInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
