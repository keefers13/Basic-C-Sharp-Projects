using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    // giving this class a generic parameter
    public class Employee<T>
    {
        //declaring a List property with a generic parameter.
        public List<T> Things { get; set; }
    }
}
