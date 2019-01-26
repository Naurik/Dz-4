using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModul4
{
    public partial class Train
    {
        private int _speed;
        private int _wagonCount;

        #region Constructor
        public Train(int speed, int wagonCount)
        {
            SetSpeed(speed);
            SetWagonCount(wagonCount);
            Console.WriteLine("Скорость поезда - " + _speed);
            Console.WriteLine("Количество вагона - " + _wagonCount);
            Console.ReadLine();
        }
        #endregion

        #region Methods
        public int GetSpeed() { return _speed; }
        public void SetSpeed(int speed) { _speed = speed; }

        public int GetWagonCount() { return _wagonCount; }
        public void SetWagonCount(int wagonCount) { _wagonCount = wagonCount; }

        public void Arguments1(int speed, int wagonCount)
        {
            _wagonCount = wagonCount;
            _speed = speed;
            Console.WriteLine("Скорость поезда - " + _speed);
            Console.WriteLine("Количество вагона - " + _wagonCount);
            Console.ReadLine();
        }
        #endregion
    }
}
