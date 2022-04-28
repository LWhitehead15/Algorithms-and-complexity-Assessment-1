using System;

public class Program
{
    static void Main()
    {
        int[] content = { };
        string choice = "";
        bool valid = false;


        Console.WriteLine("Search and Sort application by Liam Whitehead (ID: 25698752)");
        // Call the file selecting method.
        content = Select();

        Console.WriteLine("\nWhich sort would you like to use?: Please enter the chosen index.");
        Console.WriteLine("0 for Bubble, 1 for Merge, 2 for insertion, 3 for Quick");

        // Begin the timer to calculate the time efficiency of the chosen sort.
        var watch = System.Diagnostics.Stopwatch.StartNew();

        // User chooses the sort.
        while (valid == false)
        {
            choice = Console.ReadLine();
            if (choice == "0")
            {
                valid = true;
                watch = System.Diagnostics.Stopwatch.StartNew();
                content = Sort.BubbleSort(content);
            }
            else if (choice == "1")
            {
                valid = true;
                watch = System.Diagnostics.Stopwatch.StartNew();
                content = Sort.MergeSort(content, 0, content.Length - 1, 0);
            }
            else if (choice == "2")
            {
                valid = true;
                watch = System.Diagnostics.Stopwatch.StartNew();
                content = Sort.InsertionSort(content);
            }
            else if (choice == "3")
            {
                valid = true;
                watch = System.Diagnostics.Stopwatch.StartNew();
                content = Sort.QuickSort(content, 0, content.Length - 1, 0);
            }
            else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }
        }

        // End timer and output time efficiency.
        watch.Stop();
        Console.WriteLine("\nThis sorting method took " + watch.ElapsedMilliseconds + " milliseconds and " + content.Last() + " steps to complete.");

        // Remove the steps value from the array.
        content = content.SkipLast(1).ToArray();

        //Perform interval output.
        Output.Interval(content);

        // User chooses to continue to search or choose again.
        Console.WriteLine("\nWould you like to search this file, choose a new file or exit?");
        Console.WriteLine("Enter 0 for file search, 1 for new file, 2 for exit");
        valid = false;

        while (valid == false)
        {
            choice = Console.ReadLine();
            if (choice == "0")
            {
                valid = true;
            }
            else if (choice == "1")
            {
                valid = true;
                Console.WriteLine("\n");
                Main();
                Environment.Exit(0);
            }
            else if (choice == "2")
            {
                valid = true;
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }
        }



        // Begin the timer to calculate the time efficiency of the chosen search.
        valid = false;

        while (valid == false)
        {
            Console.WriteLine("\nWhich search would you like to use?:");
            Console.WriteLine("Enter 0 for Linear, 1 for Binary search");
            choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Please enter a number to search for:");
                choice = Console.ReadLine();
                if (choice.All(char.IsDigit) == true && choice.Count() > 0)
                {
                    watch = System.Diagnostics.Stopwatch.StartNew();
                    string steps = Output.LinearSearch(Convert.ToInt32(choice), content, 0).ToString();
                    // End timer and output time efficiency.
                    watch.Stop();
                    Console.WriteLine("\nThis sorting method took " + watch.ElapsedMilliseconds + " milliseconds and " + steps + " steps to complete.");
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry... Please enter a number.");
                }
            }
            else if (choice == "1")
            {
                Console.WriteLine("Please enter a number to search for:");
                choice = Console.ReadLine();
                if (choice.All(char.IsDigit) == true && choice.Count() > 0)
                {
                    watch = System.Diagnostics.Stopwatch.StartNew();
                    string steps = Output.BinarySearch(content, Convert.ToInt32(choice), 0).ToString();
                    // End timer and output time efficiency.
                    watch.Stop();
                    Console.WriteLine("\nThis sorting method took " + watch.ElapsedMilliseconds + " milliseconds and " + steps + " steps to complete.");
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry... Please enter a number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry... Please try again.");
            }

            // Continue additional tasks here.
            // Merging section.
            Console.WriteLine("\nWould you like to analyse 2 Files merged?:");
            Console.WriteLine("Enter 0 for yes, 1 to exit application, 2 to restart application.");

            valid = false;
            while (valid == false)
            {
                choice = Console.ReadLine();
                if (choice == "0")
                {
                    content = Select();
                    content = content.Union(Select()).ToArray();

                    Console.WriteLine("\nWhich sort would you like to use?: Please enter the chosen index.");
                    Console.WriteLine("0 for Bubble, 1 for Merge, 2 for insertion, 3 for Quick");

                    // Begin the timer to calculate the time efficiency of the chosen sort.
                    watch = System.Diagnostics.Stopwatch.StartNew();

                    // User chooses the sort.
                    while (valid == false)
                    {
                        choice = Console.ReadLine();
                        if (choice == "0")
                        {
                            valid = true;
                            watch = System.Diagnostics.Stopwatch.StartNew();
                            content = Sort.BubbleSort(content);
                        }
                        else if (choice == "1")
                        {
                            valid = true;
                            watch = System.Diagnostics.Stopwatch.StartNew();
                            content = Sort.MergeSort(content, 0, content.Length - 1, 0);
                        }
                        else if (choice == "2")
                        {
                            valid = true;
                            watch = System.Diagnostics.Stopwatch.StartNew();
                            content = Sort.InsertionSort(content);
                        }
                        else if (choice == "3")
                        {
                            valid = true;
                            watch = System.Diagnostics.Stopwatch.StartNew();
                            content = Sort.QuickSort(content, 0, content.Length - 1, 0);
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry... Please try again.");
                        }
                    }

                    // End timer and output time efficiency.
                    watch.Stop();
                    Console.WriteLine("\nThis sorting method took " + watch.ElapsedMilliseconds + " milliseconds and " + content.Last() + " steps to complete.");

                    // Remove the steps value from the array.
                    content = content.SkipLast(1).ToArray();

                    //Perform interval output in ascending or descending.
                    Output.Interval(content);

                    valid = false;
                    while (valid == false)
                    {
                        Console.WriteLine("\nWhich search would you like to use?:");
                        Console.WriteLine("Enter 0 for Linear, 1 for Binary search");
                        choice = Console.ReadLine();

                        if (choice == "0")
                        {
                            Console.WriteLine("Please enter a number to search for:");
                            choice = Console.ReadLine();
                            if (choice.All(char.IsDigit) == true && choice.Count() > 0)
                            {
                                watch = System.Diagnostics.Stopwatch.StartNew();
                                string steps = Output.LinearSearch(Convert.ToInt32(choice), content, 0).ToString();
                                // End timer and output time efficiency.
                                watch.Stop();
                                Console.WriteLine("\nThis sorting method took " + watch.ElapsedMilliseconds + " milliseconds and " + steps + " steps to complete.");
                                valid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry... Please enter a number.");
                            }
                        }
                        else if (choice == "1")
                        {
                            Console.WriteLine("Please enter a number to search for:");
                            choice = Console.ReadLine();
                            if (choice.All(char.IsDigit) == true && choice.Count() > 0)
                            {
                                watch = System.Diagnostics.Stopwatch.StartNew();
                                string steps = Output.BinarySearch(content, Convert.ToInt32(choice), 0).ToString();
                                // End timer and output time efficiency.
                                watch.Stop();
                                Console.WriteLine("\nThis sorting method took " + watch.ElapsedMilliseconds + " milliseconds and " + steps + " steps to complete.");
                                valid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid entry... Please enter a number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry... Please try again.");
                        }
                    }
                }

                else if (choice == "1")
                {
                    valid = true;
                    Environment.Exit(0);
                }
                else if (choice == "2")
                {
                    valid = true;
                    Main();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid entry... Please enter a number.");
                }
            }
        }

        static int[] Select()
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
}
