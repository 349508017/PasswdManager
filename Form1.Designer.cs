namespace PasswordApplication_
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.CheckBox();
            this.letter = new System.Windows.Forms.CheckBox();
            this.other = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.strLen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成随机数";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Checked = true;
            this.number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.number.Location = new System.Drawing.Point(30, 106);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(48, 16);
            this.number.TabIndex = 1;
            this.number.Text = "数字";
            this.number.UseVisualStyleBackColor = true;
            // 
            // letter
            // 
            this.letter.AutoSize = true;
            this.letter.Location = new System.Drawing.Point(111, 106);
            this.letter.Name = "letter";
            this.letter.Size = new System.Drawing.Size(48, 16);
            this.letter.TabIndex = 1;
            this.letter.Text = "字母";
            this.letter.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(184, 106);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(72, 16);
            this.other.TabIndex = 1;
            this.other.Text = "特殊字符";
            this.other.UseVisualStyleBackColor = true;
            this.other.CheckedChanged += new System.EventHandler(this.othoer_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "字符串长度";
            // 
            // strLen
            // 
            this.strLen.Location = new System.Drawing.Point(111, 140);
            this.strLen.Name = "strLen";
            this.strLen.Size = new System.Drawing.Size(48, 21);
            this.strLen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "位";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(42, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(0, 18);
            this.title.TabIndex = 5;
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "保存数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.strLen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.other);
            this.Controls.Add(this.letter);
            this.Controls.Add(this.number);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "密码管理器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox number;
        private System.Windows.Forms.CheckBox letter;
        private System.Windows.Forms.CheckBox other;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox strLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
    }
}

