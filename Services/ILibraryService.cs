using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Services
{
    internal interface ILibraryService
    {
        void AddBook(Book book);
        void BorrowBook(int bookId, int memberId);
        void RegisterMember(Member member);
        void ReturnBook(int bookId, int memberId);
        void ViewAllBooks();
        void ViewAllMembers();
    }
}