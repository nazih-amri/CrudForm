using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teestForm2
{
    class Person
    {
        public int id { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public int age { get; set; }
        static int nbP = 1;

        public Person(string prenom,string nom,int age)
        {
            this.id = nbP;
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
            nbP++;
        }
    }
}
