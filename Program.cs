using System;
using System.Globalization;
using System.Security.Cryptography;
using TestClasess.Interfaces_and_methods;
using static TestClasess.Interfaces_and_methods.ExampleA;
using static TestClasess.Interfaces_and_methods.ExampleB;
using static TestClasess.Interfaces_and_methods.ExampleC;


//Example A
Console.WriteLine("Example A:");
A a = new C();

//Example B
Console.WriteLine("Example B:");
aA b = new cC();

//Example C
Console.WriteLine("Example C:");
Number number = new Number { Value = 0 };
ExampleC inc = new ExampleC();
inc.Increment(ref number);
inc.Increment(ref number);
inc.Increment(ref number);
var result = number.Value;
Console.WriteLine(result);

//Example D
Console.WriteLine("Example D:");
ExampleD Foo = new ExampleD();
Console.WriteLine();
Console.WriteLine("(0, SE)");
Foo.Bar(0, string.Empty);
Console.WriteLine();
Console.WriteLine("(1, SE)");
Foo.Bar(1, string.Empty);
Console.WriteLine();
Console.WriteLine("(-10, SE)");
Foo.Bar(-10, string.Empty);
Console.WriteLine();
Console.WriteLine("(0, SE)");
Foo.Bar(0, string.Empty);
Console.WriteLine();
Console.WriteLine("(-1, SE)");
Foo.Bar(-1, string.Empty);

//Example E
Console.WriteLine("Example E:");
ExampleE Ex4 = new ExampleE();
int[] integers = new[] {1,2,3,4,5,6,7,8,9};
foreach (var i in Ex4.Foo(integers,5))
{
    Console.Write(i);
}

//Example F
Console.WriteLine("Example F:");
string path = "text.txt";
using Stream stream = new FileStream(path, FileMode.Create);
stream.WriteByte(1);
byte[] block = {2, 3, 4, 5};
stream.Write(block, 0, block.Length);
stream.Position = 3;
stream.WriteByte(11);
stream.Position = 0;
Console.WriteLine($"{stream.Read(block, 0, block.Length - 1)}, {stream.ReadByte()}, {stream.ReadByte()}, {stream.ReadByte()}");

//Example G
Console.WriteLine("Example G:");
ExampleG Ex7 = new ExampleG();
//Console.WriteLine("A");
//Ex7.A();
Console.WriteLine("B");
Ex7.B();
Console.WriteLine();
Console.WriteLine("C");
Ex7.C();
Console.WriteLine();
//Console.WriteLine("D");
//Ex7.D();

//Example H
Console.WriteLine("Example H:");
ExampleH Ex8 = new ExampleH();
Console.WriteLine("A");
Ex8.A();
Console.WriteLine();
Console.WriteLine("B");
Ex8.B();
Console.WriteLine();
Console.WriteLine("C");
Ex8.C();
Console.WriteLine();
Console.WriteLine("D");
Ex8.D();


//Example I
Console.WriteLine("Example I:");
int GetByte(Stream stream)

{
    stream.Seek(offset: 2, origin: SeekOrigin.Begin);
    for (int i = 10; i > 15; i++)
    {
        stream.WriteByte((byte)i);
    }
    stream.Position = 5;
    return stream.ReadByte();
}

var bytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
var memoryStream = new MemoryStream(bytes);
var res = GetByte(memoryStream); //6
Console.WriteLine("resultado", res);

//Example J
Console.WriteLine("Example J:");
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int element = array.Count(ele => ele > 4 && ele < 6);
//first
//firstordefault
//single
//singleordefault
Console.WriteLine(element);

//Example K
Console.WriteLine("Example K:");
var fruits = new List<string> { "Apple", "Banana", "Cherry", "Apricot", "Blueberry" };
var _result = fruits.GroupBy(f => f.Length).Select(g => $"{g.Key}: {string.Join(",", g.Select(e => e))}");
Console.WriteLine(_result); // ["5: Apple","6: Banana, cherry","7: Apricot","9:Blueberry" ]

//Example L
Console.WriteLine("Example L:");
int _number = 123;
string format = "D2";
string _resu = _number.ToString(format, CultureInfo.InvariantCulture);
Console.WriteLine(_resu);

//Example M
Console.WriteLine("Example M:");
var numbers = new List<int> { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (var number_ in numbers)
{
    sum += number_;
}
double res1 = (double)sum / numbers.Count;
double res2 = numbers.Average();
Console.WriteLine(res1);
Console.WriteLine(res2);

//Example N
Console.WriteLine("Example N:");
ExampleN Ex13 = new ExampleN();

var num = new List<int> { 1, 2, 3, 4, 5 };
var result1 = Ex13.Foo(num);
var result2 = numbers.Where(n => n % 2 != 0).Select(n => n * n);
//[1, 9, 25]

Console.WriteLine("res1", result1);
//Console.WriteLine("res2", result2);
