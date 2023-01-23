using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;

namespace HTTPServer
{
    public class HTTPServer
    {
        public const String MSG_DIR = "/root/msg/";
        public const String WEB_DIR = "/root/web/";
        public const String VERSION = "HTTP/1.1 ";
        public const String NAME = "Siwiq te obicha HTTPS Response <3 v0.a";

        private bool running = false;

        private TcpListener listener;

        public HTTPServer(int port)
        {
            listener = new TcpListener(System.Net.IPAddress.Any, port);
        }

        public void Start()
        {
            Thread serverThread = new Thread(new ThreadStart(Run));
            serverThread.Start(); 
        }

        private void Run()
        {
            running = true;
            listener.Start();
            
            while(running)
            {
                System.Console.WriteLine("Establishing Connection...");
                TcpClient client = listener.AcceptTcpClient();
                
                System.Console.WriteLine("Connection established");
                HandleClient(client);
                client.Close(); 
            }
            running = false;

            listener.Stop();
        }

        private void HandleClient(TcpClient client)
        {
            StreamReader reader = new StreamReader(client.GetStream());

            string msg = "";
            while(reader.Peek() != -1)
            {
                msg +=reader.ReadLine() + "\n";
            }
            Debug.WriteLine("Request: \n" + msg);

            Request req = Request.GetRequest(msg);
            Response resp = Response.From(req);

            resp.Post(client.GetStream());
        }
    }
}
