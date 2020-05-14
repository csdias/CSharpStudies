using System;

namespace Collections
{
    public partial class Program
    {

        static void Main(){
            EmptyBST<int> bst = new EmptyBST<int>();
            var bt = bst.add(2);
        }

        static void Main_LinkedList(string[] args){
            LinkedList linkedList = new LinkedList();
            linkedList.computeDifference();
            // Node node = linkedList.Add(3);
            // linkedList.Add(5);
            // node = linkedList.Add(6);
            // linkedList.Add(9);
            // Console.WriteLine($"{linkedList}");

            // //linkedList.ReverseIteratively();
            // linkedList.ReverseRecursively();
        }

        static void Main_ArrayList(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayList<int> list = new ArrayList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);            
            list.Insert(200, 2);
        }        
    }
}
