using System;
using System.Collections;
using System.Collections.Generic;

namespace _09_10_2022
{
    static public void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Hashtable my_graph = new Hashtable();
        for (i = 0; i < n; i++)
        {
            string[] edge = Console.ReadLine().Split(':', ' ').Trim();
            if (edge[1] == null)
            {
                my_graph.Add(edge[0], 0);
            }
            else if (edge.Length = 2)
            {
                my_graph.Add(edge[0], edge[1]);
            }
            else
            {
                for (int o = 1; o < edge.length; o++)
                {
                    my_graph.Add(edge[0], edge[o]);
                }
            }

            foreach (DictionaryEntry branch in my_graph)
            {
                Console.WriteLine($"{branch.Key}and {branch.Value}");
            }

        }
    }

}
