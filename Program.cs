/*Benji Stansfield, 8-28-25, Lab 2 "Merge Sort"*/
using System.Diagnostics;
Console.Clear();

/*Non-Recursive Merging Tests*/
Debug.Assert(Enumerable.SequenceEqual(
    CombineSortedArrays(new int[]{1, 3, 5}, new int[]{-5, 3, 6, 7}),
    new int[]{-5, 1, 3, 3, 5, 6, 7}));
Debug.Assert(Enumerable.SequenceEqual(
    CombineSortedArrays(new int[]{-5, 2, 5, 8, 10}, new int[]{1, 2, 5}),
    new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));

/*Recursive Merging Tests*/
Debug.Assert(Enumerable.SequenceEqual(
    SortViaMergesort(new int[]{6, 1, -5, 3, 5, 3, 7}),
    new int[]{-5, 1, 3, 3, 5, 6, 7}));
Debug.Assert(Enumerable.SequenceEqual(
    SortViaMergesort(new int[]{1, 10, -5, 2, 5, 2, 5, 8}),
    new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));

Console.WriteLine("All tests passed!");

/*Non-recursive merge*/
int[] CombineSortedArrays(int[] a, int[] b)
{
    int[] combined = new int[a.Length + b.Length];
    int aIndex = 0;
    int bIndex = 0;

    for (int combinedIndex = 0; combinedIndex < combined.Length; combinedIndex++)
    {
        if (bIndex >= b.Length || (aIndex < a.Length && a[aIndex] <= b[bIndex]))
        {
            combined[combinedIndex] = a[aIndex];
            aIndex++;
        }
        else
        {
            combined[combinedIndex] = b[bIndex];
            bIndex++;
        }
    }

    return combined;
}

/*Recursive merge*/
int[] SortViaMergeSort(int[] values)
{
    
}
