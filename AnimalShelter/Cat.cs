using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat : Pet // 자식 class는 부모 class의 모든 public 요소에 접근 가능함.
    {
        // 자식 class의 생성자가 호출되려면 부모 class의 생성자가 먼저 호출되어야만 한다.
        // : base()가 부모 class의 생성자를 호출함.
        public Cat(int petid, string name, string color, string gender)
            : base(petid, name, color, gender) { }

        // virtual method를 override.
        public override string MakeSound()
        {
            return "meow";
        }

        // 부모 class에 없는 method.
        public string Scratch()
        {
            return "scratch";
        }
    }
}
