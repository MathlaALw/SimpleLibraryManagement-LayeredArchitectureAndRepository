using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Services
{
    class LibraryService 
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IBorrowRecordRepository _borrowRecordRepository;


        public LibraryService(IBookRepository bookRepository, IMemberRepository memberRepository, IBorrowRecordRepository borrowRecordRepository)
        {
            _bookRepository = bookRepository;
            _memberRepository = memberRepository;
            _borrowRecordRepository = borrowRecordRepository;
        }
        public void BorrowBook(int bookId, int memberId)
        {

            var book = _bookRepository.GetBook(bookId);
            var member = _memberRepository.GetMember(memberId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            if (member == null)
            {
                Console.WriteLine("Member not found.");
            }
            if (!book.IsAvailable)
            {
                Console.WriteLine("Book is not available for borrowing.");
            }
            book.IsAvailable = false;
            _bookRepository.UpdateBook(book);
            var borrowRecord = new BorrowRecord
            {
                BookId = book.Id,
                MemberId = member.Id,
                BorrowDate = DateTime.Now
            };
            _borrowRecordRepository.AddBorrowRecord(borrowRecord);

        }

        public void ReturnBook(int bookId, int memberId)
        {
            var book = _bookRepository.GetBook(bookId);
            var member = _memberRepository.GetMember(memberId);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }
            if (book.IsAvailable)
            {
                Console.WriteLine("Book is already available.");
                return;
            }
            book.IsAvailable = true;
            _bookRepository.UpdateBook(book);
            _borrowRecordRepository.DeleteBorrowRecord(bookId, memberId);

        }

        public void RegisterMember(Member member)
        {
            if (member == null)
            {
                Console.WriteLine("Member cannot be null.");
                return;
            }
            _memberRepository.AddMember(member);
            Console.WriteLine("Member registered successfully.");

        }


        public void AddBook(Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Book cannot be null.");
                return;
            }
            _bookRepository.AddBook(book);
            Console.WriteLine("Book added successfully.");

        }

    }
}