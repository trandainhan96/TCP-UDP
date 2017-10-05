using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace UDPSocket_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khoi tao Client ");
            //b1 xac dinh ip server
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            //b2 Tao socket
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //b3 gui nhan data
            byte[] send = Encoding.ASCII.GetBytes("Hello Server!");
            EndPoint epServer = (EndPoint)ipServer;
            client.SendTo(Send, epServer);
            byte[] rec = new byte[25];
            client.ReceiveFrom(rec, ref epServer);
            Console.WriteLine("Client nhan data {0}", Encoding.ASCII.GetString(rec));
            //b4 dong Client Socket
            client.Close();
        }
    }
}
