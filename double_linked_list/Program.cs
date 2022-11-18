using System;

namespace double_linked_list
{
    class Node
    {
        /* Node class represent the node of doubly linked list
         * It consist of the information part and links to 
         * Its succending and precending
         * in terms of next and previous */
        public int noMhs;
        public string name;
        // Point to the succending node
        public Node next;
        // Point to the precending node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;
        // Constructor
        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the students: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ");
        }
    }
}