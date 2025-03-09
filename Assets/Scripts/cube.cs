using UnityEditor.DeviceSimulation;
using UnityEngine;

public class cube : MonoBehaviour
{
    public bool estActif;
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
//Faire un systeme ou chaque cube a un numéro
//et que chaque box est relier au cube par le même numéro.
