// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
String example = "Объект – категория, выражающая то, что противостоит субъекту в его предметно-практической и познавательной деятельности.";
Console.WriteLine(Encoding.UTF7.GetByteCount(example));
Console.WriteLine(Encoding.UTF8.GetByteCount(example));
Console.WriteLine(Encoding.UTF32.GetByteCount(example));
Console.WriteLine(Encoding.ASCII.GetByteCount(example));

Console.WriteLine($"byte{byte.MinValue}{byte.MaxValue} {sizeof(byte)}byte/s");
Console.WriteLine($"int{int.MinValue}{int.MaxValue} {sizeof(int)}byte/s");
Console.WriteLine($"decimal{decimal.MinValue}{decimal.MaxValue} {sizeof(decimal)}byte/s");
Console.WriteLine($"sbyte{sbyte.MinValue}{sbyte.MaxValue} {sizeof(sbyte)}byte/s");
Console.WriteLine($"uint{uint.MinValue}{uint.MaxValue} {sizeof(uint)}byte/s");
Console.WriteLine($"short{short.MinValue}{short.MaxValue} {sizeof(short)}byte/s");
Console.WriteLine($"double{double.MinValue}{double.MaxValue} {sizeof(double)}byte/s");
Console.WriteLine($"ushort{ushort.MinValue}{ushort.MaxValue} {sizeof(ushort)}byte/s");
Console.WriteLine($"float{float.MinValue}{float.MaxValue}{sizeof(float)}byte/s");
Console.WriteLine($"long{long.MinValue}{long.MaxValue} {sizeof(long)}byte/s");
Console.WriteLine($"ulong{ulong.MinValue}{ulong.MaxValue} {sizeof(ulong)}byte/s");

Console.WriteLine($" char {typeof(char)} {char.MinValue} {char.MaxValue} {sizeof(char)} ");

Console.WriteLine($" bool {typeof(bool)} {bool.TrueString} {bool.FalseString} {sizeof(bool)}");

Console.WriteLine($" object {typeof(object)}");
unsafe
{
    Console.WriteLine(sizeof(object));

}

