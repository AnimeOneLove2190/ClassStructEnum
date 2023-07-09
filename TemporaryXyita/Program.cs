using System;

namespace TemporaryXyita
{
    class Program
    {
        static void Main(string[] args)
        {
            Point cordOne = new Point();
            cordOne.x = 3;
            cordOne.y = 3;
            Point cordTwo = new Point();
            cordTwo.x = 6;
            cordTwo.y = 6;
            double resOne = (cordTwo.x - cordOne.x) * (cordTwo.x - cordOne.x) + (cordTwo.y - cordOne.y) * (cordTwo.y - cordOne.y);
            double resTwo = Math.Sqrt(resOne);
            Console.WriteLine(resTwo);
        }
    }
}
