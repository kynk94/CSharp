using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        /*  private 변수는 _ 붙여서 구분하면 바로 알 수 있다는 장점이 있다.
            DateTime 구조체의 사용. 날짜와 시간을 저장한다.
            class가 구조체보다 더 큰 개념으로 class와 똑같이 사용가능하다.
            시간은 입력하지 않으면 자정으로 인식한다.
        DateTime date = new DateTime(year:2019, month:4, day:14);
            DateTime.Now는 지금 현재 시간을 가져온다.
        DateTime current = DateTime.Now;*/
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        //private int _Age;
        private bool _IsQualified;
        public string Address;
        public string Description;

        // 상속의 이점
        // 부모 class의 type에 자식 class를 대입할 수 있다.
        private List<Pet> _MyPets = new List<Pet>();
        public List<Pet> MyPets
        {
            get { return _MyPets; }
        }
        public bool Adopt(Pet pet)
        {
            if (_IsQualified)
            {
                _MyPets.Add(pet);
                return true;
            }
            else return false;
        }
        /*
        private List<Cat> _MyCats = new List<Cat>();
        public List<Cat> MyCats
        {
            get { return _MyCats; }
        }
        private List<Dog> _MyDogs = new List<Dog>();
        public List<Dog> MyDogs
        {
            get { return _MyDogs; }
        }
        public bool Adopt(Cat cat)
        {
            if (_IsQualified)
            {
                _MyCats.Add(cat);
                return true;
            }
            else return false;
        }
        public bool Adopt(Dog dog) // 함수 overload. 매개변수를 다르게 해서 같은 이름의 함수 생성.
        {
            if (_IsQualified)
            {
                _MyDogs.Add(dog);
                return true;
            }
            else return false;
        }*/

        // 생성자는 무조건 public이다.
        public Customer(string firstname, string lastname, DateTime birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this._Birthday = birthday;
            this._IsQualified = DateTime.Now.Year - birthday.Year >= 18; 
        }
        /*
        public int GetAge()
        {
            return this._Age;
        }
        public void SetAge(int age)
        {
            this._Age = age;
            this._IsQualified = age >= 18; // 비교 연산자는 항상 bool형을 반환한다.
        }
        public bool GetIsQualified()
        {
            return this._IsQualified;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // 속성 사용하기
        // 속성은 메서드와 비슷하며 일반 field로 사용하면 된다.
        // 1. 단순히 field의 값을 조작해서 저장, 반환하는 경우
        // 2. 특정 field의 값이 변화할 때, 다른 field의 값이 변화할 필요성이 있는 경우
        // 3. field의 값이 중요해서, 잘못 변경되면 안되기 때문에 보호해야 하는 경우
        public int Age
        {
            // get 접근자는 return값이 필요하다.
            // get은 반드시 인자가 없어야 한다.
            // GetAge()의 역할과 같다.
            get { return _Age; }
            // set 접근자는 SetAge()의 역할과 같다.
            // set에는 속성의 타입과 같은 인자가 하나 들어온다.
            // 이 인자의 이름은 무조건 value로 정해져 있다.
            set
            {
                this._Age = value;
                this._IsQualified = value >= 18;
            }
        }*/
        public int Age
        {
            get { return DateTime.Now.Year - this._Birthday.Year; }
        }
        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                this._Birthday = value;
                this._IsQualified = Age >= 18;
            }
        }
        
        public bool IsQualified
        {
            //set이 없으면 해당 속성은 읽기 전용이 된다.
            get { return this._IsQualified; }
        }        
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
