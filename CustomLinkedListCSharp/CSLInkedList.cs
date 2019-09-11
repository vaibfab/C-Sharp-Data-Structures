using System;
using System.Collections.Generic;
using System.Reflection;
namespace CustomLinkedListCSharp
{
    class CSLinkedList
    {
        Node head;

        public CSLinkedList InsertNode(CSLinkedList list, int data)
        {

            Node newNode = new Node(data);

            if (list.head == null)
            {
                list.head = newNode;
                return list;
            }
            else
            {
                if (list.head.next == null)
                {
                    list.head.next = newNode;
                    return list;
                }
                Node lastNode = list.head;
                while (lastNode.next != null)
                    lastNode = lastNode.next;
                lastNode.next = newNode;
                return list;
            }
        }

        public void PrintList(CSLinkedList list)
        {
            if (list.head != null)
            {
                Node currNode = list.head;
                if (currNode.next == null)
                {
                    Console.WriteLine(list.head.data + "\t");
                    return;
                }
                while (currNode.next != null)
                {
                    Console.Write("\t" + currNode.data);
                    currNode = currNode.next;
                }
                Console.WriteLine("\t" + currNode.data);
            }
        }

        public void DeleteByKey(CSLinkedList list, int key)
        {
            if (list.head != null)
            {
                Node currNode = this.head;
                if (currNode.data == key)
                {
                    list.head = currNode.next;
                    Console.WriteLine("Key {0} found and deleted. Printing updated list...", key);
                    list.PrintList(list);
                    return;
                }
                else
                {
                    Node previousNode = currNode;
                    currNode = currNode.next;
                    while (currNode.next != null)
                    {
                        if (currNode.data == key)
                        {
                            previousNode.next = currNode.next;
                            Console.WriteLine("Key {0} found and deleted. Printing updated list...", key);
                            list.PrintList(list);
                            return;
                        }
                        previousNode = currNode;
                        currNode = currNode.next;

                    }
                    if (currNode.data == key)
                    {
                        previousNode.next = null;
                        Console.WriteLine("Key {0} found and deleted. Printing updated list...", key);
                        list.PrintList(list);
                        return;
                    }
                    Console.WriteLine("Key {0} not found. Printing list...", key);
                    list.PrintList(list);
                }
            }
        }
        public void InsertAtPosition(CSLinkedList list, int data, int position)
        {
            if (position > list.Length(list) + 1 || position < 1)
            {
                Console.WriteLine("Can't add to this position. Position doesn't exist");
                return;
            }
            else if (position == list.Length(list) + 1)
            {
                Console.WriteLine("List length is {0} and position is {1}.Appending at the end of the list", list.Length(list), position);
                list.InsertNode(list, data);
                list.PrintList(list);
            }
            else if (position == 1)
            {
                Console.WriteLine("Adding new node at the beginning of the list");
                Node newNode = new Node(data);
                Node currHead = list.head;
                list.head = newNode;
                newNode.next = currHead;
                list.PrintList(list);

            }
            else
            {
                int currPosition = 2;
                Node previousNode = list.head;
                Node currNode = previousNode.next;
                Node newNode = new Node(data);
                while (currNode.next != null)
                {
                    if (position == currPosition)
                    {
                        previousNode.next = newNode;
                        newNode.next = currNode;
                        Console.WriteLine("Adding new node at position {0}", position);
                        Console.WriteLine("Printing updated list...");
                        list.PrintList(list);
                        return;
                    }
                    previousNode = currNode;
                    currNode = currNode.next;
                    currPosition++;
                }
            }
        }

        public int Length(CSLinkedList list)
        {
            int length = 0;
            if (list.head == null)
                length = 0;
            else if (list.head.next == null)
                length = 1;
            else
            {
                Node currNode = list.head;
                while (currNode.next != null)
                {
                    length++;
                    currNode = currNode.next;
                }
                length++;
            }
            return length;
        }


    }

    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tCustom Linked List");
            Console.WriteLine("\t\t**************");
            CSLinkedList list = new CSLinkedList();
            list.InsertNode(list, 1);
            list.InsertNode(list, 2);
            list.InsertNode(list, 3);
            list.InsertNode(list, 5);
            list.PrintList(list);
            list.DeleteByKey(list, 3);
            list.DeleteByKey(list, 1);
            list.DeleteByKey(list, 7);
            Console.WriteLine("Adding a new element at the end of the list");
            list.InsertNode(list, 43);
            list.PrintList(list);
            Console.WriteLine("-------------------");
            list.PrintList(list);
            Console.WriteLine("Adding a new element at random positions in list");
            list.InsertAtPosition(list, 77, 6);
            list.InsertAtPosition(list, 77, 4);
            list.InsertAtPosition(list, 71, 1);
            list.InsertAtPosition(list, 73, 3);
            Console.ReadKey();
        }
    }
}
