using UnityEngine;

public class CustomSimpleLinkedList : SimpleLinkedList<CustomObject>
{
    public override void Add(CustomObject customObject)
    {
        base.Add(customObject);



        customObject.Spawn();

    }
    public override void Remove(CustomObject customObject)
    {
        base.Remove(customObject);


      // customObject.OnDestroy();
    }
}
