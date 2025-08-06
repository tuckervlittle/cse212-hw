public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }
    public int Height;


    public Node(int data)
    {
        this.Data = data;
        Height = 1;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data) return;
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        int leftHeight = Left?.Height ?? 0;
        int rightHeight = Right?.Height ?? 0;
        Height = 1 + Math.Max(leftHeight, rightHeight);
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data) return true;
        else if (value < Data)
        {
            if (Left is not null)
                return Left.Contains(value);
        }
        else
        {
            // Insert to the right
            if (Right is not null)
                return Right.Contains(value);
        }
        return false;
    }
    // O(n)
    // public int GetHeight()
    // {
    //     // TODO Start Problem 4
    //     int leftHeight = Left?.GetHeight() ?? 0;
    //     int rightHeight = Right?.GetHeight() ?? 0;
    //     return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    // }
    // O(1)
    public int GetHeight(Node _root)
    {
        // TODO Start Problem 4
        return _root?.Height ?? 0; // Replace this line with the correct return statement(s)
    }
}