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
    public partial class InputBasicinfo : UserControl
    {       
        Myresume personinfo = Myresume.Create();
        
        public InputBasicinfo()
        {
            InitializeComponent();
            BasicInfo inputbasic = personinfo.MybasicInfo;
            this.Controls[1].DataBindings.Add("Text", inputbasic, "Address");
            this.Controls[2].DataBindings.Add("Text",inputbasic, "Email");
            this.Controls[3].DataBindings.Add("Text", inputbasic, "PhoneNumber");
            this.Controls[4].DataBindings.Add("Text", inputbasic, "Experience");
            this.Controls[5].DataBindings.Add("Text", inputbasic, "Age");
            this.Controls[6].DataBindings.Add("Text", inputbasic, "Name");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            personinfo.Save();
            //MessageBox.Show(this.Parent.Parent.);
            
        }
    }
}
