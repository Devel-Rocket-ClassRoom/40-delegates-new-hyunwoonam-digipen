using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 인스턴스 메서드 참조");

    Calculator calc = new Calculator();
    Transformer t = calc.Multiply;

    Console.WriteLine(t(5));
}

Console.WriteLine();

{
    Console.WriteLine("2. 멀티캐스트 대리자: 추가와 제거");

    CarDriver driver = GoStraight;
    driver += GoLeft;
    driver += GoRight;

    driver();

    driver -= GoLeft;

    Console.WriteLine();
    driver();

    void GoStraight()
    {
        Console.WriteLine("직진");
    }

    void GoLeft()
    {
        Console.WriteLine("좌회전");
    }

    void GoRight()
    {
        Console.WriteLine("우회전");
    }
}

Console.WriteLine();

{
    Console.WriteLine("3. 배열 변환 예제");
    int[] Values = { 1, 2, 3, 4, 5 };
    Transformer square = Square;
    Transformer cube = Cube;

    Transform(Values, square);
    Transform(Values, cube);

    void Transform(int[] values, Transformer t)
    {
        int[] result = new int[values.Length];
        
        for (int i = 0; i < values.Length; i++)
        {
            result[i] = t(values[i]);
        }

        Console.WriteLine(string.Join(", ", result));
    }

    int Square(int x)
    {
        return x * x;
    }

    int Cube(int x)
    {
        return Square(x) * x;
    }
}

delegate int Transformer(int x);
delegate void CarDriver();






