using UnityEngine;

public class CustomObject : MonoBehaviour
{
    public int id;
    public int value;
    public string CustomObjectName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        Instantiate(this, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }
}
