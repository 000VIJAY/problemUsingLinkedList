using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class linked
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            this.head = node;
            Console.WriteLine("starting Node : " + head.data);
        }
        public void AddOne(int dataOne)
        {
            Node nodeOne = new Node(dataOne);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = nodeOne;
        Console.WriteLine("inserted in Linked list: {0}", nodeOne.data);
        }
        
        public void Show()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}