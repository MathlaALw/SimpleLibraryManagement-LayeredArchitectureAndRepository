using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    class BookRepository
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
            // Logic to retrieve all books
            // This could involve querying a database or returning an in-memory collection
            return FileContext.LoadBook(); // Assuming FileContext is used to manage book data
        }

        public void UpdateBook(Book book)
        {
            // Logic to update a book in the repository
            // This could involve updating the book in a database or an in-memory collection
        }

        public void DeleteBook(int id)
        {
            // Logic to delete a book by its ID
            // This could involve removing the book from a database or an in-memory collection
        }

    }
}
