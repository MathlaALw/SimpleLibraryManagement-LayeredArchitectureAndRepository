using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    internal interface IBookRepository
    {
        void AddBook(Book book);
        void DeleteBook(int id);
        List<Book> GetAllBooks();
        Book GetBook(int id);
        void UpdateBook(Book book);
    }
}