using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _01_线程优先级
{

    class Program
    {

        //线程功能函数
        public static void DoWork1(object data)
        {
            long count1 = 0;
            try
            {
                while (true)
                {
                    count1++;
                    Thread.Sleep(10);
                }    
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("{0},count-{1}", data, count1);
            }
        }
        public static void DoWork2(object data)
        {
            long count2 = 0;
            try
            {
                while (true)
                {
                    count2++;
                    Thread.Sleep(10);
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("{0},count2-{1}", data, count2);
            }
        }
        static void Main(string[] args)
        {
            //创建线程对象实例
            Thread thread_Lowest = new Thread(DoWork1);
            Thread thread_Hight = new Thread(DoWork2);

            //设置线程优先级
            thread_Lowest.Priority = ThreadPriority.Lowest;
            thread_Hight.Priority = ThreadPriority.Highest;

            //启动线程
            thread_Lowest.Start("Lowest");
            thread_Hight.Start("Hight");

            Console.WriteLine("请耐心等待五秒钟.....");
            Thread.Sleep(5000);

            //停止线程
            thread_Lowest.Abort();
            thread_Hight.Abort();

            Console.Read();
        }
    }
}
