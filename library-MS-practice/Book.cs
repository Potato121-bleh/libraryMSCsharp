using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_MS_practice
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsBorrowed { get; set; }
        public string CurrentBorrower { get; set; }
        public Queue<string> BorrowQueue { get; set; }
        public Stack<string> ReturnStack { get; set; } = new Stack<string>();



        public Book() { }
        public Book(int id, string title)
        {
            this.Id = id;
            this.Title = title;
            IsBorrowed = false;
            CurrentBorrower = null;
            BorrowQueue = new Queue<string>();

        }
        public override string ToString()
        {
            string status = CurrentBorrower == null ? "Available" : $"Borrowed by {CurrentBorrower}";
            return $"ID: {Id}, Title: {Title}, Status: {status}, Waiting: {BorrowQueue.Count} waiting";
        }





    }
}
