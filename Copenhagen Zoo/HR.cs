using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_Zoo
{ // the most simple one of them all, as per assignment words, the only thing hr has privileges or rights to, is to change a zookeeprs name. nothing more, nothing less.
    class HR 
    {
     
        internal void changeName(string newName, Zookeeper zk)  // we get the new name, aswell as the specific zookeeper from outside.
        {
            zk.name = newName;
        }
    }
}
