using System;

// README.md를 읽고 코드를 작성하세요.

string input = "Hello World";

Console.WriteLine("=== 문자열 가공기 ===\n");

Console.WriteLine($"원본: {input}\n");

Console.WriteLine("[대문자 변환]");

ProcessAndPrint(input, ToUpperCase);

Console.WriteLine("\n[소문자 변환]");

ProcessAndPrint(input, ToLowerCase);

Console.WriteLine("\n[괄호 추가]");

ProcessAndPrint(input, AddBrackets);

Console.WriteLine("\n[문자열 뒤집기]");

ProcessAndPrint(input, Reverse);

string ToUpperCase(string s)
{
    return s.ToUpper();
}

string ToLowerCase(string s)
{
    return s.ToLower();
}

string AddBrackets(string s)
{
    return $"[{s}]";
}

string Reverse(string s)
{
    char[] chars = s.ToCharArray();

    Array.Reverse(chars);

    return new string(chars);
}

void ProcessAndPrint(string input, StringProcessor processor)
{
    string result = processor(input);

    Console.WriteLine($"결과: {result}");
}

delegate string StringProcessor(string s);
