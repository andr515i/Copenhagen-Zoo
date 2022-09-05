using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_Zoo
{
    class Program
    {

        // in this assignemnt i have tried my best to restrict as much as possible, only making what is absolutely neccesary or ideal visible to as little as posible


        static void Main(string[] args)
        {
            //we get some test animals, zookeepers and 1 hr
            Animal[] lions = GetLions(10);  //10 lions
            Zookeeper[] zk = GetZooKeepers(10); // 10 zookepers
            HR hr = new HR(); // creates 1 hr object
            // now we feed the animals because they must have been hungry
            bool food = zk[1].PressFoodButton(); //we call the pressfoodbutton method which returns a true value, which we can then pass into the animals eat method, to make them eat
            foreach (Animal animal in lions)  // loop through each animal in lions array
            {
                animal.Eat(food);  // every lion feeds, however if i wanted multiple animals, i would throw them in a multidirectional array or list, and go through each animal racially (dont sue)
            } // could also pass a second argument in that would tell it what to eat, or have it done behind the scenes to make sure it gets the right food /to make it a little more realistic


            // name before: steve || bob
            hr.changeName("Some new name", zk[4]);  // now we change zookeeper number 5's (index) name to some new name
            // name after: Some new name
            Console.ReadLine();  // pause program so we can read
            
            foreach (Zookeeper zookeeper in zk)
            {
                Console.WriteLine(zookeeper.name + " : " + zookeeper.id);
            }
            foreach (Animal animal in lions)
            {
                Console.WriteLine(animal.race);
            }
        }
        static Animal[] GetLions(int amountOfLions) // here we make the lion array and send it back via return
        {
            bool isMale = false;  // check for male
            Animal[] lionArray = new Animal[amountOfLions];  //we make an empty array of defined size, which we pass through upon calling the method
            Random random = new Random();

            for (int i = 0; i < lionArray.Length; i++)  // now we loop through and fill each empty array spot with data
            {
                int maleOrFemale = random.Next(0, 3);  // figure out if male or female
                if (maleOrFemale == 1)
                {
                    isMale = true;
                }

                lionArray[i] = new Animal(isMale, "lion", true); // then we populate with data and send it into the array
            }
            return lionArray; //returns lion array
        }
        static Zookeeper[] GetZooKeepers(int amountOfKeepers)  // this doesnt generate the desired objects, it just generates the same person over and over, but in truth it doesnt matter too much
        {
            Random random = new Random();
            int counter = 0;  // this unfortunately is not very modular, it does not take into context if we make a new array of zookeepers, or if we add a few to the existing one, at a later date.
            Zookeeper[] zk = new Zookeeper[amountOfKeepers];  // makes an empty array of desired length

            for (int i = 0; i < zk.Length; i++) // we get the length of desired array length ie desired amount of zookeepers
            {
                int rndName = random.Next(0, 5); // not very intuitive way to figure out what to call employees

                counter++;
                zk[i] = new Zookeeper(counter, rndName);  // we then insert data into empty array spots

            }
            return zk; // returns zookeeper array
        }
    }
}
