using System;
using System.Collections.Generic;

namespace Collections
{
    public class LinkedList
    {
        public Node Head { get; set; }
        int count = 0;
        public Node Add(int val)
        {
            Node node = new Node(val);

            if (Head == null)
            {
                Head = node;
                count++;
                return Head;
            }
            else
            {
                Node n = Head;
                while (n.Next != null)
                {
                    n = n.Next;
                }
                n.Next = node;
                count++;
                return Head;
            }
        }







        public LinkedList ReverseIteratively()
        {
            Node current = this.Head;
            Node next = null;
            Node previous = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            this.Head = previous;
            return this;
        }

        public LinkedList ReverseRecursively()
        {
            Node h = ReverseRecursively_aux(this.Head);

            this.Head = h;

            return this;
        }

        private Node ReverseRecursively_aux(Node node)
        {
            if (node == null || node.Next == null)
            {
                return node;
            }

            Node reversedListHead = null;
            reversedListHead = ReverseRecursively_aux(node.Next);
            node.Next.Next = node;
            node.Next = null;

            return reversedListHead;
        }

        public Node RemoveDuplicates(Node node){
            if(node == null || node.Next == null)
                return node;

            var root = node;

            while(node?.Next != null){

                while(node?.Value == node?.Next?.Value){
                    node.Next = node.Next?.Next;
                    count--;
                }
                
                node = node?.Next;
            }

            return root;
        }

    }

    public class Node
    {
        public Node(int val)
        {
            this.Value = val;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}