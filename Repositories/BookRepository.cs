using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    class BookRepository : IBookRepository
    {

        public void AddBook(Book book)
        {
            var books = GetAllBooks();
            books.Add(book);
            FileContext.SaveBook(books);
        }

        public Book GetBook(int id)
        {
            return GetAllBooks().FirstOrDefault(b => b.Id == id);

        }

        public List<Book> GetAllBooks()
        {
            return FileContext.LoadBook();
        }

        public void UpdateBook(Book book)
        {
            var books = GetAllBooks();
            var index = books.FindIndex(a => a.Id == book.Id);
            if (index != -1)
            {
                books[index] = book;
                FileContext.SaveBook(books);
            }
        }

        public void DeleteBook(int id)
        {
            var books = GetAllBooks();
            var bookToRemove = books.FirstOrDefault(b => b.Id == id);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                FileContext.SaveBook(books);
            }
        }

        // get book by Id
        //public Book GetBookById(int id)
        //{
        //    return GetAllBooks().FirstOrDefault(b => b.Id == id);
        //}
    }
}
