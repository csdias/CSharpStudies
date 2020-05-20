using System;

namespace Collections
{
    public partial class Program
    {

        static void Main(string[] args){
            BNode root = null;
            root = BinarySearchTree.insert(root, 3);
            root = BinarySearchTree.insert(root, 5);
            root = BinarySearchTree.insert(root, 4);
            root = BinarySearchTree.insert(root, 7);
            root = BinarySearchTree.insert(root, 2);
            root = BinarySearchTree.insert(root, 1);

            BinarySearchTree.traverseOnOrder(root);        

            //var count = BinarySearchTree.getHeight(root);
        }

        static void Main_LinkedList(string[] args){
            LinkedList linkedList = new LinkedList();
            Node node = linkedList.Add(3);
            linkedList.Add(5);
            node = linkedList.Add(6);
            linkedList.Add(9);
            Console.WriteLine($"{linkedList}");

            //linkedList.ReverseIteratively();
            //linkedList.ReverseRecursively();
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
