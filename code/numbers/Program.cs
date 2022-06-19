using System;
namespace numberApplication
{
    class number
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int num = 0;
            int n;
            int num2;

            for( ; ; )
            {
                Console.WriteLine("您要猜1至几的数字？请输入整数。");
                num = Convert.ToInt32(Console.ReadLine());
                num = num + 1;
                n = dice.Next(1, num);

                for( ; ; )
                {
                    Console.WriteLine("请猜。");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 == n)
                    {
                        Console.WriteLine("猜对了！！！！！！！！！！");
                        break;
                    }

                    if (num2 > num)
                    {
                        Console.WriteLine("不能输入大于设定值的整数。");
                    }

                    else if (num2 > n)
                    {
                        Console.WriteLine("大了。");
                    }

                    else if (num2 < n)
                    {
                        Console.WriteLine("小了。");
                    }
                }
            }
        }
    }
}
