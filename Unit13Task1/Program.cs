
using System.Diagnostics;
using System.Threading.Channels;

var str = File.ReadAllText("Text1.txt");

string[] strings = str.Split();
List<string> list = new List<string>();
LinkedList<string> linkedList = new LinkedList<string>();

Stopwatch listStop = new Stopwatch();

listStop.Start();
foreach (var s in strings)
{
    linkedList.AddLast(s);
}
listStop.Stop();
Console.WriteLine(listStop.ElapsedMilliseconds);

Stopwatch linkedListStop = new Stopwatch();
linkedListStop.Start();
foreach (var s in strings)
{
    list.Add(s);
}
linkedListStop.Stop();
Console.WriteLine(linkedListStop.ElapsedMilliseconds);