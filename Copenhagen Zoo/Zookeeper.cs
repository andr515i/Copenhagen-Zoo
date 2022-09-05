using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_Zoo
{
     class Zookeeper 
    {
        // this class serves the only purpose as to substitate a real person, which makes it useful in testing purposes
        // each zookeeper has a unique id, it will never be changed. however, for simplicity's sake, i will just start from 0 and add one for each creation, this does mean we need it from outside 
        private int _id;
        internal int id
        {
            get { return _id; }
        }

        private string _name;  // stated in the assignment that the name could be changed, though only by hr, however that isnt too important right now

         internal string name  // need to find a way to make it even more private. as it is now everyone in the same namespace can alter this, however only hr should be able to
        {
            get { return _name; }
            set { _name = value; }
        }



        // defualt ctor
        public Zookeeper(int randomId, int rndName)
        {
            Random random = new Random();
            if (rndName > 2) // name doesnt matter, we can also change it later incase our zookeeper wants to change it, only through hr tho ;p
            {
                _name = "Steve"; // steve has no brain, he is practically a robot at this point, only doning what his boss asks him to
            }
            else
            {
                _name = "bob"; // bob is even worse, he doesnt actually know what he is doing at a zoo, as he is too dumb to know anything about zookeeping
            }
            _id = randomId;
        }

        internal bool PressFoodButton()  // to simulate the button getting pressed, could have sent the specific food to the specific animals, however i deem this uneccesary and will not do it.
        {
            Console.WriteLine("food has been delivered");
            return true;  // returns true so i can make sure the animals "knows" when they get food
        }
    }
}
