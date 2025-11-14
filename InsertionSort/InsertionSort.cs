// Define a generic class for insertion sort
//NOTE: Insertion Sort is an in-place sorting algorithm.
//      IT will MODIFY the original array
public class InsertionSort<T>
{
    // Method to sort an array of elements
    public void Sort(T[] elements)
    {
        int i = 1; // Start from the second element (index 1)
        
        // Loop through each element in the array
        while (i < elements.Length)
        {
            int j = i; // Set j to the current element's index
            
            // Keep moving the element left while it is smaller than the one before it
            while(j > 0 && Greater(elements[j-1], elements[j]))
            {
                Swap(elements, j, j-1); // Swap elements if the previous one is bigger
                j--; // Move to the previous index
            }
            i++; // Move to the next element in the array
        }
    }

    // Method to check if one element is greater than another
    public bool Greater(T x, T y)
    {
        // Use the default comparer for type T
        if(Comparer<T>.Default.Compare(x,y) > 0)
            return true; // Return true if x is greater than y
        return false; // Otherwise return false
    }

    // Method to swap two elements in an array
    public void Swap(T[] elements, int index0, int index1)
    {
        T temp = elements[index0]; // Store the first element temporarily
        elements[index0] = elements[index1]; // Put the second element in the first's place
        elements[index1] = temp; // Put the first element in the second's place
    }
}
