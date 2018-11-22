using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWCF_Test
{
    class Program
    {
        static void Main(string[] args)
        {
           // ServiceWCF.Service1Client proxy = new ServiceWCF.Service1Client();
            ServiceWCFapp.Service1Client proxyApp = new ServiceWCFapp.Service1Client();
            Console.WriteLine(proxyApp.Sum(5, 5));
            Console.ReadKey();
        }
    }
}
