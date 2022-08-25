using System;

namespace demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 捕获异常
            //practice
            int num = 0;
            Console.WriteLine("请输入数字");
            try
            {
                int a =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a * 2);
            }
            //try和catch之间不能有代码
            catch
            {
                Console.WriteLine("输入错误");
            }
            Console.ReadKey();
            //如果try里的代码不抛异常则执行try里的，如果抛异常就执行catch里的
            
            #endregion

            //date 2022/1/11
        }
    }
}
