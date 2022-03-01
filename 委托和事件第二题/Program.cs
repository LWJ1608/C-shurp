using System;

namespace 委托和事件第二题
{
    class Program
    {
        public delegate void MyDelegate();
        public class D
        {
            public event MyDelegate myEvent;
            private int score;
            
            public int Score
            {
                set { myEvent(); }
            }
            public D(int score_1)
            {
                score = score_1;
            }
            public void Output()
            {
                Console.WriteLine("score为:{0}", score);
/*                return score;*/
            }
        }
        static void Main(string[] args)
        {
            D d;
            d.myEvent += new MyDelegate();

        }
    }
}
