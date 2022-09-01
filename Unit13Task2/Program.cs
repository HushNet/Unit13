


var str = File.ReadAllText("Text1.txt");

str = str.Replace(',', ' ');
str = str.Replace('.', ' ');

string[] strings = str.Trim().Split();


Dictionary<string, int> repeats = new Dictionary<string, int>();
int maxRepeats = 0;
foreach (var s in strings)
{
    if (repeats.ContainsKey(s))
    {
        repeats[s]++;

        if (repeats[s] > maxRepeats)
            maxRepeats = repeats[s];
    }
    else
    {
        repeats.Add(s,1);
    }
}
repeats.OrderBy(x => x.Value);

var keys = repeats.Keys.ToList();
for (int i = 0; i < 11; i++)
{
    Console.WriteLine(keys[i]);
}