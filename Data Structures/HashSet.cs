public class HashSet
{
    public static void Demostration()
    {
        //Create HashSet - it is like a list
        //Difference: It do not allow duplicate values
        HashSet<int> hashset = new HashSet<int>();
        hashset.Add(200);
        hashset.Add(800);
        hashset.Add(200);
        hashset.Add(900);
        hashset.Add(7500);
        hashset.Add(540);
        Console.WriteLine("\n");
        Console.WriteLine("printing the items in hashset:");
        foreach (int item in hashset)
        {
            Console.WriteLine("--> {0}", item);
        }

        //Delete an item:
        hashset.Remove(900);
        //Deleting other by specific attribute, usefull with objects.
        hashset.RemoveWhere(x => x.ToString() == "540");
        Console.WriteLine("\n");
        Console.WriteLine("Printing the hashset after delete 900 & 540:");
        foreach (int item in hashset)
        {
            Console.WriteLine("--> {0}", item);
        }

        Console.WriteLine("\n");
        Console.WriteLine("////////////////////////////////");
    }



}
