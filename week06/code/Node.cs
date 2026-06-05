public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value != Data && value != Left?.Data && value != Right?.Data)
        {
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
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            if (Left is not null)
            return Left.Contains(value);
        }
        else
        {
            if (Right is not null)
            return Right.Contains(value);
        }
        return false; 
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int height = 1;
        int heightLeft = 0;
        int heighRigth = 0;
        if (Left is not null)
        {
            heightLeft =  Left.GetHeight();
        }
        if (Right is not null)
        {
            heighRigth = Right.GetHeight();
        }
        if (Left is null && Right is null)
        {
            return 1;
        }
        if (heightLeft == heighRigth)
        {
            return height + heightLeft;
        }
        if (heightLeft > heighRigth)
        {
            return height + heightLeft;
        }
        if (heightLeft < heighRigth)
        {
            return height + heighRigth;
        }
        return height;
    }
}