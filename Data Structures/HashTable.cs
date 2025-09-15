using System.Collections;
public class HashTable
{
    public static void Demostration()
    {
        //Create 
        //it does not allow duplicate keys --> error
        //it allows any type in key or value
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "Frederick");
        hashtable.Add(2, "Johan");
        hashtable.Add(3, "Emily");
        hashtable.Add(4, "Tita");
        hashtable.Add(5, "Federico");
        hashtable.Add(6, "Manfred");
        hashtable.Add(7, 8);
        Console.WriteLine("\n");
        Console.WriteLine("Create Hashtable:");
        foreach (DictionaryEntry item in hashtable)
        {
            Console.WriteLine("--> Key:{0} - Value:{1}", item.Key, item.Value);
        }
        //Update an item
        hashtable[6] = "Juan";

        //Find Items
        Console.WriteLine("\n");
        Console.WriteLine("Manfred Value updated -> {0}", hashtable[6]);
        Console.WriteLine("Is here an item with the key:4? -> " + hashtable.Contains(4));
        Console.WriteLine("Existe un Item con el valor=Johan?? -> " + hashtable.ContainsValue("Johan"));
        Console.WriteLine("It Contains {0} items", hashtable.Count);

        //Delete item
        hashtable.Remove(5);
    }
}