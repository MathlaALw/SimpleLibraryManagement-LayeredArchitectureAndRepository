using SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();
            IMemberRepository memberRepository = new MemberRepository();
            IBorrowRecordRepository borrowRecordRepository = new BorrowRecordRepository();

            

        }
    }
}
