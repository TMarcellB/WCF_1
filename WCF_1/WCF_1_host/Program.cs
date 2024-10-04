using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCF_1_host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:3000");
            WebHttpBinding binding = new WebHttpBinding();
            using (ServiceHost host = new ServiceHost(typeof(WCF_1_server.Service1), uri))
            {
                ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(WCF_1_server.IService1), binding, "");
                endpoint.EndpointBehaviors.Add(new WebHttpBehavior());
                host.Open();
                Console.WriteLine($"A szerverem elindult: {DateTime.Now}");
                Console.ReadKey();
                host.Close();

            }

        }
    }
}
