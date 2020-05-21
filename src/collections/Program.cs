using System;

namespace Collections
{
    public partial class Program
    {

        static void Main_BST(string[] args){
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

        static void Main(string[] args){
            LinkedList linkedList = new LinkedList();
            Node node = linkedList.Add(2);
            node = linkedList.Add(5);
            node = linkedList.Add(6);
            node = linkedList.Add(9);
            //node = linkedList.Add(5);
            //node = linkedList.Add(9);
            //node = linkedList.Add(7);
            //node = linkedList.Add(7);

            //var b = linkedList.RemoveDuplicates(linkedList.Head);

            //Console.WriteLine($"{linkedList}");

            var n = linkedList.ReverseRecursively();
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
