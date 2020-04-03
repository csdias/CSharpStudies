using System;

namespace Collections
{
    public class LinkedList {
        public Node Head { get; set; }
        int count = 0;
        public Node Add(int val) {
            Node node = new Node(val);

            if(Head == null){
                Head = node;
                count ++;
                return Head;
            }
            else{
                Node n = Head;
                while(n.Next != null){
                    n = n.Next;
                }
                n.Next = node;
                count++;
                return n;
            }
        }
    }

    public class Node {
        public Node(int val)
        {
            this.Value = val;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    
}
