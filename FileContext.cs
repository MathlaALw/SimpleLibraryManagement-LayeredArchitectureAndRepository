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
    }
}
