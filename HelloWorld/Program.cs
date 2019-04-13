using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// exe파일 경로 : Csharp\HelloWorld\HelloWorld\bin\Debug\HelloWorld.exe

namespace HelloWorld // HelloWorld.exe 를 만드는 것이라고 볼 수 있음.
{
    class Program // exe를 실행하면 OS가 실행하는 것이 이 class.
    {
        // 정적으로 어떤 return도 없는(void) string으로 된 배열([])을 args로 받아라.
        // 인자 args를 받아들일 수는 있지만 안써도 된다.
        static void Main(string[] args) // OS에 의해 호출되는 유일한 함수 Main, 고유명사로 보면 됨.
        {
            Console.WriteLine("Hello C#"); // 콘솔에 Hello C# 을 써라.
            Console.WriteLine(args.Length); 
            // args의 길이, args가 몇개인지 알 수 있다.
            // args가 아무것도 입력이 되지 않은 것을 알 수 있다.
            // args에 무언가를 입력하고 싶다면,
            // cmd를 실행하여 이 프로그램이 위치한 경로로 이동한 후 HelloWorld 를 실행한다.
            // HelloWorld test1 test2 로 실행하면 args=["test1", "test2"] 로 입력된 것으로 인지한다.

            Console.ReadKey(); // 콘솔에 키입력이 들어올 때까지 기다려라.
        }
    }
}
