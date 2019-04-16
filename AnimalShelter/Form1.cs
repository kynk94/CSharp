using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //ArayList를 사용하기 위함.

namespace AnimalShelter
{
    // partial은 class의 정의가 여러 곳에 있음을 의미한다.
    // Form1이라는 class가 Form class를 상속받음.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // array의 사용법
        // public Customer[] CustomerArray = new Customer[10];
        //public int CustomersIndex = 0;
        // List 사용
        public List<Customer> Customers = new List<Customer>();
        

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstname.Text, CusNewLastname.Text, DateTime.Parse(CusNewBirthday.Text))
            {
                Address = CusNewAddress.Text,
                Description = CusNewDescription.Text
            };
            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
            //CustomerList.Items.Add(cus.FirstName);

            CusNewFirstname.Text = "";
            CusNewLastname.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName; // 속성의 사용, 사용하는 사람 입장에서는 이것이 속성인지 field인지 알 필요 없다.
            CusAge.Text = cus.Age.ToString(); // 속성의 사용.
            CusAddress.Text = cus.Address;
            CusIsQualified.Text = cus.IsQualified.ToString();
            CusDescription.Text = cus.Description;
            //if (cus.MyCat != null) CusPetInfo.Text = cus.MyCat.Name + " : " + cus.MyCat.MakeSound() + Environment.NewLine; // OS에 맞게 줄바꿈
            //if (cus.MyDog != null) CusPetInfo.Text += cus.MyDog.Name + " : " + cus.MyDog.MakeSound();
            CusPetInfo.Text = "";
            //foreach (Cat cat in cus.MyCats) CusPetInfo.Text += cat.Name + " : " + cat.MakeSound() + Environment.NewLine;
            //foreach (Dog dog in cus.MyDogs) CusPetInfo.Text += dog.Name + " : " + dog.MakeSound() + Environment.NewLine;
            foreach (Pet pet in cus.MyPets)
            {
                CusPetInfo.Text += pet.Name + " : " + pet.MakeSound();
                // pet is Dog // bool type 반환. pet == Dog 을 의미함.
                // pet as Cat // 부모 class를 자식 class로 치환함.
                if (pet is Cat) CusPetInfo.Text += " : " + (pet as Cat).Scratch();
                else if (pet is Dog) CusPetInfo.Text += " : " + (pet as Dog).Bite();

                CusPetInfo.Text += Environment.NewLine;
            }
        }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e) // e 인자가 Row Index를 갖고 있다.
        {
            string firstname = (string)CusList.Rows[e.RowIndex].Cells[0].Value;

            foreach(Customer cus in Customers)
            {
                if (cus.FirstName == firstname)
                {
                    ShowDetails(cus);
                    break;
                }
            }

            CustomerDetail.Show();
            CusNewPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CustomerDetail.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("f", "l", new DateTime(1990, 1, 1));

            Cat cat = new Cat(1, "RuRu", "Black", "Female");
            cus.Adopt(cat);
            Cat cat2 = new Cat(3, "MoMo", "Brown", "Male");
            cus.Adopt(cat2);

            Dog dog = new Dog(2, "TiTi", "White", "Male", DogBreed.Jindo);
            cus.Adopt(dog);

            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CustomerDetail.Hide();
        }

        /*
        // ListBox의 사용
        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
           string firstName = CustomerList.SelectedItem.ToString();

           foreach(Customer cus in Customers)
           {
               if (cus.FirstName == firstName)
               {
                   ShowDetails(cus);
                   break;
               }
           }
           for(int index = 0; index < Customers.Count; index++)
           {
               if (Customers[index].FirstName == firstName)
               {
                   ShowDetails(Customers[index]);
                   break;
               }
           }
        }
        public void TestArray()
        {
           // 배열의 사용 방법.
           int[] numberArray = new int[5]; // 길이가 5인 int array
           numberArray[0] = 1; // array의 0번 인덱스에 1 할당
           numberArray[1] = 2;
           numberArray[2] = 3;
           numberArray[3] = 4;
           numberArray[4] = 5;
           int[] numberArray2 = new int[5] { 1, 2, 3, 4, 5 }; // 길이가 5이며 1,2,3,4,5의 값을 가지는 int array
           int[] numberArray3 = new int[] { 1, 2, 3, 4, 5 }; // 위와 동일하다. 길이는 자동으로 5가 된다.
           int[] numberArray4 = { 1, 2, 3, 4, 5 }; // 위와 동일하다.

           Customer[] customerArray = new Customer[5]; // 길이가 5인 Customer array
           customerArray[0] = new Customer("first", "last", new DateTime(2000, 1, 1)); // 클래스는 new를 해야한다.
           customerArray[1] = new Customer("first", "last", new DateTime(2000, 1, 1));
           customerArray[2] = new Customer("first", "last", new DateTime(2000, 1, 1));
           customerArray[3] = new Customer("first", "last", new DateTime(2000, 1, 1));
           customerArray[4] = new Customer("first", "last", new DateTime(2000, 1, 1));

           Customer[] customerArray2 = {
               new Customer("first", "last", new DateTime(2000, 1, 1)),
               new Customer("first", "last", new DateTime(2000, 1, 1)),
               new Customer("first", "last", new DateTime(2000, 1, 1)),
               new Customer("first", "last", new DateTime(2000, 1, 1)),
               new Customer("first", "last", new DateTime(2000, 1, 1))
           };
        }
        public void ArrayListTest() // ArrayList는 collection 중 하나.
        {
           ArrayList arrayList = new ArrayList();
           arrayList.Add(0); // 무조건 object 데이터 타입으로 추가된다.
           arrayList.Add(1);
           arrayList.Add(2);

           arrayList.Insert(2, 2); // 2번 인덱스에 2를 삽입. 기존 2번 인덱스는 3번으로 밀려남.
           arrayList.Remove(2); // 2를 찾아서 지움. 인덱스를 재정렬함.
           arrayList.RemoveAt(1); // 1번 인덱스를 지움. 인덱스를 재정렬함.

           int sum = 0;
           // arrayList.Count = arrayList의 원소 개수
           for (int index = 0; index < arrayList.Count; index++)
           {
               sum += (int)arrayList[index];
           }
           // ArrayList는 데이터 타입이 무조건 object.
           // 때문에 형변환을 자주 해야하는 문제점이 있다.
           // 그래서 ArrayList와 같은 단순한 collection 보다는 generic collection을 사용한다.
           // generic collection은 data type을 지정하여 사용하는 collection을 말한다.
           // 그냥 List를 쓰자.

           // List<data type>
           // List는 ArrayList와 정확히 동일하다. 다만 data type을 지정해 준다.
           int[] intArray = new int[5];
           ArrayList arrayList = new ArrayList();
           List<int> intList = new List<int>();

           int sum2 = 0
           for (int index = 0; index < intList.Count; index++)
           {
               sum2 += intList[index]; // 형변환을 하지 않는다.
           }

           // foreach의 사용법. 파이썬의 for문과 비슷한 것 같다.
           foreach(int value in intList)
           {
               sum2 += value;
           }
        }*/
    }
}
