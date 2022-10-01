namespace Program1
{
    internal class Tree<T>
    {
        internal static Tree<T> deepest;
        internal static int deepestIndent = -1;
 
        internal T Value{get; set;}
        internal Tree<T> Parent{get; set;}
        internal List<Tree<T>> Children {get; private set;}
        /*
        internal Tree(T value, List<Tree<T>> children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach(var child in children)
            {
                this.Children.Add(child);
                child.Parent=this;
            }
        }
        */
        internal Tree(T value)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
        }
 
        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            if (deepestIndent < indent) {
                deepestIndent = indent;
                deepest = this;
            }
            foreach(var childin in this.Children)
            {
                childin.Print(indent + 1);
            }
        }
 
        public void PrintParent()
        {
            Console.Write($"{this.Value} ");
            if (this.Parent != null) 
            {
                this.Parent.PrintParent();
            }
        }
 
    }
    internal class Program{
 
    internal static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
 
 
 
        public static void Main()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for(int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
            Console.WriteLine("--Output--");
            Console.WriteLine(GiveRoot().Value);
            Tree<int> root = GiveRoot();
            root.Print();
            Console.WriteLine("-------");
            // Tree<int> root2 = nodeByValue[nodeByValue.Keys.FirstOrDefault(x => x == 19)];
            Tree<int> root2 = nodeByValue.Values.FirstOrDefault(x => x.Value == 19);
            root2.Print();
            Console.WriteLine("-----");
            GiveChild();
 
            foreach(var tree in nodeByValue.Where(x => x.Value.Children.Count == 0))
            {
                Console.Write(tree.Value.Value); Console.Write(" ");
            }
            Console.WriteLine();
            foreach(var tree in nodeByValue.Where(x => 
                x.Value.Children.Count != 0 && x.Value.Parent != null 
            ))
            {
                Console.Write(tree.Value.Value); Console.Write(" ");
            }
            Console.WriteLine();
 
            Console.WriteLine(Tree<int>.deepest.Value);
 
            Tree<int>.deepest.PrintParent();
        }
 
        internal static Tree<int> GetTreeNodeByValue(int value)
        {
            if(!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }
            return nodeByValue[value];
        }
 
        internal static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);
            parentNode.Children.Add(childNode);
            childNode.Parent= parentNode;
        }
 
 
        internal static Tree<int> GiveRoot(){
            return nodeByValue.Values.FirstOrDefault(x => x.Parent == null);
        }
 
        internal static Tree<int> GiveChild(){
            return nodeByValue.Values.FirstOrDefault(x => x.Children == null);
        }
 
    }
}