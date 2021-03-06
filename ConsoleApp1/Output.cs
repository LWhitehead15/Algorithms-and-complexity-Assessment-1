using System;

public class Output
{
    public static void Interval(int[] input)
    {

        //Perform interval output in ascending or descending.
        int freq = 0;
        bool valid = false;
        while (valid == false)
        {
            Console.WriteLine("\nWould you like to output the interval in Ascending or Descending order?:");
            Console.WriteLine("Enter 0 for Ascending, 1 for descending order");
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                valid = true;
            }
            else if (choice == "1")
            {
                valid = true;
                Array.Reverse(input, 0, input.Length);
            }
            else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }
        }

        if (input.Length > 256)
        {
            freq = 50;
        }
        else
        {
            freq = 10;
        }

        Console.WriteLine("\nDisplaying every " + freq + "th in sorted file.\n");

        for(int i = 0; i <= input.Length; i = i + freq)
        {
            Console.WriteLine(input[i]);
        }

        Console.WriteLine("\nNo more intervals available.");
    }

    public static int LinearSearch(int value, int[] input, int steps)
    {
        List<int> index = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            steps++;
            if (value == input[i])
            {
                steps++;
                index.Add(i + 1);
            } else if (index.Count > 0 && value != input[i])
            {
                break;
            }
        }

       if (index.Count > 0)
        {
            Console.WriteLine("\n" + input[index[0]] + " was found at positions " + string.Join(", ", index) + ".");
        }
        else if (index.Count == 0)
        {
            Console.WriteLine("\nThe value you are searching could not be found.");
            Console.WriteLine("The closest values are...");

            closest(value, input, steps, 1, index);
            closest(value, input, steps, -1, index);

            if(index.Count == 0)
            {
                Console.WriteLine("\nInput much greater than any values in the file. No close values.");
            }
        }
       return steps;
    }

    public static int closest(int value, int[] input, int steps, int dir, List<int> index)
    {
        int search = 0;
        bool found = false;
        index.Clear();

        for (int i = 0; i < input.Length; i++)
        {
            steps++;
            search = value - (dir*i);
            foreach (int e in input)
            {
                steps++;
                if (search == e)
                {
                    for (int r = 0; r < input.Length; r++)
                    {
                        steps++;
                        if (search == input[r])
                        {
                            steps++;
                            index.Add(r + 1);
                            found = true;
                        } else if (found == true && search != input[r])
                        {
                            Console.WriteLine(search + " at positions " + string.Join(", ", index) + ".");
                            break;
                        }
                    }
                    if (found == true && e == input.Last())
                    {
                        Console.WriteLine(search + " at positions " + string.Join(", ", index) + ".");
                        break;
                    }
                }
                if (found == true)
                {
                    break;
                }
            }
            if (found == true)
            {
                break;
            }
        }
        return steps;
    }

    public static int BinarySearch(int[] input, int value, int steps)
    {
        List<int> index = new List<int>();

        int min = 0;
        int max = input.Length - 1;
        bool found = false;

        while (max >= min)
        {
            steps++;
            int mid = (max + min) / 2;
            if (value == input[mid])
            {
                for (int r = 0; r < input.Length; r++)
                {
                    steps++;
                    if (value == input[r])
                    {
                        steps++;
                        index.Add(r + 1);
                        found = true;
                    }
                    if(found == true && value != input[r])
                    {
                        Console.WriteLine(value + " at positions " + string.Join(", ", index) + ".");
                        found = false;
                        return steps;
                    }
                }
                if (found == true && index.Count > 0)
                {
                    Console.WriteLine(value + " at positions " + string.Join(", ", index) + ".");
                    return steps;
                }

            }
            else if (value < input[mid])
            {
                steps++;
                max = mid - 1;
            }
            else if (value > input[mid])
            {
                steps++;
                min = mid + 1;
            }
        }

        if (index.Count == 0)
        {
            Console.WriteLine("\nThe value you are searching could not be found.");
            Console.WriteLine("The closest values are...");

            closest(value, input, steps, 1, index);
            closest(value, input, steps, -1, index);

            if (index.Count == 0)
            {
                Console.WriteLine("\nInput much greater than any values in the file. No close values.");
            }
        }

        return steps;
    }
}
