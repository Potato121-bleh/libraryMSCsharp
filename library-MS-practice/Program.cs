using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_MS_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> userLists = new LinkedList<string>();
            string loginId = "";



            Book book = new Book();
            while (true) {

                userSelect userSelects = new userSelect();
                bool whileFlag = true;
                bool whileAuthFlag = true;
                while (whileAuthFlag)
                {
                    string authFlag = userSelects.askToAuth(userLists);
                    if (authFlag != "")
                    {
                        loginId = authFlag;
                        whileAuthFlag = false;
                        break;
                    }

                }
                Console.WriteLine("======================================");
                Console.WriteLine("Welcome to jampa library");
                BookManagement bookManagement = new BookManagement();
                bookManagement.libraryMenu(loginId);


            }

        }


        

    }

}
