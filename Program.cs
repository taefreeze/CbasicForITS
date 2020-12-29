using System;

namespace CBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\nWhat is your name? ");
            // var name = Console.ReadLine();
            // var date = DateTime.Now;
            // Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            // Console.Write("\nPress any key to exit");
            // Console.ReadKey(true);
            // Volumn();
            Console.WriteLine("Enter number a : ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b : ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is  : " + Add(a,b));
        }
        // ไม่คืนค่า และไม่รับพารมิเตอร์(input)
        static void Volumn()
        {
            int a = 5;
            int b = 5;
            int c = 5;
            int volumn = a * b * c;
            Console.WriteLine("The volumn of 3D is : " + volumn);
        }
        static int Add(int x,int y)
        {
            int result = x + y;
            return result;
        }
    }
}
