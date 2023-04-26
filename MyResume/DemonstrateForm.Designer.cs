namespace MyResume
{
    partial class DemonstrateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemonstrateForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.display = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.basicPersonInfo = new MyResume.BasicPersonInfo();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.input = new System.Windows.Forms.TabPage();
            this.inputBasicinfo1 = new MyResume.InputBasicinfo();
            this.inputEducation1 = new MyResume.InputEducation();
            this.inputSkill1 = new MyResume.InputSkill();
            this.inputJob1 = new MyResume.InputJob();
            this.tabControl.SuspendLayout();
            this.display.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.input.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.display);
            this.tabControl.Controls.Add(this.input);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1426, 923);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // display
            // 
            this.display.Controls.Add(this.panel1);
            this.display.Location = new System.Drawing.Point(4, 29);
            this.display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display.Name = "display";
            this.display.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.display.Size = new System.Drawing.Size(1418, 890);
            this.display.TabIndex = 0;
            this.display.Text = "简历展示";
            this.display.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.basicPersonInfo);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 882);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox3.Location = new System.Drawing.Point(0, 678);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 201);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox2.Location = new System.Drawing.Point(0, 462);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 212);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Location = new System.Drawing.Point(0, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(807, 690);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 189);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "教育经历";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "学校名称";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专业名称";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "入学时间";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "学习周期";
            this.columnHeader5.Width = 80;
            // 
            // basicPersonInfo
            // 
            this.basicPersonInfo.Location = new System.Drawing.Point(191, 2);
            this.basicPersonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basicPersonInfo.Name = "basicPersonInfo";
            this.basicPersonInfo.Size = new System.Drawing.Size(602, 162);
            this.basicPersonInfo.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(191, 232);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.Silver;
            this.input.Controls.Add(this.inputBasicinfo1);
            this.input.Controls.Add(this.inputEducation1);
            this.input.Controls.Add(this.inputSkill1);
            this.input.Controls.Add(this.inputJob1);
            this.input.ForeColor = System.Drawing.SystemColors.ControlText;
            this.input.Location = new System.Drawing.Point(4, 29);
            this.input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input.Name = "input";
            this.input.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input.Size = new System.Drawing.Size(1418, 890);
            this.input.TabIndex = 1;
            this.input.Text = "简历更新";
            // 
            // inputBasicinfo1
            // 
            this.inputBasicinfo1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inputBasicinfo1.Location = new System.Drawing.Point(90, 47);
            this.inputBasicinfo1.Name = "inputBasicinfo1";
            this.inputBasicinfo1.Size = new System.Drawing.Size(525, 343);
            this.inputBasicinfo1.TabIndex = 4;
            // 
            // inputEducation1
            // 
            this.inputEducation1.Location = new System.Drawing.Point(873, 511);
            this.inputEducation1.Name = "inputEducation1";
            this.inputEducation1.Size = new System.Drawing.Size(379, 254);
            this.inputEducation1.TabIndex = 3;
            // 
            // inputSkill1
            // 
            this.inputSkill1.BackColor = System.Drawing.Color.Silver;
            this.inputSkill1.Location = new System.Drawing.Point(177, 511);
            this.inputSkill1.Name = "inputSkill1";
            this.inputSkill1.Size = new System.Drawing.Size(377, 254);
            this.inputSkill1.TabIndex = 2;
            // 
            // inputJob1
            // 
            this.inputJob1.Location = new System.Drawing.Point(699, 47);
            this.inputJob1.Name = "inputJob1";
            this.inputJob1.Size = new System.Drawing.Size(654, 343);
            this.inputJob1.TabIndex = 1;
            // 
            // DemonstrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 927);
            this.Controls.Add(this.tabControl);
            this.Location = new System.Drawing.Point(100, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1450, 974);
            this.MinimumSize = new System.Drawing.Size(1450, 974);
            this.Name = "DemonstrateForm";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "MyResume";
            this.SizeChanged += new System.EventHandler(this.DemonstrateForm_SizeChanged);
            this.tabControl.ResumeLayout(false);
            this.display.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.input.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private TabControl tabControl;
        private TabPage display;
        private TabPage input;
        private Panel panel1;
        private PictureBox pictureBox;
        private BasicPersonInfo basicPersonInfo;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private InputJob inputJob1;
        private InputSkill inputSkill1;
        private InputEducation inputEducation1;
        private InputBasicinfo inputBasicinfo1;
    }
}