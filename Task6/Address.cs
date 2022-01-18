using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Address
    {
        int _index;
        string _country;
        string _city;
        string _street;
        int _house;
        int _apartment;

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public int House
        {
            get => _house;
            set => _house = value;
        }

        public int Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }

        public string Country
        {
            get
            {
                if (_country != null)
                    return _country;
                else
                    return "Название страны отсутствует.";
            }
            set => _country = value;
        }

        public string City
        {
            get
            {
                if (_city != null)
                    return _city;
                else
                    return "Название города отсутствует.";
            }
            set => _city = value;
        }

        public string Street
        {
            get
            {
                if (_street != null)
                    return _street;
                else
                    return "Название улицы отсутствует.";
            }
            set => _street = value;
        }

        public override string ToString()
        {
            string address = $"{_index}, {_country}, г. {_city}, {_street}, " +
                                         $"дом {_house}, квартира {_apartment}";
            return address;
        }
    }
}
