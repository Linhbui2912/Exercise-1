namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baitap01();
            baitap02();
            baitap03();
            baitap04();
            baitap05();
            baitap06();
            baitap07();
            baitap08();
            baitap09();
            baitap10();
        }

        static void baitap01() //check whether a given number is even or odd
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("This is an even number.");
            }
            else Console.WriteLine("This is an odd number.");

            Console.ReadLine();

        }

        static void baitap02() //find the largest of three numbers
        {
            Console.WriteLine("Enter three numbers:");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int max = a1;

            max = Math.Max(Math.Max(a1, a2), a3);

            Console.WriteLine($"Max: {max}");

            Console.ReadLine() ;
        }

        static void baitap03() //Write a program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
        {
            int x, y;
            Console.Write("Input the value for X coordinate : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x>0 && y>0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the First quadrant.");
            else 
                if (x>0 && y<0) 
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the Fourth quadrant.");
            else 
                if (x<0 && y<0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the Third quadrant.");
            else
                if (x<0 && y>0)
                Console.WriteLine($"The coordinate point ({x} {y}) lies in the Second quadrant.");
            else 
                if (x==0 && y==0) 
                Console.WriteLine("$\"The coordinate point ({x} {y}) lies at the origin.");

            Console.ReadLine();
        }

        static void baitap04() //check whether a triangle is Equilateral, Isosceles or Scalene (tam giác đều, tam giác cân hay tam giác không cân)
        {
            Console.WriteLine("Enter the length of three sides of the triangle");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("This is an Equilateral triangle.");
            else
                if (a == b || a == c || b == c)
                Console.WriteLine("This is an Isosceles triangle.");
            else
                Console.WriteLine("This is an Scelene triangle.");

            Console.ReadLine();

        }

        public static void baitap05() //read 10 numbers and find their average and sum
        {
            int sum = 0, count = 0, num = 0;
            double avr = 0.0d;

            Console.WriteLine("Enter the 10 numbers: ");
          
            
            for (count = 1; count <= 10; count++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }    
            
            avr = sum / 10;
            Console.WriteLine($"The sum of 10 numbers is {sum} and the average is {avr}");

            Console.ReadLine() ;
        }

        public static void baitap06() //display the multiplication table of a given integer
        {
            int num1, num2;

            Console.Write("Input the number you want to display its multiplication table : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (num2 = 1; num2 <= 10; num2++)
            {
                Console.WriteLine($"{num1} x {num2} = {num1*num2} ");
            }

            Console.ReadLine();
        }

        public static void baitap07() //display a pattern like triangles with a number
        { 
        
        }

        public static void baitap08() //display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        {
            int term, loopctrl;
            float sum = 0.0f;

            Console.WriteLine("Input the number you want to display its terms of harmonic series and their sum : ");
            term = Convert.ToInt32(Console.ReadLine());

            for (loopctrl = 1; loopctrl <= term; loopctrl++) 
            {
                Console.Write($"1/{loopctrl} + ");
                sum += 1 / (loopctrl * 0.1f);

            }

            Console.WriteLine($" The sum of series upto {loopctrl} terms : {sum}");
            Console.ReadLine();
        }

        public static void baitap09() //find the ‘perfect’ numbers within a given number range
        {
            int n, startingNum, endingNum;
            int i, sum = 0;

            Console.Write("Input the starting range of number : ");
            startingNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range of number : ");
            endingNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("The Perfect numbers within the given range : ");

            for (n = startingNum; n <= endingNum; n++)
            {
                i = 1; sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                    i++;
                }
                if (sum == n)
                {
                    Console.Write($"{n},");
                }    

            }
            Console.ReadLine();

        }

        public static void baitap10() //determine whether a given number is prime or not
        {

            int check = 0;
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine("This is not a prime number");
                Console.ReadKey();
                return; 
            }

            else 
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        check++;
                        break;
                    }
                }
                if (check == 0 && num != 1)
                {
                    Console.WriteLine("This is a prime number");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("This is not a prime number");
                }
            }           
        }
    }
}

