using System;

namespace demo14
{
    public struct Person
    {
        public string _name;   //括号里的东西叫字段，不是变量
        public int _age;   //字段和变量都能存储数据
        public Gender _gender;   //程序运行时变量只能存一个值，而字段能存好多个
        //必须加public，不加只能访问内部，外部要想访问必须加public
        //为区分字段和变量，一般在字段前加下划线  _name
    }

    public enum Gender  //为使用规范，性别用枚举
    {
        男,
        女
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region  结构

            //一次性声明多个不同类型的变量

            Person zsPerson;   //变量类型为Person
            zsPerson._name = "张三";
            zsPerson._age = 20;
            zsPerson._gender = Gender.男;
            //记录这么多数据只用了zsPerson这一个变量

            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 21;
            lsPerson._gender = Gender.女;

            Console.WriteLine(zsPerson._name);
            Console.WriteLine(lsPerson._name);
            Console.ReadKey();

            #endregion

            //date 2022/8/25

        }
    }
}
