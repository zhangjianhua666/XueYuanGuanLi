namespace StuSystem
{
    partial class frmStudent
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
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.radW = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStuTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(257, 569);
            this.btnCanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(138, 40);
            this.btnCanel.TabIndex = 22;
            this.btnCanel.Text = "取消";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(75, 569);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 40);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(145, 263);
            this.cboClass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(248, 29);
            this.cboClass.TabIndex = 20;
            // 
            // radW
            // 
            this.radW.AutoSize = true;
            this.radW.Location = new System.Drawing.Point(282, 217);
            this.radW.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radW.Name = "radW";
            this.radW.Size = new System.Drawing.Size(56, 25);
            this.radW.TabIndex = 18;
            this.radW.Text = "女";
            this.radW.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Checked = true;
            this.radM.Location = new System.Drawing.Point(145, 217);
            this.radM.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(56, 25);
            this.radM.TabIndex = 19;
            this.radM.TabStop = true;
            this.radM.Text = "男";
            this.radM.UseVisualStyleBackColor = true;
            this.radM.CheckedChanged += new System.EventHandler(this.radM_CheckedChanged);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(145, 376);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(246, 179);
            this.txtRemark.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(145, 320);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 31);
            this.txtPhone.TabIndex = 15;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(145, 159);
            this.txtAge.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(248, 31);
            this.txtAge.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 31);
            this.txtName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 382);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "备注信息：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "电话号码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "班级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "年龄：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "姓名：";
            // 
            // lblStuTitle
            // 
            this.lblStuTitle.AutoSize = true;
            this.lblStuTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuTitle.Location = new System.Drawing.Point(68, 30);
            this.lblStuTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStuTitle.Name = "lblStuTitle";
            this.lblStuTitle.Size = new System.Drawing.Size(159, 35);
            this.lblStuTitle.TabIndex = 7;
            this.lblStuTitle.Text = "学生信息";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 637);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.radW);
            this.Controls.Add(this.radM);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStuTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudent";
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.RadioButton radW;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStuTitle;
    }
}