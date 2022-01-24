namespace Task3
{
    internal class Author
    {
        private string _name = "";

        public string Name
        {
            get
            {
                if (_name != null)
                    return _name;
                else
                    return "Имя автора отсутствует.";
            }
            set => _name = value; 
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Имя автора: {_name}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
