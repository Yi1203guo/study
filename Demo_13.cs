using System;

namespace demo13
{
    //prectice
    public enum QQState
    {
        OnLine=5,   //变量与变量之间逗号隔开；默认第一个变量的int值为0，后面依次+1
        OffLine,    //如果在变量后赋值则改变这个变量的int值
        Leave,
        Busy,
        QMe,
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 枚举

            /*
                        枚举一般写在命名空间内，类之上
                        [public] enum 名字
                        {
                            xxxxx
                        }

            */

            QQState state = QQState.OnLine;
            //枚举类型默认可以和int类型相互转换（显式转换）
            //枚举转int
            int a = Convert.ToInt32(state);
            Console.WriteLine(a);

            //int转枚举
            int b = 5;
            QQState s = (QQState)b;
            Console.WriteLine(s);

            //所有类型都可以转成string类型，包括枚举
            string strState = Convert.ToString(state);
            Console.WriteLine(strState);


            Console.ReadKey();
            #endregion
        }
    }
}
