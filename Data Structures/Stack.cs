public class Stack
{
    public static void Demostration()
    {
        //Create Stack
        Stack<string> Stack = new Stack<string>();
        Stack.Push("Cali");
        Stack.Push("Rio");
        Stack.Push("Moscú");
        Stack.Push("Medellín");
        Stack.Push("Cartagena");
        Console.WriteLine("\n");
        Console.WriteLine("Create a Stack and add items with Push:");
        foreach (string s in Stack)
        {
            Console.WriteLine("Item value --> {0}", s);
        }

        //Process Pop - Peek - Clear
        Console.WriteLine("\n");
        Console.WriteLine("Next to be attended(Peek) --> {0}", Stack.Peek());
        Console.WriteLine("Attending(Pop) --> {0}", Stack.Pop());
        Console.WriteLine("Current items in the stack:");
        foreach (string s in Stack)
        {
            Console.WriteLine("Item value --> {0}", s);
        }

        Console.WriteLine("\n");
        Console.WriteLine("////////////////////////////////");

    }

    
}
