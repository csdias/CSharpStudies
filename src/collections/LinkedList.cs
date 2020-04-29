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
    
        public LinkedList Reverse() {
            Node current = this.Head;
            Node next = null; 
            Node previous = null;

            while (current != null){

                next = current.Next;

                current.Next = previous;

                previous = current;
                
                current = next;
            }

            this.Head = previous;
            
            return this;
        }
        public LinkedList OldReverse() {
            Node current = this.Head;
            Node newTail = this.Head;
            Node previous; 
            Node next = this.Head.Next;
            while (next != null){
                previous = current;
                
                next = new Node(current.Value);
                next.Next = current.Next;

                current.Next.Next = previous;
            }
            newTail.Next = null;

            return this;
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
