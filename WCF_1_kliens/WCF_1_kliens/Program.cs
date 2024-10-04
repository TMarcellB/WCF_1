using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_1_kliens.ServiceReference1;

namespace WCF_1_kliens
{
    internal class Program
    {
        static ServiceReference1.Service1Client client;
        static void Main(string[] args)
        {
            client = new ServiceReference1.Service1Client();
            Eloado eloado = client.GetEloado();
            Console.WriteLine(eloado.EloadoName);
            Console.ReadKey();
        }
    }
}
