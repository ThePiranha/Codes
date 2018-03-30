Dictionary<string, List<string>> FullInfo = new Dictionary<string, List<string>>();
FullInfo.Add("Cities", new List<string> { "Paris", "Chicago", "Tokyo", "Seoul" });
FullInfo.Add("Countries", new List<string> { "France", "US", "Japan", "Korea" });
FullInfo.Add("Number", new List<string> { "One", "Two", "Three", "Four" });

foreach( var contents in FullInfo.Keys)
{
    foreach(var listMember in FullInfo[contents])
    {
        Console.WriteLine("Key : " + contents + " member :" + listMember);
    }
}