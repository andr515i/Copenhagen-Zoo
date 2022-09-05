using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_Zoo
{
    class HR
    {
     
        internal void changeName(string newName, Zookeeper zk)
        {
            zk.name = newName;
        }
    }
}
