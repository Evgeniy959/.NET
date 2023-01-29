using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class AgeAttribute : Attribute
    {
        public uint age;
        public AgeAttribute() {} 
        public AgeAttribute(uint age) 
        {
            this.age = age;
        } 
    }
}
