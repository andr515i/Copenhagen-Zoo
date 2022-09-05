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
            Animal[] lions = GetLions(10);
            Zookeeper[] zk = GetZooKeepers(10);
            HR hr = new HR();
            // now we feed the animals because they must have been hungry
            bool food = zk[1].PressFoodButton();
            foreach (Animal animal in lions)
            {
                animal.Eat(food);  // every lion feeds, however if i wanted multiple animals, i would throw them in a multidirectional array or list, and go through each animal racially (dont sue)
            }


            // name before: Steve
            hr.changeName("Some new name", zk[4]);  // now we change zookeeper number 5's (index) name to some new name
            // name after: Some new name
            Console.ReadLine();
            
        }
        static Animal[] GetLions(int amountOfLions)
        {
            bool isMale = false;
            Animal[] lionArray = new Animal[amountOfLions];
            Random random = new Random();

            for (int i = 0; i < lionArray.Length; i++)
            {
                int maleOrFemale = random.Next(0, 2);
                if (maleOrFemale == 1)
                {
                    isMale = true;
                }
                Animal lion = new Animal(isMale, "lion", true);
                lionArray[i] = lion;
            }
            return lionArray;
        }
        static Zookeeper[] GetZooKeepers(int amountOfKeepers)  // this doesnt generate the desired objects, it just generates the same person over and over, but in truth it doesnt matter too much
        { 
            Zookeeper[] zk = new Zookeeper[amountOfKeepers];

            for (int i = 0; i < zk.Length; i++)
            {

                zk[i] = new Zookeeper(i);

            }
            return zk;
        }
    }
}
