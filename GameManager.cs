using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    private SimpleLinkedList<string> SimpleLinkedList = new SimpleLinkedList<string>();
    void Start()
    {
        
    }
    [Button("Add to List")]
    public void AddToList(string value)
    {

        SimpleLinkedList.Add(value);
        print("Added " + value + " to the list");
    }
    [Button("Remove from List")]
    public void RemoveFromList(string value)
    {
        print("Tyring to remove " + value + " from the list");
        SimpleLinkedList.Remove(value);
       
    }
    [Button("Search Node")]
    public void SearchNode(string value)
    {
        Node<string> objective = SimpleLinkedList.Seek(value);

        if (objective != null)
            print("Elemento encontrado: " + objective.Value.ToString());
        else
            print("No se encontro el elemento");
    }
    [Button("Read All")]
    public void ReadAll()
    {
        SimpleLinkedList.ReadAll();

        print("Total de elementos: " + SimpleLinkedList.count);
    }

}
