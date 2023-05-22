using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public string Author
        {
            get { return author; }
            set
            {
                    if (char.IsDigit(value.Split(' ')[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }

                author = value;
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type: {GetType().Name}")
                         .AppendLine($"Title: {Title}")
                         .AppendLine($"Author: {Author}")
                         .AppendLine($"Price: {Price:f2}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
