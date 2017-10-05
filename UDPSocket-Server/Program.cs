using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace UDPSocket_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //b1 tao Socket u
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 12345);
            //b2 ket noi socket voi card mang
            // IPENDPOINT gồm 2 phần
            server.Bind(ip);
            //b3 gui nhan data
            //server phai nhan data truoc
            //vi neu khong nhan data tu client
            byte[] rec = new byte[25];
            EndPoint Client = (EndPoint)ip; //khong lay gia tri thi khong duyet
            server.ReceiveFrom(rec, ref Client); //khong tao EP se bao loi
            byte[] send = Encoding.ASCII.GetBytes("Helllo client: ");
            server.SendTo(send, Client);
            server.Close();
           

        }
    }
}
