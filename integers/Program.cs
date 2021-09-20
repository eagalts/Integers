using System;
using System.Collections;

namespace integers
{
    class Program
    {
        public static void ShowIntegers(int n)
        {
            Queue Q2 = new Queue();
            Queue Q3 = new Queue();
            Queue Q5 = new Queue();

            int[] array = new int[n];

            Q2.Enqueue(2);
            Q3.Enqueue(3);
            Q5.Enqueue(5);

            long t = 1;
            long _t;
            sbyte count = 1;

            Console.WriteLine(t);
             
            for (int i = 0; count < n; i++)
            {
                if (Convert.ToInt64(Q2.Peek()) > t)
                {
                    t = Convert.ToInt64(Q2.Dequeue());
                    Console.WriteLine(t);

                    Q2.Enqueue(t * 2);
                    count++;
                }
                else
                {
                    _t = t = Convert.ToInt64(Q2.Dequeue());
                    Q2.Enqueue(_t * 2);
                }


                if (count == n) break;


                if (Convert.ToInt64(Q3.Peek()) > t)
                {
                    t = Convert.ToInt64(Q3.Dequeue());
                    Console.WriteLine(t);

                    Q3.Enqueue(t * 3);
                    count++;
                }
                else
                {
                    _t = t = Convert.ToInt64(Q3.Dequeue());
                    Q3.Enqueue(_t * 3);
                }


                if (count == n) break;


                if (Convert.ToInt64(Q2.Peek()) > t)
                {
                    t = Convert.ToInt64(Q2.Dequeue());
                    Console.WriteLine(t);

                    Q2.Enqueue(t * 2);
                    count++;
                }
                else
                {
                    _t = t = Convert.ToInt64(Q2.Dequeue());
                    Q2.Enqueue(_t * 2);
                }


                if (count == n) break;


                if (Convert.ToInt64(Q5.Peek()) > t)
                {
                    t = Convert.ToInt64(Q5.Dequeue());
                    Console.WriteLine(t);

                    Q5.Enqueue(t * 5);
                    count++;
                }

                else
                {
                    _t = t = Convert.ToInt64(Q5.Dequeue());
                    Q5.Enqueue(_t * 5);
                }
            }
        }

        static void Main(string[] args)
        {
            ShowIntegers(10);
        }
    }
}
