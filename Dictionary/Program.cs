using System.Runtime.InteropServices;

IKeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>("key", "value");

Console.WriteLine(keyValuePair);

Dictionary<string, string> dictionary = new Dictionary<string, string>();

dictionary.Add("1", "Amber");
dictionary.Add("2", "Nai");
dictionary.Add("3", "Amber");
dictionary.Add("4", "Clark");
dictionary.Add("5", "Roger");
dictionary.Add("6", "Goku");
dictionary.Add("7", "Naruto");

for(int i = 100; i < 150000000; i++)
{
    Console.WriteLine($"Adding {i} to the dictionary");
    dictionary.Add(i.ToString(), i.ToString());
}


Console.WriteLine($"Count:{dictionary.Count}");

dictionary.Remove("3");
Console.WriteLine($"Count:{dictionary.Count}");

IKeyValuePair<string, string> kvp = dictionary.Get("1");
Console.WriteLine(kvp);

Console.WriteLine($"Does Amber exist in the dictionary:{dictionary.ContainsValue("Amber")}");
// dictionary.Remove("yolo"); //non-existence key

