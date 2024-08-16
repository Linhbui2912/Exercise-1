using System.Numerics;
namespace BTVN_Session_2
{
    internal class programBTVNss2
    {
        static void Main(string[] args)
        {
            baitap01();
            baitap02();
            baitap03();
            baitap04();
            baitap05();
            baitap06();
            baitap08();
            baitap09();
            baitap10();

        }


        static void baitap01() //to add/sum two numbers
        {
            Console.WriteLine("nhap so thu nhat:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine($"{num1}+{num2}={sum}");

            Console.ReadLine();
        }

        static void baitap02() //to swap values of two variables 
        {
            int a = 5; int b = 3;
            Console.WriteLine($"before swap a={a}, b={b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"after swap a={a}, b={b}");
            Console.ReadLine();
        }

        static void baitap03() //to multiply two floating point numbers
        {
            float num01, num02, kq;

            Console.WriteLine("nhap so thu nhat:");
            num01 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            num02 = Convert.ToSingle(Console.ReadLine());
            kq = num01 * num02;
            Console.WriteLine($"{num01}*{num02}={kq}");

            Console.ReadLine();
        }

        static void baitap04() //to convert feet to meter 
        {
            double feet, meter;

            Console.WriteLine("nhap feet:");
            feet = Convert.ToDouble(Console.ReadLine());
            meter = feet * 3.28084;
            Console.WriteLine($"{feet} feet = {meter} meter");

            Console.ReadLine();
        }

        static void baitap05() //to convert Celcius to Fahrenheit and vice versa 
        {
            double Fahrenheit, Celsius;
            Console.WriteLine("nhap do C:");
            Celsius = Convert.ToDouble(Console.ReadLine());
            Fahrenheit = Celsius / 33.8;
            Console.WriteLine($"{Celsius} do C bang {Fahrenheit} do F");

            Console.ReadLine();

            Console.WriteLine("nhap do F:");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Celsius = 33.8 * Fahrenheit;
            Console.WriteLine($"{Fahrenheit} do F bang {Celsius} do C");

            Console.ReadLine();
        }

        static void baitap06() //to find the size of data types
        {
            Console.WriteLine("sizeof(int): {0}", sizeof(int));
            Console.WriteLine("sizeof(float): {0}", sizeof(float));
            Console.WriteLine("sizeof(char): {0}", sizeof(char));
            Console.WriteLine("sizeof(double): {0}", sizeof(double));
            Console.WriteLine("sizeof(bool): {0}", sizeof(bool));

            Console.ReadLine();
        }

        static void baitap08() //to calculate area of circle
        {
            Console.WriteLine("Nhap ban kinh hinh tron:");
            double rad = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine("Dien tich hinh tron la:", +area);

            Console.ReadLine();
        }

        static void baitap09() //to calculate area of square
        {
            Console.WriteLine("Nhap canh hinh vuong:");
            double canhHv = Convert.ToDouble(Console.ReadLine());
            double DT = canhHv * canhHv;
            Console.WriteLine("Dien tich hinh vuong la:", +DT);

            Console.ReadLine();
        }

        static void baitap10() //to convert days to years, weeks and days
        {
            int givendays, days, years, weeks, daysinweek = 7;

            Console.WriteLine("Nhap so ngay can chuyen:");
            givendays = int.Parse(Console.ReadLine());

            years = givendays / 365;
            weeks = (givendays % 365) / daysinweek;
            days = (givendays % 365) % daysinweek;

            Console.WriteLine("{0} tuong duong vơi {1} nam, {2} tuan and {3} ngay", givendays, years, weeks, days);

            Console.ReadLine();
        }
    }
}