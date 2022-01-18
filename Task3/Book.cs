using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;

        void InitializeBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public Book()
        {
            InitializeBook();
        }

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public Book(string title, string author, string content)
        {
            InitializeBook();
            this.title.TitleOfBook = title;
            this.author.Name = author;
            this.content.Summary = content;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

        #region Properties
        public Title Title
        {
            get
            {
                if (title != null)
                    return title;
                else
                    return default;
            }
            set => title = value;
        }

        public Author Author
        {
            get
            {
                if (author != null)
                    return author;
                else
                    return default;
            }
            set => author = value;
        }

        public Content Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return default;
            }
            set => content = value;
        }
        #endregion
    }
}
