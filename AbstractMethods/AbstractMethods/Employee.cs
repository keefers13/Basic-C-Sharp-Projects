using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    //creating a child class that inherits from abstract class Person
    public class Employee : Person
    {
        //inheriting from the virtual method
        public override void SayName()
        {
            base.SayName();
        }
    }
}
