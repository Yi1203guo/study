using System;

namespace demo9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 循环四大天王之while循环
            /*说明：
                        while (循环条件)
            {
                循环体
                        }
            判断while括号内循环条件是否成立，成立执行循环体，执行完毕再次判断
            知道判断出循环条件为否时跳出循环*/

            //practice 1
            /*int i = 1;
            while (i <= 100)
            {
                Console.WriteLine("卢本伟牛逼\t{0}", i);
                i++;
            }
            Console.ReadKey();

            //practice 2
            int p = 1;
            int answer = 1;
            while (p < 100)
            {
                p++;
                answer += p;
            }
            Console.WriteLine(answer);
            Console.ReadKey();*/


            //practice 2
            int number;  
            double score=0;  
            int i = 1;
            double p;
            while (true)  
            {
                Console.WriteLine("请输入班级人数");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    while(number<0)
                    {
                        Console.WriteLine("人数怎么能是负数呢，请重新输入");
                        Console.WriteLine("请输入班级人数");
                        number = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("请输入每一位成员的成绩");
                    while (i <= number)
                    {
                        Console.WriteLine("请输入第{0}名学生的成绩", i);
                        try
                        {
                            
                            p = Convert.ToDouble(Console.ReadLine());
                            while (p < 0)
                            {
                                Console.WriteLine("成绩怎么能是负数呢，请重新输入");
                                Console.WriteLine("请输入第{0}名学生的成绩", i);
                                p = Convert.ToDouble(Console.ReadLine());
                            }
                            score += p;
                            i++;
                        }
                        catch
                        {
                            Console.WriteLine("输入值错误，请重新输入");
                        }
                    }
                    Console.WriteLine("本班共{0}人，总成绩{1:0.00}分，平均成绩{2:0.00}分", number, score, score / number);
                    Console.ReadKey();
                    break;
                }
                catch
                {
                    Console.WriteLine("输入值错误，请重新输入");
                }
            }
            #endregion

            //date 2022/1/15

        }
    }
}
