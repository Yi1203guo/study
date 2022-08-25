using System;

namespace demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 变量类型转换
            //practice

            Console.WriteLine("你叫什么");
            string name =Console.ReadLine();  //输入名字

            Console.WriteLine("请输入语文成绩");
            string strChinese = Console.ReadLine();  //注意输入的都是string类型，
                                                     //必须要用string类型的变量接收，否则报错

            Console.WriteLine("请输入数学成绩");
            string strMath = Console.ReadLine();

            Console.WriteLine("请输入英语成绩");
            string strEnglish = Console.ReadLine();

            double douChinese = Convert.ToDouble(strChinese);  //将输入的string变量转为double变量
            double douMath = Convert.ToDouble(strMath);  //以便计算方便
            double douEnglish = Convert.ToDouble(strEnglish);

            double sumScore = douChinese + douMath + douEnglish;  //计算总成绩和平均分，全部采用double型
            double ave = sumScore / 3;

            Console.WriteLine("{0}同学你好\n你的语文成绩是{1}分\t数学成绩是{2}分\t英语成绩是{3}分\n总分{4}分,平均分{5:0.00}分", name, douChinese, douMath, douEnglish, sumScore, ave);
            Console.ReadKey();  //{1:0.00}表示该占位符取两位小数


            #endregion

            #region 一些理论
            //兼容类型（如int和double）可以直接隐式/显式转换
            int a = 5;
            double b = a;  //实现由int转为double，隐式转换。即低转高

            //double c = 3;
            //int d = c;    不可行，高转低不能隐式，可以显式

            double c = 3;
            int d = (int)c;  //强制转换，实现由高转低

            //不兼容类型如（string与int或double）可以使用Convert
            string e = "666";
            int f = Convert.ToInt32(e);  //Convert.To想要的类型(变量)
            double g = Convert.ToDouble(e);

            //int g = e;  不可行
            //int g = (int)f;  (int)无效，与上一行等同

            //不兼容类型还可以用.Parse
            string h = "666";
            int i = int.Parse(h);

            //枚举类型和int类型兼容

            #endregion

            //date 2022/1/9
        }
    }
}
