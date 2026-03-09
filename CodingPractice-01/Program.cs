using System;
using System.Text;

// README.md를 읽고 아래에 코드를 작성하세요.
static void Hello() => Console.WriteLine("Hello Delegate");
static void Hi() => Console.WriteLine("안녕하세요.");
static double GetArea(int r) => 3.14 * r * r;
static void WriteToConsole(int percent) => Console.WriteLine($"진행률: {percent}%");
static void WriteToFile(int percent) => Console.WriteLine($"[파일 기록] {percent}%");
static void Go() => Console.WriteLine("직진");
static void Back() => Console.WriteLine("후진");
static void RunnerCall(Runner runner)
{
    Console.WriteLine("=== 실행 시작 ===");
    runner();
    Console.WriteLine("=== 실행 종료 ===");
}

{
    Console.WriteLine("1. 대리자를 통한 메서드 호출");

    SayDelegate say = new SayDelegate(Hello);
    say();
    say.Invoke();
}

Console.WriteLine();

{
    Console.WriteLine("2. 대리자 인스턴스 생성 방법");

    SayDelegate say = new SayDelegate(Hi);
    say();

    var hi = new SayDelegate(Hi);
    hi();
}

Console.WriteLine();

{
    Console.WriteLine("3. 매개변수와 반환값이 있는 대리자");

    GetAreaDelegate pointer = new GetAreaDelegate(GetArea);

    Console.WriteLine(pointer(10));
    Console.WriteLine(pointer.Invoke(10));

}

Console.WriteLine();

{
    Console.WriteLine("4. 강력한 형식의 대리자");

    MathOperation pow = Math.Pow; ;
    double result = pow(2, 10);

    Console.WriteLine(result);
}

Console.WriteLine();

{
    Console.WriteLine("5. 정적 메서드 참조");
    
    Transformer t = Calculator.Square;

    Console.WriteLine(t(5));

}

Console.WriteLine();

{
    Console.WriteLine("6. 멀티캐스트 대리자: 진행률 보고");

    ProgressReporter reporter = WriteToConsole;
    reporter += WriteToFile;

    for (int i = 0; i <= 100; i += 25)
    {
        reporter(i);
        Console.WriteLine();
    }

}

Console.WriteLine();

{
    Console.WriteLine("7. 대리자를 매개변수로 전달");

    RunnerCall(Go);
    Console.WriteLine();
    RunnerCall(Back);

}

Console.WriteLine();

{
    Console.WriteLine("8. Action 대리자");

    Action greet = () => Console.WriteLine("안녕하세요!");
    Action<string> print = (msg) => Console.WriteLine(msg);
    Action<string, int> printRepeat = (msg, count) =>
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(msg);
        }
    };

    greet();
    print("Hello, Action!");
    printRepeat("반복", 3);
}

Console.WriteLine();

{
    Console.WriteLine("9. Func 대리자");

    Func<int> getNumber = () => 42;
    Func<int, int> square = (x) => x * x;
    Func<int, int, int> add = (a, b) => a + b;
    Func<int, int, string> addToString = (a, b) => (a + b).ToString();

    Console.WriteLine(getNumber());
    Console.WriteLine(square(5));
    Console.WriteLine(add(3, 7));
    Console.WriteLine(addToString(3, 5));
}

Console.WriteLine();

{
    Console.WriteLine("10. Predicate 대리자");

    Predicate<int> isEven = (x) => x % 2 == 0;
    Predicate<int> isPositive = (x) => x > 0;

    Console.WriteLine(isEven(4));      
    Console.WriteLine(isEven(7));      
    Console.WriteLine(isPositive(5));  
    Console.WriteLine(isPositive(-3)); 
}

Console.WriteLine();

{
    Console.WriteLine("11. 익명 메서드");

    SayDelegate say = delegate ()
    {
        Console.WriteLine("반갑습니다.");
    };

    say();
}

delegate void SayDelegate();
delegate double GetAreaDelegate(int r);
delegate double MathOperation(double x, double y);
delegate int Transformer(int x);
delegate void ProgressReporter(int percent);
delegate void Runner();