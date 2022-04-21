using System;

public class Sort
{
	// A method that exhanges array elements.
	static void Swap(int x, int y)
	{ x = y; y = x; }


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

			return input;
		}
		else
        {
			Console.WriteLine("\n Error! Not enough values to sort.");
			return input;
		}
	}

	// Merge method for the Merge-Sort.
	public static int[] Merge(int[] input, int left, int middle, int right)
	{
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

		for (int e = left; e < right; e++)
        {
			if (i == leftArr.Length)
			{
				input[e] = rightArr[j];
				j++;
			}
			else if (j == rightArr.Length)
            {
				input[e] = leftArr[i];
				i++;
            }
			else if (leftArr[i] <= rightArr[j])
			{
				input[e] = leftArr[i];
				i++;
			}
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
			// if there is less than one value, it cannot be sorted.
			Console.WriteLine("\n Error! Not enough values to sort.");
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
		for (int i = min; i <= max; i++)
        {
			if (input[i] > input[max])
            {
				pivot++;
				Swap(input[pivot], input[i]);
            }
        }

		pivot++;
		Swap(input[pivot], input[max]);
		return pivot;
    }


	// Insertion-Sort Algorithm.
	public static int[] InsertionSort(int[] input)
	{


		return input;
	}
}
