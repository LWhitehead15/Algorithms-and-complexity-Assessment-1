using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Search and Sort application by Liam Whitehead (ID: 25698752)");

        int[] content = { };
        bool valid = false;

        content = Select();

        Console.WriteLine("\nWhich sort would you like to use?: Please enter the chosen index.");
        Console.WriteLine("0 for Bubble, 1 for Merge, 2 for insertion, 3 for Quick");

        while (valid == false)
        {
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                valid = true;
                content = Sort.BubbleSort(content);
            } else if (choice == "1")
            {
                valid = true;
                content = Sort.MergeSort(content, 0, content.Length - 1);
            } else if (choice == "2")
            {
                valid = true;
                content = Sort.InsertionSort(content);
            } else if (choice == "3")
            {
                valid = true;
                content = Sort.QuickSort(content, 0, content.Length - 1);
            } else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }
        }

            Output.Interval(content);



        // Continue additional tasks here.
    }

    static public int[] Select()
    {
        int[] content = { };
        string size = "";
        bool valid = false;

        while (valid == false)
        {
            Console.WriteLine("\nSelect file size: Enter 0 for 256 / Enter 1 for 2048");
            string choice = Console.ReadLine();
            if (choice == "0")
            {
                valid = true;
                // Select 256 size files.
                size = "256";
            }
            else if (choice == "1")
            {
                valid = true;
                // Select 2048 size files.
                size = "2048";
            }
            else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }
        }

        valid = false;
        while (valid == false)
        {
            Console.WriteLine("\nSelect a file: Enter 1 or 2 or 3 for file index.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                valid = true;
                content = Input.retrieve("1", size);
            }
            else if (choice == "2")
            {
                valid = true;
                content = Input.retrieve("2", size);
            }
            else if (choice == "3")
            {
                valid = true;
                content = Input.retrieve("3", size);
            } else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }
        }

        return content;
    }
}
