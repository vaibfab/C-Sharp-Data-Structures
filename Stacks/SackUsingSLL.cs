using System;

namespace Stacks
{
    class CustomStackSLL
    {
        Node topNode = null;

        public void Pop()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            if (topNode.GetNext() != null)
            {
                Console.WriteLine("{0} popped from the stack", topNode.GetData());
                topNode = topNode.GetNext();
            }
            else
            {
                Console.WriteLine("Popping out last element in the stack");
                Console.WriteLine("{0} popped from the stack", topNode.GetData());
                topNode = topNode.GetNext();
            }
        }

        public void Push(int data)
        {

            Node newNode = new Node(data);
            if (topNode == null)
            {
                newNode.SetNext(null);
                topNode = newNode;
            }
            else
            {
                newNode.SetNext(topNode);
                topNode = newNode;
            }
        }

        public void PrintStack()
        {
            Node currNode = topNode;
            if (currNode == null)
            {
                Console.WriteLine("No elements in Stack to print");
                return;
            }
            while (currNode.GetNext() != null)
            {
                Console.Write(currNode.GetData() + "\t");
                currNode = currNode.GetNext();
            }
            Console.WriteLine(currNode.GetData());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tStack Using LinkedList");
            Console.WriteLine("*************************************");
            CustomStackSLL stack = new CustomStackSLL();
            stack.Pop();
            stack.Push(62);
            stack.Push(98);
            stack.Push(118);
            stack.PrintStack();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.PrintStack();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\tStack Using Array");
            Console.WriteLine("*************************************");
            CustomStackArray arrStack = new CustomStackArray();
            arrStack.Pop();
            arrStack.Push(62);
            arrStack.Push(98);
            arrStack.Push(118);
            arrStack.PrintStack();
            arrStack.Pop();
            arrStack.Pop();
            arrStack.Pop();
            arrStack.Pop();
            arrStack.PrintStack();
            Console.ReadKey();
        }
    }

    class CustomStackArray
    {
         int top = -1;
        static int max = 5;
        int[] arr=new int[max];
        public void Push(int data)
        {
            if (top > max - 1)
            {
                Console.WriteLine("Stack Overflow!!!");
                return;
            }
            arr[++top] = data;
            Console.WriteLine("{0} added to stack, number of elems in stack after push is {1}", arr[top],top+1);
        }
        public void Pop()
        {
            if(top<0)
            {
                Console.WriteLine("stack underflow");
                return;
            }
            Console.WriteLine("Popped : {0} from the stack, Number of elems in stack after pop: {1}", arr[top--],top+1);
        }

        public void PrintStack()
        {
            if(top<0)
            {
                Console.WriteLine("No elements in stack to print");
                return;
            }
            Console.WriteLine("Printing Stack\n");
            var iter = top;
            while (iter >= 0)
            { 
                Console.Write(arr[iter--] + "\t");
                Console.WriteLine();
            }
        }

    }
    class Node
    {
        Node next;
        int data;
        public Node(int _data)
        {
            data = _data;
            next = null;
        }

        public int GetData()
        {
            return this.data;
        }

        public void SetData(int data)
        {
            this.data = data;
        }

        public Node GetNext()
        {
            return this.next;
        }
        public void SetNext(Node _next)
        {
            this.next = _next;
        }
    }
}
