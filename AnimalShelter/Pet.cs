using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Pet // 부모 클래스
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int petid, string name, string color, string gender)
        {
            PetId = petid;
            Name = name;
            Color = color;
            Gender = gender;
        }

        // 가상 method.
        // 자식 클래스에서 재정의된 method가 존재하면 그것을 호출함.
        // 재정의가 필요하기 때문에 virtual로 선언함.
        public virtual string MakeSound()
        {
            return "";
        }
    }
}
