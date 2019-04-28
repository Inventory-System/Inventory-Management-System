using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var Container = new WindsorContainer(); 
        }
    }
}
