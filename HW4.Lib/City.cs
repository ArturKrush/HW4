using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    public class City
    {
        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                if (value == " " || value == "   ")
                    throw new InvalidDataException("City must have a name.");
                name = value;
            }
        }
        private long population;
        public long Population
        {
            get { return population; }
            private set
            {
                if (value <= 0)
                    throw new InvalidDataException("City population must be higher than 0.");
                population = value;
            }
        }

        public City(string name, long population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, long inc)
        {
            return new City(city.Name, city.Population + inc);
        }

        public static City operator -(City city, long dec)
        {
            return new City(city.Name, city.Population - dec);
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }
    }
}
