using System;

namespace demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 运算符II ++和--
            /*int a = 5;
            int b = a++ + ++a*4 + a-- - --a*2;
            Console.WriteLine("原a=5");
            Console.WriteLine("现a={0}\tb={1}",a,b);
            Console.ReadKey();*/

            //复合赋值运算符
            int num = 10;
            num += 10;  //  相当于num = num+10
            num -= 10;
            num *= 10;
            num /= 10;
            num %= 10;

            //逻辑运算符
            bool result1 = 3 > 5 && 9 < 8;  //与
            bool result2 = 3 > 5 || 9 < 8;  //或
            bool result3 = 3 > 5 != 9 < 8;  //非
            bool result4 = 3 > 5 == 9 < 8;  //是否相等
            #endregion
        }
    }
}
