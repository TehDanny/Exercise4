using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSideSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerSideSocket server = new ServerSideSocket(45000);
            server.Run();
        }
    }
}
