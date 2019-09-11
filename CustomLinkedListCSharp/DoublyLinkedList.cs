using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedListCSharp
{

    class BiDirectionalNode
    {
        private BiDirectionalNode next;
        private BiDirectionalNode prev;
        private int data;
        public BiDirectionalNode(int _data)
        {
            this.data = _data;
            this.next = null;
            this.prev = null;
        }
        public int GetData()
        {
            return this.data;
        }
        public BiDirectionalNode GetNext()
        {
            return this.next;
        }
        public BiDirectionalNode GetPrev()
        {
            return this.prev;
        }

        public void SetNext(BiDirectionalNode _next)
        {
            this.next = _next;
        }
        public void SetPrev(BiDirectionalNode _prev)
        {
            this.prev = _prev;
        }
    }
    class DoublyLinkedList
    {
        BiDirectionalNode head;
        BiDirectionalNode tail;
        public void InsertNode(int data)
        {
            if(head==null)
            {
                head = new BiDirectionalNode(data);
                head.SetNext(null);
                head.SetPrev(null);
                tail = head;
            }
            else
            {
                BiDirectionalNode newNode = new BiDirectionalNode(data);
                newNode.SetPrev(tail);
                newNode.SetNext(null);
                tail.SetNext(newNode);
                tail = newNode;
            }
        }
        public void PrintDLL()
        {
            BiDirectionalNode currNode = head;
            while(currNode!=tail)
            {
                Console.WriteLine("\t{0}\t", currNode.GetData());
                currNode = currNode.GetNext();
            }
            Console.WriteLine("\t{0}\t", tail.GetData());
        }
    }

    //class TestMain
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("\t\tDLL");
    //        Console.WriteLine("*****************************");
    //        DoublyLinkedList list = new DoublyLinkedList();
    //        list.InsertNode(4);
    //        list.InsertNode(5);
    //        list.InsertNode(61);
    //        list.InsertNode(54);
    //        list.InsertNode(1231);
    //        list.PrintDLL();
    //    }
    //}
}
