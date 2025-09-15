public class Dictionary
{
    public static void Demostration()
    {
        //Create Dictionary
        Dictionary<int, string> Dictionary = new Dictionary<int, string> { { 10, "Josh" } };
        Dictionary.Add(25, "Emily");
        Dictionary.Add(17, "Martin");
        Dictionary.Add(9, "Steven");

        Console.WriteLine("\n");
        Console.WriteLine("Dictionary created by int & string:");
        foreach (var d in Dictionary)
        {
            Console.WriteLine("--> {0} | divided in Key {1} & Value {2}", d, d.Key, d.Value);
        }

        //Delete item
        Dictionary.Remove(17);
        Console.WriteLine("\n");
        Console.WriteLine("Delete an item with key 17:");
        foreach (var d in Dictionary)
        {
            Console.WriteLine("--> {0} | divided in Key {1} & Value {2}", d, d.Key, d.Value);
        }

        //Searh item by key or value
        var it1 = Dictionary.ContainsKey(25);
        var it2 = Dictionary.ContainsValue("Steven");
        Console.WriteLine("\n");
        Console.WriteLine("Searh item by key(ContainsKey('25')) or value(ContainsValue('Steven'))");
        Console.WriteLine("Was the key founded? {0}", it1);
        Console.WriteLine("Was the value founded? {0}", it2);

        //Update value
        Console.WriteLine("\n");
        Console.WriteLine("Update value of a specific item with the key 25:");
        Console.WriteLine("25 --> {0}", Dictionary[25]);
        Dictionary[25] = "Maria";
        Console.WriteLine("25 --> Changing - - - - - - > {0}", Dictionary[25]);

        Console.WriteLine("\n");
        Console.WriteLine("/////////////////////////////////");



    }





}