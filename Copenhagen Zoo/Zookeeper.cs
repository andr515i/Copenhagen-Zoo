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
        public int id
        {
            get { return _id; }
        }

        private string _name;  // stated in the assignment that the name could be changed, though only by hr, however that isnt too important right now

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }




        public Zookeeper(int randomId)
        {
            Random random = new Random();
            if (random.Next(0,5) >= 2) // name doesnt matter, we can also change it later incase our zookeeper wants to change it, only through hr tho ;p
            {
                _name = "Steve"; // steve has no brain, he is practically a robot at this point, only doning what his boss asks him to
            }
            else
            {
                _name = "bob"; // bob is even worse, he doesnt actually know what he is doing at a zoo, as he is too dumb to know anything about zookeeping
            }
        }

        internal bool PressFoodButton()
        {
            Console.WriteLine("food has been delivered");
            return true;
        }
    }
}
