using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public string codigoSabor;
    public float cantidadHelado;
    float costo;


    void Start()
    {
        if (codigoSabor != "DDL" && codigoSabor != "CHO" && codigoSabor != "FRU" || cantidadHelado < 250 || cantidadHelado > 3000)
        {
            
                Debug.Log("El gusto ingresado o la cantidad de helado pedida son incorrectos");
                return;
            
        }    else
        {

            costo = cantidadHelado/1000 * 500;

            if (codigoSabor == "FRU")
            {
                costo = costo * 0.9f;
            }

            Debug.Log("El costo es de " + costo + "$");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
