using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HavePet = true;
            double MyShoeSize = 37.5;
            DaysOfWeek MyFavoriteDay;

            Console.WriteLine("My name is " + MyName);

            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + HavePet);
            Console.WriteLine("My shoe size is "+ MyShoeSize);

            MyFavoriteDay = DaysOfWeek.Friday;
            Console.WriteLine(MyFavoriteDay);

            byte age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine(age);


            Console.ReadKey();

         }
    }

    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thurday,
        Friday,
        Saturday,
        Sunday
    }

    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
