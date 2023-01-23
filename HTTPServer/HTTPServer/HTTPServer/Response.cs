using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HTTPServer
{
    public class Response
    {

        private Byte[] data = null;
        private String status;
        private String mime;

        private Response(String status,String mime,  Byte[] data)
        {
            this.data = data;
            this.status = status;
            this.mime = mime;
        }

        public static Response From(Request request)
        {
            if (request == null)
                return MakeNullRequest();

            if (request.Type != "POST")
            {
                String file = Environment.CurrentDirectory + HTTPServer.WEB_DIR + request.URL;
                FileInfo f  = new FileInfo(file);
                if (f.Exists && f.Extension.Contains("."))
                {
                    return MakeFromFile(f);
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(f + "/");
                    if (!di.Exists)
                    {
                        return MakeNotFound();
                    }
                    FileInfo[] files = di.GetFiles();
                    foreach (FileInfo fi in files)
                    {
                        String n = fi.Name;
                        if (n.Contains("default.html") || n.Contains("default.html")||n.Contains("Index.html"))
                        {
                            f = fi;
                            return MakeFromFile(fi);
                        }
                    }
                }

            }
            else
            {
                return MakeMethodNotAllowed();
            }
            return MakeNotFound();
        }

        private static Response MakeFromFile(FileInfo f)
        {
            FileStream fs = f.OpenRead();
            BinaryReader br = new BinaryReader(fs);
            Byte[] d = new Byte[fs.Length];
            br.Read(d, 0, d.Length);
            fs.Close();
            return new Response("200 OK", "text/html", d);
        }

        private static Response MakeNullRequest()
        {
            String file = Environment.CurrentDirectory + HTTPServer.MSG_DIR + "400.html";
            FileInfo fileInfo = new FileInfo(file);
            FileStream fs = fileInfo.OpenRead();
            BinaryReader br = new BinaryReader(fs);
            Byte[] d = new Byte[fs.Length];
            br.Read(d, 0, d.Length);
            fs.Close();
            return new Response("400 Bad Request", "text/html", d );
        }
        private static Response MakeNotFound()
        {
            String file = Environment.CurrentDirectory + HTTPServer.MSG_DIR + "404.html";
            FileInfo fileInfo = new FileInfo(file);
            FileStream fs = fileInfo.OpenRead();
            BinaryReader br = new BinaryReader(fs);
            Byte[] d = new Byte[fs.Length];
            br.Read(d, 0, d.Length);
            fs.Close();
            return new Response("404 Page Not Found", "text/html", d );
        }
        private static Response MakeMethodNotAllowed()
        {
            String file = Environment.CurrentDirectory + HTTPServer.MSG_DIR + "405.html";
            FileInfo fileInfo = new FileInfo(file);
            FileStream fs = fileInfo.OpenRead();
            BinaryReader br = new BinaryReader(fs);
            Byte[] d = new Byte[fs.Length];
            br.Read(d, 0, d.Length);
            fs.Close();
            return new Response("405 Method Not Allowed", "text/html", d );
        }

        public void Post(NetworkStream stream)
        {
            StreamWriter write = new StreamWriter(stream);
            write.Flush();
            write.WriteLine(String.Format("{0} {1}\r\nServer: {2}\r\nContent-Type: {3}\r\nAccept-Ranges\r\nContent-length: {4}\r\n",
                HTTPServer.VERSION,
                status,
                HTTPServer.NAME,
                mime,
                data.Length));

            stream.Write(data, 0, data.Length);
        }
    }
}
