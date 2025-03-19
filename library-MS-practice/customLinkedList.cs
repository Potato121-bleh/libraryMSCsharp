using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_MS_practice
{
    internal class customLinkedList
    {
        public string removeNode<T>(LinkedList<T> list, int index)
        {
            
            if (index > list.Count())
            {
                return "index out of bound";
            }
            LinkedListNode<T> selectedNode = retrieveNode(list, index);
            list.Remove(selectedNode.Value);
            return "";
        }

        public string insertNode<T>(LinkedList<T> list, int index, T value)
        {
            if (index > list.Count())
            {
                return "index out of bound";
            }

            LinkedListNode<T> selectedNode = retrieveNode(list, index);
            if (selectedNode != null)
            {
                list.AddBefore(selectedNode, value);
            }
            return "";
        }

        public LinkedListNode<T> retrieveNode<T>(LinkedList<T> list, int index)
        {
            LinkedListNode<T> current = list.First;
            for (int i = 0; i < list.Count(); i++)
            {
                if (i == index)
                {
                    return current;
                }
                current = current.Next;

            }
            return null;
        }

    }
}



// Usage:
//LinkedList<int> list = new LinkedList<int>();
//customLinkedList customLinkedList = new customLinkedList();

//list.AddFirst(1);
//list.AddFirst(54);
//list.AddFirst(10);
//list.AddLast(100);

//// 10, 54,  2000 , 1, 3000, 5000, 100
////customLinkedList.insertNode("", 1, 10);

//customLinkedList.insertNode(list, 3, 3000);
//customLinkedList.insertNode(list, 2, 2000);
//customLinkedList.insertNode(list, 5, 5000);
//customLinkedList.insertNode(list, 0, 0909);
//customLinkedList.removeNode(list, 0);
//customLinkedList.removeNode(list, 3);