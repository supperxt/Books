using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_s
{
    //Класс Book представляет книгу с уникальным идентификатором, названием, автором и годом издания
    public class Book
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, {Year}";
        }
    }
}
