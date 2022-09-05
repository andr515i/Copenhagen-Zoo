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

    // only real thing i miss now is a class that would represent HR for the zookeepers, however i dont think its super improtant to implement, as its just more of the same

        static void Main(string[] args)
        {            
            //we get some test animals and zookeepers
            Animal[] lions = GetLions(10);
            Zookeeper[] zk = GetZooKeepers(10);

            // now we feed the animals because they must have been hungry
            bool food = zk[1].PressFoodButton();
            foreach (Animal animal in lions)
            {
                animal.Eat(food);
            }

                
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
