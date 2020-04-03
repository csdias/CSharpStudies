using System;

namespace Collections
{
    public partial class Program
    {
        static void Main(string[] args){
            LinkedList linkedList = new LinkedList();
            Node node = linkedList.Add(5);
            node = linkedList.Add(6);
            Console.WriteLine($"{linkedList}");
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
