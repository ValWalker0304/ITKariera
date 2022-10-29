using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

/*
namespace primerenIzpitM10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> waterBody = new Dictionary<string, string>();
            List<string> history = new List<string>();
            Dictionary<string, string> outputs = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "end")
                {
                    string[] cutinput = input.Split(' ').ToArray();
                    waterBody.Add(cutinput[0], cutinput[1]);
                    history.Add(cutinput[0]);
                    history.Add(cutinput[1]);
                }
                else break;
            }
            int i = 0;
            foreach (var letter in waterBody)
            {
                if (letter.Value == history[i])
                {
                    if (letter.Key == history[i + 1])
                    {
                        outputs.Add(letter.Key, letter.Value);
                    }
                }
                else if (letter.Value == history[i + 1])
                {
                    if (letter.Key == history[i])
                    {
                        outputs.Add(letter.Key, letter.Value);
                    }
                }
                i = i + 2;
            }
            foreach (var output in outputs)
            {
                Console.WriteLine("{0} <=> {1}", output.Key, output.Value);
            }
        }
    }
} */

/* 
    namespace primerenIzpitM10
    {
        class Graph
        {
            public List<Node> nodes = new List<Node>();

            public Graph() {}

            public void AddConnection(string nodeName1, string nodeName2)
            {
                if (nodes.Find(x => x.name == nodeName1) == null)
                {
                    nodes.Add(new Node(nodeName1));
                }
                
                if (nodes.Find(x => x.name == nodeName2) == null)
                {
                    nodes.Add(new Node(nodeName2));
                }

                Node node1 = nodes.Find(x => x.name == nodeName1);
                Node node2 = nodes.Find(x => x.name == nodeName2);

                if (node1.connections.Find(x => x.name == node2.name) == null)
                {
                    node1.connections.Add(node2);
                }
            }

            public void FindDoubleConnections(List<DoubleConnection> doubleConnections)
            {
                foreach (var node in nodes)
                {
                    foreach (var connectedNode in node.connections)
                    {
                        if (connectedNode.connections.Find(x => x.name == node.name) != null)
                        {
                            if (doubleConnections.Find(x => (x.first == node && x.second == connectedNode) || (x.first == connectedNode && x.second == node)) == null)
                            {
                                doubleConnections.Add(new DoubleConnection(node, connectedNode));
                            }
                        }
                    }
                }
            }
        }

        class Node
        {
            public string name;
            public List<Node> connections = new List<Node>();

            public Node(string name)
            {
                this.name = name;
            }
        }

        class DoubleConnection
        {
            public Node first;
            public Node second;

            public DoubleConnection(Node first, Node second)
            {
                this.first = first;
                this.second = second;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Graph graph = new Graph();

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input != "end")
                    {
                        string[] cutinput = input.Split(' ').ToArray();
                        graph.AddConnection(cutinput[0], cutinput[1]);
                    }
                    else break;
                }

                List<DoubleConnection> doubleConnections = new List<DoubleConnection>();
                graph.FindDoubleConnections(doubleConnections);

                foreach (var connection in doubleConnections)
                {
                    Console.WriteLine($"{connection.first.name} -> {connection.second.name}");
                }
            }
        }
    } */


namespace primerenIzpitM10
{
    internal class Program
    {
        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] {t});

            return GetPermutations(list, length - 1).SelectMany(t => list.Where(e => !t.Contains(e)), (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        static void Main(string[] args)
        {
            string[] firstString = Console.ReadLine().Split(' ');
            List<string> inputs = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                inputs.Add(input);
            }
            
            IEnumerable<IEnumerable<string>> permutations = GetPermutations(firstString, firstString.Length);

            foreach (var permutation in permutations)
            {

                if (inputs.Contains(string.Join("", permutation)))
                {
                    Console.WriteLine(string.Join(' ', permutation));
                }
            }
        }
    }
}
