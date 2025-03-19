using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_MS_practice
{
    internal class userSelect
    {
        public string askToAuth(
            //LinkedList<Dictionary<string, object>> 
            LinkedList<string>
            userList)
        {
            //Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            Console.WriteLine("Welcome to Jampa library Co.ltd");
            Console.WriteLine("1 to login");
            Console.WriteLine("2 to sign up");
            Console.WriteLine("3 to exit");
            string userAuthSel = Console.ReadLine();
            switch (userAuthSel)
            {
                case "1":
                    Console.WriteLine("Your ID: ");
                    string userId = Console.ReadLine();
                        if (userList.Find(userId) != null)
                        {
                            Console.WriteLine("Login Successfully");
                            return "logined";
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



        // // ZIN
        //public string askToAuth(
        //    LinkedList<Dictionary<string, object>> 
        //    //LinkedList<string>
        //    userList)
        //{
        //    //Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
        //    Console.WriteLine("Welcome to Jampa library Co.ltd");
        //    Console.WriteLine("1 to login");
        //    Console.WriteLine("2 to sign up");
        //    Console.WriteLine("3 to exit");
        //    string userAuthSel = Console.ReadLine();
        //    switch (userAuthSel)
        //    {
        //        case "1":
        //            Console.WriteLine("Your ID: ");
        //            string userId = Console.ReadLine();
        //            LinkedListNode<Dictionary<string, object>> current = userList.First;
        //            //LinkedListNode<string> current = userList.First;
        //            for (int i = 0; i < userList.Count(); i++)
        //            {
        //                current = current.Next;
        //                Dictionary<string, object> selectedDic = current.Value;
        //                //string selectedDic = current.Value;
        //                //Dictionary<string, object> selectedVal = userList.Find(selectedDic);
        //                if (selectedDic["userid"] == userId)
        //                {
        //                    Console.WriteLine("Login Successfully");
        //                    return "logined";
        //                }
        //            }
        //            break;
        //        case "2":
        //            Console.WriteLine("Insert your new Id: ");
        //            string newUserId = Console.ReadLine();
        //            if (newUserId == "")
        //            {

        //            }
        //            break;
        //        case "3":
        //            break;
        //        default:
        //            break;
        //    }
        //    return "";
        //}

    }
}
