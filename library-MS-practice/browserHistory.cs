﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practice_stack
{
    public class browserHistory
    {
        private Stack<string> forwardStack = new Stack<string>();
        private Stack<string> backwardStack = new Stack<string>();
        private string currentPage;
        public browserHistory(string currentpage)
        {
            this.currentPage = currentpage;
            backwardStack.Push(currentPage);
            //Console.WriteLine("You currently visit: " + currentpage);
        }


        public void visit(string newPage)
        {
            this.currentPage = newPage;
            backwardStack.Push(newPage);
            forwardStack.Clear();
            //Console.WriteLine("You currently visit: " + this.currentPage);
        }

        public string back()
        {
            if (backwardStack.Count == 1)
            {
                Console.WriteLine("No Stack Found");
                //Console.WriteLine(backwardStack.Peek());
                return backwardStack.Peek();
            }
            
            forwardStack.Push(this.currentPage);
            backwardStack.Pop();
            this.currentPage = backwardStack.Peek();

            Console.WriteLine("You currently move back to: " + this.currentPage);
            return this.currentPage;
        }

        public string forward()
        {
            if (forwardStack.Count == 0) { 
                Console.WriteLine("No Stack Found");
                return backwardStack.Peek();
            }
            this.currentPage = forwardStack.Peek();
            forwardStack.Pop();
            backwardStack.Push(this.currentPage);
            Console.WriteLine("You currently forward to: " + this.currentPage);
            return this.currentPage;
        }


    }
}
