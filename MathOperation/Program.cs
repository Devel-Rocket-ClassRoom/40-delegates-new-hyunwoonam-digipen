using System;

// README.md를 읽고 코드를 작성하세요.

MathOp Calc = Add;
Calc += Subtract;
Calc += Multiply;
Calc += Divide;

Calc(20, 4);


int Add(int a, int b)
{
    int result = a + b;

    Console.WriteLine("[덧셈]");
    Console.WriteLine($"{a} + {b} = {result}\n");
    return result;
}
int Subtract(int a, int b)
{
    int result = a - b;

    Console.WriteLine("[뺄셈]");
    Console.WriteLine($"{a} - {b} = {result}\n");
    return result;
}
int Multiply(int a, int b)
{
    int result = a * b;

    Console.WriteLine("[곱셈]");
    Console.WriteLine($"{a} * {b} = {result}\n");
    return result;
}
int Divide(int a, int b)
{
    int result = a / b;

    Console.WriteLine("[나눗셈]");
    Console.WriteLine($"{a} / {b} = {result}\n");
    return result;
}

delegate int MathOp(int a, int b);