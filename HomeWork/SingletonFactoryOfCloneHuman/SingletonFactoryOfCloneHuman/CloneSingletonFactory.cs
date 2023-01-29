using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryOfCloneHuman
{
    public class CloneSingletonFactory //Singletone (одиночка) фабрика
    {
        private static CloneSingletonFactory _singleton;

        private CloneSingletonFactory()
        {
        }
        public static CloneSingletonFactory GetSingletone()
        {
            if (_singleton == null)
            {
                _singleton = new CloneSingletonFactory();
            }
            return _singleton;
        }

        public IHuman CloneHumanFactory(IHuman human)
        {
            if (human != default)
            {
                human?.Clone();
            }
            else human = default;
            return human;
        }
    }
}
