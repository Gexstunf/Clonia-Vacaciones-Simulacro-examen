using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public float cantidadJuve;
    public float cantidadInfa;
    float cantidadPJ;
    float cantidadPI;
    float restoJ;
    float restoI;
    float cantidadCord;

    // Start is called before the first frame update
    void Start()
    {
        if (cantidadInfa < 0f || cantidadInfa > 100f && cantidadJuve < 0f || cantidadJuve > 100f)
        {
            Debug.Log("error");
            return;
        }
        else
        {
            cantidadPJ = cantidadJuve / 20f;
            cantidadPI = cantidadInfa / 10f;
            cantidadCord = (cantidadPJ + cantidadPI) / 5;
            Debug.Log(Mathf.CeilToInt(cantidadCord));
            Debug.Log(cantidadPJ);
            Debug.Log(cantidadPI);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
