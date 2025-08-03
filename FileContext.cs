using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository
{
    class FileContext
    {
        private static string filePath = "Book.json";
        private static string memberFilePath = "Member.json";
        private static string borrowRecordFilePath = "BorrowRecord.json";

        // Load and Save methods for Book
        public static List<Book> LoadBook()
        {
            if (!File.Exists(filePath))
                return new List<Book>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
        }

        public static void SaveBook(List<Book> book)
        {
            var json = JsonSerializer.Serialize(book);
            File.WriteAllText(filePath, json);
        }

        // Load and Save methods for Member
        public static List<Member> LoadMember()
        {
            if (!File.Exists(memberFilePath))
                return new List<Member>();
            var json = File.ReadAllText(memberFilePath);
            return JsonSerializer.Deserialize<List<Member>>(json) ?? new List<Member>();
        }
        public static void SaveMember(List<Member> member)
        {
            var json = JsonSerializer.Serialize(member);
            File.WriteAllText(memberFilePath, json);
        }

        // Load and Save methods for BorrowRecord
        public static List<BorrowRecord> LoadBorrowRecord()
        {
            if (!File.Exists(borrowRecordFilePath))
                return new List<BorrowRecord>();
            var json = File.ReadAllText(borrowRecordFilePath);
            return JsonSerializer.Deserialize<List<BorrowRecord>>(json) ?? new List<BorrowRecord>();
        }
        public static void SaveBorrowRecord(List<BorrowRecord> borrowRecord)
        {
            var json = JsonSerializer.Serialize(borrowRecord);
            File.WriteAllText(borrowRecordFilePath, json);
        }
    }
}
