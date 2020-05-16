using System;

namespace Collections{
    public class Node{
        public int value { get; }
        public Node left, right = null;
        public Node(int val)
        {
            this.value = val;
        }
    }

    public class BinarySearchTree{
        static int count = 0;

        public static Node insert(Node node, int val){
            Node root = node;
            Node newNode = null;

            if (node == null){
                return new Node(val);
            }

            if (val >= node.value){
                newNode = insert(node.right, val);
                node.right = newNode;
            }
            else{
                newNode = insert(node.left, val);
                node.right = newNode;
            }

            return root;
        }
        
    }

}