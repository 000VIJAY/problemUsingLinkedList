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
            Console.WriteLine("Added list : " + temp.next.data);
        }
        public Node incert(int position, int data)
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
                Console.WriteLine("incert new node : " + node.data);
            }
            else
            {
                int pos = 1;
                while (pos != position - 1)
                {
                    temp = temp.next;
                    pos++;
                }
                Node node = newNode;
                node.next = temp.next;
                temp.next = node;
                Console.WriteLine("inserted new node : " + node.data);
            }
            return head;
        }
        public int search(int value)
        {

            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public Node removeLast()
        {

            Node node = head;

            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head.next == null)
            {
                Console.WriteLine("Last element :{0} ", node.data);
                head = null;
            }
            else
            {
                while (node.next.next != null)
                {
                    node = node.next;
                }
                Console.WriteLine("Last element :{0} ", node.next.data);
                node.next = null;
            }
            return node;
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
        public void delete(int data)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }
        public int size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
        public void Sort()
        {
            Node node; Node nodeOne;
            int temp;
            for (node = this.head; node.next != null; node = node.next)
            {
                for (nodeOne = node.next; nodeOne != null; nodeOne = nodeOne.next)
                {
                    if (node.data > nodeOne.data)
                    {
                        temp = node.data;
                        node.data = nodeOne.data;
                        nodeOne.data = temp;
                    }
                }
            }
        }
    }
}