using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copenhagen_Zoo
{
    class Animal
    {
        private bool _isMale;   // true = male, false = female
        internal bool isMale
        {
            get { return _isMale; }
        }


        private string _race;    //  ie, lion, elephant, giraffe etc.
        internal string race 
        {
            get { return _race; }
        }


        private string _gender;// easily printable gender
        internal string gender   
        {
            get { return _gender; }
        }


        private bool _carnivore;  // only have carnivores or herbivores in our zoo >:) // if we did, i would have used an int instead
        internal bool carnivore
        {
            get { return _carnivore; }
        } 

        // ctor
        public Animal(bool male, string animalRace, bool isCarnivore)
        {
            if (male)  // checks for gender upon initialization
            {
                _gender = "male";
            } else
            {
                _gender = "female";
            }
            _race = animalRace;   // set the race

            if (isCarnivore)  // could add the type of food it would eat here, and send that down to the eat method
            {
                _carnivore = isCarnivore;   
            }
            else
            {
                _carnivore = false; // herbivore
            }
            
        }
        internal void Eat(bool food)   // simulates eating, in a very imaginative sense
        {  
            if (food)
            { 
                if (_race=="lion")   // tried to do a little modular design, so you could add more if statements to send the appropriate foods and responses for that.
                {
                    Console.WriteLine("nom nom nom      (the lion feeds on the meat given to it)");

                }
            } 
        }

    }
}
