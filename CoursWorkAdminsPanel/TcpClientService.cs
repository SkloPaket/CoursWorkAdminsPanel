using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CoursWork
{
    public class TcpClientService
    {
        public static string SendMessage(string message)
        {
            TcpClient client = new TcpClient("192.168.0.199", 85);

            NetworkStream stream = client.GetStream();

            byte[] data = Encoding.UTF8.GetBytes(message);

            stream.Write(data, 0, data.Length);

            byte[] buffer = new byte[4096];

            int bytes = stream.Read(buffer, 0, buffer.Length);

            string response = Encoding.UTF8.GetString(buffer, 0, bytes);

            client.Close();

            return response;
        }
    }
}
