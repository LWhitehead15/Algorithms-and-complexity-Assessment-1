using System;
using System.Linq;

public class Input
{

    public static int[] retrieve (string index, string size)
    {
        List<int> content = new List<int>();

        var path = Directory.GetCurrentDirectory();
        path =  path + "\\Share_" + index + "_" + size + ".txt";

        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            content.Add(Convert.ToInt32(line));
        }

        int[] output = content.ToArray();

        return output;
    }

}
