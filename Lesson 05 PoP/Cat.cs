using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_PoP
{
    public class Cat : Animal
    {
        //Attributs
        private string name;

        //Constructeurs
        public Cat(string name, string owner)
        {
            Name = name;
            Owner = owner;
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat()
        {
        }

        //Propriétés
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Can must have name!!!");
                }
                name = value;
            }
        }

        public string Owner
        {
            get;
            set;
        }

        //Méthodes
        public void SayMiau()
        {
            Console.WriteLine("Miauuuuuuu!");
        }
    }
}
