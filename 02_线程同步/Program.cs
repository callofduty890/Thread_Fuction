using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _02_线程同步
{
   //创建一个银行收取支出的账号
    class Account
    {
        //为Lock准备线程锁需要的类
        private object thisLock = new object();
        //存款金额
        int balance;
        //构造函数  ->作用：初始化账户金额
        public Account(int intiial)
        {
            this.balance = intiial;
        }
        //从账户中取款
        public void WithDraw(object amount)
        {
            lock (thisLock)//这个位置会形成临界区
            {
                //判断金额是否大于扣款数
                if (balance>=(int)amount)
                {
                    Thread.Sleep(500);
                    //取款,amount取款金额
                    balance = balance - (int)amount;
                    //操作成功
                    Console.WriteLine("{0} 操作成功,余额-{1}", Thread.CurrentThread.Name, balance);
                }
                else
                {
                    //操作失败
                    Console.WriteLine("{0} 操作失败,账户余额不足,余额-{1}", Thread.CurrentThread.Name, balance);
                }

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //初始化账号的余额
            Account acc = new Account(1000);

            //启动线程去取款
            Thread t1 = new Thread(acc.WithDraw);
            t1.Name = "小明";

            Thread t2 = new Thread(acc.WithDraw);
            t2.Name = "老王";

            t1.Start(600);
            t2.Start(600);

            Console.ReadKey();

        }
    }
}
