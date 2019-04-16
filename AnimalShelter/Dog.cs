using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire }

    public class Dog : Pet
    {
        public DogBreed Breed;

        public Dog(int petid, string name, string color, string gender, DogBreed breed)
            : base(petid, name, color, gender) { Breed = breed; }

        // virtual method를 override.
        public override string MakeSound()
        {
            return "woof woof";
        }

        // 부모 class에 없는 method.
        public string Bite()
        {
            return "bite";
        }
    }
}