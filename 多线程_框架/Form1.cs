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
        //线程的类 5个线程数组
        Thread[] thread=new Thread[5];

        public Form1()
        {
            InitializeComponent();
            //取消跨线程访问
            
        }
        
        public void Thread_Fuction(object J)
        {
                for (int i = 0; i < 100; i++)
                {
                    //控制UI界面的代码示例
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        //查找进度条
                        UCProcessLine processline = (UCProcessLine)this.Controls.Find("ucProcessLine"+J.ToString(),false).FirstOrDefault();
                        //拿到进度条的对象
                        processline.Value += 1;
                    }));
                    //模拟各种代码操作
                    Thread.Sleep(500);
                }
        }

        public void Thread_Start(int count)
        {
            //初始化线程
            thread[count-1] = new Thread(Thread_Fuction);
            //线程设置后后台线程(随exe程序关闭而关闭)
            thread[count-1].IsBackground = true;
            //将线程标记为可以启动，等待GC启动线程
            thread[count-1].Start(count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Thread_Start(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //终止线程
            thread[0].Abort();
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
        //全部停止
        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < thread.Length; i++)
            {
                thread[i].Abort();
            }
        }
        //进度条清零
        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                //查找进度条
                UCProcessLine processline = (UCProcessLine)this.Controls.Find("ucProcessLine" + i.ToString(), false).FirstOrDefault();
                //拿到进度条的对象
                processline.Value = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //终止线程
            thread[1].Abort();
            //自定义的进度条
            this.ucProcessLine2.Value = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //终止线程
            thread[2].Abort();
            //自定义的进度条
            this.ucProcessLine3.Value = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //终止线程
            thread[3].Abort();
            //自定义的进度条
            this.ucProcessLine4.Value = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //终止线程
            thread[4].Abort();
            //自定义的进度条
            this.ucProcessLine5.Value = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread_Start(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thread_Start(4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Thread_Start(5);
        }
        //线程挂起
        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < thread.Length; i++)
            {
                thread[i].Suspend();
            }
        }
        //线程恢复
        private void button15_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < thread.Length; i++)
            {
                thread[i].Resume();
            }
        }
    }
}
