using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCsharpWin
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public float Result = 0;
        public bool isNewNum = true;
        public bool isResult = false;
        public bool isfin = false;
        public enum Oper { Plus, Minus, Multiply, Division }
        public Oper Opt = Oper.Plus;

        public void SetScreen(string input)
        {
            if (isNewNum)
            {
                Screen.Text = "0";
                isNewNum = false;
                isResult = false;
                isfin = false;
            }
            if (Screen.Text == "0")
            {
                if (input == ".") Screen.Text += input;
                else Screen.Text = input;
            }
            else if (Screen.Text == "-0")
            {
                if (input == ".") Screen.Text += input;
                else Screen.Text = '-' + input;
            }
            else Screen.Text += input;
        }

        private void button_num_Click(object sender, EventArgs e)
        {
            if (isfin) { isNewNum = true; Result = 0; Opt = Oper.Plus; }
            Button numButton = (Button)sender; // 버튼 오브젝트 사용법
            SetScreen(numButton.Text);
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (isResult) return;
            if (isNewNum) SetScreen(".");
            else
            {
                if (Screen.Text.Contains(".")) return;
                else SetScreen(".");
            }
        }

        private void button_signed_Click(object sender, EventArgs e)
        {
            if (isResult) return;
            if (isNewNum)
            {
                Screen.Text = "-0";
                isNewNum = false;
            }
            else
            {
                if (Screen.Text.Contains("-")) Screen.Text = Screen.Text.Substring(1);
                else Screen.Text = "-" + Screen.Text;
            }
            
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            Result = 0;
            Screen.Text = "0";
            isNewNum = true;
            isResult = false;
            isfin = false;
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            if (isResult) return;
            Screen.Text = "0";
            isNewNum = true;
            isfin = false;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (isResult) return;
            string text = Screen.Text;
            if (text.Contains("-"))
            {
                if (text.Length > 2) Screen.Text = text.Substring(0, text.Length - 1);
                else if (Screen.Text != "-0") Screen.Text = "-0";
                else Screen.Text = "0";
            }
            else
            {
                if (text.Length > 1) Screen.Text = text.Substring(0, text.Length - 1);
                else Screen.Text = "0";
            }
        }

        public float get_result(float num)
        {
            float temp = float.Parse(Screen.Text);
            if (Opt == Oper.Plus) num += temp;
            else if (Opt == Oper.Minus) num -= temp;
            else if (Opt == Oper.Multiply) num *= temp;
            else num /= temp;
            return num;
        }

        private void button_oper_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                if (isResult == false)
                {
                    Screen.Text = get_result(Result).ToString();
                    isResult = true;
                }
                Result = float.Parse(Screen.Text);
                isNewNum = true;
                isfin = false;
            }
            Button outButton = (Button)sender;
            if (outButton.Text == "+") Opt = Oper.Plus;
            else if (outButton.Text == "-") Opt = Oper.Minus;
            else if (outButton.Text == "X") Opt = Oper.Multiply;
            else Opt = Oper.Division;
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (isResult) return;
            Screen.Text = get_result(Result).ToString();
            isResult = true;
            isfin = true;
        }
        /*
        private void HelloLabel_Click(object sender, EventArgs e)
        {
            //HelloLabel.Text = "Hello C#";

            int number1 = 10;
            int number2 = 2;

            int sum = number1 + number2;

            HelloLabel.Text = sum.ToString();
        }

        private void Sum_numbers_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            
            if (Sum1.Text == "") // 이건 공백만 판별가능하다. 다른 방법이 필요함.
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요.");
                return; // 바로 함수가 종료된다. 함수가 void 이므로 빈칸으로 둔다.
            }
            if (Sum2.Text == "")
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요.");
                return;
            }            
            
            if (String.IsNullOrWhiteSpace(Sum1.Text)) // 문자가 들어가면 판별이 불가능하다. 또 다른 방법이 필요함.
            {
                MessageBox.Show("Sum1에 숫자를 입력해주세요.");
                Sum1.SelectAll();
                Sum1.Focus();
                return; // 바로 함수가 종료된다. 함수가 void 이므로 빈칸으로 둔다.
            }
            if (String.IsNullOrWhiteSpace(Sum2.Text))
            {
                MessageBox.Show("Sum2에 숫자를 입력해주세요.");
                Sum2.SelectAll();
                Sum2.Focus();
                return;
            }
            // 함수 안에 out 이라는 매개변수는 값을 함수 안에서 해당 변수로 받아옴.
            if(int.TryParse(Sum1.Text, out number1) == false)
            {
                MessageBox.Show("Sum1에 문자를 입력하였습니다. 숫자를 입력해주세요.");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }
            if (int.TryParse(Sum2.Text, out number2) == false)
            {
                MessageBox.Show("Sum2에 문자를 입력하였습니다. 숫자를 입력해주세요.");
                Sum2.SelectAll();
                Sum2.Focus();
                return;
            }
            number1 = Convert.ToInt32(Sum1.Text);
            number2 = Convert.ToInt32(Sum2.Text);

            // int sum = number1 + number2;
            int sum = Add(number1, number2);

            Sum3.Text = sum.ToString(); // Convert를 쓸 수 있지만 이게 더 간편하다.
        }
        */
    }
}
