using System;
//using System.Collections.Generic;

namespace Collections{
    public class Node{
        public int value { get; set;}
        public Node left, right = null;
        public Node(int val)
        {
            this.value = val;
        }
    }

    public class BinarySearchTree{
        static int count = 0;

        public static int getHeight(Node root){
            var count = countNode(root);
            return count.value-1;
        }

        private static Node countNode(Node node){

            if(node.left == null && node.right == null)
            {
                node.value = 1;
                return node;
            }

            Node left = null;
            if (node.left != null){
                 left = countNode(node.left);
                 left.value++;
            }

            Node right = null;
            if (node.right != null){
                right = countNode(node.right);
                right.value++;
            }

            int countLeft = left?.value == null ? 0: left.value;
            int countRight = right?.value == null ? 0: right.value;            

            node.value = countLeft >= countRight? countLeft: countRight;

            return node;
        }


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
                node.left = newNode;
            }

            return root;
        }
        
    }

}