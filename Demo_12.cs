using System;

namespace demo12
{
    class Program
    {
        static void Main(string[] args)
        {
            //三元表达式
            //表达式1?表达式2:表达式3  1为判断，成立结果为2，不成立结果为3
            //practice
            Console.WriteLine("请输入两个数字");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a > b ? a : b;
            Console.WriteLine(result);
        }
    }
}
