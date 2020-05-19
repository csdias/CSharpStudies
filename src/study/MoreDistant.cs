using System;

namespace Study
{
    public class MoreDistant
    {

        private int[] elements;

        public MoreDistant()
        {
            this.elements = new int[5] { 8, 19, 3, 2, 7 };
        }

        int maxDifference = 0;
        int difference = 0;
        int iEl = 0;
        int jEl = 0;
        public int computeDifference()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                iEl = this.elements[i];
                for (int j = i; j < this.elements.Length; j++)
                {
                    jEl = this.elements[j];
                    difference = (iEl - jEl < 0) ? jEl - iEl : iEl - jEl;
                    if (difference > maxDifference)
                        maxDifference = difference;

            }
                            }
            return maxDifference;
        }
    }
}



