using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Content
    {
        private string _summary = "";

        public string Summary
        {
            get
            {
                if (_summary != null)
                    return _summary;
                else
                    return "Содержание отсутствует.";
            }
            set => _summary = value;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Содержание книги: {_summary}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
