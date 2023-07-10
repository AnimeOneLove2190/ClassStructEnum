using System;

namespace TemporaryXyita
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            AccesType someText = (AccesType)numberOne;
            if (someText == AccesType.Creation)
            {
                Console.WriteLine($"Доступно создание");
            }
            if (someText == AccesType.Removal)
            {
                Console.WriteLine($"Доступно удаление");
            }
            if (someText == AccesType.Reading)
            {
                Console.WriteLine($"Доступно чтение");
            }
            if (someText == AccesType.Update)
            {
                Console.WriteLine($"Доступно обновление");
            }
        }
    }
}
