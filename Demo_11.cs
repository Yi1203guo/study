using System;

namespace demo11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //类型转换新招式
            /*
                        string str = "123";
                        int str1 = Convert.ToInt32(str);   //Conver.Toxx()
                        Console.WriteLine(str);
                        Console.ReadKey();*/

            /*
                        string str = "123";
                        int str1 = int.Parse(str);     //xx.Parse()
                        Console.WriteLine(str1);
                        Console.ReadKey();
            */
            /*
                        int i = 1;
                        int sum = 0;
                        while (i<=100)
                        {
                            if (i%7==0)
                            {
                                i++;
                                continue;
                            }
                            else
                            {
                                sum += i;
                                i++;
                            }

                        }
                        Console.WriteLine(sum);
                        Console.ReadKey();*/

            //another practice  look for prime numbers from 0 to 100

            for (int primeNumbers = 2; primeNumbers < 100; primeNumbers++)
            {
                bool b = true;
                for (int i = 2; i < primeNumbers; i++)
                {
                    if (primeNumbers%i==0)
                    {
                        b = false;
                        break;
                    }
                }
                if(b)
                {
                    Console.WriteLine(primeNumbers);
                }
                
                
            }
            Console.ReadKey();









            #endregion



        }
    }
}
