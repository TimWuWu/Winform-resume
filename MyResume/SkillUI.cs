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
    public partial class SkillUI : UserControl
    {
        //private List<Skill> skills= new List<Skill>();
        int Amount = 0;
        public SkillUI()
        {
            InitializeComponent();
        }
        //从父类control获取数据定制生成自己
        public SkillUI(Skill skill)
        {
            InitializeComponent();
            //UI binding datasource
            this.Controls[0].DataBindings.Add("Text", skill, "ComponentsOne");
            this.Controls[1].DataBindings.Add("Text", skill, "ComponentsTwo");
            this.Controls[2].DataBindings.Add("Text", skill, "ComponentsThree");
            this.Controls[3].DataBindings.Add("Text", skill, "ComponentsFour");
            this.Controls[4].DataBindings.Add("Text", skill, "Topic");


            //判断该如何显示
            if (!(skill.ComponentsOne is null))
            {
                Amount = 1;
                this.button4.Visible = true;
                this.button3.Visible = false;
                this.button2.Visible = false;
                this.button1.Visible = false;
                if (!(skill.ComponentsTwo is null))
                {
                    Amount = 2;
                    this.button3.Visible = true;
                    if (!(skill.ComponentsThree is null))
                    {
                        Amount = 3;
                        this.button2.Visible = true;
                        if (!(skill.ComponentsFour is null))
                        {
                            Amount = 4;
                            this.button1.Visible = true;
                        }
                    }
                }
            }
        }

        private void SkillUI_Paint(object sender, PaintEventArgs e)
        {
            int x = this.Width;
            int y = this.Height;
            int bottonX = this.button1.Width;
            int bottonY = this.button1.Height;
                                 
            Graphics skillUI= e.Graphics;
            Pen skillUIpen = new Pen(Color.Brown, 2);
            Point start = new Point(x/2, y/2);
            Point endone = new Point(bottonX / 2, bottonY + 3);
            Point endtwo = new Point(x - bottonX / 2, bottonY + 3);
            Point endthree = new Point(bottonX / 2, y - bottonY - 3);
            Point endfour = new Point(x - bottonX / 2, y - bottonY - 3);
            //根据按钮的可见性进行连线操作
            switch (Amount)
            {
                case 1:
                    skillUI.DrawLine(skillUIpen, start, endone);
                    break;
                case 2:
                    Point[] pointsfortwo = new Point[] { start, endone, start, endtwo};
                    skillUI.DrawLines(skillUIpen, pointsfortwo);
                    break;
                case 3:
                    Point[] pointsforthree = new Point[] { start, endone, start, endtwo,start,endthree };
                    skillUI.DrawLines(skillUIpen, pointsforthree);
                    break;
                case 4:
                    Point[] pointsforfour = new Point[] { start, endone, start, endtwo, start, endthree,start,endfour };
                    skillUI.DrawLines(skillUIpen, pointsforfour);
                    break;
            }          
        }
  
    }
}
