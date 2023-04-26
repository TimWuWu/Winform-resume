using MyResume.Functions;
using MyResume.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace MyResume
{
    public partial class DemonstrateForm : Form
    {
        //AutoSizeFormClass asc = new AutoSizeFormClass();
        Myresume myResumeforUI;
        BasicInfo basicInfo;
        List<Job> jobdatasource;
        List<Skill> skilldatasource;
        List<Education> educationsource;
        string[] jobuindexs=new string[] {"a","b","c","d","e","f","g","h" };
        string[] skillindexs = new string[] {"j","k","l","m","n","o","p","q" };
        int countofjob;
        int countofskill;

        //将数据模型和UI控件绑定
        public DemonstrateForm()
        {
            InitializeComponent();
            //为每个control准备数据源
            myResumeforUI= Myresume.Create();
            basicInfo = myResumeforUI.MybasicInfo;
            jobdatasource = myResumeforUI.MyJobs;
            skilldatasource = myResumeforUI.MySkill;
            educationsource=myResumeforUI.MyEducation;

            //为每个Control进行数据绑定
            //BasicPersonInfo与BasicInfo进行绑定            
            this.basicPersonInfo.Controls[0].
                DataBindings.Add("Text", basicInfo, "Address");
            this.basicPersonInfo.Controls[2].
                DataBindings.Add("Text", basicInfo, "Email");
            this.basicPersonInfo.Controls[4].
                DataBindings.Add("Text", basicInfo, "PhoneNumber");
            this.basicPersonInfo.Controls[6].
                DataBindings.Add("Text", basicInfo, "Experience");
            this.basicPersonInfo.Controls[8].
                DataBindings.Add("Text", basicInfo, "Age");
            this.basicPersonInfo.Controls[10].
                DataBindings.Add("Text", basicInfo, "Name");                
     
            //展示教育经历的数据
            if (educationsource.Count>0)
            {
                foreach (Education education in educationsource)
                {
                    string[] listviewitem = new string[]
                    {
                    education.Stage,
                    education.SchoolName,
                    education.Majoy,
                    education.Start,
                    education.Period,
                    };
                    ListViewItem listViewItem = new ListViewItem(listviewitem);
                    this.listView1.Items.Add(listViewItem);
                }
            }                     
        
            //如果是用数据控制整个用户控件，数据绑定就在用户控件的Parent控件上定义
            if (jobdatasource.Count>0)
            {
                //完成根据List<Job>的长度生成对应JobUI的设计，并将生成的JobUI控件与Job实列绑定
                //JobUI的位置的原点标的物时basicPersonInfo
                int x = this.basicPersonInfo.Location.X;
                int y = this.basicPersonInfo.Location.Y;
                int h = 168;
                int w = this.basicPersonInfo.Width;
                int bh = this.basicPersonInfo.Height;
                countofjob = jobdatasource.Count;
                for (int i = 0; i < jobdatasource.Count; i++)
                {
                    //生成新JobUI并添加到父类控件的Controls
                    this.panel1.Controls.Add(new JobUI()
                    {
                        Location = new Point(x, y + bh + 6 + (h + 6) * i),
                        Height = h,
                        Width = w,
                        Name = jobuindexs[i]
                    });
                    
                    //获得新的JobUI控件在父类控件Controls（集合）中的位置
                    int position = this.panel1.Controls.Count - 1;
                    //收集JobUI在Parent的controls里的index                    
                    
                    //给每个控件一个对应的简单类进行简单绑定
                    this.panel1.Controls[position].Controls[8].
                        DataBindings.Add("Text", jobdatasource[i], "CompanyName");
                    this.panel1.Controls[position].Controls[6].
                        DataBindings.Add("Text", jobdatasource[i], "Title");
                    this.panel1.Controls[position].Controls[4].
                        DataBindings.Add("Text", jobdatasource[i], "Input");
                    this.panel1.Controls[position].Controls[2].
                        DataBindings.Add("Text", jobdatasource[i], "Output");
                    this.panel1.Controls[position].Controls[0].
                        DataBindings.Add("Text", jobdatasource[i], "Duty");
                }
            }
                                 

            //如果想用数据控制用户控件内部的组件的生成，数据绑定要下沉到控件
            if (skilldatasource.Count>0)
            {
                //完成根据List<Skill>的长度生成对应SkillUI的设计，并将生成的SkillUI控件与Skill实列绑定
                //SkillUI的位置的标的物同样是basicPersonInfo
                int Sx = this.basicPersonInfo.Location.X + this.basicPersonInfo.Width + 3;
                int Sy = this.basicPersonInfo.Location.Y;
                int Sh = 150;
                //SkillUI的宽度
                //（这里设计为固定宽度，其实一个更加灵活的思路是设计为窗口的宽度减掉其他的并排组件的宽度）
                //但是这个灵活的思路需要调试在拉伸和全屏化的时候是否会背执行，工作量会被增加。
                //而且因为是展示品，为了简单我决定采取固定窗口大小，所以直接取固定值
                int Sw = 602;
                countofskill = skilldatasource.Count;
                for (int j = 0; j < skilldatasource.Count; j++)
                {
                    //导入数据生成新JobUI并添加到父类控件的Controls
                    this.panel1.Controls.Add(new SkillUI(skilldatasource[j])
                    {
                        Location = new Point(Sx, Sy + (Sh + 3) * j),
                        Height = Sh,
                        Width = Sw,
                        Name = skillindexs[j]
                    });
                }
            }          
        }

        private void DemonstrateForm_SizeChanged(object sender, EventArgs e)
        {
            //锚定对象就是本窗口，窗口以下皆随窗口自适应
            //asc.ControlAutoSize(this);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            //e.TabPage.Controls["button1"].Text=myResumeforUI.MybasicInfo.Name;
            if (e.TabPage.Name == "display")
            {
                Myresume updated = Myresume.Create();
                //基础信息展示
                basicInfo = updated.MybasicInfo;
                this.basicPersonInfo.Controls[0].Text = basicInfo.Address;
                this.basicPersonInfo.Controls[2].Text = basicInfo.Email;
                this.basicPersonInfo.Controls[4].Text = basicInfo.PhoneNumber;
                this.basicPersonInfo.Controls[6].Text = basicInfo.Experience;
                this.basicPersonInfo.Controls[8].Text = basicInfo.Age;

                //工作经验展示
                jobdatasource = updated.MyJobs;
                //先清楚旧的JobUI
                for (int i = 0; i < countofjob; i++)
                {
                    this.panel1.Controls.RemoveByKey(jobuindexs[i]);
                }
                countofjob=jobdatasource.Count;
                //重新描绘新的JobUI
                if (jobdatasource.Count > 0)
                {
                    //完成根据List<Job>的长度生成对应JobUI的设计，并将生成的JobUI控件与Job实列绑定
                    //JobUI的位置的原点标的物时basicPersonInfo
                    int x = this.basicPersonInfo.Location.X;
                    int y = this.basicPersonInfo.Location.Y;
                    int h = 168;
                    int w = this.basicPersonInfo.Width;
                    int bh = this.basicPersonInfo.Height;
                    
                    for (int i = 0; i < jobdatasource.Count; i++)
                    {
                        //生成新JobUI并添加到父类控件的Controls
                        this.panel1.Controls.Add(new JobUI()
                        {
                            Location = new Point(x, y + bh + 6 + (h + 6) * i),
                            Height = h,
                            Width = w,
                            Name= jobuindexs[i]
                        });

                        //获得新的JobUI控件在父类控件Controls（集合）中的位置
                        int position = this.panel1.Controls.Count - 1;
                        //收集JobUI在Parent的controls里的index                       
                        
                        //给每个控件一个对应的简单类进行简单绑定
                        this.panel1.Controls[position].Controls[8].
                            DataBindings.Add("Text", jobdatasource[i], "CompanyName");
                        this.panel1.Controls[position].Controls[6].
                            DataBindings.Add("Text", jobdatasource[i], "Title");
                        this.panel1.Controls[position].Controls[4].
                            DataBindings.Add("Text", jobdatasource[i], "Input");
                        this.panel1.Controls[position].Controls[2].
                            DataBindings.Add("Text", jobdatasource[i], "Output");
                        this.panel1.Controls[position].Controls[0].
                            DataBindings.Add("Text", jobdatasource[i], "Duty");
                    }
                }

                //个人技能展示
                skilldatasource = updated.MySkill;
                //先清楚旧的SkillUI
                for (int i = 0; i < countofskill; i++)
                {
                    this.panel1.Controls.RemoveByKey(skillindexs[i]);
                }
                //冲洗描绘新的SkillUI
                if (skilldatasource.Count > 0)
                {
                    //完成根据List<Skill>的长度生成对应SkillUI的设计，并将生成的SkillUI控件与Skill实列绑定
                    //SkillUI的位置的标的物同样是basicPersonInfo
                    int Sx = this.basicPersonInfo.Location.X + this.basicPersonInfo.Width + 3;
                    int Sy = this.basicPersonInfo.Location.Y;
                    int Sh = 150;
                    //SkillUI的宽度
                    //（这里设计为固定宽度，其实一个更加灵活的思路是设计为窗口的宽度减掉其他的并排组件的宽度）
                    //但是这个灵活的思路需要调试在拉伸和全屏化的时候是否会背执行，工作量会被增加。
                    //而且因为是展示品，为了简单我决定采取固定窗口大小，所以直接取固定值
                    int Sw = 602;
                    countofskill = skilldatasource.Count;
                    for (int j = 0; j < skilldatasource.Count; j++)
                    {
                        //导入数据生成新JobUI并添加到父类控件的Controls
                        this.panel1.Controls.Add(new SkillUI(skilldatasource[j])
                        {
                            Location = new Point(Sx, Sy + (Sh + 3) * j),
                            Height = Sh,
                            Width = Sw,
                            Name = skillindexs[j]
                        });                       
                    }
                }

                //个人教育经历展示
                //先删除旧的展示数据
                this.listView1.Items.Clear();

                //获取新数据，然后展示
                educationsource = updated.MyEducation;
                if (educationsource.Count > 0)
                {
                    foreach (Education education in educationsource)
                    {
                        string[] listviewitem = new string[]
                        {
                            education.Stage,
                            education.SchoolName,
                            education.Majoy,
                            education.Start,
                            education.Period,
                        };
                        ListViewItem listViewItem = new ListViewItem(listviewitem);
                        this.listView1.Items.Add(listViewItem);
                    }
                }

            }    
        }               
    }
}
