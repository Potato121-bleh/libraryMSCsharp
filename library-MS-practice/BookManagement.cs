using library_MS_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_MS_practice
{
    internal class BookManagement
    {
        public static LinkedList<Book> bookList = new LinkedList<Book>();
        //public int bookListRange()
        //{
        //    return bookList.Count();
        //}

        //public LinkedList<Book> bookList = new LinkedList<Book>();
        private int originBookId = 0;

        

        public BookManagement()
        {
            if (bookList.Count == 0)
            {
                bookList.AddLast(new Book(101, "NiceI"));
                bookList.AddLast(new Book(102, "NiceII"));
                bookList.AddLast(new Book(103, "NiceIII"));
                bookList.AddLast(new Book(104, "NiceIV"));
                this.originBookId = 100 + bookList.Count();
            }
        }
            
            
        

        public string Insert(int index, Book book)
        {
            if (index < 0 || index > bookList.Count)
                return "!!!!!!!   Index out of bounds   !!!!!!!";

            if (index == 0)
            {
                bookList.AddFirst(book);
                return $"Inserted {book.Title} at index {index}";
            }
            else if (index == bookList.Count)
            {
                bookList.AddLast(book);
                return $"Inserted {book.Title} at index {index}";
            }

            LinkedListNode<Book> selectedNode = RetrieveNode(index);
            if (selectedNode != null)
            {
                bookList.AddBefore(selectedNode, book);
                return $"Inserted {book.Title} at index {index}";
            }
            return "Insertion failed";
        }

        public string Remove(int index)
        {
            if (index < 0 || index >= bookList.Count)
                return "!!!!!!!!!!!!! Index out of bounds !!!!!!!!!!!!";

            LinkedListNode<Book> selectedBook = RetrieveNode(index);
            if (selectedBook != null)
            {
                bookList.Remove(selectedBook);
                return $"Removed: {selectedBook.Value.Title} (ID: {selectedBook.Value.Id})";
            }
            return "!!!!!!!!!!!  Book not found !!!!!!!!!!!!!!";
        }
        public string RemoveById(int bookId)
        {
            LinkedListNode<Book> current = bookList.First;

            while (current != null)
            {
                if (current.Value.Id == bookId)
                {
                    bookList.Remove(current);
                    return $"Removed: {current.Value.Title} (ID: {bookId})";
                }
                current = current.Next;
            }

            return "!!!!!!!!!!!  Book not found  !!!!!!!!!!!!";
        }

        private LinkedListNode<Book> RetrieveNode(int index)
        {
            LinkedListNode<Book> current = bookList.First;
            for (int i = 0; i < bookList.Count(); i++)
            {
                if (i == index)
                {
                    return current;
                }
                current = current.Next;

            }
            return null;
        }


        public void DisplayBooks()
        {
          
            Console.WriteLine("Jampa library:");
            Console.WriteLine("---------------------------- Current Book List ----------------------------");
            if (bookList.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in bookList)
            {
                Console.WriteLine(book);
            }
        }
        /// add last
        public void AddBook(int id, string title)
        {
            Book newBook = new Book(id, title);
            
            Insert(bookList.Count, newBook);
            Console.WriteLine($"Added: {title} (ID: {id})");
        }


        /// add specific index
        public void AddBook(int id, string title, int index)
        {
            Book newBook = new Book(id, title);
            string result = Insert(index, newBook);
            Console.WriteLine(result);
        }

        private Book FindBookById(int id)
        {
            foreach (var book in bookList)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }




        //// Not yet check if user is exist or not
        public void BorrowBook(int id, string user)
        {
            Book book = FindBookById(id);
            if (book == null)
            {
                Console.WriteLine($"---------------------------- Book ID {id} not found.");
                return;
            }

            if (book.CurrentBorrower == null) 
            {
                book.CurrentBorrower = user;
                Console.WriteLine($"---------------------------- {user} borrowed '{book.Title}'.");
            }
            else
            {
                book.BorrowQueue.Enqueue(user);
                Console.WriteLine($"---------------------------- {user} added to the waiting list for '{book.Title}'.");
            }
        }


        public void ReturnBook(int id)
        {
            Book book = FindBookById(id);

            if (book == null || book.CurrentBorrower == null)
            {
                Console.WriteLine($"---------------------------- Book ID {id} is not currently borrowed.");
                return;
            }
            Console.WriteLine($"---------------------------- '{book.Title}' returned by {book.CurrentBorrower}.");

            book.ReturnStack.Push(book.CurrentBorrower);

            if (book.BorrowQueue.Count > 0)
            {
                book.CurrentBorrower = book.BorrowQueue.Dequeue(); 
                Console.WriteLine($"---------------------------- '{book.Title}' is now borrowed by {book.CurrentBorrower}.");
            }
            else
            {
                book.CurrentBorrower = null;
                Console.WriteLine($"---------------------------- '{book.Title}' is now available.");
            }
        }

        public void libraryMenu(string loginID)
        {
            Book book = new Book();
            bool whileFlag = true;
            while (whileFlag)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Delete a Book");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View All Books");
                Console.WriteLine("6. Logout");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    //// in this case ask user that they want to add specific index, so if the ans yes the method that has three param work
                    ////  if no method with 2 param work
                    case "1":
                        Console.Write("---------------------------- Enter Book Title: ");
                        string title = Console.ReadLine();
                        //Console.Write("Enter Book ID: ");
                        //int id = int.Parse(Console.ReadLine());
                        originBookId++;
                        int id = originBookId;
                        

                        Console.Write("---------------------------- Do you want to specify an index? (y/n): ");
                        string option = Console.ReadLine().ToLower();
                        if (option == "y")
                        {
                            Console.Write("---------------------------- Enter the index to insert at: ");
                            int index = int.Parse(Console.ReadLine());
                            AddBook(id, title, index);
                            DisplayBooks();
                        }
                        else
                        {
                            AddBook(id, title);
                            DisplayBooks();
                        }
                        break;
                    
                    case "2":
                        Console.WriteLine("---------------------------- You want to delete by book's ID or index\n Note wirte : index if u want dlt by index, write id if you want dlt by id");
                    
                        
                        string op2 = Console.ReadLine().ToLower(); 

                        if(op2 == "id")
                        {

                            Console.Write("---------------------------- Enter Id to delete: ");
                            int Id = int.Parse(Console.ReadLine());
                            
                            if (FindBookById(Id) != null)
                            {
                                string result = RemoveById(Id);
                                Console.WriteLine(result);
                                DisplayBooks();
                                
                            }
                            else
                            {
                                Console.WriteLine($"---------------------------- Book ID {Id} not found.");
                                DisplayBooks();
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("---------------------------- Enter index to delete: ");
                            int index = int.Parse(Console.ReadLine());
                            string result  = Remove(index);
                            Console.WriteLine(result);
                            DisplayBooks();
                        }
                        break;

                    case "3":
                        Console.Write("---------------------------- Enter Book ID to Borrow: ");
                        int borrowId = int.Parse(Console.ReadLine());
                        //Console.Write("Enter Your ID: ");
                        //string borrower = Console.ReadLine();
                        BorrowBook(borrowId, loginID);
         
                        DisplayBooks();
                        break;

                    case "4":
                        Console.Write("---------------------------- Enter Book ID to Return: ");
                        int returnId = int.Parse(Console.ReadLine());
                        ReturnBook(returnId);
                        DisplayBooks();
                        break;

                    case "5":                   
                        DisplayBooks();
                        break;
                    case "6":
                        Console.WriteLine("---------------------------- Log out, Successfully.");
                        whileFlag = false;
                        break;
                    case "7":
                        
                        Console.WriteLine("---------------------------- Exiting the system...");
                        System.Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("---------------------------- Invalid choice, try again.");
                        break;
                    
                }
            }
        }
    }
}
