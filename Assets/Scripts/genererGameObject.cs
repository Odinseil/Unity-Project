using UnityEngine;

public class genererGameObject : MonoBehaviour
{
    public GameObject box;
    public float x = 0;
    public float y = 0;
    public float z = 0;

    void Start()
    {
        Debug.Log("création des cubes...");
        for (int i = 0; i < 17; i = i + 1)
        {
            GameObject myObject = Instantiate(box);
            myObject.transform.position = new Vector3(x, y, z);
            for (int j = 0; j < 31; j = j + 1)
            {
                GameObject mySecondeObject = Instantiate(box);
                mySecondeObject.transform.position = new Vector3(x, y, z);
                x = x + 0.5f;

            }
            z = z + 0.5f;
            x = 0;
        }
        Debug.Log("création des cubes fini !");
        
    
    
    }
}
