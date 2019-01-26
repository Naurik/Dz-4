using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModul4
{
    public partial class Train
    {
        private string _nameType;
        private string _wagonType;
        private int _placeWagon;


        #region Constructor
        public Train() { }
        public Train(string nameType, string wagonType, int placeWagon)
        {
            SetNameType(nameType);
            SetWagonType(wagonType);
            SetPlaceWagon(placeWagon);
            Console.WriteLine("Тип поезда - " + _nameType);
            Console.WriteLine("Тип вагона - " + _wagonType);
            Console.WriteLine("Место - " + _placeWagon);
            Console.ReadLine();
        }
        #endregion

        #region Методы
        public string GetNameType() { return _nameType; }
        public void SetNameType(string nameType) { _nameType = nameType; }

        public string GetWagonType() { return _wagonType; }
        public void SetWagonType(string wagonType) { _wagonType = wagonType; }

        public int GetPlaceWagon() { return _placeWagon; }
        public void SetPlaceWagon(int placeWagon) { _placeWagon = placeWagon; }

        public void Arguments(string nameType, string wagonType, int placeWagon)
        {
            _nameType = nameType;
            _wagonType = wagonType;
            _placeWagon = placeWagon;
            Console.WriteLine("Тип поезда - " + _nameType);
            Console.WriteLine("Тип вагона - " + _wagonType);
            Console.WriteLine("Место - " + _placeWagon);
            Console.ReadLine();
        }
        #endregion


    }
}
