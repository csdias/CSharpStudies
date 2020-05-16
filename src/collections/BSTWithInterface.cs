using System;

namespace Collections
{
    public interface ITree<T> where T: IComparable<T>
    {
        bool isEmpty();
        int cardinality();
        bool find(T elem);
        ITree<T> add(T elem); 
    }

    public class EmptyBST<T> : ITree<T> where T: IComparable<T>
    {
        public EmptyBST(){
        }

        public bool isEmpty(){
            return true;
        }
        public int cardinality(){
            return 0;
        }
        public bool find(T elem){
            return false;
        }

        public ITree<T> add(T elem){
            return new NonEmptyBST<T>(elem);
        }
        
    }

    public class NonEmptyBST<T>: ITree<T> where T : IComparable<T> {
        T data;
        ITree<T> left;
        ITree<T> right;
        
        public NonEmptyBST(T elem){
            data = elem;
            left = new EmptyBST<T>();
            right = new EmptyBST<T>();
        }

        public NonEmptyBST(T elem, ITree<T> leftTree, ITree<T> rightTree){
            data = elem;
            left = leftTree;
            right = rightTree;
        }        

        public bool isEmpty(){
            return false;
        }

        public int cardinality(){
            return 1 + left.cardinality() + right.cardinality();
        }

        public bool find(T elem){
            if (elem.CompareTo(data) == 0)
                return true;
            else if(elem.CompareTo(data) < 0)
                return left.find(data);
            else
                return right.find(data);
        }

        public ITree<T> add(T elem){
            if (elem.CompareTo(data) == 0)
                return this;
            else if (elem.CompareTo(data) < 0)
                return new NonEmptyBST<T>(elem, left.add(elem), right);
            else 
                return new NonEmptyBST<T>(elem, left, right.add(elem));
        }

    }    
}
