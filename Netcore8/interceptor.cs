using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using  System.Runtime.CompilerServices;
namespace Netcore8
{
    
    public static class interceptor
    {
        [InterceptsLocation()]
        public static  void interceptors(this example example) {

            Console.WriteLine("Im from interceptor");
        }
    }
}
