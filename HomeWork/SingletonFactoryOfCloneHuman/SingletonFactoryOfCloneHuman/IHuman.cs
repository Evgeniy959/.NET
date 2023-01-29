using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryOfCloneHuman
{
    public interface IHuman 
    {
        string Name { get; set; }
        int Age { get; set; }
        object Clone();
    }
}
