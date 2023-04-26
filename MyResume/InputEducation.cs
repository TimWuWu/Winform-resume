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
    public partial class InputEducation : UserControl
    {
        Education inputofeducation;
        public InputEducation()
        {
            InitializeComponent();
            //展示最新的记录
            if (Myresume.Create().MyEducation.Count == 0)
            {
                inputofeducation = new Education();
                this.Controls[0].DataBindings.Add("Text", inputofeducation, "Period");
                this.Controls[1].DataBindings.Add("Text", inputofeducation, "Start");
                this.Controls[2].DataBindings.Add("Text", inputofeducation, "Majoy");
                this.Controls[3].DataBindings.Add("Text", inputofeducation, "SchoolName");
                this.Controls[4].DataBindings.Add("Text", inputofeducation, "Stage");
            }
            else
            {
                inputofeducation = Myresume.Create().MyEducation.Last();
                this.Controls[0].DataBindings.Add("Text", inputofeducation, "Period");
                this.Controls[1].DataBindings.Add("Text", inputofeducation, "Start");
                this.Controls[2].DataBindings.Add("Text", inputofeducation, "Majoy");
                this.Controls[3].DataBindings.Add("Text", inputofeducation, "SchoolName");
                this.Controls[4].DataBindings.Add("Text", inputofeducation, "Stage");
            }
        }
        //删除教育记录
        private void button6_Click(object sender, EventArgs e)
        {
            Myresume myresumeofeducation = Myresume.Create();
            //delete the last one
            //删除前的MyJobs的长度
            if (myresumeofeducation.MyEducation.Count > 0)
            {
                myresumeofeducation.MyEducation.RemoveAt(myresumeofeducation.MyEducation.Count - 1);
                myresumeofeducation.Save();
                MessageBox.Show("删除成功,当前工作经历数量：" + myresumeofeducation.MyEducation.Count.ToString());
                //删除后的MyJobs的长度
                if (myresumeofeducation.MyEducation.Count > 0)
                {
                    this.Controls[0].Text = 
                        myresumeofeducation.MyEducation[myresumeofeducation.MyEducation.Count - 1].Period;
                    this.Controls[1].Text = 
                        myresumeofeducation.MyEducation[myresumeofeducation.MyEducation.Count - 1].Start;
                    this.Controls[2].Text =
                        myresumeofeducation.MyEducation[myresumeofeducation.MyEducation.Count - 1].Majoy;
                    this.Controls[3].Text =
                        myresumeofeducation.MyEducation[myresumeofeducation.MyEducation.Count - 1].SchoolName;
                    this.Controls[4].Text =
                        myresumeofeducation.MyEducation[myresumeofeducation.MyEducation.Count - 1].Stage;
                }
                else
                {
                    this.Controls[0].Text = null;
                    this.Controls[1].Text = null;
                    this.Controls[2].Text = null;
                    this.Controls[3].Text = null;
                    this.Controls[4].Text = null;
                }
            }
            else
            {
                MessageBox.Show("没有记录可以被删除!");
            }
        }

        //添加教育记录
        private void button7_Click(object sender, EventArgs e)
        {
            if (!(inputofeducation is null))
            {
                //从数据固化层获取数据
                Myresume myresumeofeducation = Myresume.Create();
                //将需要添加的数据添加后保存到数据固化层
                myresumeofeducation.MyEducation.Add(inputofeducation);
                myresumeofeducation.Save();
                //通知用户当前被保存的数据数量
                MessageBox.Show("添加成功,当前工作经历数量：" + myresumeofeducation.MyEducation.Count.ToString());
                //清除旧的数据绑定
                this.Controls[0].DataBindings.Clear();
                this.Controls[1].DataBindings.Clear();
                this.Controls[2].DataBindings.Clear();
                this.Controls[3].DataBindings.Clear();
                this.Controls[4].DataBindings.Clear();
                //重新绑定一个新的空的数据源！！！
                inputofeducation = new Education();
                this.Controls[0].DataBindings.Add("Text", inputofeducation, "Period");
                this.Controls[1].DataBindings.Add("Text", inputofeducation, "Start");
                this.Controls[2].DataBindings.Add("Text", inputofeducation, "Majoy");
                this.Controls[3].DataBindings.Add("Text", inputofeducation, "SchoolName");
                this.Controls[4].DataBindings.Add("Text", inputofeducation, "Stage");
            }
            else
            {
                MessageBox.Show("请输入数据");
            }
        }
    }
}
