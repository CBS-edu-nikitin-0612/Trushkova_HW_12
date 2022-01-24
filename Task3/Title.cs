namespace Task3
{
    internal class Title
    {
        private string _titleOfBook = "";

        public string TitleOfBook
        {
            get
            {
                if (_titleOfBook != null)
                    return _titleOfBook;
                else
                    return "Название книги отсутствует.";
            }
            set => _titleOfBook = value; 
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название книги: {_titleOfBook}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
