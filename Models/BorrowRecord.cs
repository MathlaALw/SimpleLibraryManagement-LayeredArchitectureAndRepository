using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Models
{
    class BorrowRecord
    {
        // Properties Id, MemberId, BookId, BorrowDate, ReturnDate
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable to allow for books that haven't been returned yet
        
        // Navigation properties
        public Member Member { get; set; }
        public Book Book { get; set; }

    }
}
