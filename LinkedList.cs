using System;

namespace LinkedList_all_
{
    class LinkedList
    {
        internal Node head;
        public static void Main(string[] args)
        { 
            LinkedList list = new LinkedList();
            list.head = new Node(56);
            Node second = new Node(30);
            Node third = new Node(70);
            list.head.next = second;
            second.next = third;
            Console.WriteLine(list.head.data);
            Console.WriteLine(second.data);
            Console.WriteLine(third.data);
        }
    }
}
