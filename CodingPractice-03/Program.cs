using System;

// README.md를 읽고 아래에 코드를 작성하세요.
using System;

{
    Console.WriteLine("1. 내장 대리자(Action)로 멀티캐스트");

    Action actions = null;
    actions += GoForward;
    actions += GoLeft;
    actions += GoRight;

    actions();
}

Console.WriteLine();

{
    Console.WriteLine("2. 익명 메서드와 멀티캐스트");
    Action actions = null;
    actions += GoForward;
    actions += GoLeft;
    actions += delegate()
    {
        Console.WriteLine("우회전");
    };

    actions();
}


void GoForward()
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