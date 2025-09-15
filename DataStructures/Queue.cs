public class Queue
{
    public static void Demostration()
    {
        //Create Queue
        Queue<int> Que = new Queue<int>();
        Que.Enqueue(15);
        Que.Enqueue(400);
        Que.Enqueue(2356);
        Que.Enqueue(5);
        Que.Enqueue(39);
        Console.WriteLine("\n");
        Console.WriteLine("Create Queue & Enqueue:");
        foreach (int q in Que)
        {
            Console.WriteLine(q);
        }
        
        //Process Dequeue - Peek - Clear - Contains
        Console.WriteLine("\n");
        Console.WriteLine("Next to be attended(Peek()): {0}", Que.Peek());

        Console.WriteLine("\n");
        Console.WriteLine("Dequeue now --> {0}", Que.Dequeue());
        Console.WriteLine("Now it has {0} items in queue.", Que.Count());
        Console.WriteLine("Next to be attended: {0}", Que.Peek());

        Console.WriteLine("\n");
        Console.WriteLine("Does it contains the value 39? --> Response: {0}", Que.Contains(39));




        Console.WriteLine("\n");
        Console.WriteLine("////////////////////////////////");
    }

} 