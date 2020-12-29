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
            // Console.WriteLine("Enter number a : ");
            // int a;
            // a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter number b : ");
            // int b;
            // b = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("The result is  : " + Add(a,b));
            Grade();
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
        static void Grade()
        {
            // input score from user
            int a,b,c,d,e;
            Console.WriteLine("Enter number a : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number b : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number c : ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number d : ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number e : ");
            e = int.Parse(Console.ReadLine());

            // result of score
            int result = a + b + c + d + e;
            if (result > 100)
                {
                    Console.WriteLine("Error");
                }
                else if (result >= 80)
                {
                    Console.WriteLine("Your grade is A");
                }
                else if (result >= 75)
                {
                    Console.WriteLine("Your grade is B+");
                }
                else if (result >= 70)
                {
                    Console.WriteLine("Your grade is B");
                }
                else if (result >= 65)
                {
                    Console.WriteLine("Your grade is C+");
                }
                else if (result >= 60)
                {
                    Console.WriteLine("Your grade is C");
                }
                else if (result >= 55)
                {
                    Console.WriteLine("Your grade is D+");
                }
                else if (result >= 50)
                {
                    Console.WriteLine("Your grade is D");
                }
                else 
                {
                    Console.WriteLine("Your grade is F");
                }

            //switch
            // switch (result)
            // {
            //     case > 100:
            //         Console.WriteLine("Error");
            //         Console.ReadLine();
            //         break;
            //     case >= 80:
            //         Console.WriteLine("Your grade is A");
            //         Console.ReadLine();
            //         break;
            //     case >= 75:
            //         Console.WriteLine("Your grade is B+");
            //         Console.ReadLine();
            //         break;
            //     case >= 70:
            //         Console.WriteLine("Your grade is B");
            //         Console.ReadLine();
            //         break;
            //     case >= 65:
            //         Console.WriteLine("Your grade is C+");
            //         Console.ReadLine();
            //         break;
            //     case >= 60:
            //         Console.WriteLine("Your grade is C");
            //         Console.ReadLine();
            //         break;
            //     case >= 55:
            //         Console.WriteLine("Your grade is D+");
            //         Console.ReadLine();
            //         break;
            //     case >= 50:
            //         Console.WriteLine("Your grade is D");
            //         Console.ReadLine();
            //         break;
            }
        }
    }
}
