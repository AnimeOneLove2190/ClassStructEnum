using System;

namespace TemporaryXyita
{
    class Program
    {
        static void Main(string[] args)
        {
            Song songOne = new Song();
            songOne.name = "Dream War";
            songOne.author = "Nomico";
            songOne.dura = 395;
            Song songTwo = new Song();
            songTwo.name = "Autum Wind";
            songTwo.author = "DVRST";
            songTwo.dura = 129;
            int resultOneOne = songOne.dura / 60;
            int resultOneTwo = songOne.dura % 60;
            int resultOneThree = resultOneTwo / 10;
            int resultTwoOne = songTwo.dura / 60;
            int resultTwoTwo = songTwo.dura % 60;
            int resultTwoThree = resultTwoTwo / 10;

            if (songOne.dura < songTwo.dura)
            {
                if (resultOneThree >= 1)
                {
                    Console.WriteLine($"{songOne.author} - {songOne.name} {resultOneOne}:{resultOneTwo}");
                }
                else
                {
                    Console.WriteLine($"{songOne.author} - {songOne.name} {resultOneOne}:0{resultOneTwo}");
                }
            }
            else
            {
                if (resultTwoThree >= 1)
                {
                    Console.WriteLine($"{songTwo.author} - {songTwo.name} {resultTwoOne}:{resultTwoTwo}");
                }
                else
                {
                    Console.WriteLine($"{songTwo.author} - {songTwo.name} {resultTwoOne}:0{resultTwoTwo}");
                }
            }
            Console.WriteLine("кек");
        }
    }
}
