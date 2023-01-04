namespace Stack;

public class Stack
{
    private readonly List<object> _elements = new List<object>();

    public void Push(object obj)
    {
        if (obj == null)
            throw new InvalidOperationException("You cannot add a null object to the stack.");
        
        _elements.Add(obj);
    }
    
    public object Pop()
    {
        var elementsLength = _elements.Count;
        if (elementsLength == 0)
            throw new InvalidOperationException("Empty stack.");

        var lastElement = _elements[elementsLength - 1];
        _elements.Remove(lastElement);
        return lastElement;
    }

    public void Clear()
    {
        _elements.Clear();
    }
}