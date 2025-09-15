public class Node
{
    public int Value;
    public Node LeftNode;
    public Node RightNode;

    public Node(int value)
    {
        Value = value;
    }
}

public class BinaryTree
{
    //The functions in this class are not static because they depends on the instance of the object.
    //We use static only when we can use functions from a class without the necesity of an instance of the object.
    public Node Root;
    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);

    }

    private Node InsertRecursive(Node node, int value)
    {
        if (node == null)
        {
            return new Node(value);
        }

        if (value < node.Value)
        {
            node.LeftNode = InsertRecursive(node.LeftNode, value);
        }
        else if (value > node.Value)
        {
            node.RightNode = InsertRecursive(node.RightNode, value);
        }

        return node;
    }

    public void In_Order(Node node, string Side)
    {
        if (node != null)
        {
            In_Order(node.LeftNode, "Left");
            Console.WriteLine("Side: {0} | Value: {1}", Side, node.Value);
            In_Order(node.RightNode, "Right");

        }

    }

    public void Pre_Order(Node node, string Side)
    {
        if (node != null)
        {
            Console.WriteLine("Side: {0} | Value: {1}", Side, node.Value);
            Pre_Order(node.LeftNode, "Left");
            Pre_Order(node.RightNode, "Right");
        }

    }

    public void Post_Order(Node node, string Side)
    {
        if (node != null)
        {
            Post_Order(node.LeftNode, "Left");
            Post_Order(node.RightNode, "Right");
            Console.WriteLine("Side: {0} | Value: {1}", Side, node.Value);
        }

    }

    public static void Demostration()
    {
        Console.WriteLine("\n");
        Console.WriteLine("BinaryTree:");
        BinaryTree Tree = new BinaryTree();
        Tree.Insert(10);
        Tree.Insert(5);
        Tree.Insert(15);
        Tree.Insert(2);
        Tree.Insert(7);
        Console.WriteLine("In-Order tree route:");
        Console.WriteLine("Used in Binary Search Trees because return the nodes in order");
        Console.WriteLine("Left - Root - Right");
        Tree.In_Order(Tree.Root, "Root");
        Console.WriteLine("\n");

        Console.WriteLine("Pre-Order tree route:");
        Console.WriteLine("To serialize trees or re-build structures.");
        Console.WriteLine("Root - Left - Right");
        Tree.Pre_Order(Tree.Root, "Root");
        Console.WriteLine("\n");

        Console.WriteLine("Post-Order tree route:");
        Console.WriteLine("Usefull to delete trees.");
        Console.WriteLine("Left - Right - Root");
        Tree.Post_Order(Tree.Root, "Root");
        Console.WriteLine("\n");
    }


}