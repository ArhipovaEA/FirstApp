using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string MyName = "Jane";
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
           */

            /*Практика анкетируем пользователя*/
            Console.WriteLine("Введите ваше имя:");
            var Name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0} и вам {1} лет", Name, Age);
            
            Console.WriteLine("Введите дату вашего рождения:");
            var Birthday = Console.ReadLine();
            Console.WriteLine("Ваш день рождения {0}", Birthday);


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
