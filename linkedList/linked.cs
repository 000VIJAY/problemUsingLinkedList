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
            Node node = new Node(dataOne);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine("Added list : " +temp.next.data );
        }
        public Node incert(int position , int data)
        {
                Node newNode = new Node(data);
            Node temp = head;
            if (position < 1)
            {
                Console.WriteLine("invalid position");
            }
            else if (position == 1)
            {
                Node node = newNode;
                node.next = temp;
                head = node;
                Console.WriteLine("incert new node : " +node.data);
            }
            else
            {
                int pos = 1;
                while (pos != position -1 )
                {
                    temp = temp.next;
                    pos++;
                }
                Node node = newNode;
                node.next = temp.next;
                temp.next = node;
                Console.WriteLine("inserted new node : " +node.data);
            }
            return head;  
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