using UnityEditor.DeviceSimulation;
using UnityEngine;

public class cube : MonoBehaviour
{
    public bool estActif;
    public float x;
    public float y;
    public float z;
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
    //Vérifier si deux cube sont a coté en ajoutant ou enlever 0.5 au axe x et y des gameObject pour voir si des cubes sont actifs a ces coordonnées.
}
