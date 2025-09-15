public class List()
{
    public static void Demostration()
    {
        //Create the list and adding values 
        List<int> numbers = new List<int>();
        numbers.Add(6);
        numbers.Add(4);
        numbers.Add(2);
        numbers.Add(7);
        numbers.Add(5);
        numbers.Add(1);

        //Read the original list
        Console.WriteLine("\n");
        Console.WriteLine("This is the original list:");
        foreach (int n in numbers)
        {
            Console.WriteLine("--> {0}", n);
        }

        //Sort the list
        numbers.Sort();

        Console.WriteLine("\n");
        Console.WriteLine("This is the sorted list:");
        for (int i = 0; i <= numbers.Count() -1; i++)
        {
            Console.WriteLine("--> {0}", numbers[i]);
        }

        //Delete an item from the list by value
        numbers.Remove(4);
        //Delete an item from the list by position
        numbers.RemoveAt(3);

        Console.WriteLine("\n");
        Console.WriteLine("List without 2 items removed by value and position:");
        foreach (int n in numbers)
        {
            Console.WriteLine("--> {0}", n);
        }

        //Find the position of a specific value
        int posNumb = numbers.BinarySearch(7);
        Console.WriteLine("\n");
        Console.WriteLine("Find the position of a specific value(7):");
        Console.WriteLine("The position is: {0}", posNumb);

        //Insert a list into another list
        List<string> NewList = new List<string>();
        NewList.Add("A");
        NewList.Add("B");
        NewList.Add("C");
        NewList.Add("D");
        List<string> NewList2 = new List<string>();
        NewList2.Add("V");
        NewList2.Add("W");
        NewList2.Add("X");
        NewList2.Add("Y");
        Console.WriteLine("\n");
        Console.WriteLine("Insert a list into another list");
        Console.WriteLine("List 1:");
        foreach (string n1 in NewList)
        {
            Console.WriteLine("--> {0}", n1);
        }
        Console.WriteLine("List 2:");
        foreach (string n2 in NewList2)
        {
            Console.WriteLine("--> {0}", n2);
        }
        NewList.AddRange(NewList2);
        Console.WriteLine("\n");
        Console.WriteLine("Combined List>");
        foreach (string n1 in NewList)
        {
            Console.WriteLine("--> {0}", n1);
        }

        //Insert value in specific space(move the position of the next items)
        NewList.Insert(3, "Josh");
        //Insert the value Z in the position of Y
        int positionOfY = NewList.BinarySearch("Y");
        NewList.Insert(positionOfY, "Z");
        Console.WriteLine("\n");
        Console.WriteLine("Insert value in specific space(move the position of the next items) with Insert and BinarySearch, new list:");
        foreach (string fl in NewList)
        {
            Console.WriteLine("--> {0}", fl);
        }

        //Update value
        Console.WriteLine("\n");
        Console.WriteLine("update value in specific space(D & V):");
        int posD = NewList.BinarySearch("D");
        NewList[posD] = "Martins";
        int posV = NewList.BinarySearch("V");
        NewList[posV] = "Spencer";
        foreach (string fl in NewList)
        {
            Console.WriteLine("--> {0}", fl);
        }

        //Clean all items of the List
        Console.WriteLine("\n");
        Console.WriteLine("Clean all items of the List: NewList.Clear()");
        NewList.Clear();

        Console.WriteLine("\n");
        Console.WriteLine("/////////////////////////////////");












    }

}