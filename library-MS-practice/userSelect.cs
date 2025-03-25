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

            browserHistory Bhistory = new browserHistory("login");
            Bhistory.visit("signup");
            string userAuthSel = "";
            string userPage = "signup";
            bool pageflag = true;
            while (pageflag)
            {
                Console.Clear();
                Console.WriteLine("You currently on page: " + userPage);
                Console.WriteLine("1 - " + userPage);
                Console.WriteLine("2 - backward");
                Console.WriteLine("3 - forward");
                Console.WriteLine("4 - exit");
                string userCommand = Console.ReadLine();
                switch (userCommand)
                {
                    case "1":
                        userAuthSel = userPage;
                        pageflag = false;
                        break;
                    case "2":
                        userPage = Bhistory.back();
                        break;
                    case "3":
                        userPage = Bhistory.forward();
                        break;
                    case "4":
                        System.Environment.Exit(0);
                        break;
                    default:
                        //Bhistory.visit(userCommand);
                        break;


                }
            }

            switch (userAuthSel)
            {
                case "login":
                    Console.WriteLine();
                    foreach (string i in userList)
                    {
                        Console.WriteLine($"{i}");
                    }
                    Console.WriteLine("Your ID: ");
                    string userId = Console.ReadLine();
                    if (userList.Find(userId) != null)
                    {
                        Console.WriteLine("Login Successfully");
                        return userId;
                    }
                    Console.WriteLine("Login Failed, user not found");
                    break;
                case "signup":
                    Console.WriteLine("Insert your new Id: ");
                    string newUserId = Console.ReadLine();
                    if (userList.Find(newUserId) == null)
                    {
                        if (newUserId != "")
                        {
                            userList.AddFirst(newUserId);
                        }
                    } else
                    {
                        Console.WriteLine("UserId already exist");
                    }
                        
                    break;
                case "":
                    Console.WriteLine("Seem like page are on empty string.");
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
                }
                return "";
        }
    }
}
