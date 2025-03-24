using practice_stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_MS_practice
{
    internal class userSelect
    {
  
        public string askToAuth(LinkedList<string> userList)
        {

            Console.WriteLine("Welcome to Jampa library Co.ltd");
            Console.WriteLine("1 to login");
            Console.WriteLine("2 to sign up");
            Console.WriteLine("3 to exit");
            string userAuthSel = Console.ReadLine();


            //while (true)
            //{
            //    Console.WriteLine("What is your next page?");
            //    Console.WriteLine("1 - Back");
            //    Console.WriteLine("2 - Forward");
            //    Console.WriteLine("3 - exit");
            //    string userCommand = Console.ReadLine();
            //    switch (userCommand)
            //    {
            //        case "1":
            //            //string userInput = Console.ReadLine();
            //            string userInpute = "Login";
            //            browserHistory Bhistorye = new browserHistory(userInpute);
            //            Bhistory.back();
            //            Console.WriteLine("Welcome Login Page");
            //            Console.WriteLine("Your ID: ");

            //            string userId = Console.ReadLine();
            //            if (userList.Find(userId) != null)
            //            {
            //                Console.WriteLine("Login Successfully");
            //                return userId;
            //            }

            //            break;
            //        case "2":
            //            string userInput2 = "Sign up";
            //            browserHistory Bhistory2 = new browserHistory(userInput2);
            //            Bhistory2.forward();
            //            break;
            //        case "3":
            //            System.Environment.Exit(0);
            //            break;
            //        default:
            //            //Bhistory.visit(userCommand);
            //            break;
            //    }
            //}

            switch (userAuthSel)
            {
                case "1":
                    Console.WriteLine("Your ID: ");
                    string userId = Console.ReadLine();
                    if (userList.Find(userId) != null)
                    {
                        Console.WriteLine("Login Successfully");
                        return userId;
                    }

                    break;
                case "2":
                    Console.WriteLine("Insert your new Id: ");
                    string newUserId = Console.ReadLine();
                    if (newUserId != "")
                    {
                        userList.AddFirst(newUserId);
                    }
                    break;
                case "3":
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
                }
                return "";
        }
    }
}
