using System;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 变量的使用规则
           
            int number;  //声明变量、赋值
            number = 20;
            Console.WriteLine(number);  //在控制台中打印变量
            Console.ReadKey();
            //变量的食用方法：先声明，再赋值，最后使用。不能替换步骤

            #endregion

            #region 运算符
            
            string name = "Yi.Guo";
            Console.WriteLine("你好，" + name);
            Console.ReadKey();
            

            //占位符
            int num_1 = 10;
            int num_2 = 20;
            int num_3 = 30;
            Console.WriteLine("第一个数字是{0},第二个数字是{1},第三个数字是{2}", num_1, num_2, num_3);
            Console.ReadKey();
            //占位符先挖坑，后填坑，后面用逗号,多填无用
            Console.WriteLine("第一个数字是{0},第二个数字是{2},第三个数字是{1}", num_1, num_2, num_3);
            //填坑时按照挖坑的顺序输出，第一个坑是0
            Console.ReadKey();
            






            #endregion

            //date 2022/1/9
        }
    }
}
