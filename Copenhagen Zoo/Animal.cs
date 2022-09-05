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
        public bool isMale
        {
            get { return _isMale; }
            set { _isMale = value; }
        }


        private string _race;    //  ie, lion, elephant, giraffe etc.
        public string race 
        {
            get { return _race; }
        }


        private string _gender;// easily printable gender
        public string gender   
        {
            get { return _gender; }
        }


        private bool _carnivore;  // only have carnivores or herbivores in our zoo >:) // if we did, i would have used an int instead
        public bool carnivore
        {
            get { return _carnivore; }
        } 

        
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

            if (isCarnivore)
            {
                _carnivore = isCarnivore;   
            }
            else
            {
                _carnivore = false; // herbivore
            }
        }
        internal void Eat(bool food)
        {
            if (food)
            { 
                if (_race=="lion")
                {
                    Console.WriteLine("nom nom nom      (the lion feeds on the meat given to it)");

                }
            } 
        }

    }
}
