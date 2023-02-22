namespace StuSystem
{
    partial class frmClass
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(301, 432);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(99, 432);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(138, 40);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(174, 238);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(259, 181);
            this.txtRemark.TabIndex = 9;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(174, 166);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(259, 31);
            this.txtTeacher.TabIndex = 10;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(174, 96);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(259, 31);
            this.txtClassName.TabIndex = 11;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(72, 32);
            this.lblClass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(157, 39);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "班级信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "班级备注信息：";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(57, 182);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(115, 21);
            this.lblTeacher.TabIndex = 6;
            this.lblTeacher.Text = "带课老师：";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(57, 112);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(115, 21);
            this.lblClassName.TabIndex = 7;
            this.lblClassName.Text = "班级名称：";
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 516);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClass";
            this.Text = "班级信息管理";
            this.Load += new System.EventHandler(this.frmClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblClassName;
    }
}