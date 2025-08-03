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
        public void BorrowBook(string bookId, string memberId)
        { 

        }

        public void ReturnBook(string bookId, string memberId)
        {

        }

        public void RegisterMember(Member member)
        {

        }


        public void AddBook(Book book)
        {


        }

    }
}