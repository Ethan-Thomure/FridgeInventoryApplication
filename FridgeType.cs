using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomureWeek8Task1
{
    internal class FridgeType
    {
        private string _name;
        private DateOnly _expirationDate;
        private int _units;
        private int _minimum;

        public FridgeType(string name, DateOnly expirationDate, int units, int minimum=0)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Units = units;
            _minimum = minimum;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value.Contains(";") ? value.Replace(";", ",") : value; }
        }
        public DateOnly ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public int Units
        {
            get { return _units; }
            set { _units = (value > 0) ? value : 0; }
        }

        public int Minimum
        {
            get { return _minimum; }
            set { _minimum = (value >= 0) ? value : 0; }
        }

        public override string ToString()
        {
            return Name + ";" + ExpirationDate.ToString() + ";" + Units + ";" + Minimum;
        }

        public static FridgeType ToFridgeType( String rawString)
        {
            string nextName = rawString.Split(";")[0];
            DateOnly nextExpirationDate = DateOnly.Parse(rawString.Split(";")[1]);
            int nextUnit = int.Parse(rawString.Split(";")[2]);
            int minimum = int.Parse(rawString.Split(";")[3]);

            return new FridgeType(nextName, nextExpirationDate, nextUnit, minimum);
        }
    }
}
