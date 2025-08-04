using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryManagement_LayeredArchitectureAndRepository.Models
{
    public class Book
    {

        // Properties 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
       // public int BookIdCounter { get; set; } = 0;


        // constructor 
        //public Book(int id, string title, string author, bool isAvailable)
        //{
            
        //    //BookIdCounter++;
        //    //id = BookIdCounter;
        //    Id = id;
        //    Title = title;
        //    Author = author;
        //    IsAvailable = isAvailable;
        //}
    }
}
