using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace calcHost
{
    class Program
    {
       
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalcServiceLib.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started, Press any key to stop");
                Console.ReadLine();
            }
        }
    }
}
