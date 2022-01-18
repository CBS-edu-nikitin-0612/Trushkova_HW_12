// See https://aka.ms/new-console-template for more information
using Task6;

Console.WriteLine("Hello, World!");

Address address = new Address();

address.Index = 115446;
address.Country = "РФ";
address.City = "Москва";
address.Street = "улица Кошечкина";
address.House = 12;
address.Apartment = 25;

Console.WriteLine(address.ToString());