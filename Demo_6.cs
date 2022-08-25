using System;

namespace demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 有关if的
            //practice
            //Console.WriteLine("请输入你的成绩");
            //string score = Console.ReadLine();
            //double douScore = Convert.ToDouble(score);
            //bool bScore = douScore > 60;
            //if (bScore == true)  //在这里==true可省略，但==false不可省略
            //{
            //    Console.WriteLine("恭喜你及格了");
            //    Console.ReadKey();
            //}        ctrl+k+c

            Console.WriteLine("请输入你的成绩");            
            double score = Convert.ToDouble(Console.ReadLine());
            if (score >= 100)
            {
                Console.WriteLine("怎么可能");
                Console.ReadKey();
            }
            else if (score >= 80 && score < 100)
            {
                Console.WriteLine("牛啊");
                Console.ReadKey();
            }
            else if(score>=60 && score<80)
            {
                Console.WriteLine("还行");
                Console.ReadKey();
            }
            else if (score>=40 && score<60)
            {
                Console.WriteLine("有点垃圾");
                Console.ReadKey();
            }
            else if(score>=0 && score<40)
            {
                Console.WriteLine("不行啊小老弟");
                Console.ReadKey();
            }
            else if (score<0)
            {
                Console.WriteLine("死吧渣渣");
                Console.ReadKey();
            }
            else
            {
             
            }
            #endregion

            //date 2022/1/10
        }
    }
}
