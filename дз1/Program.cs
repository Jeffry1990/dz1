using System;

namespace дз1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string placeOfWork;

            Console.Write("Как вас зовут: ");
            name = Console.ReadLine();
            Console.Write("Сколько вам лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кто вы по знаку зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Где вы работаете: ");
            placeOfWork = Console.ReadLine();

            Console.WriteLine("Вас зовут "+name+", вам "+age+"год, вы "+zodiacSign+" и работаете "+ placeOfWork + ".");
        }
    }
}
