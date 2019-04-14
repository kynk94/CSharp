using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    // 아무것도 안적혀 있으면 자동으로 internal. internal은 해당 namespace 내에서만 쓸 수 있다.
    // public이면 namespace 밖에서도 호출할 수 있다.
    // 다른 코드에서 using (namespace); 를 하면 public으로 선언한 클래스를 호출할 수 있음.
    public class Cat
    {
        // 아무것도 안적혀 있으면 자동으로 private. private은 해당 class 내에서만 쓸 수 있다.
        // public이면 class 밖에서도 호출할 수 있다.
        public string Name;
        public int Age;
        private int Happiness = 50;

        // 생성자 선언
        // return 타입을 전혀 붙이지 않는다.
        // 생성자의 이름은 클래스 이름과 같아야한다.
        public Cat(string name, int age)
        {
            // this는 현재 인스턴스를 가리킨다.
            this.Name = name;
            this.Age = age;
        }

        public void Play()
        {
            Happiness += 10;
            if (Happiness > 100) Happiness = 100;
        }

        public void Eat()
        {
            Happiness += 20;
            if (Happiness > 100) Happiness = 100;
        }

        public string Express()
        {
            string message = "";    

            if (Happiness >= 80) message = "I'm very Happy.";
            else if (Happiness >= 60) message = "I'm Happy."; // 조건문이 위에서부터 내려오므로 80보다 작을 조건은 주지 않아도 된다.
            else if (Happiness >= 40) message = "I'm soso.";
            else if (Happiness >= 20) message = "I'm gloomy.";
            else message = "I'm sad";
            return this.Name + ": " + message;
        }

        public void GetBored()
        {
            Happiness -= 10;
            if (Happiness < 0) Happiness = 0;
        }
    }
}
