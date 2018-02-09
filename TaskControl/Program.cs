using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TaskControl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Start New Task 
            Console.WriteLine("Hello Task!");
            var task1 = new Task(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("task1 is start");
            });

            var task2 = new Task(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("task2 is start");
            });
            task1.Start();
            task2.Start();
            task1.Wait();
            Console.WriteLine("end output..");
            #endregion

            #region Task Cancel
            Console.WriteLine(Environment.NewLine + "Cancel Task ...");
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var task = Task.Factory.StartNew(() =>
            {
                for (var i = 0; i < 1000; i++)
                {
                    Console.WriteLine("start output " + i);
                    Thread.Sleep(100);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Abort mission success!");
                        return;
                    }
                }
            }, token);
            token.Register(() =>
            {
                Console.WriteLine("Canceled");
            });
            Console.WriteLine("Press enter to cancel task...");
            Console.ReadKey();
            tokenSource.Cancel();
            #endregion

            #region CancellationTokenSource 练习
            TaskCancel.CountManagement();
            #endregion

            Console.Read();
        }
    }

    /// <summary>
    /// CancellationTokenSource 练习 
    /// </summary>
    public class TaskCancel
    {
        static CancellationTokenSource source = new CancellationTokenSource();
        /// <summary>
        /// 计数管理
        /// </summary>
        public static void CountManagement()
        {
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (!source.IsCancellationRequested)
                    {
                        Console.WriteLine(DateTime.Now);
                        Thread.Sleep(500);
                    }
                }
            }, source.Token);
            Console.WriteLine("please input anything cancel task");
            var rst = Console.ReadKey();
            source.Cancel();
            Console.WriteLine("cancel success");
        }

        /// <summary>
        /// 计数器
        /// </summary>
        public void Counter(CancellationTokenSource source)
        {
            Task.Run(() =>
            {
                return Task.Run(() =>
                {
                    return "";
                });
            }, new CancellationTokenSource().Token);
        }
    }
}
