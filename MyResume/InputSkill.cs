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
    public partial class InputSkill : UserControl
    {
        Skill inputskill;
        public InputSkill()
        {
            InitializeComponent();
            //展示最新的记录
            if (Myresume.Create().MySkill.Count == 0)
            {
                inputskill = new Skill();
                this.Controls[2].DataBindings.Add("Text", inputskill, "ComponentsFour");
                this.Controls[3].DataBindings.Add("Text", inputskill, "ComponentsThree");
                this.Controls[4].DataBindings.Add("Text", inputskill, "ComponentsTwo");
                this.Controls[5].DataBindings.Add("Text", inputskill, "ComponentsOne");
                this.Controls[6].DataBindings.Add("Text", inputskill, "Topic");
            }
            else
            {
                inputskill = Myresume.Create().MySkill.Last();
                this.Controls[2].DataBindings.Add("Text", inputskill, "ComponentsFour");
                this.Controls[3].DataBindings.Add("Text", inputskill, "ComponentsThree");
                this.Controls[4].DataBindings.Add("Text", inputskill, "ComponentsTwo");
                this.Controls[5].DataBindings.Add("Text", inputskill, "ComponentsOne");
                this.Controls[6].DataBindings.Add("Text", inputskill, "Topic");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Myresume myresumeofskill = Myresume.Create();
            //delete the last one
            //删除前的MySkill的长度
            if (myresumeofskill.MySkill.Count > 0)
            {
                myresumeofskill.MySkill.RemoveAt(myresumeofskill.MySkill.Count - 1);
                myresumeofskill.Save();
                MessageBox.Show("删除成功,当前工作经历数量：" + myresumeofskill.MySkill.Count.ToString());
                //删除后的MySkill的长度
                if (myresumeofskill.MySkill.Count > 0)
                {
                    this.Controls[2].Text = myresumeofskill.MySkill[myresumeofskill.MySkill.Count - 1].ComponentsFour;
                    this.Controls[3].Text = myresumeofskill.MySkill[myresumeofskill.MySkill.Count - 1].ComponentsThree;
                    this.Controls[4].Text = myresumeofskill.MySkill[myresumeofskill.MySkill.Count - 1].ComponentsTwo;
                    this.Controls[5].Text = myresumeofskill.MySkill[myresumeofskill.MySkill.Count - 1].ComponentsOne;
                    this.Controls[6].Text = myresumeofskill.MySkill[myresumeofskill.MySkill.Count - 1].Topic;
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(inputskill is null))
            {
                //从数据固化层获取数据
                Myresume myresumeofskill = Myresume.Create();
                //将需要添加的数据添加后保存到数据固化层
                myresumeofskill.MySkill.Add(inputskill);
                myresumeofskill.Save();
                //通知用户当前被保存的数据数量
                MessageBox.Show("添加成功,当前工作经历数量：" + myresumeofskill.MySkill.Count.ToString());
                //清除旧的数据绑定
                this.Controls[2].DataBindings.Clear();
                this.Controls[3].DataBindings.Clear();
                this.Controls[4].DataBindings.Clear();
                this.Controls[5].DataBindings.Clear();
                this.Controls[6].DataBindings.Clear();
                //重新绑定一个新的空的数据源！！！
                inputskill = new Skill();
                this.Controls[2].DataBindings.Add("Text", inputskill, "ComponentsFour");
                this.Controls[3].DataBindings.Add("Text", inputskill, "ComponentsThree");
                this.Controls[4].DataBindings.Add("Text", inputskill, "ComponentsTwo");
                this.Controls[5].DataBindings.Add("Text", inputskill, "ComponentsOne");
                this.Controls[6].DataBindings.Add("Text", inputskill, "Topic");
            }
            else
            {
                MessageBox.Show("请输入数据");
            }
        }
    }
}
