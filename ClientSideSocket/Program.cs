using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientSideSocket client = new ClientSideSocket("127.0.0.1", 45000);
            client.Run();
        }
    }
}
