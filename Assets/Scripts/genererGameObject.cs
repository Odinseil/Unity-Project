using UnityEngine;

public class genererGameObject : MonoBehaviour
{
    public GameObject cube;
    public float x = 0;
    public float y = 0;
    public float z = 0;
    public float ligne = 0;
    
    void Start()
    {
        for (int i = 0; i < 17; i = i + 1)
        {
            GameObject myObject = Instantiate(cube);
            myObject.transform.position = new Vector3(x, y, z);
            for (int j = 0; j < 31; j = j + 1)
            {
                GameObject mySecondeObject = Instantiate(cube);
                mySecondeObject.transform.position = new Vector3(x, y, z);
                x = x + 0.5f;

            }
            y = y + 0.5f;
            x = 0;
        }
        











    }
}
