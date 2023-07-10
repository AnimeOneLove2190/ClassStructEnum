﻿using System;

namespace ClassStructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание1
            Person personOne = new Person();
            personOne.name = Console.ReadLine();
            personOne.age = int.Parse(Console.ReadLine());
            personOne.weight = int.Parse(Console.ReadLine());
            Person personTwo = new Person();
            personTwo.name = Console.ReadLine();
            personTwo.age = int.Parse(Console.ReadLine());
            personTwo.weight = int.Parse(Console.ReadLine());
            if (personOne.weight < personTwo.weight)
            {
                Console.WriteLine($"{personOne.name}");
            }
            else
            {
                Console.WriteLine($"{personTwo.name}");
            }
            if (personOne.age < personTwo.age)
            {
                Console.WriteLine($"{personOne.name}");
            }
            else
            {
                Console.WriteLine($"{personTwo.name}");
            }
            //Задание2
            Time TimeOne = new Time();
            TimeOne.hours = int.Parse(Console.ReadLine());
            TimeOne.minutes = int.Parse(Console.ReadLine());
            TimeOne.seconds = int.Parse(Console.ReadLine());
            bool condOne = (TimeOne.hours >= 0) && (TimeOne.hours < 24);
            bool condTwo = (TimeOne.minutes >= 0) && (TimeOne.hours < 60);
            bool condThree = (TimeOne.seconds >= 0) && (TimeOne.seconds < 60);
            bool condFour = condOne && condTwo && condThree;
            Console.WriteLine(condFour);
            //Задание3
            int numberOne = int.Parse(Console.ReadLine());
            MessageStatus someTextOne = (MessageStatus)numberOne;
            if (someTextOne == MessageStatus.sent)
            {
                Console.WriteLine($"Сообщение отправлено");
            }
            if (someTextOne == MessageStatus.delivered)
            {
                Console.WriteLine($"Сообщение доставлено");
            }
            if (someTextOne == MessageStatus.read)
            {
                Console.WriteLine($"Сообщение прочитано");
            }
            //Задание4
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
                //Задание5
                Point cordOne = new Point();
                cordOne.x = 3;
                cordOne.y = 3;
                Point cordTwo = new Point();
                cordTwo.x = 6;
                cordTwo.y = 6;
                double resOne = (cordTwo.x - cordOne.x) * (cordTwo.x - cordOne.x) + (cordTwo.y - cordOne.y) * (cordTwo.y - cordOne.y);
                double resTwo = Math.Sqrt(resOne);
                Console.WriteLine(resTwo);
                //Задание6
                int someIntNumberOne = int.Parse(Console.ReadLine());
                AccessType someTextTwo = (AccessType)someIntNumberOne;
                if (someTextTwo == AccessType.Creation)
                {
                    Console.WriteLine($"Доступно создание");
                }
                if (someTextTwo == AccessType.Removal)
                {
                    Console.WriteLine($"Доступно удаление");
                }
                if (someTextTwo == AccessType.Reading)
                {
                    Console.WriteLine($"Доступно чтение");
                }
                if (someTextTwo == AccessType.Update)
                {
                    Console.WriteLine($"Доступно обновление");
                }

            }
        }
    }
}
