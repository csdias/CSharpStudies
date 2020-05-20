using System;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace Collections{
    public class BNode{
        public int value { get; set;}
        public BNode left, right = null;
        public BNode(int val)
        {
            this.value = val;
        }
    }

    public class BinarySearchTree{
        public static int getHeight(BNode root){
            var count = countNode(root);
            return count.value-1;
        }

    	public static void traverseOnlevelOrder(BNode root){

            Queue<BNode> queue = new Queue<BNode>();

            if(root != null)
                queue.Enqueue(root);

            while(queue.Count > 0){
                var n = queue.Dequeue();
                Console.Write(n.value + " ");
                if (n.left != null)
                    queue.Enqueue(n.left);
                if (n.right != null)
                    queue.Enqueue(n.right);
            }            
        }

    	public static void traverseOnOrder(BNode root){
            if(root != null){
                traverseOnOrder(root.left);
                Console.Write(root.value + " ");
                traverseOnOrder(root.right);
            }          
        }

        private static BNode countNode(BNode node){

            if(node.left == null && node.right == null)
            {
                node.value = 1;
                return node;
            }

            BNode left = null;
            if (node.left != null){
                 left = countNode(node.left);
                 left.value++;
            }

            BNode right = null;
            if (node.right != null){
                right = countNode(node.right);
                right.value++;
            }

            int countLeft = left?.value == null ? 0: left.value;
            int countRight = right?.value == null ? 0: right.value;            

            node.value = countLeft >= countRight? countLeft: countRight;

            return node;
        }


        public static BNode insert(BNode node, int val){
            BNode root = node;
            BNode newNode = null;

            if (node == null){
                return new BNode(val);
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