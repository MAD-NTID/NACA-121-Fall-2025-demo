using System.Dynamic;

public class MergeSort<T>
{
    public T[] Sort(T[] elements)
    {
        int n = elements.Length;

        //the base case to stop if we already break down all elements to 1
        if(n == 1)
            return elements;

        int midpoint = (int)(n/2);

        T[] arrayOne = Copy(elements, 0, midpoint);
        T[] arrayTwo = Copy(elements, midpoint, n);

        //recursive mergesort
        arrayOne = Sort(arrayOne);
        arrayTwo = Sort(arrayTwo);

        return Merge(arrayOne, arrayTwo);

    }

    public T[] Copy(T[] elements, int start, int stop)
    {
        int size = stop - start;
        T[] copy = new T[size];

        int index = 0;
        for(int i = start; i < stop; i++)
        {
            copy[index] = elements[i];
            index++;
        }

        return copy;
    }

    public T[] Merge(T[] arrayA, T[] arrayB)
    {
        int lengthA = arrayA.Length;
        int lengthB = arrayB.Length;

        T[] c = new T[lengthA+ lengthB];

        int indexA = 0, indexB = 0, indexC = 0;


        //while a and b still have elements
        while(indexA < lengthA && indexB < lengthB)
        {
            T a = arrayA[indexA];
            T b = arrayB[indexB];

            if (Greater(a, b))
            {
                c[indexC] = b;
                indexB++;
            }
            else
            {
                c[indexC] = a;
                indexA++;
            }

            indexC++;
        }

        //we still have a
        while(indexA < lengthA)
        {
            T a = arrayA[indexA];
            c[indexC] = a;
            indexC++;
            indexA++;
        }

        //we still have b
        while(indexB < lengthB)
        {
            T b = arrayB[indexB];
            c[indexC] = b;
            indexC++;
            indexB++;
        }

        return c;
    }

    public bool Greater(T a, T b)
    {
        return Comparer<T>.Default.Compare(a,b)  == 1;
    }
}