using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories
{
    class BorrowRecordRepository : IBorrowRecordRepository
    {

        public void AddBorrowRecord(BorrowRecord record)
        {
            var records = GetAllBorrowRecords();
            records.Add(record);
            FileContext.SaveBorrowRecord(records);

        }

        public BorrowRecord GetBorrowRecord(int id)
        {
            return GetAllBorrowRecords().FirstOrDefault(r => r.Id == id);
        }

        public List<BorrowRecord> GetAllBorrowRecords()
        {
            return FileContext.LoadBorrowRecord();
        }

        public void UpdateBorrowRecord(BorrowRecord record)
        {
            var records = GetAllBorrowRecords();
            var index = records.FindIndex(r => r.Id == record.Id);
            if (index != -1)
            {
                records[index] = record;
                FileContext.SaveBorrowRecord(records);
            }
        }

        public void DeleteBorrowRecord(int id)
        {
            var records = GetAllBorrowRecords();
            var recordToRemove = records.FirstOrDefault(r => r.Id == id);
            if (recordToRemove != null)
            {
                records.Remove(recordToRemove);
                FileContext.SaveBorrowRecord(records);
            }
        }

    }
}
