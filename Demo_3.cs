using System;

namespace demo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 接收数据
            Console.WriteLine("少年，你叫什么名字？");
            string name = Console.ReadLine();  //将输入的变量存到name变量中
            Console.WriteLine("你好啊{0}!", name);
            Console.ReadKey();

            #endregion

            #region 转义符
            /*
             *  \n 换行
             *  \" 表示双引号
             *  \t 表示一个缩进
             *  \\ 表示一个\
             *  @  取消\在字符串中的转移作用 将字符串按照原格式输出
             */

            //practice1 \
            Console.WriteLine("\\锄禾1日当午，\n汗滴禾下土。\t谁知盘中餐，\n\"粒粒皆辛苦\"");
            Console.ReadKey();

            //practice2 @1
            Console.WriteLine(@"路径为R:\Visual Studio\Microsoft Visual Studio\Installer");
            Console.ReadKey();
            //Console.WriteLine(@"路径为R:\Visual Studio\Microsoft Visual Studio\Installer");  报错
            char a = '\b';

            //practice3 @2
            Console.WriteLine(@"aaaaaa
bbbbbb");
            Console.ReadKey();
            #endregion

            //date 2022/1/9
        }
    }
}
