using System;

namespace demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region switch-case的用法

            #region 这是if的写法
            /*
                        bool a = true;
                        int money = 5000;
                        Console.WriteLine("请输入等级");
                        string level = Console.ReadLine();
                        if (level == "A")
                        {
                            money += 1000;
                        }
                        else if (level == "B")
                        {
                            money += 500;
                        }
                        else if (level == "C")
                        {
                            money += 100;
                        }
                        else if (level == "D")
                        {
                        }
                        else if (level == "E")
                        {
                            money -= 500;
                        }
                        else
                        {
                            Console.WriteLine("输入有误");
                            a = false;
                        }
                        if (a)
                        {
                            Console.WriteLine("余额为{0}", money);
                        }
                        Console.ReadKey();
            */
            #endregion

            #region 这是switch-case的写法

            bool b = true;
            int money = 5000;
            Console.WriteLine("请输入等级");
            string level = Console.ReadLine();
            switch(level)  //switch(要讨论的变量)
            {
                case "A":money += 1000;   //case 值--各种情况，满足就执行case里的，不满足跳过
                    break;  //break对case的结尾
                case "B":money += 500;  //这里的money是string变量，所以值要加""
                    break;
                case "C":money += 100;
                    break;
                case "D":
                    break;
                case "E":money -= 500;
                    break;
                default:Console.WriteLine("输入错误");b = false;  //default备选项
                    break;  //若以上都不满足则执行default，也可以不用default直接跳出
            }
            if(b)
            {
                Console.WriteLine("余额为{0}", money);
            }
            Console.ReadKey();
            #endregion

            //date 2022/1/13

            #endregion


        }
    }
}
