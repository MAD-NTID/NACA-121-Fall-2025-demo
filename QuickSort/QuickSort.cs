using System.Globalization;
using System.Security.Cryptography;

public class QuickSort<T>
{
    public void Sort(T[] values, int low, int hi, bool sortDescending=false)
    {
        //base case
        if(low>=hi || low < 0)
            return ;
        
        //find the pivot
        int pivot = Partition(values, low, hi, sortDescending);

        //recursively sort the subarray left(elements before the pivot)
        Sort(values, low, pivot-1, sortDescending);
        Sort(values, pivot+1, hi, sortDescending);

    }

    public void Swap(T[] values, int index1, int index2)
    {
        T temp = values[index1];
        values[index1] = values[index2];
        values[index2] = temp;
    }

    public int Partition(T[] values, int low, int hi, bool sortDescending = false)
    {
        //chose the last elements as pivot
        T pivot = values[hi];

        //start comparing for pivots from element position low -1
        int i = low-1;

        //loop through the sub arrays
        for(int j = low; j < hi; j++)
        {
            //if the current element is greater than or less than the pivot
            //then they go on the left side
            if(!sortDescending && Comparer<T>.Default.Compare(values[j], pivot) <= 0)
            {
                i++;
                Swap(values, i,j);
            }
            else if(sortDescending && Comparer<T>.Default.Compare(values[j], pivot) > 0)
            {
                i++;
                Swap(values, i,j);
            }
        }

        //move the pivot to it correct sorted position
        i++;
        Swap(values, i, hi);

        //return the index position of the pivot
        return i;
    }
}