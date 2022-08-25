using System;

namespace demo15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  数组

            #region  int数组

            //一次性存储多个相同类型的变量
            //数组类型[] 数组名=new 数组类型[数组长度];
            int[] nums = new int[10];   //往nums数组里存10个变量
            //当写下这行代码时，数组就在内存里已经开辟了连续的10块空间
            //每一块称为这个数组的元素,未改动的情况下每一个元素都是0
            //每一块空间对应一个从0开始的下标（或索引） 数组从零开始

            nums[1] = 5;  //给下标为1的元素赋值 下标为1,即第二个元素
            //nums[10] = 1;  抛异常，索引越界，数组中没有第十个下标
            //数组的长度一旦被固定就不能改变

            for (int i = 0; i < 10; i++)
            {
                nums[i]= i+1;
                Console.WriteLine(nums[i]);
            }  //for循环为数组分别赋值并打印

            Console.ReadKey();

            #endregion

            #region 其他数组

            //string[] str = new string[10];
            //string类型的数组默认元素都是null
            //null与""（空）不同，null在内存中没有开辟空间
            //而空在内存里开辟了一个叫“空”的空间

            //bool[] boo = new bool[10];
            //bool数组默认元素为false



            #endregion

            #endregion

            #region 数组的声明方法
            //int[] nums = new int[10];  声明数组和长度


            //int[] numsTwo = {1,2,3,4,5,6};  声明数组和元素


            //int[] numsThree = new int[10] {1,2,3};   声明数组、长度、元素
            //不能多也不能少

            //一般用第一种或第二种
            #endregion

            #region 数组的计算（最值等）

            #endregion
        }
    }
}
