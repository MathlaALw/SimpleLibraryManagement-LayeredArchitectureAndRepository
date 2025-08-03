using SimpleLibraryManagement_LayeredArchitectureAndRepository.Models;
using SimpleLibraryManagement_LayeredArchitectureAndRepository.Repositories;
using SimpleLibraryManagement_LayeredArchitectureAndRepository.Services;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();
            IMemberRepository memberRepository = new MemberRepository();
            IBorrowRecordRepository borrowRecordRepository = new BorrowRecordRepository();

            ILibraryService libraryService = new LibraryService(bookRepository, memberRepository, borrowRecordRepository);

            while (true)
            {
                Console.WriteLine("Welcome to the Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Member");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. View All Books");
                Console.WriteLine("6. View All Members");
                Console.WriteLine("7. View All Borrow Records");
                Console.WriteLine("8. Exit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Add book logic
                        Console.WriteLine("Enter book title:");
                        var title = Console.ReadLine();
                        Console.WriteLine("Enter book author:");
                        var author = Console.ReadLine();
                        libraryService.AddBook(new Book
                        {
                            Title = title,
                            Author = author,
                            IsAvailable = true
                        });

                        Console.WriteLine("Book added successfully.");

                        break;
                    case "2":
                        // Add member logic
                        Console.WriteLine("Enter member name:");
                        var memberName = Console.ReadLine();
                        libraryService.RegisterMember(new Member
                        {
                            Name = memberName
                        });
                        Console.WriteLine("Member added successfully.");
                        break;
                    case "3":
                        // Borrow book logic
                        Console.WriteLine("Enter book ID to borrow:");
                        if (int.TryParse(Console.ReadLine(), out int bookId))
                        {
                            Console.WriteLine("Enter member ID:");
                            if (int.TryParse(Console.ReadLine(), out int memberId))
                            {
                                libraryService.BorrowBook(bookId, memberId);
                                Console.WriteLine("Book borrowed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid member ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid book ID.");
                        }
                        break;
                    case "4":
                        // Return book logic
                        Console.WriteLine("Enter book ID to return:");
                        if (int.TryParse(Console.ReadLine(), out int returnBookId))
                        {
                            Console.WriteLine("Enter member ID:");
                            if (int.TryParse(Console.ReadLine(), out int returnMemberId))
                            {
                                libraryService.ReturnBook(returnBookId, returnMemberId);
                                Console.WriteLine("Book returned successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid member ID.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid book ID.");
                        }
                        break;
                    case "5":
                        // View all books logic
                        var books = bookRepository.GetAllBooks();
                        Console.WriteLine("List of all books:");
                        foreach (var book in books)
                        {
                            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Available: {book.IsAvailable}");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "6":
                        // View all members logic
                        var members = memberRepository.GetAllMembers();
                        Console.WriteLine("List of all members:");
                        foreach (var member in members)
                        {
                            Console.WriteLine($"ID: {member.Id}, Name: {member.Name}");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "7":
                        // View all borrow records logic
                        var borrowRecords = borrowRecordRepository.GetAllBorrowRecords();
                        Console.WriteLine("List of all borrow records:");
                        foreach (var record in borrowRecords)
                        {
                            Console.WriteLine($"ID: {record.Id}, Book ID: {record.BookId}, Member ID: {record.MemberId}, Borrow Date: {record.BorrowDate}");
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

            }
        }
    }
}
