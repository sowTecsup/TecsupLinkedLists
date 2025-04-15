using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Stack<T> : MonoBehaviour
{
    private StackNode<T> last = null;
    private int count = 0;

    public StackNode<T> Last => last;

    public int Count => count;  
    public virtual void Push(T item)
    {
        StackNode<T> newNode = new StackNode<T>(item);
        count++;

        if (last == null)
        {
            last = newNode;
            return;
        }
        newNode.SetPrev(last);
        last = newNode;

    }
    public virtual T Pop()
    {
        if(count <= 1)
        {
            Clear();
            count = 0;
            return default;
        }
        count--;
        StackNode<T> popNode = new(last.Value);
        
        last = last.Prev;
        return popNode.Value;
    }

    public virtual T Peak()
    {
        if(last == null)
            return default;
        return last.Value;
    }
    public virtual void Clear()
    {
        last = null;
    }
}
