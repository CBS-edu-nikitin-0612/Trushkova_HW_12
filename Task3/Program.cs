// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, Teacher!");

Console.WriteLine("Введите название книги:");
string titleOfBook = Console.ReadLine();
Console.WriteLine("Введите имя автора книги:");
string nameOfAuthor = Console.ReadLine();
Console.WriteLine("Введите содержание книги:");
string contentOfBook = Console.ReadLine();

Book book = new Book(titleOfBook, nameOfAuthor, contentOfBook);

book.Show();

