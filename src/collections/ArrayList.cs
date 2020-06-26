using System;

namespace Collections
{
    public partial class ArrayList
    {
    }

    public class ArrayList<T>{

        T[] internalStorage;
        int lastItemIndex;

        public ArrayList()
        {
            internalStorage = new T[4];
            lastItemIndex = -1;
        }

        public void Add(T item){

            if (lastItemIndex == internalStorage.Length - 1)
                ExpandStorage();

            internalStorage[lastItemIndex + 1] = item;
            lastItemIndex++;
        }

        public void Insert(T item, int index){
            Validate(index);

            if (lastItemIndex == internalStorage.Length - 1)
                ExpandStorage();

            int segment = lastItemIndex - index + 1;

            Array.Copy(internalStorage, index, internalStorage, index + 1, segment);

            internalStorage[index] = item;

            lastItemIndex++;
        }

        private void Validate(int index){
            if (index == -1 || index > lastItemIndex)
                throw new ArgumentOutOfRangeException();
        }

        private void ExpandStorage(){
            T[] newStorage = new T[internalStorage.Length * 2];
            Array.Copy(internalStorage, newStorage, internalStorage.Length - 1);

            internalStorage = newStorage;
        }

        public T this[int index] { 
            get { return internalStorage[index]; }
            set { internalStorage[index] = value; }
        }

        public int Length { get { return internalStorage.Length;} }
    
    }
}


class ArraysStudies {
  public static void Main_ (string[] args) {

    //jagged
    int[][] arJ = new int[5][];
    arJ[0] = new int[2];
    arJ[1] = new int[1];
    arJ[2] = new int[2];
    arJ[3] = new int[1];
    arJ[4] = new int[0];
    Console.WriteLine("\n");
    for(var a = 0; a < arJ.Length; a++){
      for(var b = 0; b < arJ[a].Length; b++){
        Console.WriteLine($"a{a}b{b} arJ[a][b] {arJ[a][b]}");
      };
    }
    Console.WriteLine("\n");    
    //multi
    //int[,,] arM = new int[2,4,3]; //or
    int[,,] arM = {{{1,2,3},{4,5,6},{7,8,9},{10,11,12}},{{13,14,15},{16,17,18},{19,20,21},{22,23,24}}};
    Console.WriteLine($"arM[1,1,1] {arM[1,1,1]}");
    Console.WriteLine($"arM.Length {arM.Length}");
    Console.WriteLine($"arM.Rank {arM.Rank}");
    for(int r = 0; r < arM.Rank; r++){
      Console.WriteLine($"Dimension {r+1} {arM.GetUpperBound(r)+1}");
    }
    Console.WriteLine("\n");
    foreach(var a in arM){
      Console.WriteLine(a);
    }

  }

}
