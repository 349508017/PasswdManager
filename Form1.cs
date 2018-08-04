using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
//technical support QQ:349508017
namespace PasswordApplication_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len;
            //获取字符串长度
            if (strLen.Text != "")
            {
                len = int.Parse(strLen.Text);
            }
            else { 
                //默认随机6位字符串
                len = 6;
            }
            //定义随机数组
            ArrayList list = new ArrayList();
            if(number.Checked == true){
                //定义数字随机字符
                string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                list.AddRange(num);
            }
            if (letter.Checked == true)
            {
                //定义字母随机字符
                string[] let = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                list.AddRange(let);
            }
            if (other.Checked == true)
            {
                //定义特殊字符随机字符
                string[] oth = { ".", "?", "|","-","[","]" ,"{","}",","};
                list.AddRange(oth);
            }
            //随机字符串
            string str = String.Empty;
            //获取list长度
            int listLen=list.Count;
            Random ran = new Random();
            for (int i = 1; i <= len;i++ )
            {
                //随机一个数
                int n = ran.Next(0, listLen);
                str += list[n];
            }
            if(str != ""){
                title.Text = str;
            }
        }

        private void othoer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string content =title.Text;
            FileStream fs = new FileStream("./stream.txt",FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            //追加内容
            sw.Write(content+"\n");
            sw.Close();
            fs.Close();
            //System.IO.File.WriteAllText("./stream.txt",file,Encoding.Default);
        }
    }
}
