using System;

namespace demo10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 循环四大天王之for循环(do-while跳过)
            //practice1  奇数
            /*
                        int sum =0;
                        for (int i = 1; i <= 100; i++)
                        {
                            if(i%2==0)
                            {
                                sum += i;
                            }

                        }
                        Console.WriteLine(sum);
                        Console.ReadKey();
            */

            //practice2  100-999的水仙花数
            Console.Write("请输入一个数字");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("{0} + {1} = {2}", i, num1, i + num1);
                num1--;
            }
            Console.ReadKey();

            
            //cw加两下tab直接召唤Console.WriteLine();   666啊
            #endregion

            //date 2022/1/16

        }
    }
}
