using UnityEditor.DeviceSimulation;
using UnityEngine;

public class cube : MonoBehaviour
{
    public bool estActif;
    public float x;
    public float y;
    public float z;
    public GameObject box;
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        estActif = false;
    }

    void OnMouseDown()
    {
        if (!estActif)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            estActif = true;
        }
        else if (estActif)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            estActif = false;
        }
    }
}
