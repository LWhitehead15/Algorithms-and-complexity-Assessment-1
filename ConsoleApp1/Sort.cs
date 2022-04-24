using System;

public class Sort
{
	// Bubble-Sort Algorithm.
	public static int[] BubbleSort(int[] input)
	{
		int temp = input[0];

		for (int i = 0; i < input.Length; i++)
		{
			// Sort until array length has been reached.
			for (int j = i + 1; j < input.Length; j++)
			{
				// if value at index i > value at index j then swap.
				if (input[i] > input[j])
				{
					temp = input[i];
					input[i] = input[j];
					input[j] = temp;
				}
			}
		}
		return input;
	}


	// Merge-Sort Algorithm.
	public static int[] MergeSort(int[] input, int left, int right)
	{
		// Only sorts if there is more than one value.
		if (left < right)
		{
			int middle = (left + right) / 2;

			MergeSort(input, left, middle);
			MergeSort(input, middle + 1, right);

            Merge(input, left, middle, right);
		}
		else if (input.Length <= 1)
        {
			Console.WriteLine("\n Not enough values in file to sort. Please try again");
        }
		return input;
	}

	// Merge method for the Merge-Sort.
	public static int[] Merge(int[] input, int left, int middle, int right)
	{
		// i = left counter j = right counter
		int i = 0;
		int j = 0;

		// Left array is the beginning to the middle.
		// + 1 to become - 1 to the middle. This stops left overlapping right arrays.
		int[] leftArr = new int[middle - left + 1];
		// Reight array size is the length(right) minus half.
		int[] rightArr = new int[right - middle];

		// Copy elements from input starting from left. Paste to leftArray starting at 0.
		// Array range of left to the middle.
		Array.Copy(input, left, leftArr, 0, middle - left + 1);

		// Copy elements from input starting from middle + 1. Paste to rightArray starting at 0.
		// Array range of middle to right.
		Array.Copy(input, middle + 1, rightArr, 0, right - middle);

		// For each index value.
		for (int e = left; e < right + 1; e++)
        {
			// If left array is empty, current index value is a
			// right array index value. Increase right counter.
			if (i == leftArr.Length)
			{
				input[e] = rightArr[j];
				j++;
			}
			// If right array is empty, current index value is a
			// left array index value. Increase left counter.
			else if (j == rightArr.Length)
            {
				input[e] = leftArr[i];
				i++;
            }
			// If value at current left array index is less or equal
			// to value at current right array index. Current index value
			// is a left array index value. Increase left counter.
			else if (leftArr[i] <= rightArr[j])
			{
				input[e] = leftArr[i];
				i++;
			}
			// Else current index value is a right array index.
			// Increase right counter.
			else
			{
				input[e] = rightArr[j];
				j++;
            }
		}
		return input;
	}


	// Quick-Sort Algorithm.
	public static int[] QuickSort(int[] input, int min, int max)
	{
		// (min must be specified as zero) and (max as array.length - 1) when called.
		if (min >= max)
        {
			return input;
        }

		// split input array into 3 parts.
		// elements less than, equal to, or more than reference index.
		int pivotIndex = Partition(input, min, max);

		// Then sort the elements less than reference.
		QuickSort(input, min, pivotIndex - 1);

		// Then recursively sort the elements more than reference.
		QuickSort(input, pivotIndex + 1, max);

		// return the sorted array.
		return input;
	}

	// Method that returns the reference element index for dividing input array.
	static int Partition(int[] input, int min, int max)
    {
		int pivot = min - 1;
		// For each index in the input array.
		for (int i = min; i < max; i++)
        {
			// if the current index value is more than the end index value of input array.
			if (input[i] < input[max])
            {
				// Increase pivot and swap the value at the current pivot index with current index.
				pivot++;
				Swap(ref input[pivot], ref input[i]);
            }
        }
		// Increase pivot, swap value at pivot index with value at end index.
		pivot++;
		Swap(ref input[pivot], ref input[max]);

		// return the reference element index.
		return pivot;
    }

	// A method that exhanges array elements.
	static void Swap(ref int x, ref int y)
	{
		int t = x; x = y; y = t;
	}


	// Insertion-Sort Algorithm.
	public static int[] InsertionSort(int[] input)
	{
		int key = 0;
		int prev = 0;

		// Sort until array length has been reached.
		for (int i = 1; i < input.Length; i++)
        {
			// key is the current value. Prev is the previous value.
			key = input[i];
			prev = i - 1;

			// if prev value is more or equal to 0 and is more than current value.
			while (prev >= 0 && input[prev] > key)
            {
				// the current value replaces the previous location value.
				input[prev + 1] = input[prev];
				// previous location is now the index before itself.
				prev = prev - 1;
            }
			// Previous location value is replaced by current key value.
			input[prev + 1] = key;
        }

		return input;
	}
}
