using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_PoP
{
    public class Person
    {
        private string name;
        private int age;
        private string eMail;

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            EMail = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100");
                }

                age = value;
            }
        }

        public string EMail
        {
            get => eMail; set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new FormatException("Invalid e-mail format!");
                }
                eMail = value;
            }
        }

        public override string ToString()
        {
            return $"Person {Name}, age={Age}, E-Mail={eMail} ";
        }
    }
}
