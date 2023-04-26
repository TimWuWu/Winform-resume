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
    public partial class InputJob : UserControl
    {       
        Job inputjob;
        public InputJob()
        {
            InitializeComponent();
            //展示最新的记录
            if (Myresume.Create().MyJobs.Count == 0)
            {
                inputjob= new Job();
                this.Controls[2].DataBindings.Add("Text", inputjob, "Duty");
                this.Controls[3].DataBindings.Add("Text", inputjob, "Output");
                this.Controls[4].DataBindings.Add("Text", inputjob, "Input");
                this.Controls[5].DataBindings.Add("Text", inputjob, "Title");
                this.Controls[6].DataBindings.Add("Text", inputjob, "CompanyName");
            }
            else
            {
                inputjob = Myresume.Create().MyJobs.Last();
                this.Controls[2].DataBindings.Add("Text", inputjob, "Duty");
                this.Controls[3].DataBindings.Add("Text", inputjob, "Output");
                this.Controls[4].DataBindings.Add("Text", inputjob, "Input");
                this.Controls[5].DataBindings.Add("Text", inputjob, "Title");
                this.Controls[6].DataBindings.Add("Text", inputjob, "CompanyName");
            }
            
        }
        //增加一个记录
        private void button7_Click(object sender, EventArgs e)
        {            
            if (!(inputjob is null))
            {
                //从数据固化层获取数据
                Myresume myresumeofjob = Myresume.Create();
                //将需要添加的数据添加后保存到数据固化层
                myresumeofjob.MyJobs.Add(inputjob);
                myresumeofjob.Save(); 
                //通知用户当前被保存的数据数量
                MessageBox.Show("添加成功,当前工作经历数量："+myresumeofjob.MyJobs.Count.ToString());
                //清除旧的数据绑定
                this.Controls[2].DataBindings.Clear();
                this.Controls[3].DataBindings.Clear();
                this.Controls[4].DataBindings.Clear();
                this.Controls[5].DataBindings.Clear();
                this.Controls[6].DataBindings.Clear();
                //重新绑定一个新的空的数据源！！！
                inputjob = new Job();
                this.Controls[2].DataBindings.Add("Text", inputjob, "Duty");
                this.Controls[3].DataBindings.Add("Text", inputjob, "Output");
                this.Controls[4].DataBindings.Add("Text", inputjob, "Input");
                this.Controls[5].DataBindings.Add("Text", inputjob, "Title");
                this.Controls[6].DataBindings.Add("Text", inputjob, "CompanyName");
            }
            else
            {
                MessageBox.Show("请输入数据");
            }           
        }
        //删除一个记录，并显示待删除的那一项
        private void button6_Click(object sender, EventArgs e)
        {
            Myresume myresumeofjob = Myresume.Create();
            //delete the last one
            //删除前的MyJobs的长度
            if (myresumeofjob.MyJobs.Count>0)
            {
                myresumeofjob.MyJobs.RemoveAt(myresumeofjob.MyJobs.Count-1);
                myresumeofjob.Save();
                MessageBox.Show("删除成功,当前工作经历数量：" + myresumeofjob.MyJobs.Count.ToString());
                //删除后的MyJobs的长度
                if (myresumeofjob.MyJobs.Count>0)
                {
                    this.Controls[2].Text = myresumeofjob.MyJobs[myresumeofjob.MyJobs.Count - 1].Duty;
                    this.Controls[3].Text = myresumeofjob.MyJobs[myresumeofjob.MyJobs.Count - 1].Output;
                    this.Controls[4].Text = myresumeofjob.MyJobs[myresumeofjob.MyJobs.Count - 1].Input;
                    this.Controls[5].Text = myresumeofjob.MyJobs[myresumeofjob.MyJobs.Count - 1].Title;
                    this.Controls[6].Text = myresumeofjob.MyJobs[myresumeofjob.MyJobs.Count - 1].CompanyName;
                }
                else
                {
                    this.Controls[2].Text = null;
                    this.Controls[3].Text = null;
                    this.Controls[4].Text = null;
                    this.Controls[5].Text = null;
                    this.Controls[6].Text = null;
                }               
            }
            else
            {
                MessageBox.Show("没有记录可以被删除!");
            }

        }
    }
}
