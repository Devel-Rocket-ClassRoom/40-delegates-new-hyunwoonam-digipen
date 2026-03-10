using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Action<string> action = PrintOriginal;
string hello = "Hello World";

Console.WriteLine("=== 문자열 처리 파이프라인 ===\n");

Console.WriteLine("--- 단계 1: 원본 출력만 ---");

action(hello);

Console.WriteLine("\n--- 단계 2: 대문자 추가 ---");

action += PrintUpper;
action(hello);

Console.WriteLine("\n--- 단계 3: 소문자, 길이 추가 ---");

action += PrintLower;
action += PrintLength;
action(hello);

Console.WriteLine("\n--- 단계 4: 대문자 제거 ---");
action -= PrintUpper;
action(hello);

void PrintOriginal(string s) => Console.WriteLine($"원본: {s}");
void PrintUpper(string s) => Console.WriteLine($"대문자: {s.ToUpper()}");
void PrintLower(string s) => Console.WriteLine($"소문자: {s.ToLower()}");
void PrintLength(string s) => Console.WriteLine($"길이: {s.Length}");