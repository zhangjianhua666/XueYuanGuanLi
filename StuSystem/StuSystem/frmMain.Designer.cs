namespace StuSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tvClass = new System.Windows.Forms.TreeView();
            this.cmsStu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvStu = new System.Windows.Forms.ListView();
            this.stuId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stuPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsClass = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogNameTxt = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmsStu.SuspendLayout();
            this.cmsClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(409, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生信息";
            // 
            // tvClass
            // 
            this.tvClass.ContextMenuStrip = this.cmsStu;
            this.tvClass.Location = new System.Drawing.Point(57, 94);
            this.tvClass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tvClass.Name = "tvClass";
            this.tvClass.Size = new System.Drawing.Size(308, 778);
            this.tvClass.TabIndex = 1;
            // 
            // cmsStu
            // 
            this.cmsStu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsStu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem});
            this.cmsStu.Name = "cmsStu";
            this.cmsStu.Size = new System.Drawing.Size(211, 106);
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            // 
            // lvStu
            // 
            this.lvStu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stuId,
            this.classId,
            this.stuName,
            this.stuSex,
            this.stuPhone,
            this.Remark});
            this.lvStu.ContextMenuStrip = this.cmsStu;
            this.lvStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvStu.HideSelection = false;
            this.lvStu.Location = new System.Drawing.Point(416, 94);
            this.lvStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lvStu.Name = "lvStu";
            this.lvStu.Size = new System.Drawing.Size(1115, 778);
            this.lvStu.TabIndex = 2;
            this.lvStu.UseCompatibleStateImageBehavior = false;
            this.lvStu.View = System.Windows.Forms.View.Details;
            // 
            // stuId
            // 
            this.stuId.Text = "学号";
            // 
            // classId
            // 
            this.classId.Text = "班级";
            // 
            // stuName
            // 
            this.stuName.Text = "姓名";
            // 
            // stuSex
            // 
            this.stuSex.Text = "性别";
            // 
            // stuPhone
            // 
            this.stuPhone.Text = "电话";
            // 
            // Remark
            // 
            this.Remark.Text = "备注";
            // 
            // cmsClass
            // 
            this.cmsClass.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加班级信息ToolStripMenuItem,
            this.修改班级信息ToolStripMenuItem,
            this.删除班级信息ToolStripMenuItem});
            this.cmsClass.Name = "cmsClass";
            this.cmsClass.Size = new System.Drawing.Size(271, 144);
            // 
            // 添加班级信息ToolStripMenuItem
            // 
            this.添加班级信息ToolStripMenuItem.Name = "添加班级信息ToolStripMenuItem";
            this.添加班级信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.添加班级信息ToolStripMenuItem.Text = "添加班级信息";
            this.添加班级信息ToolStripMenuItem.Click += new System.EventHandler(this.添加班级信息ToolStripMenuItem_Click);
            // 
            // 修改班级信息ToolStripMenuItem
            // 
            this.修改班级信息ToolStripMenuItem.Name = "修改班级信息ToolStripMenuItem";
            this.修改班级信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.修改班级信息ToolStripMenuItem.Text = "修改班级信息";
            // 
            // 删除班级信息ToolStripMenuItem
            // 
            this.删除班级信息ToolStripMenuItem.Name = "删除班级信息ToolStripMenuItem";
            this.删除班级信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.删除班级信息ToolStripMenuItem.Text = "删除班级信息";
            // 
            // LogNameTxt
            // 
            this.LogNameTxt.AutoSize = true;
            this.LogNameTxt.Location = new System.Drawing.Point(1186, 46);
            this.LogNameTxt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LogNameTxt.Name = "LogNameTxt";
            this.LogNameTxt.Size = new System.Drawing.Size(115, 21);
            this.LogNameTxt.TabIndex = 3;
            this.LogNameTxt.Text = "当前用户：";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUser.Location = new System.Drawing.Point(1316, 46);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 21);
            this.lblUser.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 896);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.LogNameTxt);
            this.Controls.Add(this.lvStu);
            this.Controls.Add(this.tvClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmMain";
            this.Text = "学员管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsStu.ResumeLayout(false);
            this.cmsClass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvClass;
        private System.Windows.Forms.ListView lvStu;
        private System.Windows.Forms.ContextMenuStrip cmsClass;
        private System.Windows.Forms.Label LogNameTxt;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem 添加班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除班级信息ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader stuId;
        private System.Windows.Forms.ColumnHeader classId;
        private System.Windows.Forms.ColumnHeader stuName;
        private System.Windows.Forms.ColumnHeader stuSex;
        private System.Windows.Forms.ColumnHeader stuPhone;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ContextMenuStrip cmsStu;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
    }
}