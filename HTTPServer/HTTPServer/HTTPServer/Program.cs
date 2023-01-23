using System;
using System.Collections.Generic;

namespace HTTPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting Server on Port 80");
            HTTPServer server = new HTTPServer(80);
            server.Start();
        }
    }
}