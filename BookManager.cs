using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_s
{
    //Класс BookManager для управления коллекцией книг
    public class BookManager
    {
        //Коллекция книг, хранящаяся в памяти
        private readonly List<Book> books = new List<Book>();

        //Добавляет новую книгу в коллекцию
        public void AddBook(string title, string author, int year)
        {
            var book = new Book(title, author, year);
            books.Add(book);
        }

        //Удаляет книгу из коллекции
        public void RemoveBook(Guid id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        //Находит книгу по названию, игнорируя регистр
        public List<Book> FindBookByName(string title)
        {
            return books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        //Находит книгу по автору, игнорируя регистр
        public List<Book> FindBookByAuthor(string author)
        {
            return books.Where(b => b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        //Возвращает все книги из коллекции
        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
