using System;

namespace UC5_RemoveFirstNode
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void AddAtFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                Console.WriteLine("{0} inserted into the linked list", node.data);
            }
            else
            {
                node.next = head;
                head = node;

                Console.WriteLine("{0} inserted into the linked list", node.data);
            }
        }

        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {

                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;//1000
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(50);
            list.Add(20);
            list.Add(16);
            list.AddAtFirst(84);
            list.AddAtFirst(11);
            list.AddAtFirst(16);
            list.InsertAtParticularPosition(2, 46);
            list.Display();
            Console.WriteLine("\nRemoving First node");
            list.RemoveFirstNode();
            Console.WriteLine();
            list.Display();
        }
    }
}
