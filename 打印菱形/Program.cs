using System;

namespace 打印菱形
{
    class Program
    {
        static void Show(int p)
        {
            int t= 2 * p - 1;
            if (p>2)
            {
                for (int i = 1; i <= t / 2 + 1; i++) 
                {
                    for (int a = 1; a <= t / 2 + 1; a++) 
                        {
                            if(a>=t/2-i+2)
                            {
                            Console.Write(" *");
                            }
                            else 
                            {
                                Console.Write(" ");
                            }
                        }
                    Console.WriteLine();
                }

                for (int i = t / 2; i >=1 ; i--)
                {
                    for (int a = 1; a <=t/2+1; a++)
                    {
                        if (a >= t / 2 - i + 2)
                        {
                            Console.Write(" *");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("输入的数不能打印组成一个菱形！");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数");
            string a = Console.ReadLine();
            int n = Convert.ToInt32(a);

/*            Console.WriteLine(n);*/
            Show(n);
            /*            Console.WriteLine("Hello World!");*/
        }
    }
}
