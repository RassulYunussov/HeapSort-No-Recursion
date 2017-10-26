using System;

namespace tt
{
    class Program
    {
        static void HeapSort(int []src)
        {
            for(int i = (src.Length-1)/2;i>=0;i--)
                Heapify(i,src.Length);
            for(int i = src.Length-1;i>=0;i--)
            {
                Swap(ref src[0],ref src[i]);
                Heapify(0,i);
            }
            void Heapify(int offset, int right)
            {
                while(offset<right)
                {
                     int l = offset*2;
                     int r = l+1;
                     int max = l<right&&src[offset]<src[l]?l:offset;
                     if(r<right&&src[max]<src[r])
                        max = r;
                     if(max==offset)
                        break;
                     Swap(ref src[offset],ref src[max]);
                     offset = max;
                }
            }
            void Swap(ref int left, ref int right)
            {
               int temp = left;
               left = right;
               right = temp;
            }
        }

       

        static void Main(string[] args)
        {
           int [] a = new int []{5,4,3,2,1};
           HeapSort(a);
        }
    }
}
