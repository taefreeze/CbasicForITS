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
            Volumn();
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
    }
}
