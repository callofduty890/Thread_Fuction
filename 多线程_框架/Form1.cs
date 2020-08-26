using HZH_Controls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 多线程_框架
{
    public partial class Form1 : Form
    {
        Thread thread;

        public Form1()
        {
            InitializeComponent();
            //取消跨线程访问
            
        }
        
        public void Thread_Fuction(object J)
        {
                for (int i = 0; i < 100; i++)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        //查找进度条
                        UCProcessLine processline = (UCProcessLine)this.Controls.Find("ucProcessLine"+J.ToString(),false).FirstOrDefault();
                        //拿到进度条的对象
                        processline.Value += 1;

                        //直接赋值的方式
                        //this.ucProcessLine1.Value += 1;
                    }));
                    //等待观察效果
                    Thread.Sleep(500);
                }
        }

        public void Thread_Start(int count)
        {
            //初始化线程
            thread = new Thread(Thread_Fuction);
            //线程设置后后台线程(随exe程序关闭而关闭)
            thread.IsBackground = true;
            //将线程标记为可以启动，等待GC启动线程
            thread.Start(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread_Start(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //终止线程
            thread.Abort();
            //自定义的进度条
            this.ucProcessLine1.Value = 0;
        }
        //启动全部线程
        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                Thread_Start(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread_Start(2);
        }
    }
}
