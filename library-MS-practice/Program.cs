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
            customLinkedList customLinkedList = new customLinkedList();
            userSelect userSelects = new userSelect();
            bool whileFlag = true;
            bool whileAuthFlag = true;
            while (whileAuthFlag) { 
                string authFlag = userSelects.askToAuth(userLists);
                if (authFlag == "logined") {
                    whileAuthFlag = false;
                    continue;
                }
            }
            Console.WriteLine("Welcome to jampa library");
            while (whileFlag) {
                whileFlag = false;
            }

            //foreach (int s in list) { 
            //    Console.WriteLine(s);
            //}

        }

    }
}
