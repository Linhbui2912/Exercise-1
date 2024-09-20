using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baitap01();
            //baitap02();
            //baitap03();
            //baitap04();
            //baitap0506();
            //baitap07();
            baitap08();

        }

        static void baitap01()
        #region baitap01
        {
            int m = max(1);
            Console.WriteLine(m);
            m = max(1, 2);
            Console.WriteLine(m);
        }

        static int max(int a, params int[] args)
        {
            if (args.Length == 0)
                return a;

            int m = args[0];
            foreach (int i in args)
            {
                if (i > m)
                    m = i;
            }
            return Math.Max(a, m);
        }
        #endregion

        //static void baitap02()
        //{
        //    int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    //int sum = num.Sum();
        //    int sum = 0;

        //    for (int count = 0; count < num.Length; count++)
        //    {
        //        sum = sum + num[count];
        //    }
        //    Console.WriteLine(sum);
        //}

        static void baitap02()
        #region baitap02
        {
            Console.WriteLine(Sum());
        }

        static int Sum()
        {
            int[] num = { 1, 2, 4, 4, 7, 8 };
            int sum = 0;
            for (int count = 0; count < num.Length; count++)
            {
                sum = sum + num[count];
            }
            return sum;
        }
        #endregion

        static void baitap03()
        #region baitap03
        {
            reverseString("ILoveListeningToChineseMusic");
            Console.ReadLine();
        }

        static string reverseString(string strInput)
        {
            string Outputstr = new string(strInput.ToCharArray().Reverse().ToArray());
            Console.WriteLine(Outputstr);
            return Outputstr;
        }
        #endregion

        static void baitap04()
        #region baitap04
        {
            long kq1 = factorial(6);
            Console.WriteLine(kq1);
            long kq = factorial_recursion(5);
            Console.WriteLine(kq);
        }

        static long factorial(int n)
        {
            long f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }
        static long factorial_recursion(int n)
        {
            if (n == 0) return 1;
            return n * factorial_recursion(n - 1);

        }
        #endregion

        static void baitap0506()
        #region baitap05
        {
            //isPrime(0);
            //printPrimeNumberUnderN(100);
            printFirstNprimeNumber(100);
        }

        static bool isPrime(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("Khong hop le!");
                return false;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            } 
        }

        //Write a C# function to print all prime numbers that less than a number (enter prompt keyboard).
        static void printPrimeNumberUnderN(int n)
        {
            for (int i = 1; i <= n; i++)
                if (isPrime(i))
                    Console.WriteLine(i);
        }
        //the first N prime numbers
        static void printFirstNprimeNumber(int n)
        {
            int count = 0;
            int number = 1;
            while (count <= n)
            {
                if (isPrime(number))
                {
                    Console.WriteLine($"{count}: {number}");
                    count++;
                }
                number++;
            }
        }
#endregion

        static void baitap07()
        #region baitap07
        {
            isPerfect(50);
            allPerfectNumberLessThanN(1000);
        }

        static bool isPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0) 
                {
                    sum += i;  
                }                        
            }
            if (sum != num)
                return false;
            return true;
        }

        static void allPerfectNumberLessThanN(int n)
        {
            for (int i = 1; i<=n ; i++)
            {
                if (isPerfect(i))
                    Console.WriteLine(i);
            } 
        }
        #endregion

        static void baitap08()
        {
            pangramStr("TheQuickBrownFoxJumpsOverTheLazyDog");

        }
        static string pangramStr(string str)
        {
           
            

        }


    }


}
