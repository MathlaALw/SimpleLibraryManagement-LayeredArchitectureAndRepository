using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    internal interface IBorrowRecordRepository
    {
        void AddBorrowRecord(BorrowRecord record);
        void DeleteBorrowRecord(int id);
        List<BorrowRecord> GetAllBorrowRecords();
        BorrowRecord GetBorrowRecord(int id);
        void UpdateBorrowRecord(BorrowRecord record);
        void DeleteBorrowRecord(int bookId, int memberId);
    }
}