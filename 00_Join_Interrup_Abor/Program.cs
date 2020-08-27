using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _00_Join_Interrup_Abor
{
    class Program
    {
        //线程函数
        static void TestMethod()
        {
            try
            {
                while (true)
                {
                    Console.Write("T");
                    Thread.Sleep(500);
                }
            }
            catch (ThreadAbortException abortException)
            {
                Console.WriteLine("   工作线程被 {0} 终止", abortException.ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始,创建并启动工作线程");
            Thread t = new Thread(TestMethod);
            t.Start();
            //等待主线程运行一会
            Thread.Sleep(1500);
            Console.WriteLine("主线程试图销毁工作线程");
            //t.Abort();//销毁t线程
            //t.Interrupt();//线程中断
            t.Join(); //等待线程终止

            //
            Console.WriteLine("工作线程终止,主线程终止");
            //Console.ReadKey();

        }
    }
}
