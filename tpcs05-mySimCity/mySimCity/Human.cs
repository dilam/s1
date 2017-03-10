using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySimCity
{
    class Human
    {
        // Attributes
        protected string name;
        protected int age;

        // Getters & Setters
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        // Constructor
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Methods
        public void BirthDay()
        {
            int year = 2015 - age;
            Console.WriteLine(year);
        }
        public virtual void Describe()
        {
            Console.WriteLine(name + ", " + age + " ans.");
        }
        public virtual void WhoAmI()
        {
            Console.WriteLine("La classe \"Human\" est une personne et a pour propriété le prénom et l'âge.");
        }
    }
}
