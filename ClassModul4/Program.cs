using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModul4
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.Arguments("Экспресс", "Купе", 16);
            train.Arguments1(198, 19);
            Console.ReadLine();

            Console.WriteLine("Выберите количество поездов: ");
            int countTrain = int.Parse(Console.ReadLine());
            Train[] train2 = new Train[countTrain];
            for(int i=0; i< countTrain; i++)
            {
                Console.WriteLine("Введите тип поезда: ");
                string nameType = Console.ReadLine();
                Console.WriteLine("Введите тип вагона: ");
                string wagonType = Console.ReadLine();
                Console.WriteLine("Введите место в вагоне: ");
                Random rand = new Random();
                int placeWagon = rand.Next(1,28);
                train2[i].Arguments(nameType, wagonType, placeWagon);
                Console.WriteLine("Введите скорость поезда: ");
                int speed = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество вагона: ");
                int wagonCount = rand.Next(10, 30);
                train2[i].Arguments1(speed, wagonCount);
                Console.ReadLine();
            }
        }
    }
}
